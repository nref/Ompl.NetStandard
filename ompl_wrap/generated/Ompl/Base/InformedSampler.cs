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

public class InformedSampler : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal InformedSampler(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(InformedSampler obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(InformedSampler obj) {
    if (obj != null) {
      if (!obj.swigCMemOwn)
        throw new global::System.ApplicationException("Cannot release ownership as memory is not owned");
      global::System.Runtime.InteropServices.HandleRef ptr = obj.swigCPtr;
      obj.swigCMemOwn = false;
      obj.Dispose();
      return ptr;
    } else {
      return new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
    }
  }

  ~InformedSampler() {
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
          ompl_basePINVOKE.delete_InformedSampler(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public virtual bool sampleUniform(State statePtr, Cost maxCost) {
    bool ret = ompl_basePINVOKE.InformedSampler_sampleUniform__SWIG_0(swigCPtr, State.getCPtr(statePtr), Cost.getCPtr(maxCost));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool sampleUniform(State statePtr, Cost minCost, Cost maxCost) {
    bool ret = ompl_basePINVOKE.InformedSampler_sampleUniform__SWIG_1(swigCPtr, State.getCPtr(statePtr), Cost.getCPtr(minCost), Cost.getCPtr(maxCost));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool hasInformedMeasure() {
    bool ret = ompl_basePINVOKE.InformedSampler_hasInformedMeasure(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getInformedMeasure(Cost currentCost) {
    double ret = ompl_basePINVOKE.InformedSampler_getInformedMeasure__SWIG_0(swigCPtr, Cost.getCPtr(currentCost));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getInformedMeasure(Cost minCost, Cost maxCost) {
    double ret = ompl_basePINVOKE.InformedSampler_getInformedMeasure__SWIG_1(swigCPtr, Cost.getCPtr(minCost), Cost.getCPtr(maxCost));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Cost heuristicSolnCost(State statePtr) {
    Cost ret = new Cost(ompl_basePINVOKE.InformedSampler_heuristicSolnCost(swigCPtr, State.getCPtr(statePtr)), true);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ProblemDefinition getProblemDefn() {
    global::System.IntPtr cPtr = ompl_basePINVOKE.InformedSampler_getProblemDefn(swigCPtr);
    ProblemDefinition ret = (cPtr == global::System.IntPtr.Zero) ? null : new ProblemDefinition(cPtr, true);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getMaxNumberOfIters() {
    uint ret = ompl_basePINVOKE.InformedSampler_getMaxNumberOfIters(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
