using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody playerRB;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown("space"))
        {
            playerRB.velocity = new Vector3(0, 5, 0);

        }
        if (Input.GetKey("up"))
            playerRB.velocity = new Vector3(0, 0, 5);
        {

        }
        if (Input.GetKey("right"))
            playerRB.velocity = new Vector3(5, 0, 0);
        {

        }
        if (Input.GetKey("down"))
            playerRB.velocity = new Vector3(0, 0, -5);
        {

        }
        if (Input.GetKey("left"))
            playerRB.velocity = new Vector3(-5, 0, 0);
        {

        }
    }
}
