using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour
{

    // void OnTriggerEnter2D(Collider2D other)
    // {
    //     if (other.tag == "obj")
    //     {

    //         Driver.fuel = 50;
    //         Debug.Log("touched an objective");
    //     }
    // }
    private void OnTriggerStay2D(Collider2D other) {
        if(other.tag == "Fuel"){
        Driver.fuel+= 0.1f;
        Debug.Log(Driver.fuel);}
    }
}
