using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // bool jumpInput = (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W));  one way of doing movement command

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W))
        {
            Rigidbody2D playerRB = GetComponent<Rigidbody2D>();

            playerRB.AddForce(Vector2.up * 200f);
        }

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            Rigidbody2D playerRB = GetComponent<Rigidbody2D>();

            playerRB.AddForce(Vector2.right * 100f);


        }


        // Debug.Log(jumpInput);

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            Rigidbody2D playerRB = GetComponent<Rigidbody2D>();

            playerRB.AddForce(Vector2.left * 1f);


        }



    }
}