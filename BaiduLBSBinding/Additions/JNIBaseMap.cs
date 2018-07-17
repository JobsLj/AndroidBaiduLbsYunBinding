using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap
{
    public class JNIBaseMapInitPara
    {
        public long ParamLong { get; set; }
        public String ParamString1 { get; set; }
        public String ParamString2 { get; set; }
        public String ParamString3 { get; set; }
        public String ParamString4 { get; set; }
        public String ParamString5 { get; set; }
        public String ParamString6 { get; set; }
        public String ParamString7 { get; set; }
        public String ParamString8 { get; set; }
        public String ParamString9 { get; set; }
        public int ParamInt1 { get; set; }
        public int ParamInt2 { get; set; }
        public int ParamInt3 { get; set; }
        public int ParamInt4 { get; set; }
        public int ParamInt5 { get; set; }
        public int ParamInt6 { get; set; }
        public int ParamInt7 { get; set; }

    }

    public partial class JNIBaseMap : global::Java.Lang.Object
    {
        static Delegate cb_Init_J;
        //static Delegate cb_CreateDuplicate_J;

        static Delegate GetInit_JHandler()
        {
            if (cb_Init_J == null)
                cb_Init_J = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, JNIBaseMapInitPara, bool>)n_Init_J);
            return cb_Init_J;
        }
        //static Delegate GetCreateDuplicate_JHandler()
        //{
        //    if (cb_CreateDuplicate_J == null)
        //        cb_CreateDuplicate_J = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, long, long>)n_CreateDuplicate_J);
        //    return cb_CreateDuplicate_J;
        //}

        static bool n_Init_J(IntPtr jnienv, IntPtr native__this, JNIBaseMapInitPara p0)
        {
            global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.Init(p0);
        }
        //static long n_CreateDuplicate_J(IntPtr jnienv, IntPtr native__this, long p0)
        //{
        //    global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
        //    return __this.CreateDuplicate(p0);
        //}

        static IntPtr id_Init_J;
        [Register("Init", "(JWRAPPARA)J", "GetInit_JHandler")]
        public virtual unsafe bool Init(JNIBaseMapInitPara p0)
        {
            if (id_Init_J == IntPtr.Zero)
                id_Init_J = JNIEnv.GetMethodID(class_ref, "Init", "(JWRAPPARA)J");
            try
            {
                IntPtr native_p1 = JNIEnv.NewString(p0.ParamString1);
                IntPtr native_p2 = JNIEnv.NewString(p0.ParamString2);
                IntPtr native_p3 = JNIEnv.NewString(p0.ParamString3);
                IntPtr native_p4 = JNIEnv.NewString(p0.ParamString4);
                IntPtr native_p5 = JNIEnv.NewString(p0.ParamString5);
                IntPtr native_p6 = JNIEnv.NewString(p0.ParamString6);
                IntPtr native_p7 = JNIEnv.NewString(p0.ParamString7);
                IntPtr native_p8 = JNIEnv.NewString(p0.ParamString8);
                IntPtr native_p9 = JNIEnv.NewString(p0.ParamString9);

                JValue* __args = stackalloc JValue[17];
                __args[0] = new JValue(p0.ParamLong);
                __args[1] = new JValue(native_p1);
                __args[2] = new JValue(native_p2);                
                __args[3] = new JValue(native_p3);
                __args[4] = new JValue(native_p4);
                __args[5] = new JValue(native_p5);
                __args[6] = new JValue(native_p6);
                __args[7] = new JValue(native_p7);
                __args[8] = new JValue(native_p8);
                __args[9] = new JValue(native_p9);
                __args[10] = new JValue(p0.ParamInt1);
                __args[11] = new JValue(p0.ParamInt2);
                __args[12] = new JValue(p0.ParamInt3);
                __args[13] = new JValue(p0.ParamInt4);
                __args[14] = new JValue(p0.ParamInt5);
                __args[15] = new JValue(p0.ParamInt6);
                __args[16] = new JValue(p0.ParamInt7);

                if (((object)this).GetType() == ThresholdType)
                    return JNIEnv.CallBooleanMethod(((global::Java.Lang.Object)this).Handle, id_Init_J, __args);
                else
                    return JNIEnv.CallNonvirtualBooleanMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "Init", "(JWRAPPARA)J"), __args);
            }
            finally
            {
            }
        }
        //static IntPtr id_CreateDuplicate_J;
        //// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='CreateDuplicate' and count(parameter)=1 and parameter[1][@type='long']]"
        //[Register("CreateDuplicate", "(J)J", "GetCreateDuplicate_JHandler")]
        //public virtual unsafe long CreateDuplicate(long p0)
        //{
        //    if (id_CreateDuplicate_J == IntPtr.Zero)
        //        id_CreateDuplicate_J = JNIEnv.GetMethodID(class_ref, "CreateDuplicate", "(J)J");
        //    try
        //    {
        //        JValue* __args = stackalloc JValue[1];
        //        __args[0] = new JValue(p0);

        //        if (((object)this).GetType() == ThresholdType)
        //            return JNIEnv.CallLongMethod(((global::Java.Lang.Object)this).Handle, id_CreateDuplicate_J, __args);
        //        else
        //            return JNIEnv.CallNonvirtualLongMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "CreateDuplicate", "(J)J"), __args);
        //    }
        //    finally
        //    {
        //    }
        //}
    }
}