using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
            Destroy(collidedWith);
        }
    }
}
