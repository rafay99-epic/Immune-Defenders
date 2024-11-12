using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    //this will tell the player speed
    public float playerSpeed;

    //this will help the player to move
    private Rigidbody2D rb;

    //This variable is responsiable for the player direction
    private Vector2 playerDirection;
    // Start is called before the first frame update
    void Start()
    {
        //this help to get the player movment input.
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //The Logic of movement:

        //The logic is that the directrion will be done using the arrow key and the player will move in just one direction.
        //So if the key is press up the value will be 1 or if key is press down then value will be -1

        //This wil get the value from Y axis 
        float directionY = Input.GetAxisRaw("Vertical");

        //firection will be set into the variable
        playerDirection = new Vector2(0, directionY).normalized;
       
    }
    
    void FixedUpdate()
    {
        // This will apply the rigid boday to the game object
        rb.velocity = new Vector2(0,playerDirection.y * playerSpeed);
    }
}
