#include <CheapStepper.h>

byte buffer[10];
CheapStepper steppers[4];

int index = 0;
int input = 0;
bool dataReady = false;
int command = 0;
int stepCount = 0;

CheapStepper stepperA(2, 3, 4, 5);
CheapStepper stepperB(6, 7, 8, 9);
CheapStepper stepperC(10, 11, 12, 13);
CheapStepper stepperD(A0, A1, A2, A3);

void setup() {

  Serial.begin(9600);

  // Pin-Modes have to be set again, no idea why
  for (int i = 2; i < 14; i++)
    pinMode(i, OUTPUT);

  pinMode(A0, OUTPUT);
  pinMode(A1, OUTPUT);
  pinMode(A2, OUTPUT);
  pinMode(A3, OUTPUT);

  steppers[0] = stepperA;
  steppers[1] = stepperB;
  steppers[2] = stepperC;
  steppers[3] = stepperD;

  for (int i = 0; i < 4; i++)
    steppers[i].setRpm(22);
}

void parseAndSetMotor(int motor, int highIdx, int lowIdx) {
  
  Serial.write("M");
  Serial.print(motor);  
  Serial.write("(");
  Serial.print(buffer[highIdx]);
  Serial.write(",");  
  Serial.print(buffer[lowIdx]);
  Serial.write(","); 
  stepCount = (((int)buffer[highIdx]) << 8) + (int)buffer[lowIdx];
  bool cw = stepCount > 0;
  if (cw)
    Serial.write("cw)");
  else
    Serial.write("ccw)");
  Serial.print(stepCount);  
  Serial.write(" ");
  steppers[motor].newMove(cw, abs(stepCount));
}

void loop() {

  for (int i = 0; i < 4; i++)
    steppers[i].run();
    
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
        (buffer[0] == 6 && index == 2)) {                       // stop a single stepper
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
    }
    else if (buffer[0] < 5) {
      parseAndSetMotor(buffer[0] - 1, 1, 2);
    }
    else if (buffer[0] == 5) {
      for (int i = 0; i < 4; i++)
        steppers[i].stop();
    }
    else if (buffer[0] == 6 && buffer[1] > 0 && buffer[1] < 6) {
      steppers[buffer[1] - 1].stop();
    }

    Serial.write('\n');
    // reset command
    buffer[0] = 0;
    dataReady = false;
  }
}
