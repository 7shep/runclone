using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class charactermovementV2 : MonoBehaviour
{// setting the speed that our character moves
    public float speed = 10;
    public Rigidbody rb;
    float horizontalInput;
     private void FixedUpdate()
    {
        // the speed multiplied by time creates an increase in speed overtime
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        // horizontal move effectd
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime;
            rb.MovePosition(rb.position + forwardMove + horizontalMove);
    }

    // Update is called once per frame
    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
    }
}
