//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.8
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Qt.NetCore {

public class StringVector : global::System.IDisposable, global::System.Collections.IEnumerable
    , global::System.Collections.Generic.IList<string>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal StringVector(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(StringVector obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~StringVector() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          QtNetCoreQmlPINVOKE.delete_StringVector(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public StringVector(global::System.Collections.ICollection c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (string element in c) {
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

  public string this[int index]  {
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
      if (value < size())
        throw new global::System.ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
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

  public void CopyTo(string[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(string[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, string[] array, int arrayIndex, int count)
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

  global::System.Collections.Generic.IEnumerator<string> global::System.Collections.Generic.IEnumerable<string>.GetEnumerator() {
    return new StringVectorEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new StringVectorEnumerator(this);
  }

  public StringVectorEnumerator GetEnumerator() {
    return new StringVectorEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class StringVectorEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<string>
  {
    private StringVector collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public StringVectorEnumerator(StringVector collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public string Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (string)currentObject;
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

  public void Clear() {
    QtNetCoreQmlPINVOKE.StringVector_Clear(swigCPtr);
  }

  public void Add(string x) {
    QtNetCoreQmlPINVOKE.StringVector_Add(swigCPtr, x);
    if (QtNetCoreQmlPINVOKE.SWIGPendingException.Pending) throw QtNetCoreQmlPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = QtNetCoreQmlPINVOKE.StringVector_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = QtNetCoreQmlPINVOKE.StringVector_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    QtNetCoreQmlPINVOKE.StringVector_reserve(swigCPtr, n);
  }

  public StringVector() : this(QtNetCoreQmlPINVOKE.new_StringVector__SWIG_0(), true) {
  }

  public StringVector(StringVector other) : this(QtNetCoreQmlPINVOKE.new_StringVector__SWIG_1(StringVector.getCPtr(other)), true) {
    if (QtNetCoreQmlPINVOKE.SWIGPendingException.Pending) throw QtNetCoreQmlPINVOKE.SWIGPendingException.Retrieve();
  }

  public StringVector(int capacity) : this(QtNetCoreQmlPINVOKE.new_StringVector__SWIG_2(capacity), true) {
    if (QtNetCoreQmlPINVOKE.SWIGPendingException.Pending) throw QtNetCoreQmlPINVOKE.SWIGPendingException.Retrieve();
  }

  private string getitemcopy(int index) {
    string ret = QtNetCoreQmlPINVOKE.StringVector_getitemcopy(swigCPtr, index);
    if (QtNetCoreQmlPINVOKE.SWIGPendingException.Pending) throw QtNetCoreQmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private string getitem(int index) {
    string ret = QtNetCoreQmlPINVOKE.StringVector_getitem(swigCPtr, index);
    if (QtNetCoreQmlPINVOKE.SWIGPendingException.Pending) throw QtNetCoreQmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, string val) {
    QtNetCoreQmlPINVOKE.StringVector_setitem(swigCPtr, index, val);
    if (QtNetCoreQmlPINVOKE.SWIGPendingException.Pending) throw QtNetCoreQmlPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(StringVector values) {
    QtNetCoreQmlPINVOKE.StringVector_AddRange(swigCPtr, StringVector.getCPtr(values));
    if (QtNetCoreQmlPINVOKE.SWIGPendingException.Pending) throw QtNetCoreQmlPINVOKE.SWIGPendingException.Retrieve();
  }

  public StringVector GetRange(int index, int count) {
    global::System.IntPtr cPtr = QtNetCoreQmlPINVOKE.StringVector_GetRange(swigCPtr, index, count);
    StringVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new StringVector(cPtr, true);
    if (QtNetCoreQmlPINVOKE.SWIGPendingException.Pending) throw QtNetCoreQmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, string x) {
    QtNetCoreQmlPINVOKE.StringVector_Insert(swigCPtr, index, x);
    if (QtNetCoreQmlPINVOKE.SWIGPendingException.Pending) throw QtNetCoreQmlPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, StringVector values) {
    QtNetCoreQmlPINVOKE.StringVector_InsertRange(swigCPtr, index, StringVector.getCPtr(values));
    if (QtNetCoreQmlPINVOKE.SWIGPendingException.Pending) throw QtNetCoreQmlPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    QtNetCoreQmlPINVOKE.StringVector_RemoveAt(swigCPtr, index);
    if (QtNetCoreQmlPINVOKE.SWIGPendingException.Pending) throw QtNetCoreQmlPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    QtNetCoreQmlPINVOKE.StringVector_RemoveRange(swigCPtr, index, count);
    if (QtNetCoreQmlPINVOKE.SWIGPendingException.Pending) throw QtNetCoreQmlPINVOKE.SWIGPendingException.Retrieve();
  }

  public static StringVector Repeat(string value, int count) {
    global::System.IntPtr cPtr = QtNetCoreQmlPINVOKE.StringVector_Repeat(value, count);
    StringVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new StringVector(cPtr, true);
    if (QtNetCoreQmlPINVOKE.SWIGPendingException.Pending) throw QtNetCoreQmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    QtNetCoreQmlPINVOKE.StringVector_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    QtNetCoreQmlPINVOKE.StringVector_Reverse__SWIG_1(swigCPtr, index, count);
    if (QtNetCoreQmlPINVOKE.SWIGPendingException.Pending) throw QtNetCoreQmlPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, StringVector values) {
    QtNetCoreQmlPINVOKE.StringVector_SetRange(swigCPtr, index, StringVector.getCPtr(values));
    if (QtNetCoreQmlPINVOKE.SWIGPendingException.Pending) throw QtNetCoreQmlPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Contains(string value) {
    bool ret = QtNetCoreQmlPINVOKE.StringVector_Contains(swigCPtr, value);
    if (QtNetCoreQmlPINVOKE.SWIGPendingException.Pending) throw QtNetCoreQmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int IndexOf(string value) {
    int ret = QtNetCoreQmlPINVOKE.StringVector_IndexOf(swigCPtr, value);
    if (QtNetCoreQmlPINVOKE.SWIGPendingException.Pending) throw QtNetCoreQmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int LastIndexOf(string value) {
    int ret = QtNetCoreQmlPINVOKE.StringVector_LastIndexOf(swigCPtr, value);
    if (QtNetCoreQmlPINVOKE.SWIGPendingException.Pending) throw QtNetCoreQmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Remove(string value) {
    bool ret = QtNetCoreQmlPINVOKE.StringVector_Remove(swigCPtr, value);
    if (QtNetCoreQmlPINVOKE.SWIGPendingException.Pending) throw QtNetCoreQmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
namespace Qt.NetCore {

public enum ApplicationAttribute {
  AA_ImmediateWidgetCreation = 0,
  AA_MSWindowsUseDirect3DByDefault = 1,
  AA_DontShowIconsInMenus = 2,
  AA_NativeWindows = 3,
  AA_DontCreateNativeWidgetSiblings = 4,
  AA_PluginApplication = 5,
  AA_MacPluginApplication = AA_PluginApplication,
  AA_DontUseNativeMenuBar = 6,
  AA_MacDontSwapCtrlAndMeta = 7,
  AA_Use96Dpi = 8,
  AA_X11InitThreads = 10,
  AA_SynthesizeTouchForUnhandledMouseEvents = 11,
  AA_SynthesizeMouseForUnhandledTouchEvents = 12,
  AA_UseHighDpiPixmaps = 13,
  AA_ForceRasterWidgets = 14,
  AA_UseDesktopOpenGL = 15,
  AA_UseOpenGLES = 16,
  AA_UseSoftwareOpenGL = 17,
  AA_ShareOpenGLContexts = 18,
  AA_SetPalette = 19,
  AA_EnableHighDpiScaling = 20,
  AA_DisableHighDpiScaling = 21,
  AA_UseStyleSheetPropagationInWidgetStyles = 22,
  AA_DontUseNativeDialogs = 23,
  AA_SynthesizeMouseForUnhandledTabletEvents = 24,
  AA_CompressHighFrequencyEvents = 25,
  AA_DontCheckOpenGLContextThreadAffinity = 26,
  AA_AttributeCount
}

}
namespace Qt.NetCore {

public class QCoreApplication : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal QCoreApplication(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(QCoreApplication obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~QCoreApplication() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          QtNetCoreQmlPINVOKE.delete_QCoreApplication(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static void setAttribute(ApplicationAttribute attribute, bool on) {
    QtNetCoreQmlPINVOKE.QCoreApplication_setAttribute__SWIG_0((int)attribute, on);
  }

  public static void setAttribute(ApplicationAttribute attribute) {
    QtNetCoreQmlPINVOKE.QCoreApplication_setAttribute__SWIG_1((int)attribute);
  }

  public int exec() {
    int ret = QtNetCoreQmlPINVOKE.QCoreApplication_exec(swigCPtr);
    return ret;
  }

}

}
namespace Qt.NetCore {

public class QGuiApplication : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal QGuiApplication(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(QGuiApplication obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~QGuiApplication() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          QtNetCoreQmlPINVOKE.delete_QGuiApplication(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public QGuiApplication(StringVector argv) : this(QtNetCoreQmlPINVOKE.new_QGuiApplication(StringVector.getCPtr(argv)), true) {
    if (QtNetCoreQmlPINVOKE.SWIGPendingException.Pending) throw QtNetCoreQmlPINVOKE.SWIGPendingException.Retrieve();
  }

  public int exec() {
    int ret = QtNetCoreQmlPINVOKE.QGuiApplication_exec(swigCPtr);
    return ret;
  }

}

}
namespace Qt.NetCore {

public class QQmlApplicationEngine : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal QQmlApplicationEngine(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(QQmlApplicationEngine obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~QQmlApplicationEngine() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          QtNetCoreQmlPINVOKE.delete_QQmlApplicationEngine(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public void loadFile(string filePath) {
    QtNetCoreQmlPINVOKE.QQmlApplicationEngine_loadFile(swigCPtr, filePath);
    if (QtNetCoreQmlPINVOKE.SWIGPendingException.Pending) throw QtNetCoreQmlPINVOKE.SWIGPendingException.Retrieve();
  }

  public QQmlApplicationEngine() : this(QtNetCoreQmlPINVOKE.new_QQmlApplicationEngine(), true) {
  }

}

}
namespace Qt.NetCore {

class QtNetCoreQmlPINVOKE {

  protected class SWIGExceptionHelper {

    public delegate void ExceptionDelegate(string message);
    public delegate void ExceptionArgumentDelegate(string message, string paramName);

    static ExceptionDelegate applicationDelegate = new ExceptionDelegate(SetPendingApplicationException);
    static ExceptionDelegate arithmeticDelegate = new ExceptionDelegate(SetPendingArithmeticException);
    static ExceptionDelegate divideByZeroDelegate = new ExceptionDelegate(SetPendingDivideByZeroException);
    static ExceptionDelegate indexOutOfRangeDelegate = new ExceptionDelegate(SetPendingIndexOutOfRangeException);
    static ExceptionDelegate invalidCastDelegate = new ExceptionDelegate(SetPendingInvalidCastException);
    static ExceptionDelegate invalidOperationDelegate = new ExceptionDelegate(SetPendingInvalidOperationException);
    static ExceptionDelegate ioDelegate = new ExceptionDelegate(SetPendingIOException);
    static ExceptionDelegate nullReferenceDelegate = new ExceptionDelegate(SetPendingNullReferenceException);
    static ExceptionDelegate outOfMemoryDelegate = new ExceptionDelegate(SetPendingOutOfMemoryException);
    static ExceptionDelegate overflowDelegate = new ExceptionDelegate(SetPendingOverflowException);
    static ExceptionDelegate systemDelegate = new ExceptionDelegate(SetPendingSystemException);

    static ExceptionArgumentDelegate argumentDelegate = new ExceptionArgumentDelegate(SetPendingArgumentException);
    static ExceptionArgumentDelegate argumentNullDelegate = new ExceptionArgumentDelegate(SetPendingArgumentNullException);
    static ExceptionArgumentDelegate argumentOutOfRangeDelegate = new ExceptionArgumentDelegate(SetPendingArgumentOutOfRangeException);

    [global::System.Runtime.InteropServices.DllImport("QtNetCoreQml", EntryPoint="SWIGRegisterExceptionCallbacks_QtNetCoreQml")]
    public static extern void SWIGRegisterExceptionCallbacks_QtNetCoreQml(
                                ExceptionDelegate applicationDelegate,
                                ExceptionDelegate arithmeticDelegate,
                                ExceptionDelegate divideByZeroDelegate, 
                                ExceptionDelegate indexOutOfRangeDelegate, 
                                ExceptionDelegate invalidCastDelegate,
                                ExceptionDelegate invalidOperationDelegate,
                                ExceptionDelegate ioDelegate,
                                ExceptionDelegate nullReferenceDelegate,
                                ExceptionDelegate outOfMemoryDelegate, 
                                ExceptionDelegate overflowDelegate, 
                                ExceptionDelegate systemExceptionDelegate);

    [global::System.Runtime.InteropServices.DllImport("QtNetCoreQml", EntryPoint="SWIGRegisterExceptionArgumentCallbacks_QtNetCoreQml")]
    public static extern void SWIGRegisterExceptionCallbacksArgument_QtNetCoreQml(
                                ExceptionArgumentDelegate argumentDelegate,
                                ExceptionArgumentDelegate argumentNullDelegate,
                                ExceptionArgumentDelegate argumentOutOfRangeDelegate);

    static void SetPendingApplicationException(string message) {
      SWIGPendingException.Set(new global::System.ApplicationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArithmeticException(string message) {
      SWIGPendingException.Set(new global::System.ArithmeticException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingDivideByZeroException(string message) {
      SWIGPendingException.Set(new global::System.DivideByZeroException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIndexOutOfRangeException(string message) {
      SWIGPendingException.Set(new global::System.IndexOutOfRangeException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidCastException(string message) {
      SWIGPendingException.Set(new global::System.InvalidCastException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidOperationException(string message) {
      SWIGPendingException.Set(new global::System.InvalidOperationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIOException(string message) {
      SWIGPendingException.Set(new global::System.IO.IOException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingNullReferenceException(string message) {
      SWIGPendingException.Set(new global::System.NullReferenceException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOutOfMemoryException(string message) {
      SWIGPendingException.Set(new global::System.OutOfMemoryException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOverflowException(string message) {
      SWIGPendingException.Set(new global::System.OverflowException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingSystemException(string message) {
      SWIGPendingException.Set(new global::System.SystemException(message, SWIGPendingException.Retrieve()));
    }

    static void SetPendingArgumentException(string message, string paramName) {
      SWIGPendingException.Set(new global::System.ArgumentException(message, paramName, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArgumentNullException(string message, string paramName) {
      global::System.Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new global::System.ArgumentNullException(paramName, message));
    }
    static void SetPendingArgumentOutOfRangeException(string message, string paramName) {
      global::System.Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new global::System.ArgumentOutOfRangeException(paramName, message));
    }

    static SWIGExceptionHelper() {
      SWIGRegisterExceptionCallbacks_QtNetCoreQml(
                                applicationDelegate,
                                arithmeticDelegate,
                                divideByZeroDelegate,
                                indexOutOfRangeDelegate,
                                invalidCastDelegate,
                                invalidOperationDelegate,
                                ioDelegate,
                                nullReferenceDelegate,
                                outOfMemoryDelegate,
                                overflowDelegate,
                                systemDelegate);

      SWIGRegisterExceptionCallbacksArgument_QtNetCoreQml(
                                argumentDelegate,
                                argumentNullDelegate,
                                argumentOutOfRangeDelegate);
    }
  }

  protected static SWIGExceptionHelper swigExceptionHelper = new SWIGExceptionHelper();

  public class SWIGPendingException {
    [global::System.ThreadStatic]
    private static global::System.Exception pendingException = null;
    private static int numExceptionsPending = 0;

    public static bool Pending {
      get {
        bool pending = false;
        if (numExceptionsPending > 0)
          if (pendingException != null)
            pending = true;
        return pending;
      } 
    }

    public static void Set(global::System.Exception e) {
      if (pendingException != null)
        throw new global::System.ApplicationException("FATAL: An earlier pending exception from unmanaged code was missed and thus not thrown (" + pendingException.ToString() + ")", e);
      pendingException = e;
      lock(typeof(QtNetCoreQmlPINVOKE)) {
        numExceptionsPending++;
      }
    }

    public static global::System.Exception Retrieve() {
      global::System.Exception e = null;
      if (numExceptionsPending > 0) {
        if (pendingException != null) {
          e = pendingException;
          pendingException = null;
          lock(typeof(QtNetCoreQmlPINVOKE)) {
            numExceptionsPending--;
          }
        }
      }
      return e;
    }
  }


  protected class SWIGStringHelper {

    public delegate string SWIGStringDelegate(string message);
    static SWIGStringDelegate stringDelegate = new SWIGStringDelegate(CreateString);

    [global::System.Runtime.InteropServices.DllImport("QtNetCoreQml", EntryPoint="SWIGRegisterStringCallback_QtNetCoreQml")]
    public static extern void SWIGRegisterStringCallback_QtNetCoreQml(SWIGStringDelegate stringDelegate);

    static string CreateString(string cString) {
      return cString;
    }

    static SWIGStringHelper() {
      SWIGRegisterStringCallback_QtNetCoreQml(stringDelegate);
    }
  }

  static protected SWIGStringHelper swigStringHelper = new SWIGStringHelper();


  static QtNetCoreQmlPINVOKE() {
  }


  [global::System.Runtime.InteropServices.DllImport("QtNetCoreQml", EntryPoint="CSharp_StringVector_Clear")]
  public static extern void StringVector_Clear(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("QtNetCoreQml", EntryPoint="CSharp_StringVector_Add")]
  public static extern void StringVector_Add(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("QtNetCoreQml", EntryPoint="CSharp_StringVector_size")]
  public static extern uint StringVector_size(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("QtNetCoreQml", EntryPoint="CSharp_StringVector_capacity")]
  public static extern uint StringVector_capacity(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("QtNetCoreQml", EntryPoint="CSharp_StringVector_reserve")]
  public static extern void StringVector_reserve(global::System.Runtime.InteropServices.HandleRef jarg1, uint jarg2);

  [global::System.Runtime.InteropServices.DllImport("QtNetCoreQml", EntryPoint="CSharp_new_StringVector__SWIG_0")]
  public static extern global::System.IntPtr new_StringVector__SWIG_0();

  [global::System.Runtime.InteropServices.DllImport("QtNetCoreQml", EntryPoint="CSharp_new_StringVector__SWIG_1")]
  public static extern global::System.IntPtr new_StringVector__SWIG_1(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("QtNetCoreQml", EntryPoint="CSharp_new_StringVector__SWIG_2")]
  public static extern global::System.IntPtr new_StringVector__SWIG_2(int jarg1);

  [global::System.Runtime.InteropServices.DllImport("QtNetCoreQml", EntryPoint="CSharp_StringVector_getitemcopy")]
  public static extern string StringVector_getitemcopy(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("QtNetCoreQml", EntryPoint="CSharp_StringVector_getitem")]
  public static extern string StringVector_getitem(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("QtNetCoreQml", EntryPoint="CSharp_StringVector_setitem")]
  public static extern void StringVector_setitem(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, string jarg3);

  [global::System.Runtime.InteropServices.DllImport("QtNetCoreQml", EntryPoint="CSharp_StringVector_AddRange")]
  public static extern void StringVector_AddRange(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

  [global::System.Runtime.InteropServices.DllImport("QtNetCoreQml", EntryPoint="CSharp_StringVector_GetRange")]
  public static extern global::System.IntPtr StringVector_GetRange(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, int jarg3);

  [global::System.Runtime.InteropServices.DllImport("QtNetCoreQml", EntryPoint="CSharp_StringVector_Insert")]
  public static extern void StringVector_Insert(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, string jarg3);

  [global::System.Runtime.InteropServices.DllImport("QtNetCoreQml", EntryPoint="CSharp_StringVector_InsertRange")]
  public static extern void StringVector_InsertRange(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, global::System.Runtime.InteropServices.HandleRef jarg3);

  [global::System.Runtime.InteropServices.DllImport("QtNetCoreQml", EntryPoint="CSharp_StringVector_RemoveAt")]
  public static extern void StringVector_RemoveAt(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("QtNetCoreQml", EntryPoint="CSharp_StringVector_RemoveRange")]
  public static extern void StringVector_RemoveRange(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, int jarg3);

  [global::System.Runtime.InteropServices.DllImport("QtNetCoreQml", EntryPoint="CSharp_StringVector_Repeat")]
  public static extern global::System.IntPtr StringVector_Repeat(string jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("QtNetCoreQml", EntryPoint="CSharp_StringVector_Reverse__SWIG_0")]
  public static extern void StringVector_Reverse__SWIG_0(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("QtNetCoreQml", EntryPoint="CSharp_StringVector_Reverse__SWIG_1")]
  public static extern void StringVector_Reverse__SWIG_1(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, int jarg3);

  [global::System.Runtime.InteropServices.DllImport("QtNetCoreQml", EntryPoint="CSharp_StringVector_SetRange")]
  public static extern void StringVector_SetRange(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, global::System.Runtime.InteropServices.HandleRef jarg3);

  [global::System.Runtime.InteropServices.DllImport("QtNetCoreQml", EntryPoint="CSharp_StringVector_Contains")]
  public static extern bool StringVector_Contains(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("QtNetCoreQml", EntryPoint="CSharp_StringVector_IndexOf")]
  public static extern int StringVector_IndexOf(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("QtNetCoreQml", EntryPoint="CSharp_StringVector_LastIndexOf")]
  public static extern int StringVector_LastIndexOf(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("QtNetCoreQml", EntryPoint="CSharp_StringVector_Remove")]
  public static extern bool StringVector_Remove(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("QtNetCoreQml", EntryPoint="CSharp_delete_StringVector")]
  public static extern void delete_StringVector(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("QtNetCoreQml", EntryPoint="CSharp_QCoreApplication_setAttribute__SWIG_0")]
  public static extern void QCoreApplication_setAttribute__SWIG_0(int jarg1, bool jarg2);

  [global::System.Runtime.InteropServices.DllImport("QtNetCoreQml", EntryPoint="CSharp_QCoreApplication_setAttribute__SWIG_1")]
  public static extern void QCoreApplication_setAttribute__SWIG_1(int jarg1);

  [global::System.Runtime.InteropServices.DllImport("QtNetCoreQml", EntryPoint="CSharp_QCoreApplication_exec")]
  public static extern int QCoreApplication_exec(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("QtNetCoreQml", EntryPoint="CSharp_delete_QCoreApplication")]
  public static extern void delete_QCoreApplication(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("QtNetCoreQml", EntryPoint="CSharp_new_QGuiApplication")]
  public static extern global::System.IntPtr new_QGuiApplication(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("QtNetCoreQml", EntryPoint="CSharp_QGuiApplication_exec")]
  public static extern int QGuiApplication_exec(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("QtNetCoreQml", EntryPoint="CSharp_delete_QGuiApplication")]
  public static extern void delete_QGuiApplication(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("QtNetCoreQml", EntryPoint="CSharp_QQmlApplicationEngine_loadFile")]
  public static extern void QQmlApplicationEngine_loadFile(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("QtNetCoreQml", EntryPoint="CSharp_new_QQmlApplicationEngine")]
  public static extern global::System.IntPtr new_QQmlApplicationEngine();

  [global::System.Runtime.InteropServices.DllImport("QtNetCoreQml", EntryPoint="CSharp_delete_QQmlApplicationEngine")]
  public static extern void delete_QQmlApplicationEngine(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("QtNetCoreQml", EntryPoint="CSharp_registerNetType")]
  public static extern int registerNetType(string jarg1, string jarg2, int jarg3, int jarg4, string jarg5);
}

}
namespace Qt.NetCore {

public class QtNetCoreQml {
  public static int registerNetType(string netType, string uri, int versionMajor, int versionMinor, string qmlName) {
    int ret = QtNetCoreQmlPINVOKE.registerNetType(netType, uri, versionMajor, versionMinor, qmlName);
    if (QtNetCoreQmlPINVOKE.SWIGPendingException.Pending) throw QtNetCoreQmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
