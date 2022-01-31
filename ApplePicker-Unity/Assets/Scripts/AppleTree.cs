/*
 * Made by: Ava Fritts
 * 
 * 
 * last edited: jan 31 2022
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    /*Variables*/
    [Header("Set in Inspector")]
    public float speed = 1f; //tree speed
    public float leftAndRightEdge = 10f; //distance for tree turning
    public GameObject applePrefab; //prefab for apple instantiation
    public float secondsBetweenAppleDrops = 1f; //just as the name says
    public float chanceToChangeDirection = 0.1f; //as name says

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //basic movement
        Vector3 pos = transform.position; //current position
        pos.x += speed * Time.deltaTime; //adds to X position
        transform.position = pos; //apply transition value

        //Change Direction
        if(pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed); //set speed to positive
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed); //set speed to negative value
        }

    }//end update
    //FixedUpdate is called on fixed intervals (50times per second)
    private void FixedUpdate()
    {
        //test chance for direction change
        if(Random.value < chanceToChangeDirection)
        {
            speed *= -1; //change
        }

    }
}
