using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    const float MAX_SPEED = 0.15f;

    float turnSpeed = 0.1f;
    float moveSpeed = 0.05f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    void Update()
    {
        transform.Rotate(0, 0, turnSpeed);
        transform.Translate(0, moveSpeed, 0);
        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKey(KeyCode.W)) && moveSpeed * 1.1f < MAX_SPEED)
        {
            moveSpeed *= 1.001f;
            Debug.Log("increasing speed");
        }
        else if (Input.GetKeyDown(KeyCode.S) || Input.GetKey(KeyCode.S))
        {
            moveSpeed *= 0.999f;
            Debug.Log("Decreasing speed");
        }
        Debug.Log(moveSpeed);
    }
}

