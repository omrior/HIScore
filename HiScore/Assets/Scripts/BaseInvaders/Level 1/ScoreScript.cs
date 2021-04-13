﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
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
        score.text = "Score: " + ZombieScript.score;
        print(ZombieScript.score);
        if(ZombieScript.score >= 1000) {
            SceneManager.LoadScene(sceneName: "InvadersLII");
        }
    }
}
