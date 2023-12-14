//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Ompl.Geometric {

using Ompl.Base;

public class RRTConnect : Planner {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal RRTConnect(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ompl_geometricPINVOKE.RRTConnect_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RRTConnect obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ompl_geometricPINVOKE.delete_RRTConnect(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public RRTConnect(SpaceInformation si, bool addIntermediateStates) : this(ompl_geometricPINVOKE.new_RRTConnect__SWIG_0(SpaceInformation.getCPtr(si), addIntermediateStates), true) {
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public RRTConnect(SpaceInformation si) : this(ompl_geometricPINVOKE.new_RRTConnect__SWIG_1(SpaceInformation.getCPtr(si)), true) {
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void getPlannerData(PlannerData data) {
    ompl_geometricPINVOKE.RRTConnect_getPlannerData(swigCPtr, PlannerData.getCPtr(data));
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public override PlannerStatus solve(PlannerTerminationCondition ptc) {
    PlannerStatus ret = new PlannerStatus(ompl_geometricPINVOKE.RRTConnect_solve(swigCPtr, PlannerTerminationCondition.getCPtr(ptc)), true);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void clear() {
    ompl_geometricPINVOKE.RRTConnect_clear(swigCPtr);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getIntermediateStates() {
    bool ret = ompl_geometricPINVOKE.RRTConnect_getIntermediateStates(swigCPtr);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setIntermediateStates(bool addIntermediateStates) {
    ompl_geometricPINVOKE.RRTConnect_setIntermediateStates(swigCPtr, addIntermediateStates);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setRange(double distance) {
    ompl_geometricPINVOKE.RRTConnect_setRange(swigCPtr, distance);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public double getRange() {
    double ret = ompl_geometricPINVOKE.RRTConnect_getRange(swigCPtr);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void setup() {
    ompl_geometricPINVOKE.RRTConnect_setup(swigCPtr);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
