using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.Design.Serialization;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class charactermovementV2 : MonoBehaviour

{// Alive is the status that our character will have allowing us to kill him and restart the game
    bool alive = true;
    // the basic starting speed that our chracter s
    public float speed = 10;
    [SerializeField] Rigidbody rb;

    float horizontalInput;
   
    [SerializeField] LayerMask groundMask;
    // speed increases based on the amont of time survived
    public float speedIncreasePerPoint = 0.1f;

    [SerializeField] float jumpForce = 400f;

    private void FixedUpdate()
    {
        if (!alive) return;
        // multiply the speed by elapsed time allowing a speed increase as you survive longer
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        // horizontal move speed increases the longer you hold it
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
    }

    // Update is called once per frame
    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();

        }

        // if the character drops below -5 Y he dies and the game will restart
        if (transform.position.y < -5)
        {
            Die();
        }
    }

    public void Die()
    {
        alive = false;
        // restarts the game upon death
        Invoke ("Restart", 2);
    }

    void Restart()
    {
        //reloaded the game scene, functioning as restart
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    void Jump()
    {
        //runs check to make sure character is on the ground
        //collider checks if he is colliding on the y axis and decides if character is on ground based on that
        float height = GetComponent<Collider>().bounds.size.y;
         bool isGrounded = Physics.Raycast(transform.position, Vector3.down, (height / 2) + 0.1f, groundMask);

        // If we are, allow the character to jump
        rb.AddForce(Vector3.up * jumpForce);
    }
}
