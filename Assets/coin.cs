using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : PlayerPickable
{
    public int coinValue = 1;
    protected override void pickUpItem(GameObject player)
    {
        player.GetComponent<CharacterStats>().Score += coinValue;
        GameObject.Destroy(this.gameObject);
    }
}