using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickable : MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            pickUpItem(other.gameObject);
            Destroy(gameObject);
            
        }
    }

    protected virtual void pickUpItem(GameObject player)
    {
        GameObject.Destroy(this.gameObject);
    }
}