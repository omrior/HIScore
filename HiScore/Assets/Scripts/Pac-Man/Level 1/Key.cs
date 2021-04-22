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
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name == "pacman1");
                SceneManager.LoadScene(sceneName: "pacman2");
            if (scene.name == "pacman2") ;
                SceneManager.LoadScene(sceneName: "pacman3");
            if (scene.name == "pacman3") ;
                SceneManager.LoadScene(sceneName: "InvadersLI");
        }
    }
}
