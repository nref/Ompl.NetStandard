%module(directors="1") ompl_geometric

%typemap(csimports) SWIGTYPE
%{
using Ompl.Base;
%}

%include common.i
%import "ompl_base.i"

%{

#include "ompl/geometric/PathGeometric.h"
#include "ompl/geometric/PathSimplifier.h"
#include "ompl/geometric/SimpleSetup.h"
#include "ompl/geometric/planners/kpiece/KPIECE1.h"
#include "ompl/geometric/planners/kpiece/BKPIECE1.h"
#include "ompl/geometric/planners/rrt/RRTConnect.h"
#include "ompl/geometric/planners/rrt/RRTstar.h"
#include "ompl/geometric/planners/prm/PRM.h"
#include "ompl/geometric/planners/prm/PRMstar.h"

%}

// Prevent CS0115 'PathGeometric._print(SWIGTYPE_p_std__ostream)': no suitable method found to override
// PathGeometric::print overrides ompl::base::Path::print
// They both take an std::ostream references.
// std::ostream gets mapped a separate C# type for each SWIG module it is referenced in.
// In this case, Ompl.Base.SWIGTYPE_p_std__ostream conflicts with Ompl.Geometric.SWIGTYPE_p_std__ostream
%ignore ompl::geometric::PathGeometric::print;

// PRM.h Ignore boost aliases
%ignore ompl::geometric::PRM::vertex_state_t;
%ignore ompl::geometric::PRM::vertex_total_connection_attempts_t;
%ignore ompl::geometric::PRM::vertex_successful_connection_attempts_t;
%ignore ompl::geometric::PRM::Graph;
%ignore ompl::geometric::PRM::Vertex;
%ignore ompl::geometric::PRM::Edge;
%ignore ompl::geometric::PRM::RoadmapNeighbors;
%ignore ompl::geometric::PRM::ConnectionFilter;
%ignore ompl::geometric::PRM::ConnectionStrategy;
%ignore ompl::geometric::PRM::setConnectionStrategy;
%ignore ompl::geometric::PRM::setConnectionFilter;
%ignore ompl::geometric::PRM::getRoadmap;
%ignore ompl::geometric::PRM::getNearestNeighbors;

%shared_ptr(ompl::base::SpaceInformation);
%shared_ptr(ompl::geometric::PathGeometric);
%shared_ptr(ompl::geometric::PathSimplifier);
%shared_ptr(ompl::geometric::SimpleSetup);
%shared_ptr(ompl::geometric::KPIECE1);
%shared_ptr(ompl::geometric::BKPIECE1);
%shared_ptr(ompl::geometric::RRTConnect);
%shared_ptr(ompl::geometric::RRTstar);
%shared_ptr(ompl::geometric::PRM);
%shared_ptr(ompl::geometric::PRMstar);

%include "ompl/geometric/PathGeometric.h"
%include "ompl/geometric/PathSimplifier.h"
%include "ompl/geometric/SimpleSetup.h"
%include "ompl/geometric/planners/kpiece/KPIECE1.h"
%include "ompl/geometric/planners/kpiece/BKPIECE1.h"
%include "ompl/geometric/planners/rrt/RRTConnect.h"
%include "ompl/geometric/planners/rrt/RRTstar.h"
%include "ompl/geometric/planners/prm/PRM.h"
%include "ompl/geometric/planners/prm/PRMstar.h"
