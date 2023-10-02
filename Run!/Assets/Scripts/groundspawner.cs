using UnityEngine;

// This is the script for spawning the tiles, the only thing that is used is the spawnTile function. This will be used in other scripts (GroundTiletile.cs)

public class groundspawner : MonoBehaviour
{

    public GameObject groundTile;
    Vector3 nextSpawnPoint;


    public void spawnTile()
    {
        //Function is "temp" allowing me to manipulate and reference it.
        GameObject temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);


        //Updates the position for the next ground tile to be spawned.
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;   

    }

    // Start is called before the first frame update
    private void Start()
    {
        //Constantly spawns tiles.
        for (int i = 0; i < 10; i++)
        {

            spawnTile();

        }
    }

    }
