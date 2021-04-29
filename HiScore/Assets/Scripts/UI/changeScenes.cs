using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScenes : MonoBehaviour
{
	public static string sceneName = "";

    // Start is called before the first frame update
    public void change(string NextScene)
    {
        SceneManager.LoadScene(NextScene);
    }

    //previous scene
    public void retryLevel()
    {
       	//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        int previousLevel = PlayerPrefs.GetInt("previousLevel");
        //Application.LoadLevel(previousLevel);
        SceneManager.LoadScene(previousLevel);
    }

    //exit
    public void exit() 
    {
     Application.Quit();
    }
}
