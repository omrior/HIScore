using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Enemy spawn script pulled from https://www.youtube.com/watch?v=AI8XNNRpTTw&ab_channel=AlexanderZotov
public class SpawnScript3 : MonoBehaviour
{
    public GameObject zombie;
    float randY;
    Vector2 spawnPoint;
    public float spawnRate = 1.0f;
    float nextSpawn = 0.0f;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randY = Random.Range(-17, 14);
            spawnPoint = new Vector2(transform.position.x, randY);
            Instantiate(zombie, spawnPoint, Quaternion.identity);
        }
    }

}
