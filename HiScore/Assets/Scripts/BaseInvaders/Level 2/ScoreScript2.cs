using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript2 : MonoBehaviour
{
    public static int score_val = 0;
    Text score;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + score_val;
        print(score_val);
        if(score_val >= 200) {
            SceneManager.LoadScene(sceneName: "InvadersLIII");
        }
    }
}
