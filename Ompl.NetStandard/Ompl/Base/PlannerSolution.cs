//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Ompl.Base {

public class PlannerSolution : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PlannerSolution(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PlannerSolution obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PlannerSolution() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ompl_basePINVOKE.delete_PlannerSolution(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public PlannerSolution(Path path) : this(ompl_basePINVOKE.new_PlannerSolution(Path.getCPtr(path)), true) {
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setApproximate(double difference) {
    ompl_basePINVOKE.PlannerSolution_setApproximate(swigCPtr, difference);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setOptimized(OptimizationObjective opt, Cost cost, bool meetsObjective) {
    ompl_basePINVOKE.PlannerSolution_setOptimized(swigCPtr, OptimizationObjective.getCPtr(opt), Cost.getCPtr(cost), meetsObjective);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setPlannerName(string name) {
    ompl_basePINVOKE.PlannerSolution_setPlannerName(swigCPtr, name);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public int index_ {
    set {
      ompl_basePINVOKE.PlannerSolution_index__set(swigCPtr, value);
      if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = ompl_basePINVOKE.PlannerSolution_index__get(swigCPtr);
      if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public Path path_ {
    set {
      ompl_basePINVOKE.PlannerSolution_path__set(swigCPtr, Path.getCPtr(value));
      if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = ompl_basePINVOKE.PlannerSolution_path__get(swigCPtr);
      Path ret = (cPtr == global::System.IntPtr.Zero) ? null : new Path(cPtr, true);
      if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double length_ {
    set {
      ompl_basePINVOKE.PlannerSolution_length__set(swigCPtr, value);
      if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = ompl_basePINVOKE.PlannerSolution_length__get(swigCPtr);
      if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool approximate_ {
    set {
      ompl_basePINVOKE.PlannerSolution_approximate__set(swigCPtr, value);
      if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      bool ret = ompl_basePINVOKE.PlannerSolution_approximate__get(swigCPtr);
      if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double difference_ {
    set {
      ompl_basePINVOKE.PlannerSolution_difference__set(swigCPtr, value);
      if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = ompl_basePINVOKE.PlannerSolution_difference__get(swigCPtr);
      if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool optimized_ {
    set {
      ompl_basePINVOKE.PlannerSolution_optimized__set(swigCPtr, value);
      if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      bool ret = ompl_basePINVOKE.PlannerSolution_optimized__get(swigCPtr);
      if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public OptimizationObjective opt_ {
    set {
      ompl_basePINVOKE.PlannerSolution_opt__set(swigCPtr, OptimizationObjective.getCPtr(value));
      if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = ompl_basePINVOKE.PlannerSolution_opt__get(swigCPtr);
      OptimizationObjective ret = (cPtr == global::System.IntPtr.Zero) ? null : new OptimizationObjective(cPtr, true);
      if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public Cost cost_ {
    set {
      ompl_basePINVOKE.PlannerSolution_cost__set(swigCPtr, Cost.getCPtr(value));
      if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = ompl_basePINVOKE.PlannerSolution_cost__get(swigCPtr);
      Cost ret = (cPtr == global::System.IntPtr.Zero) ? null : new Cost(cPtr, false);
      if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string plannerName_ {
    set {
      ompl_basePINVOKE.PlannerSolution_plannerName__set(swigCPtr, value);
      if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = ompl_basePINVOKE.PlannerSolution_plannerName__get(swigCPtr);
      if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

}

}