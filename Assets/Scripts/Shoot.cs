using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shoot : MonoBehaviour
{
    private Transform tf;
    public GameObject pf;
    public int lengthOfTime;

    //Stores the current scene number to choose the song to be played
    public int SceneNumber;

    //Stores the value of 1 or 0 in order to tell if the song is over
    public int End = 0;
    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
        pf = GameObject.Find("Ball");
        //Makes it possible to wait a few seconds
        StartCoroutine(Example());
        //Gets the scene number from the UIManager
        SceneNumber = GameObject.Find("Lives").GetComponent<UIManager>().Scene;
    }

    IEnumerator Example()
    {
        //Bob-Omb Battlefield
        if ( SceneNumber == 1)
        {
            //Each block of three lines is one bullet shot at a certain time
            yield return new WaitForSecondsRealtime(4);
            tf.Rotate(new Vector3(0, 0, 40)); //right
            Shooting();

            yield return new WaitForSecondsRealtime(2.7f);
            tf.Rotate(new Vector3(0, 0, -80)); //left
            Shooting();

            yield return new WaitForSecondsRealtime(2.1f);
            tf.Rotate(new Vector3(0, 0, 40));//middle
            Shooting();

            yield return new WaitForSecondsRealtime(1.2f); 
            //middle
            Shooting();

            yield return new WaitForSecondsRealtime(0.7f);
            //middle
            Shooting();

            yield return new WaitForSecondsRealtime(2.3f);
            tf.Rotate(new Vector3(0, 0, 40)); //right
            Shooting();

            yield return new WaitForSecondsRealtime(2.2f);
            tf.Rotate(new Vector3(0, 0, -80)); //left
            Shooting();

            yield return new WaitForSecondsRealtime(2.1f);
            tf.Rotate(new Vector3(0, 0, 40)); //middle
            Shooting();

            yield return new WaitForSecondsRealtime(1.1f);
            //middle
            Shooting();

            yield return new WaitForSecondsRealtime(0.6f);
            tf.Rotate(new Vector3(0, 0, -40)); //left
            Shooting();

            yield return new WaitForSecondsRealtime(5);
        }

        //Gourmet Race
        else if (SceneNumber == 2)
        {
            yield return new WaitForSecondsRealtime(3);
            //middle
            Shooting();

            yield return new WaitForSecondsRealtime(1.2f);
            //middle
            Shooting();

            yield return new WaitForSecondsRealtime(1.3f);
            tf.Rotate(new Vector3(0, 0, 40));//right
            Shooting();

            yield return new WaitForSecondsRealtime(1.2f);
            tf.Rotate(new Vector3(0, 0, -80));//left
            Shooting();

            yield return new WaitForSecondsRealtime(1.3f);
            tf.Rotate(new Vector3(0, 0, 40));//middle
            Shooting();

            yield return new WaitForSecondsRealtime(1.3f);
            //middle
            Shooting();

            yield return new WaitForSecondsRealtime(1.4f);
            tf.Rotate(new Vector3(0, 0, -40));//left
            Shooting();

            yield return new WaitForSecondsRealtime(1.2f);
            tf.Rotate(new Vector3(0, 0, 80));//right
            Shooting();

            yield return new WaitForSecondsRealtime(1.1f);
            tf.Rotate(new Vector3(0, 0, -40));//middle
            Shooting();

            yield return new WaitForSecondsRealtime(1.4f);
            //middle
            Shooting();

            yield return new WaitForSecondsRealtime(1.3f);
            tf.Rotate(new Vector3(0, 0, 40));//right
            Shooting();

            yield return new WaitForSecondsRealtime(1.3f);
            tf.Rotate(new Vector3(0, 0, -80));//left
            Shooting();

            yield return new WaitForSecondsRealtime(1.3f);
            tf.Rotate(new Vector3(0, 0, 40));//middle
            Shooting();

            yield return new WaitForSecondsRealtime(1.3f);
            //middle
            Shooting();

            yield return new WaitForSecondsRealtime(1.3f);
            tf.Rotate(new Vector3(0, 0, 40));//right
            Shooting();

            yield return new WaitForSecondsRealtime(1.3f);
            tf.Rotate(new Vector3(0, 0, -40));//middle
            Shooting();

            yield return new WaitForSecondsRealtime(2f);
        }

        //Your Best Friend
        else if (SceneNumber == 3)
        {
            yield return new WaitForSecondsRealtime(.2f);
            tf.Rotate(new Vector3(0, 0, 40));//right
            Shooting();

            yield return new WaitForSecondsRealtime(2f);
            tf.Rotate(new Vector3(0, 0, -80));//left
            Shooting();

            yield return new WaitForSecondsRealtime(2f);
            tf.Rotate(new Vector3(0, 0, 80));//right
            Shooting();

            yield return new WaitForSecondsRealtime(2f);
            tf.Rotate(new Vector3(0, 0, -80));//left
            Shooting();

            yield return new WaitForSecondsRealtime(2f);
            tf.Rotate(new Vector3(0, 0, 80));//right
            Shooting();

            yield return new WaitForSecondsRealtime(2f);
            tf.Rotate(new Vector3(0, 0, -80));//left
            Shooting();

            yield return new WaitForSecondsRealtime(2f);
            tf.Rotate(new Vector3(0, 0, 80));//right
            Shooting();

            yield return new WaitForSecondsRealtime(1.7f);
            tf.Rotate(new Vector3(0, 0, -40));//middle
            Shooting();

            yield return new WaitForSecondsRealtime(1.9f);
            tf.Rotate(new Vector3(0, 0, 40));//right
            Shooting();

            yield return new WaitForSecondsRealtime(2f);
            tf.Rotate(new Vector3(0, 0, -80));//left
            Shooting();

            yield return new WaitForSecondsRealtime(2f);
            tf.Rotate(new Vector3(0, 0, 80));//right
            Shooting();

            yield return new WaitForSecondsRealtime(1.8f);
            tf.Rotate(new Vector3(0, 0, -80));//left
            Shooting();

            yield return new WaitForSecondsRealtime(.5f);
            tf.Rotate(new Vector3(0, 0, 40));//middle
            Shooting();

            yield return new WaitForSecondsRealtime(2f);
        }

        //Says the song is over
        End = 1;
    }

    //This function makes it easy to shoot the bullet, needing only one line of code instead of these two over and over again.
    void Shooting()
    {
        //Shoot the bullet
        GameObject newObject = Instantiate(pf, tf.position, tf.rotation) as GameObject;
        Destroy(newObject, lengthOfTime);
    }
}
