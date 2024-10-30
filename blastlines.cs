// Grasshopper Script Instance
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

using Rhino;
using Rhino.Geometry;

using Grasshopper;
using Grasshopper.Kernel;
using Grasshopper.Kernel.Data;
using Grasshopper.Kernel.Types;

public class Script_Instance : GH_ScriptInstance
{
  /* 
    Members:
      RhinoDoc RhinoDocument
      GH_Document GrasshopperDocument
      IGH_Component Component
      int Iteration

    Methods (Virtual & overridable):
      Print(string text)
      Print(string format, params object[] args)
      Reflect(object obj)
      Reflect(object obj, string method_name)
  */
  
  private void RunScript(
	double rangeStart,
	double rangeEnd,
	int n,
	int point_i,
	out object points,
	out object point)
  {

    // Create a Random instance
    Random random = new Random();

    // Initialize an array to store the generated points
    Point3d[] pointArray = new Point3d[n];

    // Generate 'n' points with random coordinates
    for (int i = 0; i < n; i++)
    {
        // Generate random values between rangeStart and rangeEnd
        double randomFloatX = random.NextDouble() * rangeEnd;
        double randomFloatY = random.NextDouble() * rangeEnd;
        double randomFloatZ = random.NextDouble() * rangeEnd;
        
        // Create a new Point3d with the random coordinates
        pointArray[i] = new Point3d(randomFloatX, randomFloatY, randomFloatZ);
    }

    // Set the output to the generated points array
    points = pointArray;
    // point = points[point_i];
    point = pointArray[point_i];

}
}
