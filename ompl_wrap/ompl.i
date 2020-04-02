%module(directors="1") ompl_wrap

%{

#include "ompl/util/ClassForward.h"
#include "ompl/util/Time.h"
#include "ompl/base/Cost.h"
#include "ompl/base/GenericParam.h"
#include "ompl/base/Path.h"
#include "ompl/base/PlannerTerminationCondition.h"
#include "ompl/base/ProjectionEvaluator.h"
#include "ompl/base/State.h"
#include "ompl/base/StateSpace.h"
#include "ompl/base/spaces/RealVectorBounds.h"
#include "ompl/base/spaces/RealVectorStateSpace.h"
#include "ompl/control/Control.h"
#include "ompl/control/ControlSampler.h"
#include "ompl/control/DirectedControlSampler.h"
#include "ompl/geometric/PathGeometric.h"
#include "ompl/geometric/PathSimplifier.h"
#include "ompl/geometric/SimpleSetup.h"
#include "ompl/control/PathControl.h"
#include "ompl/control/StatePropagator.h"
#include "ompl/control/SpaceInformation.h"

using State = ompl::base::State;
using StateSpace = ompl::base::StateSpace;
using StateSamplerPtr = ompl::base::StateSamplerPtr;
using StateSamplerAllocator = std::function<StateSamplerPtr(const StateSpace *)>;
using StatePropagatorFn = std::function<void(const ompl::base::State *, const ompl::control::Control *, const double, ompl::base::State *)>;

%}

%feature("director") ompl;

%ignore OMPL_CLASS_FORWARD;
%ignore ompl::base::ParamSet::declareParam;
%ignore ompl::base::ProjectionMatrix;
%ignore ompl::base::ProjectionEvaluator;

%include "ompl/util/ClassForward.h"
%include "ompl/util/Time.h"
%include "ompl/base/Cost.h"
%include "ompl/base/GenericParam.h"
%include "ompl/base/Path.h"
%include "ompl/base/PlannerTerminationCondition.h"
%include "ompl/base/ProjectionEvaluator.h"
%include "ompl/base/State.h"
%include "ompl/base/StateSpace.h"
%include "ompl/base/spaces/RealVectorBounds.h"
%include "ompl/base/spaces/RealVectorStateSpace.h"
%include "ompl/control/Control.h"
%include "ompl/control/ControlSampler.h"
%include "ompl/control/DirectedControlSampler.h"
%include "ompl/geometric/PathGeometric.h"
%include "ompl/geometric/PathSimplifier.h"
%include "ompl/geometric/SimpleSetup.h"
%include "ompl/control/PathControl.h"
%include "ompl/control/StatePropagator.h"
%include "ompl/control/SpaceInformation.h"
