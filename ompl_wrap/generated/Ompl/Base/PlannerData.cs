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

public class PlannerData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal PlannerData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PlannerData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PlannerData() {
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
          ompl_basePINVOKE.delete_PlannerData(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public static PlannerDataEdge NO_EDGE {
    get {
      global::System.IntPtr cPtr = ompl_basePINVOKE.PlannerData_NO_EDGE_get();
      PlannerDataEdge ret = (cPtr == global::System.IntPtr.Zero) ? null : new PlannerDataEdge(cPtr, false);
      if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public static PlannerDataVertex NO_VERTEX {
    get {
      global::System.IntPtr cPtr = ompl_basePINVOKE.PlannerData_NO_VERTEX_get();
      PlannerDataVertex ret = (cPtr == global::System.IntPtr.Zero) ? null : new PlannerDataVertex(cPtr, false);
      if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public static uint INVALID_INDEX {
    get {
      uint ret = ompl_basePINVOKE.PlannerData_INVALID_INDEX_get();
      if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public PlannerData(SpaceInformation si) : this(ompl_basePINVOKE.new_PlannerData(SpaceInformation.getCPtr(si)), true) {
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public uint addVertex(PlannerDataVertex st) {
    uint ret = ompl_basePINVOKE.PlannerData_addVertex(swigCPtr, PlannerDataVertex.getCPtr(st));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint addStartVertex(PlannerDataVertex v) {
    uint ret = ompl_basePINVOKE.PlannerData_addStartVertex(swigCPtr, PlannerDataVertex.getCPtr(v));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint addGoalVertex(PlannerDataVertex v) {
    uint ret = ompl_basePINVOKE.PlannerData_addGoalVertex(swigCPtr, PlannerDataVertex.getCPtr(v));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool markStartState(State st) {
    bool ret = ompl_basePINVOKE.PlannerData_markStartState(swigCPtr, State.getCPtr(st));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool markGoalState(State st) {
    bool ret = ompl_basePINVOKE.PlannerData_markGoalState(swigCPtr, State.getCPtr(st));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool tagState(State st, int tag) {
    bool ret = ompl_basePINVOKE.PlannerData_tagState(swigCPtr, State.getCPtr(st), tag);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool removeVertex(PlannerDataVertex st) {
    bool ret = ompl_basePINVOKE.PlannerData_removeVertex__SWIG_0(swigCPtr, PlannerDataVertex.getCPtr(st));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool removeVertex(uint vIndex) {
    bool ret = ompl_basePINVOKE.PlannerData_removeVertex__SWIG_1(swigCPtr, vIndex);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool addEdge(uint v1, uint v2, PlannerDataEdge edge, Cost weight) {
    bool ret = ompl_basePINVOKE.PlannerData_addEdge__SWIG_0(swigCPtr, v1, v2, PlannerDataEdge.getCPtr(edge), Cost.getCPtr(weight));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool addEdge(uint v1, uint v2, PlannerDataEdge edge) {
    bool ret = ompl_basePINVOKE.PlannerData_addEdge__SWIG_1(swigCPtr, v1, v2, PlannerDataEdge.getCPtr(edge));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool addEdge(uint v1, uint v2) {
    bool ret = ompl_basePINVOKE.PlannerData_addEdge__SWIG_2(swigCPtr, v1, v2);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool addEdge(PlannerDataVertex v1, PlannerDataVertex v2, PlannerDataEdge edge, Cost weight) {
    bool ret = ompl_basePINVOKE.PlannerData_addEdge__SWIG_3(swigCPtr, PlannerDataVertex.getCPtr(v1), PlannerDataVertex.getCPtr(v2), PlannerDataEdge.getCPtr(edge), Cost.getCPtr(weight));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool addEdge(PlannerDataVertex v1, PlannerDataVertex v2, PlannerDataEdge edge) {
    bool ret = ompl_basePINVOKE.PlannerData_addEdge__SWIG_4(swigCPtr, PlannerDataVertex.getCPtr(v1), PlannerDataVertex.getCPtr(v2), PlannerDataEdge.getCPtr(edge));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool addEdge(PlannerDataVertex v1, PlannerDataVertex v2) {
    bool ret = ompl_basePINVOKE.PlannerData_addEdge__SWIG_5(swigCPtr, PlannerDataVertex.getCPtr(v1), PlannerDataVertex.getCPtr(v2));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool removeEdge(uint v1, uint v2) {
    bool ret = ompl_basePINVOKE.PlannerData_removeEdge__SWIG_0(swigCPtr, v1, v2);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool removeEdge(PlannerDataVertex v1, PlannerDataVertex v2) {
    bool ret = ompl_basePINVOKE.PlannerData_removeEdge__SWIG_1(swigCPtr, PlannerDataVertex.getCPtr(v1), PlannerDataVertex.getCPtr(v2));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void clear() {
    ompl_basePINVOKE.PlannerData_clear(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void decoupleFromPlanner() {
    ompl_basePINVOKE.PlannerData_decoupleFromPlanner(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public uint numEdges() {
    uint ret = ompl_basePINVOKE.PlannerData_numEdges(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint numVertices() {
    uint ret = ompl_basePINVOKE.PlannerData_numVertices(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint numStartVertices() {
    uint ret = ompl_basePINVOKE.PlannerData_numStartVertices(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint numGoalVertices() {
    uint ret = ompl_basePINVOKE.PlannerData_numGoalVertices(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool vertexExists(PlannerDataVertex v) {
    bool ret = ompl_basePINVOKE.PlannerData_vertexExists(swigCPtr, PlannerDataVertex.getCPtr(v));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PlannerDataVertex getVertex(uint index) {
    PlannerDataVertex ret = new PlannerDataVertex(ompl_basePINVOKE.PlannerData_getVertex__SWIG_0(swigCPtr, index), false);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PlannerDataVertex getStartVertex(uint i) {
    PlannerDataVertex ret = new PlannerDataVertex(ompl_basePINVOKE.PlannerData_getStartVertex__SWIG_0(swigCPtr, i), false);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PlannerDataVertex getGoalVertex(uint i) {
    PlannerDataVertex ret = new PlannerDataVertex(ompl_basePINVOKE.PlannerData_getGoalVertex__SWIG_0(swigCPtr, i), false);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getStartIndex(uint i) {
    uint ret = ompl_basePINVOKE.PlannerData_getStartIndex(swigCPtr, i);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getGoalIndex(uint i) {
    uint ret = ompl_basePINVOKE.PlannerData_getGoalIndex(swigCPtr, i);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isStartVertex(uint index) {
    bool ret = ompl_basePINVOKE.PlannerData_isStartVertex(swigCPtr, index);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isGoalVertex(uint index) {
    bool ret = ompl_basePINVOKE.PlannerData_isGoalVertex(swigCPtr, index);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint vertexIndex(PlannerDataVertex v) {
    uint ret = ompl_basePINVOKE.PlannerData_vertexIndex(swigCPtr, PlannerDataVertex.getCPtr(v));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool edgeExists(uint v1, uint v2) {
    bool ret = ompl_basePINVOKE.PlannerData_edgeExists(swigCPtr, v1, v2);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PlannerDataEdge getEdge(uint v1, uint v2) {
    PlannerDataEdge ret = new PlannerDataEdge(ompl_basePINVOKE.PlannerData_getEdge__SWIG_0(swigCPtr, v1, v2), false);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getEdges(uint v, SWIGTYPE_p_std__vectorT_unsigned_int_t edgeList) {
    uint ret = ompl_basePINVOKE.PlannerData_getEdges__SWIG_0(swigCPtr, v, SWIGTYPE_p_std__vectorT_unsigned_int_t.getCPtr(edgeList));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getEdges(uint v, SWIGTYPE_p_std__mapT_unsigned_int_ompl__base__PlannerDataEdge_const_p_t edgeMap) {
    uint ret = ompl_basePINVOKE.PlannerData_getEdges__SWIG_1(swigCPtr, v, SWIGTYPE_p_std__mapT_unsigned_int_ompl__base__PlannerDataEdge_const_p_t.getCPtr(edgeMap));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getIncomingEdges(uint v, SWIGTYPE_p_std__vectorT_unsigned_int_t edgeList) {
    uint ret = ompl_basePINVOKE.PlannerData_getIncomingEdges__SWIG_0(swigCPtr, v, SWIGTYPE_p_std__vectorT_unsigned_int_t.getCPtr(edgeList));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getIncomingEdges(uint v, SWIGTYPE_p_std__mapT_unsigned_int_ompl__base__PlannerDataEdge_const_p_t edgeMap) {
    uint ret = ompl_basePINVOKE.PlannerData_getIncomingEdges__SWIG_1(swigCPtr, v, SWIGTYPE_p_std__mapT_unsigned_int_ompl__base__PlannerDataEdge_const_p_t.getCPtr(edgeMap));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool getEdgeWeight(uint v1, uint v2, Cost weight) {
    bool ret = ompl_basePINVOKE.PlannerData_getEdgeWeight(swigCPtr, v1, v2, Cost.getCPtr(weight));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool setEdgeWeight(uint v1, uint v2, Cost weight) {
    bool ret = ompl_basePINVOKE.PlannerData_setEdgeWeight(swigCPtr, v1, v2, Cost.getCPtr(weight));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void computeEdgeWeights(OptimizationObjective opt) {
    ompl_basePINVOKE.PlannerData_computeEdgeWeights__SWIG_0(swigCPtr, OptimizationObjective.getCPtr(opt));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public void computeEdgeWeights() {
    ompl_basePINVOKE.PlannerData_computeEdgeWeights__SWIG_1(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public void printGraphviz(SWIGTYPE_p_std__ostream _out) {
    ompl_basePINVOKE.PlannerData_printGraphviz__SWIG_0(swigCPtr, SWIGTYPE_p_std__ostream.getCPtr(_out));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public void printGraphviz() {
    ompl_basePINVOKE.PlannerData_printGraphviz__SWIG_1(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public void printGraphML(SWIGTYPE_p_std__ostream _out) {
    ompl_basePINVOKE.PlannerData_printGraphML__SWIG_0(swigCPtr, SWIGTYPE_p_std__ostream.getCPtr(_out));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public void printGraphML() {
    ompl_basePINVOKE.PlannerData_printGraphML__SWIG_1(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public void printPLY(SWIGTYPE_p_std__ostream _out, bool asIs) {
    ompl_basePINVOKE.PlannerData_printPLY__SWIG_0(swigCPtr, SWIGTYPE_p_std__ostream.getCPtr(_out), asIs);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public void printPLY(SWIGTYPE_p_std__ostream _out) {
    ompl_basePINVOKE.PlannerData_printPLY__SWIG_1(swigCPtr, SWIGTYPE_p_std__ostream.getCPtr(_out));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public void extractMinimumSpanningTree(uint v, OptimizationObjective opt, PlannerData mst) {
    ompl_basePINVOKE.PlannerData_extractMinimumSpanningTree(swigCPtr, v, OptimizationObjective.getCPtr(opt), PlannerData.getCPtr(mst));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public void extractReachable(uint v, PlannerData data) {
    ompl_basePINVOKE.PlannerData_extractReachable(swigCPtr, v, PlannerData.getCPtr(data));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_std__shared_ptrT_ompl__base__StateStorage_t extractStateStorage() {
    SWIGTYPE_p_std__shared_ptrT_ompl__base__StateStorage_t ret = new SWIGTYPE_p_std__shared_ptrT_ompl__base__StateStorage_t(ompl_basePINVOKE.PlannerData_extractStateStorage(swigCPtr), true);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_ompl__base__PlannerData__Graph toBoostGraph() {
    SWIGTYPE_p_ompl__base__PlannerData__Graph ret = new SWIGTYPE_p_ompl__base__PlannerData__Graph(ompl_basePINVOKE.PlannerData_toBoostGraph__SWIG_0(swigCPtr), false);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SpaceInformation getSpaceInformation() {
    global::System.IntPtr cPtr = ompl_basePINVOKE.PlannerData_getSpaceInformation(swigCPtr);
    SpaceInformation ret = (cPtr == global::System.IntPtr.Zero) ? null : new SpaceInformation(cPtr, true);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool hasControls() {
    bool ret = ompl_basePINVOKE.PlannerData_hasControls(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__mapT_std__string_std__string_t properties {
    set {
      ompl_basePINVOKE.PlannerData_properties_set(swigCPtr, SWIGTYPE_p_std__mapT_std__string_std__string_t.getCPtr(value));
      if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = ompl_basePINVOKE.PlannerData_properties_get(swigCPtr);
      SWIGTYPE_p_std__mapT_std__string_std__string_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_std__mapT_std__string_std__string_t(cPtr, false);
      if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

}

}
