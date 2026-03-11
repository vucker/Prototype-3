using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstacleObject;
    public float startDelay;
    public float intervalDelay;
    private Vector3 spawnPosition = new Vector3(20,0,0);
    private PlayerController playerControllerScript;
    private void Awake()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();   
    }
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, intervalDelay);
    }
    private void SpawnObstacle()
    {
        if (playerControllerScript.isGameOver == false)
        {
            Instantiate(obstacleObject, spawnPosition, Quaternion.identity);
        }
    }
}
