using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour
{
    //Stores the current scene number
    public int Scene;

    public void StartGame()
    {
        //The game gives the player a random song every time they hit play
        Scene = Random.Range(1, 4);

        SceneManager.LoadScene(Scene);

    }

    public void Credits()
    {
        //Shows the credits for all the assets and such
        GameObject.Find("Credits").GetComponent<Canvas>().sortingOrder = 0;
        GameObject.Find("MainMenu").GetComponent<Canvas>().sortingOrder = -1;

    }
    public void ExitGame()
    {
        //Closes the game
        Application.Quit();
    }

    public void MainMenu()
    {
        //Pulls up the main menu
        SceneManager.LoadScene(0);
    }

    public void CreditsToMenu()
    {
        //Special case to go rom the credits page to the main menu
        GameObject.Find("Credits").GetComponent<Canvas>().sortingOrder = -1;
        GameObject.Find("MainMenu").GetComponent<Canvas>().sortingOrder = 0;
    }
}