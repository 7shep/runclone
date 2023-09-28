using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController   : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 3;
    public float roationspeed = 90;
    public float gravity = -20;
    public float jumpspeed = 15;

    CharacterController characterController;
    Vector3 moveVelocity;
    Vector3 turnVelocity;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }


    // Update is called once per frame
    void Update()
    {
        var hInput = Input.GetAxis("Horizontal");
        var vinput = Input.GetAxis("Vertical");

        if(characterController.isGrounded)
        {
            moveVelocity = transform.forward * speed * vinput;
            turnVelocity = transform.up * roationspeed * hInput;
                if(Input.GetButtonDown("Jump"))
                {
                moveVelocity.y = jumpspeed;
            }
        }
        //Adding gravity
        moveVelocity.y += gravity * Time.deltaTime;
        characterController.Move(moveVelocity * Time.deltaTime);
        transform.Rotate(turnVelocity * Time.deltaTime);
    }
}
