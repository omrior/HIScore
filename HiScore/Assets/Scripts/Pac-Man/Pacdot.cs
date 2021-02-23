using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacdot : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D co)
    {
    	ScoringScript.scoreValue += 10;
        //print(co.name);
        if (co.name == "Hero")
        {
            gameObject.SetActive(false);
        }
       

    }
}
