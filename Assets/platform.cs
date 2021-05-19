using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    public float speed = 3f;
    public bool mRight = true;

    void Update()
    {
        if (transform.position.x > 33)
        {
            mRight = false;
        }
        if (transform.position.x < 25)
        {
            mRight = true;
        }
        if (mRight)
        {
            transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        }
    }
    
}