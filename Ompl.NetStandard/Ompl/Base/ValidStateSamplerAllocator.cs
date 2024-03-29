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

public class ValidStateSamplerAllocator : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ValidStateSamplerAllocator(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ValidStateSamplerAllocator obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(ValidStateSamplerAllocator obj) {
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

  ~ValidStateSamplerAllocator() {
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
          ompl_basePINVOKE.delete_ValidStateSamplerAllocator(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }


        //public delegate ompl::base::ValidStateSamplerPtr ValidStateSamplerAllocator##Delegate(FOR_EACH(param, const ompl::base::SpaceInformation *));
        public delegate ValidStateSampler ValidStateSamplerAllocatorDelegate(/*@SWIG:std_function.i,26,FOR_EACH@*/ 
  SpaceInformation arg0
/*@SWIG@*/);
                
        public class ConcreteDirector : ValidStateSamplerAllocatorDirector
        {
            public ConcreteDirector(ValidStateSamplerAllocatorDelegate f)
            {
                _f = f;
            }

            //protected override ompl::base::ValidStateSamplerPtr Invoke(FOR_EACH(param, const ompl::base::SpaceInformation *))
            protected override ValidStateSampler Invoke(/*@SWIG:std_function.i,26,FOR_EACH@*/ 
  SpaceInformation arg0
/*@SWIG@*/)
            {
                return _f.Invoke(/*@SWIG:std_function.i,26,FOR_EACH@*/ 
  arg0
/*@SWIG@*/);
            }

            private readonly ValidStateSamplerAllocatorDelegate _f;
        }

        public ValidStateSamplerAllocator(ValidStateSamplerAllocatorDelegate callback) 
        {
            _director = new ConcreteDirector(callback);
            _proxy = new ValidStateSamplerAllocator(_director);
            swigCPtr = _proxy.swigCPtr;
            swigCMemOwn = _proxy.swigCMemOwn;
        }

        public static ValidStateSamplerAllocator makeNative(ValidStateSamplerAllocator f) {
            return null == f._director
                ? f
                : f._proxy;
        }

        private readonly ValidStateSamplerAllocatorDirector _director;
        private readonly ValidStateSamplerAllocator _proxy;
    
  public ValidStateSamplerAllocator(ValidStateSamplerAllocator arg0) : this(ompl_basePINVOKE.new__function__SWIG_0(ValidStateSamplerAllocator.getCPtr(arg0)), true) {
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public ValidStateSampler Invoke(SpaceInformation arg0) {
    global::System.IntPtr cPtr = ompl_basePINVOKE.ValidStateSamplerAllocator_Invoke(swigCPtr, SpaceInformation.getCPtr(arg0));
    ValidStateSampler ret = (cPtr == global::System.IntPtr.Zero) ? null : new ValidStateSampler(cPtr, true);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ValidStateSamplerAllocator(SWIGTYPE_p_f_p_q_const__ompl__base__SpaceInformation__std__shared_ptrT_ompl__base__ValidStateSampler_t arg0) : this(ompl_basePINVOKE.new__function__SWIG_1(SWIGTYPE_p_f_p_q_const__ompl__base__SpaceInformation__std__shared_ptrT_ompl__base__ValidStateSampler_t.getCPtr(arg0)), true) {
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public ValidStateSamplerAllocator(ValidStateSamplerAllocatorDirector _in) : this(ompl_basePINVOKE.new__function__SWIG_2(ValidStateSamplerAllocatorDirector.getCPtr(_in)), true) {
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

}

}
