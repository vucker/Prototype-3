using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private void Awake()
    {
        playerRb = GetComponent<Rigidbody>();
    }
    private void Start()
    {
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
            playerRb.AddForce(Vector3.up * 10, ForceMode.Impulse);

    }
}
