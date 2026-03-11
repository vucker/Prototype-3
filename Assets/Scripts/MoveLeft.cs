using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveLeft : MonoBehaviour
{
    public float speed = 2f;
    private PlayerController playerControllerScript;
    private void Awake()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    private void Update()
    {
        if (playerControllerScript.isGameOver == false) 
        { 
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }
}
