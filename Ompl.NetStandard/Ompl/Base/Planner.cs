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

public class Planner : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal Planner(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Planner obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Planner() {
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
          ompl_basePINVOKE.delete_Planner(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public SpaceInformation getSpaceInformation() {
    global::System.IntPtr cPtr = ompl_basePINVOKE.Planner_getSpaceInformation(swigCPtr);
    SpaceInformation ret = (cPtr == global::System.IntPtr.Zero) ? null : new SpaceInformation(cPtr, true);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ProblemDefinition getProblemDefinition() {
    global::System.IntPtr cPtr = ompl_basePINVOKE.Planner_getProblemDefinition__SWIG_0(swigCPtr);
    ProblemDefinition ret = (cPtr == global::System.IntPtr.Zero) ? null : new ProblemDefinition(cPtr, true);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PlannerInputStates getPlannerInputStates() {
    PlannerInputStates ret = new PlannerInputStates(ompl_basePINVOKE.Planner_getPlannerInputStates(swigCPtr), false);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void setProblemDefinition(ProblemDefinition pdef) {
    ompl_basePINVOKE.Planner_setProblemDefinition(swigCPtr, ProblemDefinition.getCPtr(pdef));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual PlannerStatus solve(PlannerTerminationCondition ptc) {
    PlannerStatus ret = new PlannerStatus(ompl_basePINVOKE.Planner_solve__SWIG_0(swigCPtr, PlannerTerminationCondition.getCPtr(ptc)), true);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PlannerStatus solve(SWIGTYPE_p_std__functionT_bool_fF_t ptc, double checkInterval) {
    PlannerStatus ret = new PlannerStatus(ompl_basePINVOKE.Planner_solve__SWIG_1(swigCPtr, SWIGTYPE_p_std__functionT_bool_fF_t.getCPtr(ptc), checkInterval), true);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PlannerStatus solve(double solveTime) {
    PlannerStatus ret = new PlannerStatus(ompl_basePINVOKE.Planner_solve__SWIG_2(swigCPtr, solveTime), true);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void clear() {
    ompl_basePINVOKE.Planner_clear(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void clearQuery() {
    ompl_basePINVOKE.Planner_clearQuery(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void getPlannerData(PlannerData data) {
    ompl_basePINVOKE.Planner_getPlannerData(swigCPtr, PlannerData.getCPtr(data));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public string getName() {
    string ret = ompl_basePINVOKE.Planner_getName(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setName(string name) {
    ompl_basePINVOKE.Planner_setName(swigCPtr, name);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public PlannerSpecs getSpecs() {
    PlannerSpecs ret = new PlannerSpecs(ompl_basePINVOKE.Planner_getSpecs(swigCPtr), false);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void setup() {
    ompl_basePINVOKE.Planner_setup(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void checkValidity() {
    ompl_basePINVOKE.Planner_checkValidity(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isSetup() {
    bool ret = ompl_basePINVOKE.Planner_isSetup(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ParamSet params_() {
    ParamSet ret = new ParamSet(ompl_basePINVOKE.Planner_params___SWIG_0(swigCPtr), false);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__mapT_std__string_std__functionT_std__string_fF_t_t getPlannerProgressProperties() {
    SWIGTYPE_p_std__mapT_std__string_std__functionT_std__string_fF_t_t ret = new SWIGTYPE_p_std__mapT_std__string_std__functionT_std__string_fF_t_t(ompl_basePINVOKE.Planner_getPlannerProgressProperties(swigCPtr), false);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void printProperties(SWIGTYPE_p_std__ostream _out) {
    ompl_basePINVOKE.Planner_printProperties(swigCPtr, SWIGTYPE_p_std__ostream.getCPtr(_out));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void printSettings(SWIGTYPE_p_std__ostream _out) {
    ompl_basePINVOKE.Planner_printSettings(swigCPtr, SWIGTYPE_p_std__ostream.getCPtr(_out));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

}

}
