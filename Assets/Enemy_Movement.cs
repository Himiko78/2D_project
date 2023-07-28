using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// To do next time
// Functions
// Collisions
// Shooting
public class Enemy_Movement : MonoBehaviour
{

    public float speed;
    public bool isMovingRight = true;
    void Start()
    {

    }

    // Staring Point
    // Vector
    // Behaviour
    // Moving Right
    void Update()
    {
       

        if(isMovingRight)
        {
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
        }
        else
        {
            transform.position -= new Vector3(speed, 0, 0) * Time.deltaTime;
        }

        if (transform.position.x >= 3)
        {
            isMovingRight = false;
        }
        if (transform.position.x <= -3)
        {
            isMovingRight = true;
        }
    }
    //
    //if ( x == y)
    //{
    // if true, run code in here
    //}

    //Comparison Operators
    // x == y -> is x equal to y
    // x !=y  -> is x not equal to y
    // x > y  -> is x greater than y
    // x < y  -> is x less than y
    // x <= y -> is x less than or equal to y
    // x >= y -> is x greater than or equal to y
}
