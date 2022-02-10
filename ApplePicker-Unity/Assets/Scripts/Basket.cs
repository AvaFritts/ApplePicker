/*
 * Made by: Ava Fritts
 * 
 * Created Jan 31 2022
 * last edited: Feb 7 2022
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //using UI Libraries

public class Basket : MonoBehaviour
{
    //private Apple aplScre;
    [Header("Set Dynamically")]
    public Text scoreGT;
    public GameObject score;

    // Start is called before the first frame update
    void Start()
    {
        GameObject scoreGO = GameObject.Find("Score Counter"); //score game object
        scoreGT = scoreGO.GetComponent<Text>(); //thetext component of the score go
        scoreGT.text = "0"; //set the text property
    }

    // Update is called once per frame
    void Update()
    {
        //current screen position
        Vector3 mousPos2D = Input.mousePosition;
        //Puts mouse in 3d space
        mousPos2D.z = -Camera.main.transform.position.z;
        //converts 2d to 3d
        Vector3 mousPos3D = Camera.main.ScreenToWorldPoint(mousPos2D);

        //attaches basket to mouse
        Vector3 pos = this.transform.position;
        pos.x = mousPos3D.x;
        this.transform.position = pos;
    }

    private void OnCollisionEnter(Collision coll)
    {
        //determin the hit
        GameObject collidedWith = coll.gameObject;
        if (collidedWith.tag == "Apple")
        {
           //aplScre = GetComponent<Apple>();
           
            int score = int.Parse(scoreGT.text); //parse text of ScoreGT into an int
            //score += aplScre.pointValue;
            score += collidedWith.GetComponent<Apple>().pointValue; //add points
            scoreGT.text = score.ToString(); //display
            Destroy(collidedWith);
            if (score > HighScore.score)
            { //track high score
                HighScore.score = score;
            }
        } //end if
    }//end OnCollisionEnter
}
