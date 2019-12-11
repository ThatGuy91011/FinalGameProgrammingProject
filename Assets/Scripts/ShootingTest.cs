using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ShootingTest : MonoBehaviour
{
    public Transform tf;

    public Transform ShooterTF;

    //Public variable for the designer to change
    public float speed;

    //Checks if the ball has hit anything
    private int HitCheck = 0;


    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
        ShooterTF = GameObject.Find("Shooter").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //If it hits the right wall...
        if (HitCheck == 1)
        {
            //Bounce off
            tf.position -= tf.right * speed;
        }
        //If it hits the left wall...
        else if (HitCheck == 2)
        {
            //Bounce off
            tf.position += tf.right * speed;
        }
        //If it hits the platform...
        else if (HitCheck == 3)
        {
            //Bounce upwards
            tf.rotation = new Quaternion(0, 0, 0, 0);
            tf.position += tf.up * speed;
        }
        //Otherwise...
        else
        {
            //Move in the direction shot
            tf.position -= tf.up * speed;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //Each number (1, 2, 3) determines what exactly the ball has hit in order for the physics to work above
        if (other.gameObject.tag == "RightWall")
        {
            HitCheck = 1;
        }
        else if (other.gameObject.tag == "LeftWall")
        {
            HitCheck = 2;
        }
        else if (other.gameObject.tag == "Player")
        {
            //Plays a sound of the ball bouncing off the platform
            GetComponent<AudioSource>().Play();
            HitCheck = 3;
        }
    }
}
