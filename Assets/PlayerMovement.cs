using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // bool jumpInput = (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W));  one way of doing movement command

    // Update is called once per frame

    Rigidbody2D _playerRB;
    bool isJumpInput = false;

    void Start()
    {
        _playerRB = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W))
        {
            isJumpInput = true;

        }
    }

    void FixedUpdate()
    {
        
        {
        
            if (isJumpInput)
            {
                _playerRB.AddForce(Vector2.up * 200f);
                isJumpInput=false;
            }
;
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {

            _playerRB.AddForce(Vector2.right * 300f * Time.deltaTime);

        }

        // Debug.Log(jumpInput); if there is no down on getkey then you don thave to tap it to move it will auto move when the key is held

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {

            _playerRB.AddForce(Vector2.left * 300f * Time.deltaTime);

        }


    }




}