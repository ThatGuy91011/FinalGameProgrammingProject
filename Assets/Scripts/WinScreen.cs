using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScreen : MonoBehaviour
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
        //If the song ends without the player losing
        if (GameObject.Find("Shooter").GetComponent<Shoot>().End == 1)
        {
            //The player wins
            GetComponent<CanvasScaler>().scaleFactor = 1;
        }
    }
}
