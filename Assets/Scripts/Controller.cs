using UnityEngine;
using UnityEngine.InputSystem;

public class Controller : MonoBehaviour
{

    public float moveSpeed;
    public float rotateSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //bool leftIsHeld = Mouse.current.leftButton.isPressed;
        //if(leftIsHeld)
        //{
        //    Debug.Log("left mouse is held");
        //}
        //bool leftIsPressed = Mouse.current.leftButton.wasPressedThisFrame;
        //if (leftIsPressed)
        //{
        //    Debug.Log("left mouse was pressed");
        //}
        //bool leftIsReleased = Mouse.current.leftButton.wasReleasedThisFrame;
        //if (leftIsReleased)
        //{
        //    Debug.Log("left mouse was released");
        //}


        bool leftKeyHeld = Keyboard.current.leftArrowKey.isPressed;
        if (leftKeyHeld)
        {
            transform.eulerAngles += transform.forward * rotateSpeed * Time.deltaTime;
        }

        bool rightKeyHeld = Keyboard.current.rightArrowKey.isPressed;
        if (rightKeyHeld)
        {
            transform.eulerAngles -= transform.forward * rotateSpeed * Time.deltaTime;
        }

        bool upKeyHeld = Keyboard.current.upArrowKey.isPressed;
        if (upKeyHeld)
        {
            transform.position += transform.up * moveSpeed * Time.deltaTime;
        }

        bool downKeyHeld = Keyboard.current.downArrowKey.isPressed;
        if (downKeyHeld)
        {
            transform.position -= transform.up * moveSpeed * Time.deltaTime;
        }

    }
}
