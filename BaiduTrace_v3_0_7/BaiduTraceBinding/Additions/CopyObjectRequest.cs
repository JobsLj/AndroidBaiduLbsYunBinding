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
using Com.Baidubce.Auth;
using Com.Baidubce.Model;
using Com.Baidubce.Services.Bos.Model;

namespace Com.Baidubce.Services.Bos.Model
{
    
    partial class CopyObjectRequest : global::Com.Baidubce.Services.Bos.Model.GenericObjectRequest
    {
        public override GenericBucketRequest WithBucketName(string p0)
        {
            return this.RawWithBucketName(p0);
        }
        
        public override GenericObjectRequest WithKey(string p0)
        {
            return this.RawWithKey(p0);
        }

        public override AbstractBceRequest WithRequestCredentials(IBceCredentials p0)
        {
            return this.RawWithRequestCredentials(p0);
        }
    }

}