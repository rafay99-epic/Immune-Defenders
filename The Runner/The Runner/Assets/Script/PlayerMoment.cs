using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoment : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //this will display the messgae in the console log
        //Debug.Log("Hwllow!!");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 14, 0);
        }
        
    }
}
