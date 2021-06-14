using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpUp : PlayerPickable
{
    public int heal = 1;
    protected override void pickUpItem(GameObject player)
    {
        player.GetComponent<CharacterStats>().Health += heal;
        //GameObject.Destroy(this.gameObject);
    }
}