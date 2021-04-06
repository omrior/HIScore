using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    //Player speed - public
    public Vector2 speed = new Vector2(50, 50);
    
    //Store movement and component
    private Vector2 movement;
    private Rigidbody2D rigidbodyComponent;
    
    // Start is called before the first frame update
    // No start actions necessary
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Retrieve axis information
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        //Movement in direction
        movement = new Vector2(speed.x * inputX, speed.y * inputY);

        //Fire laser
        bool fire = Input.GetButtonDown("Fire1");
        fire |= Input.GetButtonDown("Fire2");

        if (fire)
        {
            FireLaser beam = GetComponent<FireLaser>();
            if (beam != null)
            {
                beam.Fire();
            }
        }
    }

    void FixedUpdate()
    {
        //Get component and store reference
        if (rigidbodyComponent == null)
        {
            rigidbodyComponent = GetComponent<Rigidbody2D>();
        }
        //Move the player
        rigidbodyComponent.velocity = movement;
    }
}
