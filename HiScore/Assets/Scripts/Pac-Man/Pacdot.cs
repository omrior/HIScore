using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pacdot : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D co)
    {
        print(co.name);
        if (co.name == "Hero")
        {
            print("lol");
            gameObject.SetActive(false);
        }
       

    }
}
