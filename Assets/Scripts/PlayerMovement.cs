using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //* Assigning Forces

    public float forwardForce = 2000f;
    public float sideForce = 500f;

    public Rigidbody rb;


    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        //! Applying Side Forces

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime , 0 , 0);
        }
        else if (Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime , 0 , 0);
        }
    }
}
