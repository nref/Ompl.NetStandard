//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.2.0
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Ompl.Geometric {

using Ompl.Base;

public class KPIECE1 : Planner {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal KPIECE1(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ompl_geometricPINVOKE.KPIECE1_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(KPIECE1 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ompl_geometricPINVOKE.delete_KPIECE1(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public KPIECE1(SpaceInformation si) : this(ompl_geometricPINVOKE.new_KPIECE1(SpaceInformation.getCPtr(si)), true) {
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public override PlannerStatus solve(PlannerTerminationCondition ptc) {
    PlannerStatus ret = new PlannerStatus(ompl_geometricPINVOKE.KPIECE1_solve(swigCPtr, PlannerTerminationCondition.getCPtr(ptc)), true);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void clear() {
    ompl_geometricPINVOKE.KPIECE1_clear(swigCPtr);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setGoalBias(double goalBias) {
    ompl_geometricPINVOKE.KPIECE1_setGoalBias(swigCPtr, goalBias);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public double getGoalBias() {
    double ret = ompl_geometricPINVOKE.KPIECE1_getGoalBias(swigCPtr);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setRange(double distance) {
    ompl_geometricPINVOKE.KPIECE1_setRange(swigCPtr, distance);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public double getRange() {
    double ret = ompl_geometricPINVOKE.KPIECE1_getRange(swigCPtr);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setBorderFraction(double bp) {
    ompl_geometricPINVOKE.KPIECE1_setBorderFraction(swigCPtr, bp);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public double getBorderFraction() {
    double ret = ompl_geometricPINVOKE.KPIECE1_getBorderFraction(swigCPtr);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setMinValidPathFraction(double fraction) {
    ompl_geometricPINVOKE.KPIECE1_setMinValidPathFraction(swigCPtr, fraction);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public double getMinValidPathFraction() {
    double ret = ompl_geometricPINVOKE.KPIECE1_getMinValidPathFraction(swigCPtr);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setFailedExpansionCellScoreFactor(double factor) {
    ompl_geometricPINVOKE.KPIECE1_setFailedExpansionCellScoreFactor(swigCPtr, factor);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public double getFailedExpansionCellScoreFactor() {
    double ret = ompl_geometricPINVOKE.KPIECE1_getFailedExpansionCellScoreFactor(swigCPtr);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setProjectionEvaluator(SWIGTYPE_p_std__shared_ptrT_ompl__base__ProjectionEvaluator_t projectionEvaluator) {
    ompl_geometricPINVOKE.KPIECE1_setProjectionEvaluator__SWIG_0(swigCPtr, SWIGTYPE_p_std__shared_ptrT_ompl__base__ProjectionEvaluator_t.getCPtr(projectionEvaluator));
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setProjectionEvaluator(string name) {
    ompl_geometricPINVOKE.KPIECE1_setProjectionEvaluator__SWIG_1(swigCPtr, name);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_std__shared_ptrT_ompl__base__ProjectionEvaluator_t getProjectionEvaluator() {
    SWIGTYPE_p_std__shared_ptrT_ompl__base__ProjectionEvaluator_t ret = new SWIGTYPE_p_std__shared_ptrT_ompl__base__ProjectionEvaluator_t(ompl_geometricPINVOKE.KPIECE1_getProjectionEvaluator(swigCPtr), false);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void setup() {
    ompl_geometricPINVOKE.KPIECE1_setup(swigCPtr);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void getPlannerData(PlannerData data) {
    ompl_geometricPINVOKE.KPIECE1_getPlannerData(swigCPtr, PlannerData.getCPtr(data));
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
