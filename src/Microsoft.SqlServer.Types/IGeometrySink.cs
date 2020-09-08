﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.SqlServer.Types
{
    [Obsolete("IGeometrySink is obsolete, use IGeometrySink110 instead.")]
    public interface IGeometrySink
    {
        void AddLine(double x, double y, double? z, double? m);
        void BeginFigure(double x, double y, double? z, double? m);
        void BeginGeometry(OpenGisGeometryType type);
        void EndFigure();
        void EndGeometry();
        void SetSrid(int srid);
    }
#pragma warning disable CS0618 // Type or member is obsolete
    public interface IGeometrySink110 : IGeometrySink
#pragma warning restore CS0618 // Type or member is obsolete
    {
        void AddCircularArc(double x1, double y1, double? z1, double? m1, double x2, double y2, double? z2, double? m2);
    }
}
