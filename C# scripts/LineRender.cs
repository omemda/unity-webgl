using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// A C# script for line rendering between two positions.
public class LineRender : MonoBehaviour
{
    public LineRenderer line;
    public Transform pos1;
    public Vector3 correction;
    public Transform pos2;


    void Update()
    {
        line.SetPosition(1, pos2.position);
        line.SetPosition(0, pos1.position + correction);
    }
}
