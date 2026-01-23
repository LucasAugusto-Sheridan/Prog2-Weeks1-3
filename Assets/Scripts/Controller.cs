using NUnit.Framework;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;

public class Controller : MonoBehaviour
{

    public float moveSpeed;
    public float rotateSpeed;

    public SpriteRenderer spriteRenderer;
    public Color startingColour;

    public List<SpriteRenderer> controllableRenderers;
    public List<Transform> controllableTransforms;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //spriteRenderer.color = startingColour;

        bool isInsideSprite = spriteRenderer.bounds.Contains(transform.position);

        controllableTransforms.Add(transform);

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 currentMousePosition = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(currentMousePosition);
        worldMousePosition.z = 0;

        bool isLeftMousePressed = Mouse.current.leftButton.wasPressedThisFrame;
        if (isLeftMousePressed)
        {
            //find renderers currently hovered over

            for (int i = 0; i < controllableRenderers.Count; i++)
            {

                SpriteRenderer currentSpriteRenderer = controllableRenderers[i];

                bool isHovered = currentSpriteRenderer.bounds.Contains(worldMousePosition);
                if (isHovered)
                {
                    controllableTransforms.Add(currentSpriteRenderer.transform);
                }
            }
        }

        for (int i = 0; i <controllableTransforms.Count; i++)
        {
            Transform currentTransforms = controllableTransforms[i];
            bool leftKeyHeld = Keyboard.current.leftArrowKey.isPressed;
            if (leftKeyHeld)
            {
                currentTransforms.eulerAngles += currentTransforms.forward * rotateSpeed * Time.deltaTime;
            }

            bool rightKeyHeld = Keyboard.current.rightArrowKey.isPressed;
            if (rightKeyHeld)
            {
                currentTransforms.eulerAngles -= currentTransforms.forward * rotateSpeed * Time.deltaTime;
            }

            bool upKeyHeld = Keyboard.current.upArrowKey.isPressed;
            if (upKeyHeld)
            {
                currentTransforms.position += currentTransforms.up * moveSpeed * Time.deltaTime;
            }

            bool downKeyHeld = Keyboard.current.downArrowKey.isPressed;
            if (downKeyHeld)
            {
                currentTransforms.position -= currentTransforms.up * moveSpeed * Time.deltaTime;
            }
        }


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


        //bool leftKeyHeld = Keyboard.current.leftArrowKey.isPressed;
        //if (leftKeyHeld)
        //{
        //    transform.eulerAngles += transform.forward * rotateSpeed * Time.deltaTime;
        //}

        //bool rightKeyHeld = Keyboard.current.rightArrowKey.isPressed;
        //if (rightKeyHeld)
        //{
        //    transform.eulerAngles -= transform.forward * rotateSpeed * Time.deltaTime;
        //}

        //bool upKeyHeld = Keyboard.current.upArrowKey.isPressed;
        //if (upKeyHeld)
        //{
        //    transform.position += transform.up * moveSpeed * Time.deltaTime;
        //}

        //bool downKeyHeld = Keyboard.current.downArrowKey.isPressed;
        //if (downKeyHeld)
        //{
        //    transform.position -= transform.up * moveSpeed * Time.deltaTime;
        //}

    }
}
