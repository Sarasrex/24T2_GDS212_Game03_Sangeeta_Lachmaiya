using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 5000f;

    public GameObject leftButton;
    public GameObject rightButton;

    void Update()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetMouseButtonDown(0))
        {
            // Left button
            MoveLeft();
        }

        if (Input.GetMouseButtonDown(0))
        {
            // Right button
            MoveRight();
        }
    }

   public void MoveLeft()
    {
        //Debug.Log("MovingLeft");
        rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
    }

    public void MoveRight()
    {
        rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
    }
}




    //private void FixedUpdate()
    //{
    //    // Below from Chat gpt with slight mods to fit my current script
    //    for (int i = 0; i < Input.touchCount; i++)
    //    {
    //        Touch touch = Input.GetTouch(i);

    //        // Check if the touch is within the left button bounds
    //        if (RectTransformUtility.RectangleContainsScreenPoint(leftButton, touch.position))
    //        {
    //            // Move the object to the left

    //            transform.Translate(Vector3.left * sidewaysForce * Time.deltaTime);
                
    //        }

    //        // Check if the touch is within the right button bounds
    //        else if (RectTransformUtility.RectangleContainsScreenPoint(rightButton, touch.position))
    //        {
    //            // Move the object to the right
    //            transform.Translate(Vector3.right * sidewaysForce * Time.deltaTime);
    //        }

    //    }

    //}

