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

public class ProlateHyperspheroid : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ProlateHyperspheroid(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ProlateHyperspheroid obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(ProlateHyperspheroid obj) {
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

  ~ProlateHyperspheroid() {
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
          ompl_basePINVOKE.delete_ProlateHyperspheroid(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public ProlateHyperspheroid(uint n, SWIGTYPE_p_double focus1, SWIGTYPE_p_double focus2) : this(ompl_basePINVOKE.new_ProlateHyperspheroid(n, SWIGTYPE_p_double.getCPtr(focus1), SWIGTYPE_p_double.getCPtr(focus2)), true) {
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setTransverseDiameter(double transverseDiameter) {
    ompl_basePINVOKE.ProlateHyperspheroid_setTransverseDiameter(swigCPtr, transverseDiameter);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public void transform(SWIGTYPE_p_double sphere, SWIGTYPE_p_double phs) {
    ompl_basePINVOKE.ProlateHyperspheroid_transform(swigCPtr, SWIGTYPE_p_double.getCPtr(sphere), SWIGTYPE_p_double.getCPtr(phs));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isInPhs(SWIGTYPE_p_double point) {
    bool ret = ompl_basePINVOKE.ProlateHyperspheroid_isInPhs(swigCPtr, SWIGTYPE_p_double.getCPtr(point));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isOnPhs(SWIGTYPE_p_double point) {
    bool ret = ompl_basePINVOKE.ProlateHyperspheroid_isOnPhs(swigCPtr, SWIGTYPE_p_double.getCPtr(point));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getPhsDimension() {
    uint ret = ompl_basePINVOKE.ProlateHyperspheroid_getPhsDimension(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double getPhsMeasure() {
    double ret = ompl_basePINVOKE.ProlateHyperspheroid_getPhsMeasure__SWIG_0(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double getPhsMeasure(double tranDiam) {
    double ret = ompl_basePINVOKE.ProlateHyperspheroid_getPhsMeasure__SWIG_1(swigCPtr, tranDiam);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double getMinTransverseDiameter() {
    double ret = ompl_basePINVOKE.ProlateHyperspheroid_getMinTransverseDiameter(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double getPathLength(SWIGTYPE_p_double point) {
    double ret = ompl_basePINVOKE.ProlateHyperspheroid_getPathLength(swigCPtr, SWIGTYPE_p_double.getCPtr(point));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getDimension() {
    uint ret = ompl_basePINVOKE.ProlateHyperspheroid_getDimension(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
