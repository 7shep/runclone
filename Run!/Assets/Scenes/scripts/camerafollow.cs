using UnityEngine;

public class camerafollow : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public float distanceFromPlayer = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // forces the camera behind the player at all times
        transform.position = player.transform.position - player.transform.forward *distanceFromPlayer;
        transform.LookAt(player.transform.position);
    }
}
