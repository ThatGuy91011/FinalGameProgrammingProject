using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallMissed : MonoBehaviour
{
    //Number of lives can be changed by a designer
    public int Lives = 3;
    void OnTriggerEnter2D(Collider2D other)
    {
        //If the ball goes out of bounds on the bottom
        if (other.gameObject.tag == "Ball")
        {
            //The player loses a life
            Lives -= 1;
            //Destroy the ball
            Destroy(other.gameObject);
        }
    }
}
