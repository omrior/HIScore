﻿using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class ZombieMovement : MonoBehaviour
{
    public bool isGhost = true;
    Rigidbody2D rb;

    // movement speed
    [SerializeField] float speed;

    // possible movent directions
    Vector2[] directions = { Vector2.up, Vector2.right, Vector2.down, Vector2.left };

    int directionIndex = 1;

    // doesn't have to be serialized
    [SerializeField] Vector2 currentDir;

    // how far to look ahead
    [SerializeField] float rayDistance;

    // which layers to raycast for
    [SerializeField] LayerMask rayLayer;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        // start moving in a directions
        currentDir = directions[directionIndex];
    }

    // Update is called once per frame
    void Update()
    {
        Physics2D.queriesStartInColliders = false;
        // raycast
        RaycastHit2D hit2D = Physics2D.Raycast(transform.position, currentDir, rayDistance, rayLayer);
        Vector3 endpoint = currentDir * rayDistance;
        // visably debug the ray
        Debug.DrawLine(transform.position, transform.position + endpoint, Color.green);
        
        // if walls and pacman layer are selected, will return true for either
        if (hit2D.collider != null)
        {

            // check if wall ahead
            if (hit2D.collider.gameObject.name
                == "Map1")
            {

                ChangeDirection();
            }

            // check if wall ahead
            else if (hit2D.collider.gameObject.name
                == "passornot")
            {

                int RandomInt = Random.Range(0, 4);


                if (RandomInt > 0)
                {
                    ChangeDirection();
                }


            }

            // check if pacman ahead
            else if (hit2D.collider.gameObject.name
                        == "PacMan")
            {
                // deal damage;
                print("pacman ahead!");
            }
        }
    }


    void ChangeDirection()
    {
        // randomly select between -1 and 1;
        
        directionIndex += Random.Range(0, 2) * 2 - 1;
        
        // keeps index from exceeding 3
        directionIndex = directionIndex % directions.Length;

        // keep index positive
        if (directionIndex < 0)
        {
            directionIndex = directions.Length + directionIndex;
        }

        
        // set the current direction from the directions array
        currentDir = directions[directionIndex];
    
    }

    

    void FixedUpdate()
    {

        // move in current direction
        //rb.AddForce(currentDir * speed);
        transform.Translate(currentDir * Time.deltaTime * speed, Space.World);
    }
}

