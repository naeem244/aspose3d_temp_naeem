//////////////////////////////////////////////////////////////////////////
// Copyright 2015 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.3D. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System;
using Aspose.ThreeD;
using Aspose.ThreeD.Entities;
using Aspose.ThreeD.Utils;
using Aspose.ThreeD.Shading;
using System.Drawing;

namespace CSharp.Geometry_Hierarchy
{
    class MaterialToCube
    {
        public static void Run()
        {
            // initialize scene object
            Scene scene = new Scene();
            
            // initialize cube node object
            Node cubeNode = new Node("cube");
            
            // Call CubeMesh class create method to set mesh instance 
            Mesh mesh = CubeMesh.CreateCubeMesh();
            
            // point node to the mesh
            cubeNode.Entity = mesh;
            
            // add cube to the scene
            scene.RootNode.ChildNodes.Add(cubeNode);

            // initiallize PhongMaterial object
            PhongMaterial mat = new PhongMaterial();
            // initiallize Texture object
            Texture diffuse = new Texture();
            
            // The path to the documents directory.
            string MyDir = RunExamples.GetDataDir_GeometryAndHierarchy();
            
            // set local file path
            diffuse.FileName = MyDir + "surface.dds";
            // set Texture of the material
            mat.SetTexture("DiffuseColor", diffuse);
            
            // set color
            mat.SpecularColor = new Vector3(Color.Red);
            // set brightness
            mat.Shininess = 100;
            // set material property of the cube object
            cubeNode.Material = mat;


            MyDir = MyDir + "MaterialToCube.fbx";
            
            // save 3D scene in the supported file formats
            scene.Save(MyDir, FileFormat.FBX7400ASCII);

            Console.WriteLine("\nMaterial added successfully to cube.");
        }
    }
}
