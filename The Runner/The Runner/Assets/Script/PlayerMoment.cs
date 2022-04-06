using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoment : MonoBehaviour
{
    //variable that will store the compoents data.
    private Rigidbody2D rb;




    // Start is called before the first frame update
    private void Start()
    {
        //Gett the compoent and storing it into the variable.
        //if it is needed then it can be reused.
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        //Movment Function.
        movement();

    }
    private void jumpmovement()
    {
        //Jump Code for the character
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(0, 14f);
        }
    }
    private void rightleftmovement()
    {
        //horizontial Input
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        //vertical Input
        float verticalInput = Input.GetAxisRaw("Vertical");

        //7f is the speed of the character.
        //rb.velocity is the axis of the charter where the charter will move.
        rb.velocity = new Vector2(horizontalInput * 7f, rb.velocity.y);

        //rb.velocity = new Vector2(verticalInput * 7f, rb.velocity.x);

        //rb.velocity= new Vector2(verticalInput *)


        // Sir Provided Code
        // Transforming thre object
        //transform.Translate(new Vector2(horizontalInput, verticalInput));
    }
    private void movement()
    {

        jumpmovement();
        rightleftmovement();

    }
}
