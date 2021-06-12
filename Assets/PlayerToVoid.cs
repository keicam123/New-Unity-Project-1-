using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerToVoid : MonoBehaviour
{

    public Vector2 PushCharacter { get; set; } = new Vector2(0f, 5f);
    public int Damage { get; set; } = 3;
 
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Rigidbody2D>().velocity = PushCharacter;
            other.GetComponent<CharacterStats>().takeDamage(Damage);
        }

    }
}
