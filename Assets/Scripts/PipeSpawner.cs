using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float maxYPos;
    public float spawnTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //StartSpawningPipes();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StopSpawningPipes()
    {
        CancelInvoke("SpawnPipe");
    }
    public void StartSpawningPipes()
    {
        InvokeRepeating("SpawnPipe",0.2f, spawnTime);
    }
    public void SpawnPipe()
    {
        Instantiate(pipe,new Vector3(transform.position.x, Random.Range(-maxYPos,maxYPos),0 ),Quaternion.identity);
    }
}
