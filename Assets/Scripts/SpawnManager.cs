using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstacleObject;
    public float startDelay;
    public float intervalDelay;
    private Vector3 spawnPosition = new Vector3(20,0,0);
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, intervalDelay);
    }
    private void SpawnObstacle()
    {
        Instantiate(obstacleObject, spawnPosition, Quaternion.identity);
    }
}
