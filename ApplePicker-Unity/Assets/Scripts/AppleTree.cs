/*
 * Made by: Ava Fritts
 * 
 * Created: jan 31 2022
 * last edited: Feb 9th 2022
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
    public GameObject rareApplePrefab; //prefab for rare apple instantiation
    public float secondsBetweenAppleDrops = 1f; //just as the name says
    public float chanceForRareDrop = 0.1f; //as name says
    public float chanceToChangeDirection = 0.1f; //as name says

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DropApple", 2f);
    }
    void DropApple()
    {
        if (Random.value < chanceForRareDrop)
        {
            GameObject apple = Instantiate<GameObject>(rareApplePrefab);
            apple.transform.position = transform.position;
            Invoke("DropApple", secondsBetweenAppleDrops);
        }
        else
        {
            GameObject apple = Instantiate<GameObject>(applePrefab);
            apple.transform.position = transform.position;
            Invoke("DropApple", secondsBetweenAppleDrops);
        }
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
