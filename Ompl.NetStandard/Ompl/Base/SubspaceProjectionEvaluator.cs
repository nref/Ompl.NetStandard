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

public class SubspaceProjectionEvaluator : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SubspaceProjectionEvaluator(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SubspaceProjectionEvaluator obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SubspaceProjectionEvaluator() {
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
          ompl_basePINVOKE.delete_SubspaceProjectionEvaluator(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public void setup() {
    ompl_basePINVOKE.SubspaceProjectionEvaluator_setup(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getDimension() {
    uint ret = ompl_basePINVOKE.SubspaceProjectionEvaluator_getDimension(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}