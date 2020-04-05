%module(directors="1") ompl_base
%include common.i

// Allow C# classes to inherit from these classes
%feature("director") ompl::base::MotionValidator;
%feature("director") ompl::base::ValidStateSampler;
%feature("director") ompl::base::StateValidityChecker;

%{

#include "ompl/base/Cost.h"
#include "ompl/base/GenericParam.h"
#include "ompl/base/GoalTypes.h"
#include "ompl/base/Path.h"
#include "ompl/base/State.h"
#include "ompl/base/StateValidityChecker.h"
#include "ompl/base/ValidStateSampler.h"
#include "ompl/base/MotionValidator.h"
#include "ompl/base/PlannerData.h"
#include "ompl/base/PlannerTerminationCondition.h"
#include "ompl/base/PlannerStatus.h"
#include "ompl/base/Goal.h"
#include "ompl/base/ScopedState.h"
#include "ompl/base/SolutionNonExistenceProof.h"
#include "ompl/base/ProblemDefinition.h"
#include "ompl/base/Planner.h"
#include "ompl/base/ProjectionEvaluator.h"
#include "ompl/base/StateSampler.h"
#include "ompl/base/samplers/InformedStateSampler.h"
#include "ompl/base/StateSpace.h"
#include "ompl/base/spaces/RealVectorBounds.h"
#include "ompl/base/spaces/RealVectorStateSpace.h"
#include "ompl/base/SpaceInformation.h"
#include "ompl/base/OptimizationObjective.h"

%}

%shared_ptr(ompl::base::Path);
%shared_ptr(ompl::base::PlannerData);
%shared_ptr(ompl::base::PlannerTerminationCondition);
%shared_ptr(ompl::base::PlannerStatus);
%shared_ptr(ompl::base::ProblemDefinition);
%shared_ptr(ompl::base::Planner);
%shared_ptr(ompl::base::StateSpace);
%shared_ptr(ompl::base::ControlSpace);
%shared_ptr(ompl::base::OptimizationObjective);
%shared_ptr(ompl::base::MultiOptimizationObjective);
%shared_ptr(ompl::base::Goal);
%shared_ptr(ompl::base::CompoundStateSpace);
%shared_ptr(ompl::base::RealVectorStateSpace);
%shared_ptr(ompl::base::SpaceInformation);
%shared_ptr(ompl::base::StateSampler);
%shared_ptr(ompl::base::InformedStateSampler);
%shared_ptr(ompl::base::CompoundStateSampler);
%shared_ptr(ompl::base::SubspaceStateSampler);
%shared_ptr(ompl::base::RealVectorStateSampler);
%shared_ptr(ompl::base::RealVectorBounds);

%include "ompl/base/Cost.h"
%include "ompl/base/GenericParam.h"
%include "ompl/base/GoalTypes.h"
%include "ompl/base/Path.h"
%include "ompl/base/State.h"
%include "ompl/base/StateValidityChecker.h"
%include "ompl/base/ValidStateSampler.h"
%include "ompl/base/MotionValidator.h"
%include "ompl/base/PlannerData.h"
%include "ompl/base/PlannerTerminationCondition.h"
%include "ompl/base/PlannerStatus.h"
%include "ompl/base/Goal.h"
%include "ompl/base/ScopedState.h"
%include "ompl/base/SolutionNonExistenceProof.h"
%include "ompl/base/ProblemDefinition.h"
%include "ompl/base/Planner.h"
%include "ompl/base/ProjectionEvaluator.h"
%include "ompl/base/StateSampler.h"
%include "ompl/base/samplers/InformedStateSampler.h"
%include "ompl/base/StateSpace.h"
%include "ompl/base/spaces/RealVectorBounds.h"
%include "ompl/base/spaces/RealVectorStateSpace.h"
%include "ompl/base/SpaceInformation.h"
%include "ompl/base/OptimizationObjective.h"