using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundtile : MonoBehaviour
{

    groundspawner groundspawner;

    // Start is called before the first frame update
    void Start()
    {
        groundspawner = GameObject.FindObjectOfType<groundspawner>();
    }

    private void OnTriggerExit(Collider other)
    {
        groundspawner.spawnTile();
        Destroy(gameObject, 2);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
