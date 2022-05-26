using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// A C# script to focus camera on a postion.
public class CameraFocus : MonoBehaviour
{
    // Focus point for Camera
    public Transform target;

    void Update()
    {
        // Sets camera rotation to an object's position
        transform.LookAt(target);

        // Setting camera position so it's not on the object
        transform.position = target.position - new Vector3(0, -1, 4);
    }
}