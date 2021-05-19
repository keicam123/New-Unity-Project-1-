using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spiker : MonoBehaviour
{
    public float speed;
    public bool mRight;

    void Update()
    {
      if(mRight)
        {
            transform.Translate(2 * Time.deltaTime * speed, 0, 0);
        }
        else
        {
            transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
        }
    }
    void OnTriggerEnter2D(Collider2D spike)
    {
        if (spike.gameObject.CompareTag("turn"))
        {
            if (mRight == true)
            {
                mRight = false;
            }
            else
            {
                mRight = true;
            }
        }

    }
}