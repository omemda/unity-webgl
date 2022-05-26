using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// A C# script to align object's rotation to main camera.
// Used to align UI text to camera while rotating the camera.
public class LookAt : MonoBehaviour
{
    void Update()
    {
        transform.rotation = Camera.main.transform.rotation;
    }
}
