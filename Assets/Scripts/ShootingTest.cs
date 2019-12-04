using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingTest : MonoBehaviour
{
    public Transform tf;

    public Transform ShooterTF;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
        ShooterTF = GameObject.Find("Shooter").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        tf.position -= tf.up * speed;

    }
}
