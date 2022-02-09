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

    [Header ("Set In Inspector")]
    public int pointValue = 100;

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

    /* private void OnCollisionEnter(Collision coll)
     {
         //determine the hit
         GameObject collidedWith = coll.gameObject;
         if (collidedWith.tag == "Basket")
         {
             Destroy(collidedWith);
             int score = int.Parse(scoreGT.text); //parse text of ScoreGT into an int
             score += pointValue; //add points
             scoreGT.text = score.ToString(); //display

             if (score > HighScore.score)
             { //track high score
                 HighScore.score = score;
             }
         } //end if
     }//end OnCollisionEnter*/
}
