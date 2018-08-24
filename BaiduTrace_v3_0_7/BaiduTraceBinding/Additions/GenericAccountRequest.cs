﻿using System;
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

namespace Com.Baidubce.Model
{
    public partial class GenericAccountRequest : global::Com.Baidubce.Model.AbstractBceRequest
    {
        public override AbstractBceRequest WithRequestCredentials(IBceCredentials p0)
        {
            return RawWithRequestCredentials(p0);
        }
    }
}