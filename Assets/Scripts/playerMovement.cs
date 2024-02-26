using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;


    private RectTransform leftButton;
    private RectTransform rightButton;



    void Update()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }

    }


    private void FixedUpdate()
    {
        // Below from Chat gpt with slight mods to fit my current script
        for (int i = 0; i < Input.touchCount; i++)
        {
            Touch touch = Input.GetTouch(i);

            // Check if the touch is within the left button bounds
            if (RectTransformUtility.RectangleContainsScreenPoint(leftButton, touch.position))
            {
                // Move the object to the left
                transform.Translate(Vector3.left * sidewaysForce * Time.deltaTime);
            }

            // Check if the touch is within the right button bounds
            else if (RectTransformUtility.RectangleContainsScreenPoint(rightButton, touch.position))
            {
                // Move the object to the right
                transform.Translate(Vector3.right * sidewaysForce * Time.deltaTime);
            }

        }

    }
}
