using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class charactermovementV2 : MonoBehaviour

{// setting the speed that our character moves 
    bool alive = true;
    public float speed = 10;
    [serializeField] Rigidbody rb;
    float horizontalInput;
    [Serializefield]
     private void FixedUpdate()
    {
        // multiplt the speed by elapsed time allowing a speed increase as you survive longer
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
