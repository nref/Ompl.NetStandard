//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Ompl.Base {

public enum GoalType {
  GOAL_ANY = 1,
  GOAL_REGION = GOAL_ANY+2,
  GOAL_SAMPLEABLE_REGION = GOAL_REGION+4,
  GOAL_STATE = GOAL_SAMPLEABLE_REGION+8,
  GOAL_STATES = GOAL_SAMPLEABLE_REGION+16,
  GOAL_LAZY_SAMPLES = GOAL_STATES+32
}

}