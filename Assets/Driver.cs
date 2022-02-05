using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    const float MAX_SPEED = 0.115f;
    const float MIN_TURN = -0.15f;
    const float MAX_TURN = -1 * MIN_TURN;
    static public float fuel = 50;

    static public float turnSpeed = 0.1f;
    static public float moveSpeed = 0.05f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    void Update()
    {


        transform.Rotate(0, 0, turnSpeed);
        transform.Translate(0, moveSpeed, 0);
        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKey(KeyCode.W)) && moveSpeed * 1.001f < MAX_SPEED && fuel > 0)
        {
            if (moveSpeed < 0.007f)
            {
                moveSpeed = 0.007f;
            }
            moveSpeed *= 1.001f;
            fuel -= 0.01f;

            //Debug.Log("increasing speed");
        }
        else if (Input.GetKeyDown(KeyCode.S) || Input.GetKey(KeyCode.S))
        {
            if (moveSpeed < 0.02f)
            {
                moveSpeed *= 0.992f;
            }
            else
            {
                moveSpeed *= 0.998f;
            }
            Debug.Log(fuel);
            //Debug.Log("Decreasing speed");
        }
        else { 
            if (moveSpeed<0.008){
                moveSpeed *= 0.994f;
            }
            else moveSpeed *= 0.9996f;
            }
        if (moveSpeed < 0.0005f) moveSpeed = 0;

        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            turnSpeed = 0;
        }
        else if ((Input.GetKeyDown(KeyCode.D) || Input.GetKey(KeyCode.D)) && turnSpeed >= MIN_TURN)
        {
            turnSpeed -= 0.01f;
        }
        else  if ((Input.GetKeyDown(KeyCode.A) || Input.GetKey(KeyCode.A)) && turnSpeed <= MAX_TURN)
        {
            turnSpeed += 0.01f;
        }
        else if (moveSpeed == 0) turnSpeed = 0;


        if (fuel < 0){
            fuel=0;
        }
    }
}

