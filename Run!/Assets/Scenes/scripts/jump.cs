using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{ //gets the rigidbody component and binds it to our character
    public float jumpForce = 5;
    public float groundDistance = 0.5f;
    Rigidbody rigidbody;
    // Start is called before the first frame update
    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, groundDistance);

    }
    // Update is called once per frame
    void Update()
    {
     // when pressing the mouse, if you are on the ground you will jump
        if(Input.GetMouseButtonDown(0) && IsGrounded())
        {
            rigidbody.velocity = Vector3.up * jumpForce;
        }
    }
}
