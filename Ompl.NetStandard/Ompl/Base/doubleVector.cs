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

public class doubleVector : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IList<double>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal doubleVector(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(doubleVector obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(doubleVector obj) {
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

  ~doubleVector() {
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
          ompl_basePINVOKE.delete_doubleVector(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public doubleVector(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (double element in c) {
      this.Add(element);
    }
  }

  public doubleVector(global::System.Collections.Generic.IEnumerable<double> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (double element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public double this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < 0 || (uint)value < size())
        throw new global::System.ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public bool IsEmpty {
    get {
      return empty();
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(double[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(double[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, double[] array, int arrayIndex, int count)
  {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

  public double[] ToArray() {
    double[] array = new double[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<double> global::System.Collections.Generic.IEnumerable<double>.GetEnumerator() {
    return new doubleVectorEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new doubleVectorEnumerator(this);
  }

  public doubleVectorEnumerator GetEnumerator() {
    return new doubleVectorEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class doubleVectorEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<double>
  {
    private doubleVector collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public doubleVectorEnumerator(doubleVector collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public double Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (double)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
  }

  public doubleVector() : this(ompl_basePINVOKE.new_doubleVector__SWIG_0(), true) {
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public doubleVector(doubleVector other) : this(ompl_basePINVOKE.new_doubleVector__SWIG_1(doubleVector.getCPtr(other)), true) {
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public void Clear() {
    ompl_basePINVOKE.doubleVector_Clear(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public void Add(double x) {
    ompl_basePINVOKE.doubleVector_Add(swigCPtr, x);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = ompl_basePINVOKE.doubleVector_size(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private bool empty() {
    bool ret = ompl_basePINVOKE.doubleVector_empty(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private uint capacity() {
    uint ret = ompl_basePINVOKE.doubleVector_capacity(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void reserve(uint n) {
    ompl_basePINVOKE.doubleVector_reserve(swigCPtr, n);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public doubleVector(int capacity) : this(ompl_basePINVOKE.new_doubleVector__SWIG_2(capacity), true) {
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  private double getitemcopy(int index) {
    double ret = ompl_basePINVOKE.doubleVector_getitemcopy(swigCPtr, index);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private double getitem(int index) {
    double ret = ompl_basePINVOKE.doubleVector_getitem(swigCPtr, index);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, double val) {
    ompl_basePINVOKE.doubleVector_setitem(swigCPtr, index, val);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(doubleVector values) {
    ompl_basePINVOKE.doubleVector_AddRange(swigCPtr, doubleVector.getCPtr(values));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public doubleVector GetRange(int index, int count) {
    global::System.IntPtr cPtr = ompl_basePINVOKE.doubleVector_GetRange(swigCPtr, index, count);
    doubleVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new doubleVector(cPtr, true);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, double x) {
    ompl_basePINVOKE.doubleVector_Insert(swigCPtr, index, x);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, doubleVector values) {
    ompl_basePINVOKE.doubleVector_InsertRange(swigCPtr, index, doubleVector.getCPtr(values));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    ompl_basePINVOKE.doubleVector_RemoveAt(swigCPtr, index);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    ompl_basePINVOKE.doubleVector_RemoveRange(swigCPtr, index, count);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public static doubleVector Repeat(double value, int count) {
    global::System.IntPtr cPtr = ompl_basePINVOKE.doubleVector_Repeat(value, count);
    doubleVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new doubleVector(cPtr, true);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    ompl_basePINVOKE.doubleVector_Reverse__SWIG_0(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public void Reverse(int index, int count) {
    ompl_basePINVOKE.doubleVector_Reverse__SWIG_1(swigCPtr, index, count);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, doubleVector values) {
    ompl_basePINVOKE.doubleVector_SetRange(swigCPtr, index, doubleVector.getCPtr(values));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Contains(double value) {
    bool ret = ompl_basePINVOKE.doubleVector_Contains(swigCPtr, value);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int IndexOf(double value) {
    int ret = ompl_basePINVOKE.doubleVector_IndexOf(swigCPtr, value);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int LastIndexOf(double value) {
    int ret = ompl_basePINVOKE.doubleVector_LastIndexOf(swigCPtr, value);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Remove(double value) {
    bool ret = ompl_basePINVOKE.doubleVector_Remove(swigCPtr, value);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
