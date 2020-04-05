%module(directors="1") ompl_control

%typemap(csimports) SWIGTYPE
%{
using Ompl.Base;
using Ompl.Geometric;
%}

%include common.i
%import "ompl_base.i"
%import "ompl_geometric.i"

%{

#include "ompl/control/Control.h"
#include "ompl/control/PathControl.h"
#include "ompl/control/ControlSampler.h"
#include "ompl/control/DirectedControlSampler.h"
#include "ompl/control/ControlSpaceTypes.h"
#include "ompl/control/ControlSpace.h"
#include "ompl/control/StatePropagator.h"
#include "ompl/control/SpaceInformation.h"
#include "ompl/control/SimpleSetup.h"
#include "ompl/control/planners/kpiece/KPIECE1.h"

%}

// Handle namespace conflicts
%rename("controlSpaceInformation") ompl::control::SpaceInformation;
%rename("controlKPIECE1") ompl::control::KPIECE1;
%rename("controlSimpleSetup") ompl::control::SimpleSetup;

// Prevent CS0115 'PathControl._print(SWIGTYPE_p_std__ostream)': no suitable method found to override
// PathGeometric::print overrides ompl::base::Path::print
// They both take an std::ostream references.
// std::ostream gets mapped a separate C# type for each SWIG module it is referenced in.
// In this case, Ompl.Base.SWIGTYPE_p_std__ostream and Ompl.Control.SWIGTYPE_p_std__ostream
%ignore ompl::control::PathControl::print;

%shared_ptr(ompl::control::PathControl);
%shared_ptr(ompl::control::ControlSampler);
%shared_ptr(ompl::control::CompoundControlSampler);
%shared_ptr(ompl::control::SpaceInformation);
%shared_ptr(ompl::control::KPIECE1);

%include "ompl/control/Control.h"
%include "ompl/control/PathControl.h"
%include "ompl/control/ControlSampler.h"
%include "ompl/control/DirectedControlSampler.h"
%include "ompl/control/ControlSpaceTypes.h"
%include "ompl/control/ControlSpace.h"
%include "ompl/control/StatePropagator.h"
%include "ompl/control/SpaceInformation.h"
%include "ompl/control/SimpleSetup.h"
%include "ompl/control/planners/kpiece/KPIECE1.h"