using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacdot : MonoBehaviour
{
    void onTriggerEnter2D(Collider2D co) {
    	if(co.name == "Hero") {
    		Destroy(gameObject);
    	}
    }
    
}
