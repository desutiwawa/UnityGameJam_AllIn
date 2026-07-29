using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public static SpawnManager Instance;

    public Transform[] spawnPoints;

    public GameObject[] objectPrefabs;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Awake()
    {
        Instance = this;
    }

    public void RandSpawn()
    {
        int pointIndex = Random.Range(0, spawnPoints.Length);

        int objectIndex = Random.Range(0, objectPrefabs.Length);

        Instantiate(objectPrefabs[objectIndex],
             spawnPoints[pointIndex].position, Quaternion.identity);


    }








}
