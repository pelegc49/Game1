using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour
{
    const float MAX_Y = 350;
    const float MIN_Y = -350;
    const float MAX_X = 700;
    const float MIN_X = -700;



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Fuel")
        {
            if(Driver.fuel + 25 < Driver.maxFuel){
            Driver.fuel += 25;
            }else{
                Driver.fuel = Driver.maxFuel;
            }
            Debug.Log("Refueled - " + Driver.fuel);
            
        }
    }
    // private void OnTriggerStay2D(Collider2D other) {
    //     if(other.tag == "Fuel"){
    //     Driver.fuel+= 0.1f;
    //     Debug.Log(Driver.fuel);}
    // }
}
