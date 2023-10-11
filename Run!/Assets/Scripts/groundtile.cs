using UnityEngine;

public class GroundTile : MonoBehaviour
{

    GroundSpawner groundSpawner;

    private void Start()
    { 
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
        SpawnObstacle();
    }

    private void OnTriggerExit(Collider other)
    {
        groundSpawner.SpawnTile();
        Destroy(gameObject, 2);
    }

    private void Update ()
    {

    }

    public GameObject obstaclePrefab;

    void SpawnObstacle ()
    {
        //Choosing a random point on the plane
        int obstacleSpawnIndex = Random.Range(2, 5);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;

        //Spawning the obstacle
        Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);

    }
}


 