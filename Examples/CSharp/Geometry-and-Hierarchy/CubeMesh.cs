//////////////////////////////////////////////////////////////////////////
// Copyright 2015 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.3D. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System;
using Aspose.ThreeD.Entities;
using Aspose.ThreeD.Utils;

namespace CSharp.Geometry_Hierarchy
{
    class CubeMesh
    {
        public static Mesh CreateCubeMesh()
        {
            // initialize control points
            Vector4[] controlPoints = new Vector4[]{
    new Vector4( -5.0, 0.0, 5.0, 1.0),
    new Vector4( 5.0, 0.0, 5.0, 1.0),
    new Vector4( 5.0, 10.0, 5.0, 1.0),
    new Vector4( -5.0, 10.0, 5.0, 1.0),
    new Vector4( -5.0, 0.0, -5.0, 1.0),
    new Vector4( 5.0, 0.0, -5.0, 1.0),
    new Vector4( 5.0, 10.0, -5.0, 1.0),
    new Vector4( -5.0, 10.0, -5.0, 1.0)
};
            // initialize mesh object
            Mesh mesh = new Mesh();
            // add control points to the mesh
            mesh.ControlPoints.AddRange(controlPoints);
            return mesh;
        }
    }
}
