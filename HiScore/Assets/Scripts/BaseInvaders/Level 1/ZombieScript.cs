using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Controls the Zombie Enemy for the Space Invaders level
 */ 
public class ZombieScript : MonoBehaviour
{

    public Rigidbody2D zombie;  //Reference to itself
    public float speed = 15.0f; //Movement speed
    public int hp = 1;          //Zombie health
    public int damage = 1;      //Damage the zombie does to the base

    // Start is called before the first frame update
    void Start()
    {
        zombie = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveZombie();
    }
    
    public void moveZombie()
    {
        zombie.velocity = new Vector2 (-1, 0) * speed;
    }

    //If a zombie is hit by a laser, the zombie loses hp. 
    //If the zombie's hp reaches 0, destroy it
    void OnTriggerEnter2D(Collider2D isLaser)
    {
        if(isLaser.gameObject.name == "LaserBeam(Clone)") 
        {
            //Damage zombie, destroy is hp = 0
            hp -= 1;
            if (hp <= 0) {
                Destroy(gameObject);
                ScoreScript.score_val += 10;
            }
            //Destroy the laser shot
            Destroy(isLaser.gameObject);

            Debug.Log("GotShot");
        }
    }
    
}
