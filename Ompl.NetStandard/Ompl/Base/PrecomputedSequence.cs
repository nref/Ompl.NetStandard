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

public class PrecomputedSequence : DeterministicSequence {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal PrecomputedSequence(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ompl_basePINVOKE.PrecomputedSequence_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PrecomputedSequence obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ompl_basePINVOKE.delete_PrecomputedSequence(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public PrecomputedSequence(string path, uint dimensions, bool shuffle, uint max_samples) : this(ompl_basePINVOKE.new_PrecomputedSequence__SWIG_0(path, dimensions, shuffle, max_samples), true) {
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public PrecomputedSequence(string path, uint dimensions, bool shuffle) : this(ompl_basePINVOKE.new_PrecomputedSequence__SWIG_1(path, dimensions, shuffle), true) {
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public PrecomputedSequence(string path, uint dimensions) : this(ompl_basePINVOKE.new_PrecomputedSequence__SWIG_2(path, dimensions), true) {
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public override doubleVector sample() {
    doubleVector ret = new doubleVector(ompl_basePINVOKE.PrecomputedSequence_sample(swigCPtr), true);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
