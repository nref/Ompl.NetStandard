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

%}

// Prevent CS0115 'PathGeometric._print(SWIGTYPE_p_std__ostream)': no suitable method found to override
// PathGeometric::print overrides ompl::base::Path::print
// They both take an std::ostream references.
// std::ostream gets mapped a separate C# type for each SWIG module it is referenced in.
// In this case, Ompl.Base.SWIGTYPE_p_std__ostream conflicts with Ompl.Geometric.SWIGTYPE_p_std__ostream
%ignore ompl::geometric::PathGeometric::print;

%shared_ptr(ompl::geometric::PathGeometric);
%shared_ptr(ompl::geometric::PathSimplifier);
%shared_ptr(ompl::geometric::SimpleSetup);
%shared_ptr(ompl::geometric::KPIECE1);

%include "ompl/geometric/PathGeometric.h"
%include "ompl/geometric/PathSimplifier.h"
%include "ompl/geometric/planners/kpiece/KPIECE1.h"
%include "ompl/geometric/SimpleSetup.h"