using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public static float moveSpeed = 5.0f;
    public float deadZone = -45;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if(transform.position.x < deadZone)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }

    [ContextMenu("Speed Up")]
    public static void SpeedUp(float speed)
    {
        moveSpeed += speed;
    }
}
