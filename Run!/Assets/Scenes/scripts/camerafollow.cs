using UnityEngine;

public class camerafollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    Vector3 offset;
   private void Start()
    {
        offset = transform.position - player.position;
    }

    // Update is called once per frame
    void Update()
    {
        // forces the camera behind the player at all times
        Vector3 targetPos = player.position + offset;
        
        transform.position = targetPos;
        
    }
}
