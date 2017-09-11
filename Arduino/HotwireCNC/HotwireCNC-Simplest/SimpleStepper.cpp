#include "Arduino.h"
#include "SimpleStepper.h"

SimpleStepper::SimpleStepper()
{}

void SimpleStepper::initialize(int pin0, int pin1, int pin2, int pin3)
{
  _steps = 0;
  
  _pins[0] = pin0;
  _pins[1] = pin1;
  _pins[2] = pin2;
  _pins[3] = pin3;

  for (int i = 0; i < 4; i++)
    pinMode(_pins[i], OUTPUT);
}

void SimpleStepper::stepCW()
{
  _steps++;
  setStep();
}

void SimpleStepper::stepCCW()
{
  // Prevent negative modulo
  if (_steps == 0)
    _steps = 8;

  _steps--;
  setStep();
}

int SimpleStepper::getStep() { return _steps; }

void SimpleStepper::setStep()
{
  int value[4];
  switch (_steps % 8)
  {
    case 0:
      value[0] = HIGH;
      value[1] = LOW;
      value[2] = LOW;
      value[3] = LOW;
      break;
    case 1:
      value[0] = HIGH;
      value[1] = HIGH;
      value[2] = LOW;
      value[3] = LOW;
      break;
    case 2:
      value[0] = LOW;
      value[1] = HIGH;
      value[2] = LOW;
      value[3] = LOW;
      break;
    case 3:
      value[0] = LOW;
      value[1] = HIGH;
      value[2] = HIGH;
      value[3] = LOW;
      break;
    case 4:
      value[0] = LOW;
      value[1] = LOW;
      value[2] = HIGH;
      value[3] = LOW;
      break;
    case 5:
      value[0] = LOW;
      value[1] = LOW;
      value[2] = HIGH;
      value[3] = HIGH;
      break;
    case 6:
      value[0] = LOW;
      value[1] = LOW;
      value[2] = LOW;
      value[3] = HIGH;
      break;
    case 7:
      value[0] = HIGH;
      value[1] = LOW;
      value[2] = LOW;
      value[3] = HIGH;
      break;
  }
  for (int i = 0; i < 4; i++)
    digitalWrite(_pins[i], value[i]);
}

