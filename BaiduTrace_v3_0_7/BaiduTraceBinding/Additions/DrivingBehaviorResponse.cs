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

namespace Com.Baidu.Trace.Api.Analysis
{
    public class DrivingBehaviorResponseCtor2
    {
        public int ParamInt1 { get; set; }
        public int ParamInt2 { get; set; }
        public String ParamString { get; set; }
        public double ParamDouble1 { get; set; }
        public int ParamInt3 { get; set; }
        public double ParamDouble2 { get; set; }
        public double ParamDouble3 { get; set; }
        public int ParamInt4{ get; set; }
        public int ParamInt5{ get; set; }
        public int ParamInt6{ get; set; }
        public int ParamInt7 { get; set; }
        public StartPoint ParamStartPoint { get; set; }
        public EndPoint ParamEndPoint { get; set; }
        public List<SpeedingInfo> ParamList { get; set; }
        public List<HarshAccelerationPoint> ParamList1 { get; set; }
        public List<HarshBreakingPoint> ParamList2 { get; set; }
        public List<HarshSteeringPoint> ParamList3 { get; set; }
    }
    public sealed partial class DrivingBehaviorResponse : global::Com.Baidu.Trace.Model.BaseResponse
    {
        public DrivingBehaviorResponse(DrivingBehaviorResponseCtor2 para) : base(para.ParamInt1, para.ParamInt2, para.ParamString)
        {
            //a
            this.Distance = para.ParamDouble1;

            //b
            this.Duration = para.ParamInt3;

            //c
            this.AverageSpeed = para.ParamDouble2;

            //d MaxSpeed
            this.MaxSpeed = para.ParamDouble3;

            //e SpeedingNum
            this.SpeedingNum = para.ParamInt4;

            //f HarshAccelerationNum
            this.HarshAccelerationNum = para.ParamInt5;

            //g HarshBreakingNum
            this.HarshBreakingNum = para.ParamInt6;

            //h HarshSteeringNum
            this.HarshSteeringNum = para.ParamInt7;

            //i StartPoint
            this.StartPoint = para.ParamStartPoint;

            //j EndPoint
            this.EndPoint = para.ParamEndPoint;

            //k Speedings
            this.Speedings = para.ParamList;

            //l HarshAccelerationPoints
            this.HarshAccelerationPoints = para.ParamList1;

            //m HarshBreakingPoints
            this.HarshBreakingPoints = para.ParamList2;

            //n HarshSteeringPoints
            this.HarshSteeringPoints = para.ParamList3;
        }
    }
}