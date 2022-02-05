using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour
{
    const float MAX_Y = 350;
    const float MIN_Y = -350;
    const float MAX_X = 700;
    const float MIN_X = -700;
    float scaleOfFuel = 36.87821f;



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
            float dx;
            float dy;
            do{
            dx = Random.Range(-100f,100f);
            dy = Random.Range(-100f,100f);
        }while(!(MIN_X < (other.transform.position.x + dx) && (other.transform.position.x + dx) < MAX_X && MIN_Y < (other.transform.position.y + dy) && (other.transform.position.y + dy) < MAX_Y));
            other.transform.Translate(dx,dy,0);
            scaleOfFuel *= 0.9f;
            other.transform.localScale = new Vector3(scaleOfFuel,scaleOfFuel,scaleOfFuel);

        }
    }
    // private void OnTriggerStay2D(Collider2D other) {
    //     if(other.tag == "Fuel"){
    //     Driver.fuel+= 0.1f;
    //     Debug.Log(Driver.fuel);}
    // }
}
