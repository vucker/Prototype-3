using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstacleObject;
    private Vector3 spawnPosition = new Vector3(20,0,0);
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(obstacleObject, spawnPosition, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
