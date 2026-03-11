using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce;
    public float gravityModifier;
    public bool isGrounded = true;
    private Rigidbody playerRb;
    private void Awake()
    {
        playerRb = GetComponent<Rigidbody>();
    }
    private void Start()
    {
        Physics.gravity *= gravityModifier;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;

        }

    }
    private void OnCollisionEnter(Collision collision) => isGrounded = true;
}
