using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    //The different game states
    private GameObject startGame;

    private GameObject movingStart;

    private GameObject GameOver;

    public void StartGame()
    {
        //Finds the menu screen
        startGame = GameObject.Find("MainMenu");
        //Finds the player
        movingStart = GameObject.Find("Player");
        //Allows the player to move when the game "starts"
        //movingStart.GetComponent<PlayerMovement>().moveCheck = 1;

        
        startGame.GetComponent<CanvasScaler>().scaleFactor = 0;
        startGame.GetComponent<Image>().color = new Color(255, 255, 255, 0);
    }

    public void ExitGame()
    {
        //Closes the game
        Application.Quit();
    }

}