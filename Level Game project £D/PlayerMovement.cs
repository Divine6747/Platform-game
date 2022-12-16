using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody playerRB;
    [SerializeField] float movementSpeed = 5f;
    [SerializeField] float jumpForce = 5f;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float VerticalMovement = Input.GetAxis("Vertical");

        playerRB.velocity = new Vector3(horizontalMovement * movementSpeed, playerRB.velocity.y, VerticalMovement * movementSpeed);
     
       if (Input.GetButton("Jump"))
       {
            playerRB.velocity = new Vector3(playerRB.velocity.x, jumpForce, playerRB.velocity.z);
       } 

       /*
       if (Input.GetKeyDown("space"))   
        {
            playerRB.velocity = new Vector3(0, 3f, 0);

        }
        if (Input.GetKey("up"))
            playerRB.velocity = new Vector3(0, 0, 5f);
        {

        }
        if (Input.GetKey("right"))
            playerRB.velocity = new Vector3(5f, 0, 0);
        {

        }
        if (Input.GetKey("down"))
            playerRB.velocity = new Vector3(0, 0, -5f);
        {

        }
        if (Input.GetKey("left"))
            playerRB.velocity = new Vector3(-5f, 0, 0);
        {

        }
            */
        
    }
}