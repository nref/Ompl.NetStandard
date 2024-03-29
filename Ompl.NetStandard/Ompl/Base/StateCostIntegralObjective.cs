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

public class StateCostIntegralObjective : OptimizationObjective {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal StateCostIntegralObjective(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ompl_basePINVOKE.StateCostIntegralObjective_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(StateCostIntegralObjective obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ompl_basePINVOKE.delete_StateCostIntegralObjective(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public StateCostIntegralObjective(SpaceInformation si, bool enableMotionCostInterpolation) : this(ompl_basePINVOKE.new_StateCostIntegralObjective__SWIG_0(SpaceInformation.getCPtr(si), enableMotionCostInterpolation), true) {
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    SwigDirectorConnect();
  }

  public StateCostIntegralObjective(SpaceInformation si) : this(ompl_basePINVOKE.new_StateCostIntegralObjective__SWIG_1(SpaceInformation.getCPtr(si)), true) {
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    SwigDirectorConnect();
  }

  public override Cost stateCost(State s) {
    Cost ret = new Cost((SwigDerivedClassHasMethod("stateCost", swigMethodTypes5) ? ompl_basePINVOKE.StateCostIntegralObjective_stateCostSwigExplicitStateCostIntegralObjective(swigCPtr, State.getCPtr(s)) : ompl_basePINVOKE.StateCostIntegralObjective_stateCost(swigCPtr, State.getCPtr(s))), true);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override Cost motionCost(State s1, State s2) {
    Cost ret = new Cost((SwigDerivedClassHasMethod("motionCost", swigMethodTypes6) ? ompl_basePINVOKE.StateCostIntegralObjective_motionCostSwigExplicitStateCostIntegralObjective(swigCPtr, State.getCPtr(s1), State.getCPtr(s2)) : ompl_basePINVOKE.StateCostIntegralObjective_motionCost(swigCPtr, State.getCPtr(s1), State.getCPtr(s2))), true);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isMotionCostInterpolationEnabled() {
    bool ret = ompl_basePINVOKE.StateCostIntegralObjective_isMotionCostInterpolationEnabled(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("isSatisfied", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateStateCostIntegralObjective_0(SwigDirectorMethodisSatisfied);
    if (SwigDerivedClassHasMethod("isCostBetterThan", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateStateCostIntegralObjective_1(SwigDirectorMethodisCostBetterThan);
    if (SwigDerivedClassHasMethod("isCostEquivalentTo", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateStateCostIntegralObjective_2(SwigDirectorMethodisCostEquivalentTo);
    if (SwigDerivedClassHasMethod("isFinite", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateStateCostIntegralObjective_3(SwigDirectorMethodisFinite);
    if (SwigDerivedClassHasMethod("betterCost", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateStateCostIntegralObjective_4(SwigDirectorMethodbetterCost);
    if (SwigDerivedClassHasMethod("stateCost", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateStateCostIntegralObjective_5(SwigDirectorMethodstateCost);
    if (SwigDerivedClassHasMethod("motionCost", swigMethodTypes6))
      swigDelegate6 = new SwigDelegateStateCostIntegralObjective_6(SwigDirectorMethodmotionCost);
    if (SwigDerivedClassHasMethod("combineCosts", swigMethodTypes7))
      swigDelegate7 = new SwigDelegateStateCostIntegralObjective_7(SwigDirectorMethodcombineCosts);
    if (SwigDerivedClassHasMethod("identityCost", swigMethodTypes8))
      swigDelegate8 = new SwigDelegateStateCostIntegralObjective_8(SwigDirectorMethodidentityCost);
    if (SwigDerivedClassHasMethod("infiniteCost", swigMethodTypes9))
      swigDelegate9 = new SwigDelegateStateCostIntegralObjective_9(SwigDirectorMethodinfiniteCost);
    if (SwigDerivedClassHasMethod("initialCost", swigMethodTypes10))
      swigDelegate10 = new SwigDelegateStateCostIntegralObjective_10(SwigDirectorMethodinitialCost);
    if (SwigDerivedClassHasMethod("terminalCost", swigMethodTypes11))
      swigDelegate11 = new SwigDelegateStateCostIntegralObjective_11(SwigDirectorMethodterminalCost);
    if (SwigDerivedClassHasMethod("isSymmetric", swigMethodTypes12))
      swigDelegate12 = new SwigDelegateStateCostIntegralObjective_12(SwigDirectorMethodisSymmetric);
    if (SwigDerivedClassHasMethod("averageStateCost", swigMethodTypes13))
      swigDelegate13 = new SwigDelegateStateCostIntegralObjective_13(SwigDirectorMethodaverageStateCost);
    if (SwigDerivedClassHasMethod("motionCostHeuristic", swigMethodTypes14))
      swigDelegate14 = new SwigDelegateStateCostIntegralObjective_14(SwigDirectorMethodmotionCostHeuristic);
    if (SwigDerivedClassHasMethod("allocInformedStateSampler", swigMethodTypes15))
      swigDelegate15 = new SwigDelegateStateCostIntegralObjective_15(SwigDirectorMethodallocInformedStateSampler);
    if (SwigDerivedClassHasMethod("_print", swigMethodTypes16))
      swigDelegate16 = new SwigDelegateStateCostIntegralObjective_16(SwigDirectorMethod_print);
    ompl_basePINVOKE.StateCostIntegralObjective_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5, swigDelegate6, swigDelegate7, swigDelegate8, swigDelegate9, swigDelegate10, swigDelegate11, swigDelegate12, swigDelegate13, swigDelegate14, swigDelegate15, swigDelegate16);
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

      if (methodInfo.IsVirtual && (methodInfo.DeclaringType.IsSubclassOf(typeof(StateCostIntegralObjective))) &&
        methodInfo.DeclaringType != methodInfo.GetBaseDefinition().DeclaringType) {
        return true;
      }
    }

    return false;
  }

  private bool SwigDirectorMethodisSatisfied(global::System.IntPtr c) {
    return isSatisfied(new Cost(c, true));
  }

  private bool SwigDirectorMethodisCostBetterThan(global::System.IntPtr c1, global::System.IntPtr c2) {
    return isCostBetterThan(new Cost(c1, true), new Cost(c2, true));
  }

  private bool SwigDirectorMethodisCostEquivalentTo(global::System.IntPtr c1, global::System.IntPtr c2) {
    return isCostEquivalentTo(new Cost(c1, true), new Cost(c2, true));
  }

  private bool SwigDirectorMethodisFinite(global::System.IntPtr cost) {
    return isFinite(new Cost(cost, true));
  }

  private global::System.IntPtr SwigDirectorMethodbetterCost(global::System.IntPtr c1, global::System.IntPtr c2) {
    return Cost.getCPtr(betterCost(new Cost(c1, true), new Cost(c2, true))).Handle;
  }

  private global::System.IntPtr SwigDirectorMethodstateCost(global::System.IntPtr s) {
    return Cost.getCPtr(stateCost((s == global::System.IntPtr.Zero) ? null : new State(s, false))).Handle;
  }

  private global::System.IntPtr SwigDirectorMethodmotionCost(global::System.IntPtr s1, global::System.IntPtr s2) {
    return Cost.getCPtr(motionCost((s1 == global::System.IntPtr.Zero) ? null : new State(s1, false), (s2 == global::System.IntPtr.Zero) ? null : new State(s2, false))).Handle;
  }

  private global::System.IntPtr SwigDirectorMethodcombineCosts(global::System.IntPtr c1, global::System.IntPtr c2) {
    return Cost.getCPtr(combineCosts(new Cost(c1, true), new Cost(c2, true))).Handle;
  }

  private global::System.IntPtr SwigDirectorMethodidentityCost() {
    return Cost.getCPtr(identityCost()).Handle;
  }

  private global::System.IntPtr SwigDirectorMethodinfiniteCost() {
    return Cost.getCPtr(infiniteCost()).Handle;
  }

  private global::System.IntPtr SwigDirectorMethodinitialCost(global::System.IntPtr s) {
    return Cost.getCPtr(initialCost((s == global::System.IntPtr.Zero) ? null : new State(s, false))).Handle;
  }

  private global::System.IntPtr SwigDirectorMethodterminalCost(global::System.IntPtr s) {
    return Cost.getCPtr(terminalCost((s == global::System.IntPtr.Zero) ? null : new State(s, false))).Handle;
  }

  private bool SwigDirectorMethodisSymmetric() {
    return isSymmetric();
  }

  private global::System.IntPtr SwigDirectorMethodaverageStateCost(uint numStates) {
    return Cost.getCPtr(averageStateCost(numStates)).Handle;
  }

  private global::System.IntPtr SwigDirectorMethodmotionCostHeuristic(global::System.IntPtr s1, global::System.IntPtr s2) {
    return Cost.getCPtr(motionCostHeuristic((s1 == global::System.IntPtr.Zero) ? null : new State(s1, false), (s2 == global::System.IntPtr.Zero) ? null : new State(s2, false))).Handle;
  }

  private global::System.IntPtr SwigDirectorMethodallocInformedStateSampler(global::System.IntPtr probDefn, uint maxNumberCalls) {
    return SWIGTYPE_p_std__shared_ptrT_ompl__base__InformedSampler_t.getCPtr(allocInformedStateSampler((probDefn == global::System.IntPtr.Zero) ? null : new ProblemDefinition(probDefn, true), maxNumberCalls)).Handle;
  }

  private void SwigDirectorMethod_print(global::System.IntPtr _out) {
    _print(new SWIGTYPE_p_std__ostream(_out, false));
  }

  public delegate bool SwigDelegateStateCostIntegralObjective_0(global::System.IntPtr c);
  public delegate bool SwigDelegateStateCostIntegralObjective_1(global::System.IntPtr c1, global::System.IntPtr c2);
  public delegate bool SwigDelegateStateCostIntegralObjective_2(global::System.IntPtr c1, global::System.IntPtr c2);
  public delegate bool SwigDelegateStateCostIntegralObjective_3(global::System.IntPtr cost);
  public delegate global::System.IntPtr SwigDelegateStateCostIntegralObjective_4(global::System.IntPtr c1, global::System.IntPtr c2);
  public delegate global::System.IntPtr SwigDelegateStateCostIntegralObjective_5(global::System.IntPtr s);
  public delegate global::System.IntPtr SwigDelegateStateCostIntegralObjective_6(global::System.IntPtr s1, global::System.IntPtr s2);
  public delegate global::System.IntPtr SwigDelegateStateCostIntegralObjective_7(global::System.IntPtr c1, global::System.IntPtr c2);
  public delegate global::System.IntPtr SwigDelegateStateCostIntegralObjective_8();
  public delegate global::System.IntPtr SwigDelegateStateCostIntegralObjective_9();
  public delegate global::System.IntPtr SwigDelegateStateCostIntegralObjective_10(global::System.IntPtr s);
  public delegate global::System.IntPtr SwigDelegateStateCostIntegralObjective_11(global::System.IntPtr s);
  public delegate bool SwigDelegateStateCostIntegralObjective_12();
  public delegate global::System.IntPtr SwigDelegateStateCostIntegralObjective_13(uint numStates);
  public delegate global::System.IntPtr SwigDelegateStateCostIntegralObjective_14(global::System.IntPtr s1, global::System.IntPtr s2);
  public delegate global::System.IntPtr SwigDelegateStateCostIntegralObjective_15(global::System.IntPtr probDefn, uint maxNumberCalls);
  public delegate void SwigDelegateStateCostIntegralObjective_16(global::System.IntPtr _out);

  private SwigDelegateStateCostIntegralObjective_0 swigDelegate0;
  private SwigDelegateStateCostIntegralObjective_1 swigDelegate1;
  private SwigDelegateStateCostIntegralObjective_2 swigDelegate2;
  private SwigDelegateStateCostIntegralObjective_3 swigDelegate3;
  private SwigDelegateStateCostIntegralObjective_4 swigDelegate4;
  private SwigDelegateStateCostIntegralObjective_5 swigDelegate5;
  private SwigDelegateStateCostIntegralObjective_6 swigDelegate6;
  private SwigDelegateStateCostIntegralObjective_7 swigDelegate7;
  private SwigDelegateStateCostIntegralObjective_8 swigDelegate8;
  private SwigDelegateStateCostIntegralObjective_9 swigDelegate9;
  private SwigDelegateStateCostIntegralObjective_10 swigDelegate10;
  private SwigDelegateStateCostIntegralObjective_11 swigDelegate11;
  private SwigDelegateStateCostIntegralObjective_12 swigDelegate12;
  private SwigDelegateStateCostIntegralObjective_13 swigDelegate13;
  private SwigDelegateStateCostIntegralObjective_14 swigDelegate14;
  private SwigDelegateStateCostIntegralObjective_15 swigDelegate15;
  private SwigDelegateStateCostIntegralObjective_16 swigDelegate16;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] { typeof(Cost) };
  private static global::System.Type[] swigMethodTypes1 = new global::System.Type[] { typeof(Cost), typeof(Cost) };
  private static global::System.Type[] swigMethodTypes2 = new global::System.Type[] { typeof(Cost), typeof(Cost) };
  private static global::System.Type[] swigMethodTypes3 = new global::System.Type[] { typeof(Cost) };
  private static global::System.Type[] swigMethodTypes4 = new global::System.Type[] { typeof(Cost), typeof(Cost) };
  private static global::System.Type[] swigMethodTypes5 = new global::System.Type[] { typeof(State) };
  private static global::System.Type[] swigMethodTypes6 = new global::System.Type[] { typeof(State), typeof(State) };
  private static global::System.Type[] swigMethodTypes7 = new global::System.Type[] { typeof(Cost), typeof(Cost) };
  private static global::System.Type[] swigMethodTypes8 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes9 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes10 = new global::System.Type[] { typeof(State) };
  private static global::System.Type[] swigMethodTypes11 = new global::System.Type[] { typeof(State) };
  private static global::System.Type[] swigMethodTypes12 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes13 = new global::System.Type[] { typeof(uint) };
  private static global::System.Type[] swigMethodTypes14 = new global::System.Type[] { typeof(State), typeof(State) };
  private static global::System.Type[] swigMethodTypes15 = new global::System.Type[] { typeof(ProblemDefinition), typeof(uint) };
  private static global::System.Type[] swigMethodTypes16 = new global::System.Type[] { typeof(SWIGTYPE_p_std__ostream) };
}

}
