﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pacdot : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D co)
    {
        
        if (co.name == "player_0")
        {
            gameObject.SetActive(false);
        }
       

    }
}
