#include "SimpleStepper.h"

byte buffer[10];
SimpleStepper steppers[4];

int index = 0;
bool dataReady = false;

SimpleStepper stepperA;
SimpleStepper stepperB;
SimpleStepper stepperC;
SimpleStepper stepperD;

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
}


void loop() {

  if (Serial.available() > 0) {
    buffer[index] = Serial.read();

    index++;
    if (index == 2) {
      index = 0;
      dataReady = true;
    }
  }

  if (dataReady)
  {
    int id = buffer[0];
    if (id > 0 && id < 5) {
      if (buffer[1] == 1) {
        steppers[id].stepCW();
      }
      else if (buffer[1] == 2) {
        steppers[id].stepCCW();
      }
    }
    Serial.write('\n');
    // reset command
    buffer[0] = 0;
    dataReady = false;
  }
}
