using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : PlayerPickable
{

    protected override void pickUpItem(GameObject player)
    {
        player.GetComponent<CharacterStats>().Score += 100;
        //GameObject.Destroy(this.gameObject);
    }
}