using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript2 : MonoBehaviour
{
    Text score;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + ZombieScript2.score;
        print(ZombieScript2.score);
        if(ZombieScript2.score >= 1500) {
            SceneManager.LoadScene(sceneName: "InvadersLIII");
        }
    }
}
