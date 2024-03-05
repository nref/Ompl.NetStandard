//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.2.0
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Ompl.Base {

public class PathLengthOptimizationObjective : OptimizationObjective {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal PathLengthOptimizationObjective(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ompl_basePINVOKE.PathLengthOptimizationObjective_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PathLengthOptimizationObjective obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ompl_basePINVOKE.delete_PathLengthOptimizationObjective(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public PathLengthOptimizationObjective(SpaceInformation si) : this(ompl_basePINVOKE.new_PathLengthOptimizationObjective(SpaceInformation.getCPtr(si)), true) {
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public override Cost stateCost(State s) {
    Cost ret = new Cost(ompl_basePINVOKE.PathLengthOptimizationObjective_stateCost(swigCPtr, State.getCPtr(s)), true);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override Cost motionCost(State s1, State s2) {
    Cost ret = new Cost(ompl_basePINVOKE.PathLengthOptimizationObjective_motionCost(swigCPtr, State.getCPtr(s1), State.getCPtr(s2)), true);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override Cost motionCostHeuristic(State s1, State s2) {
    Cost ret = new Cost(ompl_basePINVOKE.PathLengthOptimizationObjective_motionCostHeuristic(swigCPtr, State.getCPtr(s1), State.getCPtr(s2)), true);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override SWIGTYPE_p_std__shared_ptrT_ompl__base__InformedSampler_t allocInformedStateSampler(ProblemDefinition probDefn, uint maxNumberCalls) {
    SWIGTYPE_p_std__shared_ptrT_ompl__base__InformedSampler_t ret = new SWIGTYPE_p_std__shared_ptrT_ompl__base__InformedSampler_t(ompl_basePINVOKE.PathLengthOptimizationObjective_allocInformedStateSampler(swigCPtr, ProblemDefinition.getCPtr(probDefn), maxNumberCalls), true);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
