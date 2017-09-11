#include "SimpleStepper.h"

byte buffer[10];
SimpleStepper steppers[4];

int index = 0;
int input = 0;
bool dataReady = false;
int command = 0;
int stepCount = 0;

SimpleStepper stepperA;
SimpleStepper stepperB;
SimpleStepper stepperC;
SimpleStepper stepperD;

bool shallMove[4];
int stepperSources[4];
int stepperTargets[4];
int maxSteps = 0;
int steps = 0;

void setup() {

  Serial.begin(9600);

  stepperA.initialize(2, 3, 4, 5);
  stepperB.initialize(6, 7, 8, 9);
  stepperC.initialize(10, 11, 12, 13);
  stepperD.initialize(A0, A1, A2, A3);
  
  steppers[0] = stepperA;
  steppers[1] = stepperB;
  steppers[2] = stepperC;
  steppers[3] = stepperD;

  for (int i = 0; i < 4; i++) {  
    stepperSources[i] = steppers[i].getStep();
  }
}

void parseAndSetMotor(int motor, int highIdx, int lowIdx) {
  
  /*Serial.write("M");
  Serial.print(motor);  
  Serial.write("(");
  Serial.print(buffer[highIdx]);
  Serial.write(",");  
  Serial.print(buffer[lowIdx]);
  Serial.write(","); */
  stepCount = (((int)buffer[highIdx]) << 8) + (int)buffer[lowIdx];
  bool cw = stepCount > 0;
  /*if (cw)
    Serial.write("cw)");
  else
    Serial.write("ccw)");
  Serial.print(stepCount);  
  Serial.write(" ");*/
  //steppers[motor].newMove(cw, abs(stepCount));
  stepperSources[motor] = steppers[motor].getStep();
  stepperTargets[motor] = steppers[motor].getStep() + stepCount;
}

void parseAndSetDelay(int motor, int highIdx, int lowIdx) {
  Serial.write("M");
  Serial.print(motor);  
  Serial.write("(");
  Serial.print(buffer[highIdx]);
  Serial.write(",");  
  Serial.print(buffer[lowIdx]);
  Serial.write(","); 
  int delayMicros = (((int)buffer[highIdx]) << 8) + (int)buffer[lowIdx];
  Serial.print(delayMicros);  
  Serial.write(") ");
  
  //steppers[motor].setDelay(delayMicros);
}

void run() {
  if (steps < maxSteps) {
    for (int i = 0; i < 4; i++) {
      if (shallMove[i]) {
        int newSteps = stepperSources[i] + (int)(((double)(stepperTargets[i] - stepperSources[i]) * (double)steps) / (double)maxSteps);
        //if (i == 0)
          //Serial.print(newSteps);
        int count = newSteps - steppers[i].getStep();
        if (count > 0)
          steppers[i].stepCW();
        else if (count < 0)
          steppers[i].stepCCW();
      }
    }
    steps++;
    delayMicroseconds(1200);
    //Serial.write("\n");
  }
}

void loop() {

  run();
  //for (int i = 0; i < 4; i++)
    //steppers[i].run();
    
  if (Serial.available() > 0) {
  // Expected data:
  // c hiA loA hiB loB hiC loC hiD loC
  // c == 0, expect all 4 motors with hi/lo bytes
  // c 1..4, set only one motor (c hi lo)

    buffer[index] = Serial.read();

    index++;

    // Single motor mode
    if ((buffer[0] == 0 && index == 9) ||                       // move all steppers at once
        (buffer[0] > 0 && buffer[0] < 5 && index == 3) ||       // move a single stepper
        (buffer[0] == 5 && index == 1) ||                       // stop all steppers
        (buffer[0] == 6 && index == 2) ||                       // stop a single stepper
        (buffer[0] == 7 && index == 9))                         // set delays for all steppers
    {
      index = 0;
      dataReady = true;
    }

    if (index == 10) // Sanity, restart to read
      index = 0;
  }

  if (dataReady)
  {
    /*for (int i = 0; i < 9; ++i) {
      Serial.print(buffer[i]);
      Serial.write(',');
    }*/
    if (buffer[0] == 0) {
      parseAndSetMotor(0, 1, 2);
      parseAndSetMotor(1, 3, 4);
      parseAndSetMotor(2, 5, 6);
      parseAndSetMotor(3, 7, 8);

      maxSteps = 0;
      for (int i = 0; i < 4; i++) {
        shallMove[i] = true;
        Serial.print("M");
        Serial.print(i);
        Serial.print(": ");
        Serial.print(stepperSources[i]);
        Serial.print(" => ");
        Serial.print(stepperTargets[i]);
        Serial.print(" ");
        int motorSteps = abs(stepperTargets[i] - stepperSources[i]);
        if (motorSteps > maxSteps)
          maxSteps = motorSteps;
      }
      Serial.print(" #");
      Serial.print(maxSteps);
      steps = 0;
    }
    else if (buffer[0] < 5) {
      int motorId = buffer[0] - 1;
      parseAndSetMotor(buffer[0] - 1, 1, 2);
      shallMove[0] = false;
      shallMove[1] = false;
      shallMove[2] = false;
      shallMove[3] = false;
      shallMove[motorId] = true;

        Serial.print("M");
        Serial.print(motorId);
        Serial.print(": ");
        Serial.print(stepperSources[motorId]);
        Serial.print(" => ");
        Serial.print(stepperTargets[motorId]);
        Serial.print(" ");

      maxSteps = abs(stepperTargets[motorId] - stepperSources[motorId]);
      Serial.print(" #");
      Serial.print(maxSteps);
      steps = 0;
    }
    else if (buffer[0] == 5) {
      for (int i = 0; i < 4; i++) {
        //steppers[i].stop();
        shallMove[i] = false;
      }
      maxSteps = -1;
      steps = 0;
    }
    else if (buffer[0] == 6 && buffer[1] > 0 && buffer[1] < 6) {
      //steppers[buffer[1] - 1].stop();
      shallMove[buffer[1] - 1] = false;
      maxSteps = -1;
      steps = 0;
    }
    else if (buffer[0] == 7) {
      parseAndSetDelay(0, 1, 2);
      parseAndSetDelay(1, 3, 4);
      parseAndSetDelay(2, 5, 6);
      parseAndSetDelay(3, 7, 8);
    }

    Serial.write('\n');
    // reset command
    buffer[0] = 0;
    dataReady = false;
  }
}
