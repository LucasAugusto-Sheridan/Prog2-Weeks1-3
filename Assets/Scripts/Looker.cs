using Microsoft.Win32.SafeHandles;
using UnityEngine;
using UnityEngine.InputSystem;

public class Looker : MonoBehaviour
{
    public float rotationSpeed;
    public float zMax, zMin;
    public Camera gameCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rotating in a direction (swapping)

        ////if we wanted to move the object, use transform.position
        //Vector3 currentRotation = transform.eulerAngles;
        //currentRotation.z += rotationSpeed * Time.deltaTime;

        //transform.eulerAngles = currentRotation;

        //Debug.Log(transform.eulerAngles);

        //if (transform.eulerAngles.z > zMax)
        //{
        //    rotationSpeed *= -1;
        //}
        //if (transform.eulerAngles.z < zMin)
        //{
        //    rotationSpeed *= -1;
        //}

        Vector3 currentMousePosition = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(currentMousePosition);
        worldMousePosition.z = 0;

        //setting the direction we're looking in
        //end - start : to get direction
        transform.up = worldMousePosition;

    }
}
