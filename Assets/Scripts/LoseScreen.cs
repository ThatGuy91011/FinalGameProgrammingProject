using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LoseScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //The screen starts off invisible
        GetComponent<CanvasScaler>().scaleFactor = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //If the player runs out of lives...
        if (GameObject.Find("PlayerBackground").GetComponent<BallMissed>().Lives == 0)
        {
            //They lose the level
            Destroy(GameObject.Find("Music"));
            Destroy(GameObject.Find("Shooter"));
            GetComponent<CanvasScaler>().scaleFactor = 1;
        }
    }
}
