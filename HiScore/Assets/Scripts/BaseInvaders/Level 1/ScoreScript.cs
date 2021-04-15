using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{
    Text score;
    public int minScore = 500;
    public string nextLevel;

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
        if(ZombieScript.score >= minScore) {
            SceneManager.LoadScene(sceneName: nextLevel);
        }
    }
}
