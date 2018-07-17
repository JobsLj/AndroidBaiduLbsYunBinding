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

namespace Com.Baidu.Platform.Comapi.Wnplatform.Walkmap
{    
    public partial class WNaviBaiduMap : global::Java.Lang.Object
    {
        IntPtr id_getId;
        IntPtr id_setId_J;
        public unsafe long Id
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.wnplatform.walkmap']/class[@name='WNaviBaiduMap']/method[@name='getId' and count(parameter)=0]"
            [Register("getId", "()J", "GetGetIdHandler")]
            get
            {
                if (id_getId == IntPtr.Zero)
                    id_getId = JNIEnv.GetStaticMethodID(class_ref, "getId", "()J");
                try
                {
                    return JNIEnv.CallStaticLongMethod(class_ref, id_getId);
                }
                finally
                {
                }
            }
            // Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comapi.wnplatform.walkmap']/class[@name='WNaviBaiduMap']/method[@name='setId' and count(parameter)=1 and parameter[1][@type='long']]"
            [Register("setId", "(J)V", "GetSetId_JHandler")]
            set
            {
                if (id_setId_J == IntPtr.Zero)
                    id_setId_J = JNIEnv.GetMethodID(class_ref, "setId", "(J)V");
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(value);

                    if (((object)this).GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setId_J, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "setId", "(J)V"), __args);
                }
                finally
                {
                }
            }
        }
    }
}