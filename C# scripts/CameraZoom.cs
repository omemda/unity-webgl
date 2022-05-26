using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// A C# script for zooming camera in and out using the scroll wheel.
// Clamped to limit the zoom level
public class CameraZoom : MonoBehaviour
{
    private Camera cam;
    private float targetZoom;
    private float zoomFactor=3f;
    private float zoomLerp = 10;

    void Start()
    {
        cam = Camera.main;
        targetZoom = cam.orthographicSize;
    }


    void Update()
    {
        float scrollData;
        scrollData = Input.GetAxis("Mouse ScrollWheel");
        targetZoom -= scrollData * zoomFactor;
        targetZoom = Mathf.Clamp(targetZoom, 1f, 3f);
        cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, targetZoom, Time.deltaTime * zoomLerp);
    }

}

