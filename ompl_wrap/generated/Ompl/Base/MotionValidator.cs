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

public class MotionValidator : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal MotionValidator(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MotionValidator obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~MotionValidator() {
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
          ompl_basePINVOKE.delete_MotionValidator(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public MotionValidator(SpaceInformation si) : this(ompl_basePINVOKE.new_MotionValidator__SWIG_0(SpaceInformation.getCPtr(si)), true) {
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    SwigDirectorConnect();
  }

  public virtual bool checkMotion(State s1, State s2) {
    bool ret = ompl_basePINVOKE.MotionValidator_checkMotion__SWIG_0(swigCPtr, State.getCPtr(s1), State.getCPtr(s2));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool checkMotion(State s1, State s2, SWIGTYPE_p_std__pairT_ompl__base__State_p_double_t lastValid) {
    bool ret = ompl_basePINVOKE.MotionValidator_checkMotion__SWIG_1(swigCPtr, State.getCPtr(s1), State.getCPtr(s2), SWIGTYPE_p_std__pairT_ompl__base__State_p_double_t.getCPtr(lastValid));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getValidMotionCount() {
    uint ret = ompl_basePINVOKE.MotionValidator_getValidMotionCount(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getInvalidMotionCount() {
    uint ret = ompl_basePINVOKE.MotionValidator_getInvalidMotionCount(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getCheckedMotionCount() {
    uint ret = ompl_basePINVOKE.MotionValidator_getCheckedMotionCount(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double getValidMotionFraction() {
    double ret = ompl_basePINVOKE.MotionValidator_getValidMotionFraction(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void resetMotionCounter() {
    ompl_basePINVOKE.MotionValidator_resetMotionCounter(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("checkMotion", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateMotionValidator_0(SwigDirectorMethodcheckMotion__SWIG_0);
    if (SwigDerivedClassHasMethod("checkMotion", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateMotionValidator_1(SwigDirectorMethodcheckMotion__SWIG_1);
    ompl_basePINVOKE.MotionValidator_director_connect(swigCPtr, swigDelegate0, swigDelegate1);
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

      if (methodInfo.IsVirtual && (methodInfo.DeclaringType.IsSubclassOf(typeof(MotionValidator))) &&
        methodInfo.DeclaringType != methodInfo.GetBaseDefinition().DeclaringType) {
        return true;
      }
    }

    return false;
  }

  private bool SwigDirectorMethodcheckMotion__SWIG_0(global::System.IntPtr s1, global::System.IntPtr s2) {
    return checkMotion((s1 == global::System.IntPtr.Zero) ? null : new State(s1, false), (s2 == global::System.IntPtr.Zero) ? null : new State(s2, false));
  }

  private bool SwigDirectorMethodcheckMotion__SWIG_1(global::System.IntPtr s1, global::System.IntPtr s2, global::System.IntPtr lastValid) {
    return checkMotion((s1 == global::System.IntPtr.Zero) ? null : new State(s1, false), (s2 == global::System.IntPtr.Zero) ? null : new State(s2, false), new SWIGTYPE_p_std__pairT_ompl__base__State_p_double_t(lastValid, false));
  }

  public delegate bool SwigDelegateMotionValidator_0(global::System.IntPtr s1, global::System.IntPtr s2);
  public delegate bool SwigDelegateMotionValidator_1(global::System.IntPtr s1, global::System.IntPtr s2, global::System.IntPtr lastValid);

  private SwigDelegateMotionValidator_0 swigDelegate0;
  private SwigDelegateMotionValidator_1 swigDelegate1;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] { typeof(State), typeof(State) };
  private static global::System.Type[] swigMethodTypes1 = new global::System.Type[] { typeof(State), typeof(State), typeof(SWIGTYPE_p_std__pairT_ompl__base__State_p_double_t) };
}

}
