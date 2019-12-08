using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ShootingTest : MonoBehaviour
{
    public Transform tf;

    public Transform ShooterTF;

    public float speed;

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
        if (HitCheck == 1)
        {
            tf.position -= tf.right * speed;
        }
        else if (HitCheck == 2)
        {
            tf.position += tf.right * speed;
        }
        else
        {
            tf.position -= tf.up * speed;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "RightWall")
        {
            HitCheck = 1;
        }
        else if (other.gameObject.tag == "LeftWall")
        {
            HitCheck = 2;
        }
    }
}
