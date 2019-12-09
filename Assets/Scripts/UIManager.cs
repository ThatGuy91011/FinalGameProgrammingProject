using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour
{
    //The different game states
    private GameObject startGame;

    private GameObject movingStart;

    private GameObject GameOver;

    private int Scene;

    public void StartGame()
    {
        Scene = Random.Range(1, 4);

        SceneManager.LoadScene(Scene);

    }

    public void ExitGame()
    {
        //Closes the game
        Application.Quit();
    }

}