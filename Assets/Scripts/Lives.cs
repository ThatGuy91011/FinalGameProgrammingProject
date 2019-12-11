using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    public int TotLives;
    // Update is called once per frame
    void Update()
    {
        //Always update the number of lives the player has
        TotLives = GameObject.Find("PlayerBackground").GetComponent<BallMissed>().Lives;

        GetComponent<Text>().text = "Lives: " + TotLives;
    }
}
