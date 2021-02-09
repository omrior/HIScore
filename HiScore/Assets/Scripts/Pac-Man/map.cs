using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map : MonoBehaviour
{
    public GameObject[] gameObjects;
    
    void Awake()
    {
       gameObjects = GameObject.FindGameObjectsWithTag("pacdot");
    }
    
    // Update is called once per frame
    void Update()
    {
        activateObjects();
    }

    public void activateObjects()
    {

        bool allInActive = true;

        foreach (GameObject go in gameObjects)
        {
            if (go.activeInHierarchy)
            {
                allInActive = false;
                break;
            }
        }
        
        if (allInActive)
        {
            foreach (GameObject go in gameObjects)
            {
                go.SetActive(true);
            }
        }
        
    }
}
