using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{

    public GameObject pipe;
    public static float globalSpawnCooldown = 10.0f;
    private float timer = 0;
    public float heightOffset = 9.5f;
    private int spawnCount = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < globalSpawnCooldown) 
        {
            timer += Time.deltaTime;
        } 
        else 
        {
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe() 
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
        spawnCount = spawnCount + 1;
    }
}
