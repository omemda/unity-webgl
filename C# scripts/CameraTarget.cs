using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// A C# script to focus camera on a postion.
// Similar to Camera focus. Distance variable can be set in the Unity editor.

public class CameraTarget : MonoBehaviour
{
    public GameObject getTarget;
    public float distance = 10f;
    public void Position()
    {
        // Setting camera position so it's not on the object
        transform.position = getTarget.transform.position - new Vector3 (0,0,distance);
    }
}
