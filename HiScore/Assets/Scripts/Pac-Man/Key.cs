using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Key : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D co)
    {
        
        if (co.name == "Hero")
        {
            SceneManager.LoadScene(sceneName: "InvadersLI");
        }
    }
}
