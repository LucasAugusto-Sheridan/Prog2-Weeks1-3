using UnityEngine;

public class Mover : MonoBehaviour
{

    public Camera gameCamera;

    float speed = 0.01f;
    float xMax = 9;
    float xMin = -9;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moverXPos = transform.position;
        moverXPos.x = moverXPos.x + speed;
        transform.position = moverXPos;

        Vector3 screenTransformPosition = gameCamera.WorldToScreenPoint(transform.position);
        xMax = Screen.width;
        xMin = 0;

        if (xMax > screenTransformPosition.x) {
            speed *= -1;
        }
        if (xMin < screenTransformPosition.x) {
            speed *= -1;
        }


    }
}
