using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    private Transform tf;
    public GameObject pf;
    public int lengthOfTime;
    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
        pf = GameObject.Find("Ball");
        StartCoroutine(Example());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Example()
    {
        yield return new WaitForSecondsRealtime(2);
        Shooting();

        yield return new WaitForSecondsRealtime(2);
        Shooting();

    }

    void Shooting()
    {
        //Shoot the bullet
        GameObject newObject = Instantiate(pf, tf.position, tf.rotation) as GameObject;
        Destroy(newObject, lengthOfTime);
    }
}
