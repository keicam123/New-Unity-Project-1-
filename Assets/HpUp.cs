using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpUp : PlayerPickable
{

    protected override void pickUpItem(GameObject player)
    {
        player.GetComponent<CharacterStats>().Health += 1;
        //GameObject.Destroy(this.gameObject);
    }
}