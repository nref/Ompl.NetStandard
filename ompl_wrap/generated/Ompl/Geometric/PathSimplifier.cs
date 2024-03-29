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

public class PathSimplifier : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal PathSimplifier(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PathSimplifier obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PathSimplifier() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnBase) {
          swigCMemOwnBase = false;
          ompl_geometricPINVOKE.delete_PathSimplifier(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public PathSimplifier(SpaceInformation si, Goal goal, OptimizationObjective obj) : this(ompl_geometricPINVOKE.new_PathSimplifier__SWIG_0(SpaceInformation.getCPtr(si), Goal.getCPtr(goal), OptimizationObjective.getCPtr(obj)), true) {
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public PathSimplifier(SpaceInformation si, Goal goal) : this(ompl_geometricPINVOKE.new_PathSimplifier__SWIG_1(SpaceInformation.getCPtr(si), Goal.getCPtr(goal)), true) {
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public PathSimplifier(SpaceInformation si) : this(ompl_geometricPINVOKE.new_PathSimplifier__SWIG_2(SpaceInformation.getCPtr(si)), true) {
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool reduceVertices(PathGeometric path, uint maxSteps, uint maxEmptySteps, double rangeRatio) {
    bool ret = ompl_geometricPINVOKE.PathSimplifier_reduceVertices__SWIG_0(swigCPtr, PathGeometric.getCPtr(path), maxSteps, maxEmptySteps, rangeRatio);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool reduceVertices(PathGeometric path, uint maxSteps, uint maxEmptySteps) {
    bool ret = ompl_geometricPINVOKE.PathSimplifier_reduceVertices__SWIG_1(swigCPtr, PathGeometric.getCPtr(path), maxSteps, maxEmptySteps);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool reduceVertices(PathGeometric path, uint maxSteps) {
    bool ret = ompl_geometricPINVOKE.PathSimplifier_reduceVertices__SWIG_2(swigCPtr, PathGeometric.getCPtr(path), maxSteps);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool reduceVertices(PathGeometric path) {
    bool ret = ompl_geometricPINVOKE.PathSimplifier_reduceVertices__SWIG_3(swigCPtr, PathGeometric.getCPtr(path));
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool shortcutPath(PathGeometric path, uint maxSteps, uint maxEmptySteps, double rangeRatio, double snapToVertex) {
    bool ret = ompl_geometricPINVOKE.PathSimplifier_shortcutPath__SWIG_0(swigCPtr, PathGeometric.getCPtr(path), maxSteps, maxEmptySteps, rangeRatio, snapToVertex);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool shortcutPath(PathGeometric path, uint maxSteps, uint maxEmptySteps, double rangeRatio) {
    bool ret = ompl_geometricPINVOKE.PathSimplifier_shortcutPath__SWIG_1(swigCPtr, PathGeometric.getCPtr(path), maxSteps, maxEmptySteps, rangeRatio);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool shortcutPath(PathGeometric path, uint maxSteps, uint maxEmptySteps) {
    bool ret = ompl_geometricPINVOKE.PathSimplifier_shortcutPath__SWIG_2(swigCPtr, PathGeometric.getCPtr(path), maxSteps, maxEmptySteps);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool shortcutPath(PathGeometric path, uint maxSteps) {
    bool ret = ompl_geometricPINVOKE.PathSimplifier_shortcutPath__SWIG_3(swigCPtr, PathGeometric.getCPtr(path), maxSteps);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool shortcutPath(PathGeometric path) {
    bool ret = ompl_geometricPINVOKE.PathSimplifier_shortcutPath__SWIG_4(swigCPtr, PathGeometric.getCPtr(path));
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool perturbPath(PathGeometric path, double stepSize, uint maxSteps, uint maxEmptySteps, double snapToVertex) {
    bool ret = ompl_geometricPINVOKE.PathSimplifier_perturbPath__SWIG_0(swigCPtr, PathGeometric.getCPtr(path), stepSize, maxSteps, maxEmptySteps, snapToVertex);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool perturbPath(PathGeometric path, double stepSize, uint maxSteps, uint maxEmptySteps) {
    bool ret = ompl_geometricPINVOKE.PathSimplifier_perturbPath__SWIG_1(swigCPtr, PathGeometric.getCPtr(path), stepSize, maxSteps, maxEmptySteps);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool perturbPath(PathGeometric path, double stepSize, uint maxSteps) {
    bool ret = ompl_geometricPINVOKE.PathSimplifier_perturbPath__SWIG_2(swigCPtr, PathGeometric.getCPtr(path), stepSize, maxSteps);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool perturbPath(PathGeometric path, double stepSize) {
    bool ret = ompl_geometricPINVOKE.PathSimplifier_perturbPath__SWIG_3(swigCPtr, PathGeometric.getCPtr(path), stepSize);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool collapseCloseVertices(PathGeometric path, uint maxSteps, uint maxEmptySteps) {
    bool ret = ompl_geometricPINVOKE.PathSimplifier_collapseCloseVertices__SWIG_0(swigCPtr, PathGeometric.getCPtr(path), maxSteps, maxEmptySteps);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool collapseCloseVertices(PathGeometric path, uint maxSteps) {
    bool ret = ompl_geometricPINVOKE.PathSimplifier_collapseCloseVertices__SWIG_1(swigCPtr, PathGeometric.getCPtr(path), maxSteps);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool collapseCloseVertices(PathGeometric path) {
    bool ret = ompl_geometricPINVOKE.PathSimplifier_collapseCloseVertices__SWIG_2(swigCPtr, PathGeometric.getCPtr(path));
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void smoothBSpline(PathGeometric path, uint maxSteps, double minChange) {
    ompl_geometricPINVOKE.PathSimplifier_smoothBSpline__SWIG_0(swigCPtr, PathGeometric.getCPtr(path), maxSteps, minChange);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public void smoothBSpline(PathGeometric path, uint maxSteps) {
    ompl_geometricPINVOKE.PathSimplifier_smoothBSpline__SWIG_1(swigCPtr, PathGeometric.getCPtr(path), maxSteps);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public void smoothBSpline(PathGeometric path) {
    ompl_geometricPINVOKE.PathSimplifier_smoothBSpline__SWIG_2(swigCPtr, PathGeometric.getCPtr(path));
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool simplifyMax(PathGeometric path) {
    bool ret = ompl_geometricPINVOKE.PathSimplifier_simplifyMax(swigCPtr, PathGeometric.getCPtr(path));
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool simplify(PathGeometric path, double maxTime, bool atLeastOnce) {
    bool ret = ompl_geometricPINVOKE.PathSimplifier_simplify__SWIG_0(swigCPtr, PathGeometric.getCPtr(path), maxTime, atLeastOnce);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool simplify(PathGeometric path, double maxTime) {
    bool ret = ompl_geometricPINVOKE.PathSimplifier_simplify__SWIG_1(swigCPtr, PathGeometric.getCPtr(path), maxTime);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool simplify(PathGeometric path, PlannerTerminationCondition ptc, bool atLeastOnce) {
    bool ret = ompl_geometricPINVOKE.PathSimplifier_simplify__SWIG_2(swigCPtr, PathGeometric.getCPtr(path), PlannerTerminationCondition.getCPtr(ptc), atLeastOnce);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool simplify(PathGeometric path, PlannerTerminationCondition ptc) {
    bool ret = ompl_geometricPINVOKE.PathSimplifier_simplify__SWIG_3(swigCPtr, PathGeometric.getCPtr(path), PlannerTerminationCondition.getCPtr(ptc));
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool findBetterGoal(PathGeometric path, double maxTime, uint samplingAttempts, double rangeRatio, double snapToVertex) {
    bool ret = ompl_geometricPINVOKE.PathSimplifier_findBetterGoal__SWIG_0(swigCPtr, PathGeometric.getCPtr(path), maxTime, samplingAttempts, rangeRatio, snapToVertex);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool findBetterGoal(PathGeometric path, double maxTime, uint samplingAttempts, double rangeRatio) {
    bool ret = ompl_geometricPINVOKE.PathSimplifier_findBetterGoal__SWIG_1(swigCPtr, PathGeometric.getCPtr(path), maxTime, samplingAttempts, rangeRatio);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool findBetterGoal(PathGeometric path, double maxTime, uint samplingAttempts) {
    bool ret = ompl_geometricPINVOKE.PathSimplifier_findBetterGoal__SWIG_2(swigCPtr, PathGeometric.getCPtr(path), maxTime, samplingAttempts);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool findBetterGoal(PathGeometric path, double maxTime) {
    bool ret = ompl_geometricPINVOKE.PathSimplifier_findBetterGoal__SWIG_3(swigCPtr, PathGeometric.getCPtr(path), maxTime);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool findBetterGoal(PathGeometric path, PlannerTerminationCondition ptc, uint samplingAttempts, double rangeRatio, double snapToVertex) {
    bool ret = ompl_geometricPINVOKE.PathSimplifier_findBetterGoal__SWIG_4(swigCPtr, PathGeometric.getCPtr(path), PlannerTerminationCondition.getCPtr(ptc), samplingAttempts, rangeRatio, snapToVertex);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool findBetterGoal(PathGeometric path, PlannerTerminationCondition ptc, uint samplingAttempts, double rangeRatio) {
    bool ret = ompl_geometricPINVOKE.PathSimplifier_findBetterGoal__SWIG_5(swigCPtr, PathGeometric.getCPtr(path), PlannerTerminationCondition.getCPtr(ptc), samplingAttempts, rangeRatio);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool findBetterGoal(PathGeometric path, PlannerTerminationCondition ptc, uint samplingAttempts) {
    bool ret = ompl_geometricPINVOKE.PathSimplifier_findBetterGoal__SWIG_6(swigCPtr, PathGeometric.getCPtr(path), PlannerTerminationCondition.getCPtr(ptc), samplingAttempts);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool findBetterGoal(PathGeometric path, PlannerTerminationCondition ptc) {
    bool ret = ompl_geometricPINVOKE.PathSimplifier_findBetterGoal__SWIG_7(swigCPtr, PathGeometric.getCPtr(path), PlannerTerminationCondition.getCPtr(ptc));
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void freeStates(bool flag) {
    ompl_geometricPINVOKE.PathSimplifier_freeStates__SWIG_0(swigCPtr, flag);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool freeStates() {
    bool ret = ompl_geometricPINVOKE.PathSimplifier_freeStates__SWIG_1(swigCPtr);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
