using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{   //rotation
    public float moveSpeed = 10f;
    public float turnSpeed = 50f;

    Rigidbody rb;
    [SerializeField] float movementSpeed = 0.1f;
    //[SerializeField] float jumpForce = 1f;
    // public bool isJump = false;
    public bool runR = false;
    public bool runL = false;
    [SerializeField] private Animator playerAnimator;

    [SerializeField] AudioSource jumpSound;
    [SerializeField] AudioSource gameSound;
    [SerializeField] AudioSource destroyEnemySound;
       
    void Start()
    {       
        rb = GetComponent<Rigidbody>();
       // playerAnimator = GetComponent;
        gameSound.Play();
    }

    
    void Update()
    {  
        // Methode classique
       // if (Input.GetKeyDown("space"))
       // {
       //   rb.velocity = new Vector3(0,5f,0);
       //  }

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(horizontalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed);

        if (Input.GetButtonDown("Jump"))
        {            
            jump();
        }
        // Animations run
        if (horizontalInput > 0)
        {
            playerAnimator.SetTrigger("runL");
            runL = false;
        }
        if (horizontalInput < 0)
        {
          //  transform.rotation(0.0f, 90.0f, 0.0f);
            playerAnimator.SetTrigger("runR");
            runR = false;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        { 
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        { 
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }
    }

    void jump()
    {
           
        playerAnimator.SetTrigger("Jump"); 
        jumpSound.Play();
             
    }
}