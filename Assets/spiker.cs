using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spiker : MonoBehaviour
{
    public float speed = 0.5f;
    public bool mRight;
    private float boostTime;
    private bool boosting = false;
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

        if (boosting)
        {
            boostTime += Time.deltaTime;
            if(boostTime > 1)
            {
                speed = 0.5f;
                boostTime = 0;
                boosting = false;
            }

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
        if (spike.gameObject.CompareTag("Player"))
        {
            boosting = true;
            speed += 0.25f;
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