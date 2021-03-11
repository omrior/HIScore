using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public Vector2 speed = new Vector2(10, 10);
    public Vector2 direction = new Vector2(1, 0);
    public int damage = 1;

    private Vector2 move;
    private Rigidbody2D rigidbodyComponent;

    void Start()
    {
        Destroy(gameObject, 10);
    }    
    
    void Update()
    {
        move = new Vector2(speed.x * direction.x, speed.y * direction.y);
    }

    void FixedUpdate()
    {
        if (rigidbodyComponent == null)
        {
            rigidbodyComponent = GetComponent<Rigidbody2D>();
        }
        rigidbodyComponent.velocity = move;
    }
}

