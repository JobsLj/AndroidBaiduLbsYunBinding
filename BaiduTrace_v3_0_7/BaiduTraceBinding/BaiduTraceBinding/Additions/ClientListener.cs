using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Com.Baidu.Trace
{        
    public sealed partial class LBSTraceClient : global::Java.Lang.Object
    {
        public partial class ClientListener : global::Com.Baidu.Trace.ListenerStub
        {
            static IntPtr id_gatherAttribute_J;
            public override unsafe IDictionary GatherAttribute(long p0)
            {
                if (id_gatherAttribute_J == IntPtr.Zero)
					id_gatherAttribute_J = JNIEnv.GetMethodID (class_ref, "gatherAttribute", "(J)Ljava/util/Map;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

                    if (((object)this).GetType() == ThresholdType)
                    {
                        var x = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_gatherAttribute_J, __args), JniHandleOwnership.TransferLocalRef);
                        var y = (IDictionary)x;
                        return y;
                    }
                    else
                    {
                        var x = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "gatherAttribute", "(J)Ljava/util/Map;"), __args), JniHandleOwnership.TransferLocalRef);
                        var y = (IDictionary)x;
                        return y;
                    }
						
				} finally {
				}
            }
        }
    }
    
}