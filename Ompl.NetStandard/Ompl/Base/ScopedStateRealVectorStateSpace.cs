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

public class ScopedStateRealVectorStateSpace : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ScopedStateRealVectorStateSpace(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ScopedStateRealVectorStateSpace obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(ScopedStateRealVectorStateSpace obj) {
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

  ~ScopedStateRealVectorStateSpace() {
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
          ompl_basePINVOKE.delete_ScopedStateRealVectorStateSpace(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public ScopedStateRealVectorStateSpace(SpaceInformation si) : this(ompl_basePINVOKE.new_ScopedStateRealVectorStateSpace__SWIG_0(SpaceInformation.getCPtr(si)), true) {
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public ScopedStateRealVectorStateSpace(StateSpace space) : this(ompl_basePINVOKE.new_ScopedStateRealVectorStateSpace__SWIG_1(StateSpace.getCPtr(space)), true) {
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public ScopedStateRealVectorStateSpace(ScopedStateRealVectorStateSpace other) : this(ompl_basePINVOKE.new_ScopedStateRealVectorStateSpace__SWIG_2(ScopedStateRealVectorStateSpace.getCPtr(other)), true) {
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public ScopedStateRealVectorStateSpace(StateSpace space, State state) : this(ompl_basePINVOKE.new_ScopedStateRealVectorStateSpace__SWIG_3(StateSpace.getCPtr(space), State.getCPtr(state)), true) {
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public StateSpace getSpace() {
    global::System.IntPtr cPtr = ompl_basePINVOKE.ScopedStateRealVectorStateSpace_getSpace(swigCPtr);
    StateSpace ret = (cPtr == global::System.IntPtr.Zero) ? null : new StateSpace(cPtr, true);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double distance(State state) {
    double ret = ompl_basePINVOKE.ScopedStateRealVectorStateSpace_distance(swigCPtr, State.getCPtr(state));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void random() {
    ompl_basePINVOKE.ScopedStateRealVectorStateSpace_random(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public void enforceBounds() {
    ompl_basePINVOKE.ScopedStateRealVectorStateSpace_enforceBounds(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool satisfiesBounds() {
    bool ret = ompl_basePINVOKE.ScopedStateRealVectorStateSpace_satisfiesBounds(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public doubleVector reals() {
    doubleVector ret = new doubleVector(ompl_basePINVOKE.ScopedStateRealVectorStateSpace_reals(swigCPtr), true);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void _print(SWIGTYPE_p_std__ostream _out) {
    ompl_basePINVOKE.ScopedStateRealVectorStateSpace__print__SWIG_0(swigCPtr, SWIGTYPE_p_std__ostream.getCPtr(_out));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _print() {
    ompl_basePINVOKE.ScopedStateRealVectorStateSpace__print__SWIG_1(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public RealVectorStateSpace.StateType __ref__() {
    RealVectorStateSpace.StateType ret = new RealVectorStateSpace.StateType(ompl_basePINVOKE.ScopedStateRealVectorStateSpace___ref____SWIG_0(swigCPtr), false);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public RealVectorStateSpace.StateType __deref__() {
    global::System.IntPtr cPtr = ompl_basePINVOKE.ScopedStateRealVectorStateSpace___deref____SWIG_0(swigCPtr);
    RealVectorStateSpace.StateType ret = (cPtr == global::System.IntPtr.Zero) ? null : new RealVectorStateSpace.StateType(cPtr, false);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public RealVectorStateSpace.StateType get() {
    global::System.IntPtr cPtr = ompl_basePINVOKE.ScopedStateRealVectorStateSpace_get__SWIG_0(swigCPtr);
    RealVectorStateSpace.StateType ret = (cPtr == global::System.IntPtr.Zero) ? null : new RealVectorStateSpace.StateType(cPtr, false);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_double values {
    set {
      ompl_basePINVOKE.ScopedStateRealVectorStateSpace_values_set(swigCPtr, SWIGTYPE_p_double.getCPtr(value));
      if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = ompl_basePINVOKE.ScopedStateRealVectorStateSpace_values_get(swigCPtr);
      SWIGTYPE_p_double ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_double(cPtr, false);
      if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

}

}
