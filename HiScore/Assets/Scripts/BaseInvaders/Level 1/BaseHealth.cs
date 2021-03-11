using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHealth : MonoBehaviour
{
    public int baseHP = 10;
    
    //If a zombie reaches the base, base loses hp
    //If base hp reaches 0, go to Game Over scene
    void OnTriggerEnter2D(Collider2D isZombie)
    {
        if(isZombie.gameObject.name == "Zombie(Clone)") 
        {
            Debug.Log("GotInvaded");
            //Damage base
            baseHP -= 1;
            if (baseHP <= 0) {
                //Go to game over scene
                Destroy(gameObject);    //Erase later, for testing purposes only
            }
            //Destroy the zombie
            Destroy(isZombie.gameObject);
        }
    }
}
