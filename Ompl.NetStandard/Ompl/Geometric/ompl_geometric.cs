//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.2.0
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Ompl.Geometric {

public class ompl_geometric {
  public static SWIGTYPE_p_std__chrono__system_clock__time_point now() {
    SWIGTYPE_p_std__chrono__system_clock__time_point ret = new SWIGTYPE_p_std__chrono__system_clock__time_point(ompl_geometricPINVOKE.now(), true);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static SWIGTYPE_p_std__chrono__system_clock__duration seconds(double sec) {
    SWIGTYPE_p_std__chrono__system_clock__duration ret = new SWIGTYPE_p_std__chrono__system_clock__duration(ompl_geometricPINVOKE.seconds__SWIG_0(sec), true);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double seconds(SWIGTYPE_p_std__chrono__system_clock__duration d) {
    double ret = ompl_geometricPINVOKE.seconds__SWIG_1(SWIGTYPE_p_std__chrono__system_clock__duration.getCPtr(d));
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static SWIGTYPE_p_std__string as_string(SWIGTYPE_p_std__chrono__system_clock__time_point p) {
    SWIGTYPE_p_std__string ret = new SWIGTYPE_p_std__string(ompl_geometricPINVOKE.as_string(SWIGTYPE_p_std__chrono__system_clock__time_point.getCPtr(p)), true);
    if (ompl_geometricPINVOKE.SWIGPendingException.Pending) throw ompl_geometricPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
