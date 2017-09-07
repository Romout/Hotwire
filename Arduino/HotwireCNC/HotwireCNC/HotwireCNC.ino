#include <AccelStepper.h>

#define STEPS 100
#define HALFSTEP 8
int input = 0;
int state = 0;
int command = 0;
int stepCount = 0;

AccelStepper stepperA(HALFSTEP, 2, 4, 3, 5);
AccelStepper stepperB(HALFSTEP, 6, 7, 8, 9);
AccelStepper stepperC(HALFSTEP, 10, 11, 12, 13);
AccelStepper stepperD(HALFSTEP, A0, A1, A2, A3);

void setup() {

  Serial.begin(9600);
  
  pinMode(A0, OUTPUT);
  pinMode(A1, OUTPUT);
  pinMode(A2, OUTPUT);
  pinMode(A3, OUTPUT);
  
  stepperA.setMaxSpeed(1000.0);
  stepperA.setAcceleration(1000.0);
  stepperA.setSpeed(700.0);
  stepperB.setMaxSpeed(1000.0);
  stepperB.setAcceleration(50.0);
  stepperB.setSpeed(200.0);
  stepperC.setMaxSpeed(1000.0);
  stepperC.setAcceleration(50.0);
  stepperC.setSpeed(200.0);
  stepperD.setMaxSpeed(1000.0);
  stepperD.setAcceleration(50.0);
  stepperD.setSpeed(200.0);
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
      stepCount = Serial.read() - 128;
      state = 2;
    }
  }

  if (state == 2)
  {
    switch (command) {
      case 'a':
        stepperA.move(stepCount);
        break;
      case 'b':
        stepperB.move(stepCount);
        break;
      case 'c':
        stepperC.move(stepCount);
        break;
      case 'd':
        stepperD.move(stepCount);
        break;
    }
    state = 0;
  }

  stepperA.run();
  stepperB.run();
  stepperC.run();
  stepperD.run();
}
