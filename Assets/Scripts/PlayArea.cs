using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayArea : MonoBehaviour
{
    void OnTriggerExit2D(Collider2D other)
    {
        //If the ball leaves the play area at any point, destroy it
        if (other.gameObject.tag == "Ball")
        {
            Destroy(other.gameObject);
        }
    }
}
