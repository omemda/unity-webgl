using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//A C# script to rotate an object on mouse drag. Fixed on X axis.
public class GrabRotation : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 100f;
    bool dragging = false;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMouseDrag()
    {
        dragging = true;
    }
    void Update()
    {
        if(Input.GetMouseButtonUp (0))
        {
            dragging = false;
        }
    }
    private void FixedUpdate()
    {
        if (dragging)
        {
            float x = Input.GetAxis("Mouse X") * rotationSpeed*Time.fixedDeltaTime;
            //float y = Input.GetAxis("Mouse Y") * rotationSpeed*Time.fixedDeltaTime;

            rb.AddTorque(Vector3.down * x);
            //rb.AddTorque(Vector3.right * y);
        }
    }
}
