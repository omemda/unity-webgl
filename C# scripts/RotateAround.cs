using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// A C# script to constantly rotate an object around.
public class RotateAround : MonoBehaviour
{
    void Update()
    {
        // Spin the object around the target at 20 degrees/second.
        transform.RotateAround(transform.position, Vector3.up, 20 * Time.deltaTime);
    }
}

