using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Randomizer : MonoBehaviour
{

    private int Scene;
    // Start is called before the first frame update
    void Start()
    {
        Scene = Random.Range(1, 2);

        SceneManager.LoadScene(Scene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
