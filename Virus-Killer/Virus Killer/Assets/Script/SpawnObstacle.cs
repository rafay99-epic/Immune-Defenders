using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    //This variable will contain the Obstacles
    public GameObject obstacle;

    //cordients for the Obstacle
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;

    // this variable will tell us about the how much time a spawn will apperar
    public float timebetweenspawn;
    private float spawnTime;
   
    // Update is called once per frame
    void Update()
    {
        //check the time and then spwan the correct way.
        if (Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time+timebetweenspawn;
        }
    }
    void Spawn()
    { 
        //To define the correct location and be random
        
        //This one is for X Axis
        float randomX = Random.Range(minX, maxX);

        //This is for the Y axis
        float randomY = Random.Range(minY, maxY);

        //Place the spawn in the random location
        Instantiate(obstacle, transform.position + new Vector3(randomX,randomY,0), transform.rotation); 
    }
}
