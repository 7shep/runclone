using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    charactermovementV2 playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        playerMovement = GameObject.FindObjectOfType<charactermovementV2>();
    }

    private void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.name == "player")
        {
            //Kills the player
            playerMovement.Die();
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
