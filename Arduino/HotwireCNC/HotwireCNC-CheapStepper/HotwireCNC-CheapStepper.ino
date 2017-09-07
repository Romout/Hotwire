#include <CheapStepper.h>

int input = 0;
int state = 0;
int command = 0;
int stepCount = 0;

CheapStepper stepperA(2, 3, 4, 5);
CheapStepper stepperB(6, 7, 8, 9);
CheapStepper stepperC(10, 11, 12, 13);
CheapStepper stepperD(A0, A1, A2, A3);

void setup() {

  Serial.begin(9600);
  
  pinMode(2, OUTPUT);
  pinMode(3, OUTPUT);
  pinMode(4, OUTPUT);
  pinMode(5, OUTPUT);
    
  pinMode(A0, OUTPUT);
  pinMode(A1, OUTPUT);
  pinMode(A2, OUTPUT);
  pinMode(A3, OUTPUT);
}

void loop() {

  if (Serial.available() > 0) {
    input = Serial.read();
    
    if (state == 0) {
      command = input;
      if (command > 0)
        state = 1;
    }
    else if (state == 1) {
      
      stepCount = input;
      Serial.print("Step count received: ");
      Serial.print(stepCount);
      stepCount = stepCount - 128;
      Serial.print("StepCount-128: ");
      Serial.print(stepCount);
      state = 2;
    }
  }

  if (state == 2)
  {
    bool cw = stepCount > 0;
    if (cw)
      Serial.write("clockwise\n");
    else
      Serial.write("counter-clockwise\n");
      
    switch (command) {
      case 'a':
        stepperA.move(cw, abs(stepCount));
        break;
      case 'b':
        stepperB.move(cw, stepCount);
        break;
      case 'c':
        stepperC.move(cw, stepCount);
        break;
      case 'd':
        stepperD.move(cw, stepCount);
        break;
    }
    state = 0;
  }
}
