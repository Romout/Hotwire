#ifndef SIMPLESTEPPER_H
#define SIMPLESTEPPER_H

#include "Arduino.h"

class SimpleStepper
{
public:
  SimpleStepper();
  
  void initialize(int pin0, int pin1, int pin2, int pin3);
  void stepCW();
  void stepCCW();

  int getStep();
  
private:
  void setStep();

  int _pins[4];
  int _steps;
};

#endif
