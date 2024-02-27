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

public class CompoundStateSampler : StateSampler {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal CompoundStateSampler(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ompl_basePINVOKE.CompoundStateSampler_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CompoundStateSampler obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ompl_basePINVOKE.delete_CompoundStateSampler(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public CompoundStateSampler(StateSpace space) : this(ompl_basePINVOKE.new_CompoundStateSampler(StateSpace.getCPtr(space)), true) {
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void addSampler(StateSampler sampler, double weightImportance) {
    ompl_basePINVOKE.CompoundStateSampler_addSampler(swigCPtr, StateSampler.getCPtr(sampler), weightImportance);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void sampleUniform(State state) {
    ompl_basePINVOKE.CompoundStateSampler_sampleUniform(swigCPtr, State.getCPtr(state));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void sampleUniformNear(State state, State near, double distance) {
    ompl_basePINVOKE.CompoundStateSampler_sampleUniformNear(swigCPtr, State.getCPtr(state), State.getCPtr(near), distance);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void sampleGaussian(State state, State mean, double stdDev) {
    ompl_basePINVOKE.CompoundStateSampler_sampleGaussian(swigCPtr, State.getCPtr(state), State.getCPtr(mean), stdDev);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

}

}
