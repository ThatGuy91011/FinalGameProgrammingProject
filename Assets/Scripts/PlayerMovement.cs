using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Transform tf;

    private int Position;
    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (tf.position.x == -23)
        {
            Position = 1;
        }
        else if (tf.position.x == -20)
        {
            Position = 2;
        }
        else if (tf.position.x == -17)
        {
            Position = 3;
        }

        if (Input.GetKeyDown((KeyCode.LeftArrow)))
        {
            if (Position != 1)
            {
                tf.position += new Vector3(-3, 0, 0);
            }
            else
            {
                tf.position += new Vector3(0, 0, 0);
            }
        }

        if (Input.GetKeyDown((KeyCode.RightArrow)))
        {
            if (Position != 3)
            {
                tf.position += new Vector3(3, 0, 0);
            }
            else
            {
                tf.position += new Vector3(0, 0, 0);
            }
        }
    }
}
