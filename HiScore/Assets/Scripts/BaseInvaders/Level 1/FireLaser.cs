using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireLaser : MonoBehaviour
{
    //Laser prefab to be fired
    public Transform laserPrefab;
    public float firingRate = 0.15f;
    private float laserCooldown;
    
    void Start()
    {
        laserCooldown = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (laserCooldown > 0)
        {
            laserCooldown -= Time.deltaTime;
        }
    }

    public void Fire()
    {
        if (LasersReady)
        {
            laserCooldown = firingRate;
            //Create new laser beam
            var laserTransform = Instantiate(laserPrefab) as Transform;
            //Assign position
            laserTransform.position = transform.position;
        }
    }

    public bool LasersReady
    {
        get
        {
            return laserCooldown <= 0f;
        }
        
    }
}
