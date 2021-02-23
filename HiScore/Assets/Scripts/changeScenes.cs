using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class changeScenes : MonoBehaviour
{
    // Start is called before the first frame update
    public void change(string NextScene)
    {
        SceneManager.LoadScene(NextScene);
    }

    public void exit() 
    {
     Application.Quit();
    }
}
