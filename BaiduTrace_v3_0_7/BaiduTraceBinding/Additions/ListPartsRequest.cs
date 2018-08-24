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

namespace Com.Baidubce.Services.Bos.Model
{
    public partial class ListPartsRequest : global::Com.Baidubce.Services.Bos.Model.GenericUploadRequest
    {
        public override GenericBucketRequest WithBucketName(string p0)
        {
            return RawWithBucketName(p0);
        }
        public override GenericObjectRequest WithKey(string p0)
        {
            return RawWithKey(p0);
        }
        public override AbstractBceRequest WithRequestCredentials(IBceCredentials p0)
        {
            return RawWithRequestCredentials(p0);
        }
        public override GenericUploadRequest WithUploadId(string p0)
        {
            return RawWithUploadId(p0);
        }
    }
}