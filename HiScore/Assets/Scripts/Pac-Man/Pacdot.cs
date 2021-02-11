using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacdot : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D co)
    {
        print(co.name);
        if (co.name == "Hero")
        {
        	Score.scoreValue += 10;
            print("lol");
            gameObject.SetActive(false);
        }
       

    }
}
