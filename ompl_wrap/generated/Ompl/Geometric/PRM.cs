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

public class PRM : Planner {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal PRM(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ompl_geometricPINVOKE.PRM_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PRM obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ompl_geometricPINVOKE.delete_PRM(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public PRM(SpaceInformation si, bool starStrategy) : this(ompl_geometricPINVOKE.new_PRM__SWIG_0(SpaceInformation.getCPtr(si), starStrategy), true) {
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public PRM(SpaceInformation si) : this(ompl_geometricPINVOKE.new_PRM__SWIG_1(SpaceInformation.getCPtr(si)), true) {
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public PRM(PlannerData data, bool starStrategy) : this(ompl_geometricPINVOKE.new_PRM__SWIG_2(PlannerData.getCPtr(data), starStrategy), true) {
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public PRM(PlannerData data) : this(ompl_geometricPINVOKE.new_PRM__SWIG_3(PlannerData.getCPtr(data)), true) {
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void setProblemDefinition(ProblemDefinition pdef) {
    ompl_geometricPINVOKE.PRM_setProblemDefinition(swigCPtr, ProblemDefinition.getCPtr(pdef));
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setDefaultConnectionStrategy() {
    ompl_geometricPINVOKE.PRM_setDefaultConnectionStrategy(swigCPtr);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setMaxNearestNeighbors(uint k) {
    ompl_geometricPINVOKE.PRM_setMaxNearestNeighbors(swigCPtr, k);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getMaxNearestNeighbors() {
    uint ret = ompl_geometricPINVOKE.PRM_getMaxNearestNeighbors(swigCPtr);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void getPlannerData(PlannerData data) {
    ompl_geometricPINVOKE.PRM_getPlannerData(swigCPtr, PlannerData.getCPtr(data));
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public void constructRoadmap(PlannerTerminationCondition ptc) {
    ompl_geometricPINVOKE.PRM_constructRoadmap(swigCPtr, PlannerTerminationCondition.getCPtr(ptc));
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public void growRoadmap(double growTime) {
    ompl_geometricPINVOKE.PRM_growRoadmap__SWIG_0(swigCPtr, growTime);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public void growRoadmap(PlannerTerminationCondition ptc) {
    ompl_geometricPINVOKE.PRM_growRoadmap__SWIG_1(swigCPtr, PlannerTerminationCondition.getCPtr(ptc));
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public void expandRoadmap(double expandTime) {
    ompl_geometricPINVOKE.PRM_expandRoadmap__SWIG_0(swigCPtr, expandTime);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public void expandRoadmap(PlannerTerminationCondition ptc) {
    ompl_geometricPINVOKE.PRM_expandRoadmap__SWIG_1(swigCPtr, PlannerTerminationCondition.getCPtr(ptc));
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public override PlannerStatus solve(PlannerTerminationCondition ptc) {
    PlannerStatus ret = new PlannerStatus(ompl_geometricPINVOKE.PRM_solve(swigCPtr, PlannerTerminationCondition.getCPtr(ptc)), true);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void clearQuery() {
    ompl_geometricPINVOKE.PRM_clearQuery(swigCPtr);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void clear() {
    ompl_geometricPINVOKE.PRM_clear(swigCPtr);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void setup() {
    ompl_geometricPINVOKE.PRM_setup(swigCPtr);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint milestoneCount() {
    uint ret = ompl_geometricPINVOKE.PRM_milestoneCount(swigCPtr);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint edgeCount() {
    uint ret = ompl_geometricPINVOKE.PRM_edgeCount(swigCPtr);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
