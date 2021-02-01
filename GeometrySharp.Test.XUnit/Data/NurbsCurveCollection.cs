﻿using System.Collections.Generic;
using GeometrySharp.Core;
using GeometrySharp.Geometry;

namespace GeometrySharp.Test.XUnit.Data
{
    public class NurbsCurveCollection
    {
        public static NurbsCurve NurbsCurveExample()
        {
            int degree = 2;
            List<Vector3> pts = new List<Vector3>()
            {
                new Vector3(){-10,15,5},
                new Vector3(){10,5,5},
                new Vector3(){20,0,0}
            };
            Knot knots = new Knot() { 0, 0, 0, 1, 1, 1 };

            return new NurbsCurve(degree, knots, pts);
        }

        public static NurbsCurve NurbsCurvePtsAndWeightsExample()
        {
            int degree = 2;
            List<Vector3> pts = new List<Vector3>()
            {
                new Vector3(){-10,15,5},
                new Vector3(){10,5,5},
                new Vector3(){20,0,0}
            };
            Knot knots = new Knot() { 1, 1, 1, 1, 1, 1 };
            var weights = new List<double>() { 0.5, 0.5, 0.5 };

            return new NurbsCurve(degree, knots, pts, weights);
        }

        public static NurbsCurve NurbsCurveExample2()
        {
            var knots = new Knot() { 0.0, 0.0, 0.0, 0.0, 0.333333, 0.666667, 1.0, 1.0, 1.0, 1.0 };
            var degree = 3;
            var controlPts = new List<Vector3>()
            {
                new Vector3() {5,5,0},
                new Vector3() {10, 10, 0},
                new Vector3() {20, 15, 0},
                new Vector3() {35, 15, 0},
                new Vector3() {45, 10, 0},
                new Vector3() {50, 5, 0}
            };
            return new NurbsCurve(degree, knots, controlPts);
        }
    }
}
