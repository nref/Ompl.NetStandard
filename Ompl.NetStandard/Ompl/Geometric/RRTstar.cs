//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Ompl.Geometric {

using Ompl.Base;

public class RRTstar : Planner {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal RRTstar(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ompl_geometricPINVOKE.RRTstar_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RRTstar obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ompl_geometricPINVOKE.delete_RRTstar(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public RRTstar(SpaceInformation si) : this(ompl_geometricPINVOKE.new_RRTstar(SpaceInformation.getCPtr(si)), true) {
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void getPlannerData(PlannerData data) {
    ompl_geometricPINVOKE.RRTstar_getPlannerData(swigCPtr, PlannerData.getCPtr(data));
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public override PlannerStatus solve(PlannerTerminationCondition ptc) {
    PlannerStatus ret = new PlannerStatus(ompl_geometricPINVOKE.RRTstar_solve(swigCPtr, PlannerTerminationCondition.getCPtr(ptc)), true);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void clear() {
    ompl_geometricPINVOKE.RRTstar_clear(swigCPtr);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void setup() {
    ompl_geometricPINVOKE.RRTstar_setup(swigCPtr);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setGoalBias(double goalBias) {
    ompl_geometricPINVOKE.RRTstar_setGoalBias(swigCPtr, goalBias);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public double getGoalBias() {
    double ret = ompl_geometricPINVOKE.RRTstar_getGoalBias(swigCPtr);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setRange(double distance) {
    ompl_geometricPINVOKE.RRTstar_setRange(swigCPtr, distance);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public double getRange() {
    double ret = ompl_geometricPINVOKE.RRTstar_getRange(swigCPtr);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setRewireFactor(double rewireFactor) {
    ompl_geometricPINVOKE.RRTstar_setRewireFactor(swigCPtr, rewireFactor);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public double getRewireFactor() {
    double ret = ompl_geometricPINVOKE.RRTstar_getRewireFactor(swigCPtr);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setDelayCC(bool delayCC) {
    ompl_geometricPINVOKE.RRTstar_setDelayCC(swigCPtr, delayCC);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getDelayCC() {
    bool ret = ompl_geometricPINVOKE.RRTstar_getDelayCC(swigCPtr);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setTreePruning(bool prune) {
    ompl_geometricPINVOKE.RRTstar_setTreePruning(swigCPtr, prune);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getTreePruning() {
    bool ret = ompl_geometricPINVOKE.RRTstar_getTreePruning(swigCPtr);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setPruneThreshold(double pp) {
    ompl_geometricPINVOKE.RRTstar_setPruneThreshold(swigCPtr, pp);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public double getPruneThreshold() {
    double ret = ompl_geometricPINVOKE.RRTstar_getPruneThreshold(swigCPtr);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setPrunedMeasure(bool informedMeasure) {
    ompl_geometricPINVOKE.RRTstar_setPrunedMeasure(swigCPtr, informedMeasure);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getPrunedMeasure() {
    bool ret = ompl_geometricPINVOKE.RRTstar_getPrunedMeasure(swigCPtr);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setInformedSampling(bool informedSampling) {
    ompl_geometricPINVOKE.RRTstar_setInformedSampling(swigCPtr, informedSampling);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getInformedSampling() {
    bool ret = ompl_geometricPINVOKE.RRTstar_getInformedSampling(swigCPtr);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setSampleRejection(bool reject) {
    ompl_geometricPINVOKE.RRTstar_setSampleRejection(swigCPtr, reject);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getSampleRejection() {
    bool ret = ompl_geometricPINVOKE.RRTstar_getSampleRejection(swigCPtr);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setNewStateRejection(bool reject) {
    ompl_geometricPINVOKE.RRTstar_setNewStateRejection(swigCPtr, reject);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getNewStateRejection() {
    bool ret = ompl_geometricPINVOKE.RRTstar_getNewStateRejection(swigCPtr);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setAdmissibleCostToCome(bool admissible) {
    ompl_geometricPINVOKE.RRTstar_setAdmissibleCostToCome(swigCPtr, admissible);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getAdmissibleCostToCome() {
    bool ret = ompl_geometricPINVOKE.RRTstar_getAdmissibleCostToCome(swigCPtr);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setOrderedSampling(bool orderSamples) {
    ompl_geometricPINVOKE.RRTstar_setOrderedSampling(swigCPtr, orderSamples);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getOrderedSampling() {
    bool ret = ompl_geometricPINVOKE.RRTstar_getOrderedSampling(swigCPtr);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setBatchSize(uint batchSize) {
    ompl_geometricPINVOKE.RRTstar_setBatchSize(swigCPtr, batchSize);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getBatchSize() {
    uint ret = ompl_geometricPINVOKE.RRTstar_getBatchSize(swigCPtr);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setFocusSearch(bool focus) {
    ompl_geometricPINVOKE.RRTstar_setFocusSearch(swigCPtr, focus);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getFocusSearch() {
    bool ret = ompl_geometricPINVOKE.RRTstar_getFocusSearch(swigCPtr);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setKNearest(bool useKNearest) {
    ompl_geometricPINVOKE.RRTstar_setKNearest(swigCPtr, useKNearest);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getKNearest() {
    bool ret = ompl_geometricPINVOKE.RRTstar_getKNearest(swigCPtr);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setNumSamplingAttempts(uint numAttempts) {
    ompl_geometricPINVOKE.RRTstar_setNumSamplingAttempts(swigCPtr, numAttempts);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getNumSamplingAttempts() {
    uint ret = ompl_geometricPINVOKE.RRTstar_getNumSamplingAttempts(swigCPtr);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint numIterations() {
    uint ret = ompl_geometricPINVOKE.RRTstar_numIterations(swigCPtr);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Cost bestCost() {
    Cost ret = new Cost(ompl_geometricPINVOKE.RRTstar_bestCost(swigCPtr), true);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
