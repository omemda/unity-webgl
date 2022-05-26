using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// A C# script for camera rotation on mouse drag. The rotation is limited by clamping the rotation angle.
// The script was modified to work differently depending on required interactivity.
public class CameraRotation : MonoBehaviour
{
    [SerializeField] private float _mouseSensitivity = 1.0f;

    private float _rotationY;
    private float _rotationX;

    // A focus point for camera rotation
    [SerializeField] private Transform _target;

    [SerializeField] private float _distanceFromTarget = 3.0f;

    private Vector3 _currentRotation;
    private Vector3 _smoothVelocity = Vector3.zero;

    [SerializeField] private float _smoothTime = 0.2f;

    [SerializeField] private Vector2 _rotationXMinMax = new Vector2(-10, 10);

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            float mouseX = Input.GetAxis("Mouse X") * _mouseSensitivity;
            float mouseY = Input.GetAxis("Mouse Y") * _mouseSensitivity;

            _rotationY += mouseX;
            _rotationX -= mouseY;

            // Apply clamping for x rotation 
            _rotationX = Mathf.Clamp(_rotationX, _rotationXMinMax.x, _rotationXMinMax.y);
            _rotationY = Mathf.Clamp(_rotationY, _rotationXMinMax.x, _rotationXMinMax.y);

            Vector3 nextRotation = new Vector3(_rotationX, _rotationY);

            // Apply damping between rotation changes
            _currentRotation = Vector3.SmoothDamp(_currentRotation, nextRotation, ref _smoothVelocity, _smoothTime);
            transform.localEulerAngles = _currentRotation;

            // Substract forward vector of the GameObject to point its forward vector to the target
            transform.position = _target.position - transform.forward * _distanceFromTarget - new Vector3(1,0,0);
        }
        
    }
}