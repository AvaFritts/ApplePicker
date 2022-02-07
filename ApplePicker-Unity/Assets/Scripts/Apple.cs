/*
 * Made by: Ava Fritts
 * 
 * Created Jan 31 2022
 * last edited: Feb 7 2022
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public static float bottomY = -20f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {  
        if ( transform.position.y < bottomY ) {
            Destroy(this.gameObject); //Destroy game object
            ApplePicker apScript = Camera.main.GetComponent< ApplePicker > ();
            apScript.AppleDestroyed();
        }//end if
    }//end update
}
