//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Ompl.Base {

public class ValidStateSampler : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal ValidStateSampler(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ValidStateSampler obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ValidStateSampler() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnBase) {
          swigCMemOwnBase = false;
          ompl_basePINVOKE.delete_ValidStateSampler(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public ValidStateSampler(SpaceInformation si) : this(ompl_basePINVOKE.new_ValidStateSampler(SpaceInformation.getCPtr(si)), true) {
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    SwigDirectorConnect();
  }

  public string getName() {
    string ret = ompl_basePINVOKE.ValidStateSampler_getName(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setName(string name) {
    ompl_basePINVOKE.ValidStateSampler_setName(swigCPtr, name);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool sample(State state) {
    bool ret = ompl_basePINVOKE.ValidStateSampler_sample(swigCPtr, State.getCPtr(state));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool sampleNear(State state, State near, double distance) {
    bool ret = ompl_basePINVOKE.ValidStateSampler_sampleNear(swigCPtr, State.getCPtr(state), State.getCPtr(near), distance);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setNrAttempts(uint attempts) {
    ompl_basePINVOKE.ValidStateSampler_setNrAttempts(swigCPtr, attempts);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getNrAttempts() {
    uint ret = ompl_basePINVOKE.ValidStateSampler_getNrAttempts(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ParamSet params_() {
    ParamSet ret = new ParamSet(ompl_basePINVOKE.ValidStateSampler_params___SWIG_0(swigCPtr), false);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("sample", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateValidStateSampler_0(SwigDirectorMethodsample);
    if (SwigDerivedClassHasMethod("sampleNear", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateValidStateSampler_1(SwigDirectorMethodsampleNear);
    ompl_basePINVOKE.ValidStateSampler_director_connect(swigCPtr, swigDelegate0, swigDelegate1);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo[] methodInfos = this.GetType().GetMethods(
        global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance);
    foreach (global::System.Reflection.MethodInfo methodInfo in methodInfos) {
      if (methodInfo.DeclaringType == null)
        continue;

      if (methodInfo.Name != methodName)
        continue;

      var parameters = methodInfo.GetParameters();
      if (parameters.Length != methodTypes.Length)
        continue;

      bool parametersMatch = true;
      for (var i = 0; i < parameters.Length; i++) {
        if (parameters[i].ParameterType != methodTypes[i]) {
          parametersMatch = false;
          break;
        }
      }

      if (!parametersMatch)
        continue;

      if (methodInfo.IsVirtual && (methodInfo.DeclaringType.IsSubclassOf(typeof(ValidStateSampler))) &&
        methodInfo.DeclaringType != methodInfo.GetBaseDefinition().DeclaringType) {
        return true;
      }
    }

    return false;
  }

  private bool SwigDirectorMethodsample(global::System.IntPtr state) {
    return sample((state == global::System.IntPtr.Zero) ? null : new State(state, false));
  }

  private bool SwigDirectorMethodsampleNear(global::System.IntPtr state, global::System.IntPtr near, double distance) {
    return sampleNear((state == global::System.IntPtr.Zero) ? null : new State(state, false), (near == global::System.IntPtr.Zero) ? null : new State(near, false), distance);
  }

  public delegate bool SwigDelegateValidStateSampler_0(global::System.IntPtr state);
  public delegate bool SwigDelegateValidStateSampler_1(global::System.IntPtr state, global::System.IntPtr near, double distance);

  private SwigDelegateValidStateSampler_0 swigDelegate0;
  private SwigDelegateValidStateSampler_1 swigDelegate1;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] { typeof(State) };
  private static global::System.Type[] swigMethodTypes1 = new global::System.Type[] { typeof(State), typeof(State), typeof(double) };
}

}
