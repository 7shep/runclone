using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This is the script for spawning the tiles, the only thing that is used is the spawnTile function. This will be used in other scripts (groundtile.cs)

public class groundspawner : MonoBehaviour
{

    public GameObject Ground;
    Vector3 NextSpawn;


    public void spawnTile()
    {
        //Function is "temp" allowing me to manipulate and reference it.
        GameObject temp = Instantiate(Ground, NextSpawn, Quaternion.identity);


        //Updates the position for the next ground tile to be spawned.
        NextSpawn = temp.transform.GetChild(1).transform.position;   

    }

    // Start is called before the first frame update
    void Start()
    {
        //Constantly spawns tiles.
        while (true)
        {
            spawnTile();
        }

    }


}
