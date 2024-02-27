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

public class RNG : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal RNG(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RNG obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(RNG obj) {
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

  ~RNG() {
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
          ompl_basePINVOKE.delete_RNG(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public RNG() : this(ompl_basePINVOKE.new_RNG__SWIG_0(), true) {
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public RNG(SWIGTYPE_p_std__uint_fast32_t localSeed) : this(ompl_basePINVOKE.new_RNG__SWIG_1(SWIGTYPE_p_std__uint_fast32_t.getCPtr(localSeed)), true) {
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public double uniform01() {
    double ret = ompl_basePINVOKE.RNG_uniform01(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double uniformReal(double lower_bound, double upper_bound) {
    double ret = ompl_basePINVOKE.RNG_uniformReal(swigCPtr, lower_bound, upper_bound);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int uniformInt(int lower_bound, int upper_bound) {
    int ret = ompl_basePINVOKE.RNG_uniformInt(swigCPtr, lower_bound, upper_bound);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool uniformBool() {
    bool ret = ompl_basePINVOKE.RNG_uniformBool(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double gaussian01() {
    double ret = ompl_basePINVOKE.RNG_gaussian01(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double gaussian(double mean, double stddev) {
    double ret = ompl_basePINVOKE.RNG_gaussian(swigCPtr, mean, stddev);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double halfNormalReal(double r_min, double r_max, double focus) {
    double ret = ompl_basePINVOKE.RNG_halfNormalReal__SWIG_0(swigCPtr, r_min, r_max, focus);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double halfNormalReal(double r_min, double r_max) {
    double ret = ompl_basePINVOKE.RNG_halfNormalReal__SWIG_1(swigCPtr, r_min, r_max);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int halfNormalInt(int r_min, int r_max, double focus) {
    int ret = ompl_basePINVOKE.RNG_halfNormalInt__SWIG_0(swigCPtr, r_min, r_max, focus);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int halfNormalInt(int r_min, int r_max) {
    int ret = ompl_basePINVOKE.RNG_halfNormalInt__SWIG_1(swigCPtr, r_min, r_max);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void quaternion(SWIGTYPE_p_double value) {
    ompl_basePINVOKE.RNG_quaternion(swigCPtr, SWIGTYPE_p_double.getCPtr(value));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public void eulerRPY(SWIGTYPE_p_double value) {
    ompl_basePINVOKE.RNG_eulerRPY(swigCPtr, SWIGTYPE_p_double.getCPtr(value));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public static void setSeed(SWIGTYPE_p_std__uint_fast32_t seed) {
    ompl_basePINVOKE.RNG_setSeed(SWIGTYPE_p_std__uint_fast32_t.getCPtr(seed));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public static SWIGTYPE_p_std__uint_fast32_t getSeed() {
    SWIGTYPE_p_std__uint_fast32_t ret = new SWIGTYPE_p_std__uint_fast32_t(ompl_basePINVOKE.RNG_getSeed(), true);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setLocalSeed(SWIGTYPE_p_std__uint_fast32_t localSeed) {
    ompl_basePINVOKE.RNG_setLocalSeed(swigCPtr, SWIGTYPE_p_std__uint_fast32_t.getCPtr(localSeed));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_std__uint_fast32_t getLocalSeed() {
    SWIGTYPE_p_std__uint_fast32_t ret = new SWIGTYPE_p_std__uint_fast32_t(ompl_basePINVOKE.RNG_getLocalSeed(swigCPtr), true);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void uniformNormalVector(doubleVector v) {
    ompl_basePINVOKE.RNG_uniformNormalVector(swigCPtr, doubleVector.getCPtr(v));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public void uniformInBall(double r, doubleVector v) {
    ompl_basePINVOKE.RNG_uniformInBall(swigCPtr, r, doubleVector.getCPtr(v));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public void uniformProlateHyperspheroidSurface(SWIGTYPE_p_std__shared_ptrT_ompl__ProlateHyperspheroid_const_t phsPtr, SWIGTYPE_p_double value) {
    ompl_basePINVOKE.RNG_uniformProlateHyperspheroidSurface(swigCPtr, SWIGTYPE_p_std__shared_ptrT_ompl__ProlateHyperspheroid_const_t.getCPtr(phsPtr), SWIGTYPE_p_double.getCPtr(value));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public void uniformProlateHyperspheroid(SWIGTYPE_p_std__shared_ptrT_ompl__ProlateHyperspheroid_const_t phsPtr, SWIGTYPE_p_double value) {
    ompl_basePINVOKE.RNG_uniformProlateHyperspheroid(swigCPtr, SWIGTYPE_p_std__shared_ptrT_ompl__ProlateHyperspheroid_const_t.getCPtr(phsPtr), SWIGTYPE_p_double.getCPtr(value));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

}

}
