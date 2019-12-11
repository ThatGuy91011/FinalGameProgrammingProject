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
        //Lines 20-31 make sure that the player can't go any more right/left than the white walls around it
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

        //Makes the player move one spot left 
        if (Input.GetKeyDown((KeyCode.LeftArrow)))
        {
            //Makes sure the platform isn't to the far left already
            if (Position != 1)
            {
                tf.position += new Vector3(-3, 0, 0);
            }
            else
            {
                tf.position += new Vector3(0, 0, 0);
            }
        }

        //Makes the player move one spot right
        if (Input.GetKeyDown((KeyCode.RightArrow)))
        {
            //Makes sure the platform isn't to the far right already
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
