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
    class TransformationToNode
    {
        public static void Run()
        {
            // initialize scene object
            Scene scene = new Scene();

            // initialize Node class object
            Node cubeNode = new Node("cube");

            // Call CubeMesh class create method to set mesh instance 
            Mesh mesh = CubeMesh.CreateCubeMesh();

            // point node to the Mesh geometry
            cubeNode.Entity = mesh;

            // set rotation
            cubeNode.Transform.Rotation = Quaternion.FromRotation(new Vector3(0, 1, 0), new Vector3(0.3, 0.5, 0.1));
            
            // set translation
            cubeNode.Transform.Translation = new Vector3(0, 0, 20);
            
            // add cube to the scene
            scene.RootNode.ChildNodes.Add(cubeNode);

            // The path to the documents directory.
            string MyDir = RunExamples.GetDataDir_GeometryAndHierarchy();
            MyDir = MyDir + "TransformationToNode.fbx";
            
            // save 3D scene in the supported file formats
            scene.Save(MyDir, FileFormat.FBX7400ASCII);

            Console.WriteLine("\nTransformation added successfully to node.");
        }
    }
}
