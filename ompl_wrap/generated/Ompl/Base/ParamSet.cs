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

public class ParamSet : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ParamSet(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ParamSet obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(ParamSet obj) {
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

  ~ParamSet() {
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
          ompl_basePINVOKE.delete_ParamSet(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public void add(SWIGTYPE_p_std__shared_ptrT_ompl__base__GenericParam_t param) {
    ompl_basePINVOKE.ParamSet_add(swigCPtr, SWIGTYPE_p_std__shared_ptrT_ompl__base__GenericParam_t.getCPtr(param));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public void remove(string name) {
    ompl_basePINVOKE.ParamSet_remove(swigCPtr, name);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public void include(ParamSet other, string prefix) {
    ompl_basePINVOKE.ParamSet_include__SWIG_0(swigCPtr, ParamSet.getCPtr(other), prefix);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public void include(ParamSet other) {
    ompl_basePINVOKE.ParamSet_include__SWIG_1(swigCPtr, ParamSet.getCPtr(other));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool setParam(string key, string value) {
    bool ret = ompl_basePINVOKE.ParamSet_setParam(swigCPtr, key, value);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool getParam(string key, SWIGTYPE_p_std__string value) {
    bool ret = ompl_basePINVOKE.ParamSet_getParam__SWIG_0(swigCPtr, key, SWIGTYPE_p_std__string.getCPtr(value));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool setParams(SWIGTYPE_p_std__mapT_std__string_std__string_t kv, bool ignoreUnknown) {
    bool ret = ompl_basePINVOKE.ParamSet_setParams__SWIG_0(swigCPtr, SWIGTYPE_p_std__mapT_std__string_std__string_t.getCPtr(kv), ignoreUnknown);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool setParams(SWIGTYPE_p_std__mapT_std__string_std__string_t kv) {
    bool ret = ompl_basePINVOKE.ParamSet_setParams__SWIG_1(swigCPtr, SWIGTYPE_p_std__mapT_std__string_std__string_t.getCPtr(kv));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void getParams(SWIGTYPE_p_std__mapT_std__string_std__string_t params_) {
    ompl_basePINVOKE.ParamSet_getParams__SWIG_0(swigCPtr, SWIGTYPE_p_std__mapT_std__string_std__string_t.getCPtr(params_));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public void getParamNames(SWIGTYPE_p_std__vectorT_std__string_t params_) {
    ompl_basePINVOKE.ParamSet_getParamNames(swigCPtr, SWIGTYPE_p_std__vectorT_std__string_t.getCPtr(params_));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public void getParamValues(SWIGTYPE_p_std__vectorT_std__string_t vals) {
    ompl_basePINVOKE.ParamSet_getParamValues(swigCPtr, SWIGTYPE_p_std__vectorT_std__string_t.getCPtr(vals));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_std__mapT_std__string_std__shared_ptrT_ompl__base__GenericParam_t_t getParams() {
    SWIGTYPE_p_std__mapT_std__string_std__shared_ptrT_ompl__base__GenericParam_t_t ret = new SWIGTYPE_p_std__mapT_std__string_std__shared_ptrT_ompl__base__GenericParam_t_t(ompl_basePINVOKE.ParamSet_getParams__SWIG_1(swigCPtr), false);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__shared_ptrT_ompl__base__GenericParam_t getParam(string key) {
    SWIGTYPE_p_std__shared_ptrT_ompl__base__GenericParam_t ret = new SWIGTYPE_p_std__shared_ptrT_ompl__base__GenericParam_t(ompl_basePINVOKE.ParamSet_getParam__SWIG_1(swigCPtr, key), false);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool hasParam(string key) {
    bool ret = ompl_basePINVOKE.ParamSet_hasParam(swigCPtr, key);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint size() {
    uint ret = ompl_basePINVOKE.ParamSet_size(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void clear() {
    ompl_basePINVOKE.ParamSet_clear(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _print(SWIGTYPE_p_std__ostream _out) {
    ompl_basePINVOKE.ParamSet__print(swigCPtr, SWIGTYPE_p_std__ostream.getCPtr(_out));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public ParamSet() : this(ompl_basePINVOKE.new_ParamSet(), true) {
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

}

}
