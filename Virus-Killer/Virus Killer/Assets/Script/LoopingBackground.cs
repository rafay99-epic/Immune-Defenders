using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    //This will tell the background Speed
    public float backgroundSpeed;
    //This will render the background
    public Renderer backgroundRenderer; 

    
    // Update is called once per frame
    void Update()
    {
        //This function will loop the background
        backgroundRenderer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0f);
        

    }
 
}
