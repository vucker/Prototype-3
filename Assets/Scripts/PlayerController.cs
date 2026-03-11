using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce;
    public float gravityModifier;
    public ParticleSystem explosionParticle;
    public bool isGrounded = true;
    public bool isGameOver = false;
    private Rigidbody playerRb;
    private Animator playerAn;
    private void Awake()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAn = GetComponent<Animator>();
    }
    private void Start()
    {
        Physics.gravity *= gravityModifier;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded && !isGameOver)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
            playerAn.SetTrigger("Jump_trig");
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            isGameOver = true;
            Debug.Log("GameOver");
            playerAn.SetBool("Death_b", true);
            playerAn.SetInteger("DeathType_int", 1);
            explosionParticle.Play();
        }
    } 

}
