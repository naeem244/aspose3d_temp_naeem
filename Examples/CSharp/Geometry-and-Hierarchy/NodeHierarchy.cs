//////////////////////////////////////////////////////////////////////////
// Copyright 2015 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.3D. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.IO;
using Aspose.ThreeD;
using Aspose.ThreeD.Entities;
using Aspose.ThreeD.Utils;

namespace CSharp.Geometry_Hierarchy
{
    class NodeHierarchy
    {
        public static void Run()
        {
            // initialize scene object
            Scene scene = new Scene();

            // get a child node object
            Node top = scene.RootNode.CreateChildNode();

            // each cube node has their own translation
            Node cube1 = top.CreateChildNode("cube1");

            // Call CubeMesh class create method to set mesh instance 
            Mesh mesh = CubeMesh.CreateCubeMesh();

            // point node to the mesh
            cube1.Entity = mesh;
            // set first cube translation
            cube1.Transform.Translation = new Vector3(-10, 0, 0);

            Node cube2 = top.CreateChildNode("cube2");
            // point node to the mesh
            cube2.Entity = mesh;
            // set second cube translation
            cube2.Transform.Translation = new Vector3(10, 0, 0);

            // the rotated top node will affect all child nodes
            top.Transform.Rotation = Quaternion.FromEulerAngle(Math.PI, 4, 0);

            // The path to the documents directory.
            string MyDir = RunExamples.GetDataDir_GeometryAndHierarchy();
            MyDir = MyDir + "NodeHierarchy.fbx";
            
            // save 3D scene in the supported file formats
            scene.Save(MyDir, FileFormat.FBX7400ASCII);

            Console.WriteLine("\nNode hierarchy added successfully to document.");
        }
    }
}
