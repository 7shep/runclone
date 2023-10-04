using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundtile : MonoBehaviour
{

    groundspawner groundSpawner;

    // Start is called before the first frame update
    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<groundspawner>();
        
    }

    private void OnTriggerExit(Collider other)
    {
        groundSpawner.spawnTile();
        Destroy(gameObject, 2);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
