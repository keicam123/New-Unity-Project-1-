using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class CharacterStats : MonoBehaviour
{
    public Animator animator;
 
    public int Health { get; set; } = 3;
    public int Score { get; set; } = 0;

    public void takeDamage(int dmg = 1)
    {
        Health -= dmg;
        animator.SetBool("IsHurt", true);
        if (Health == 0)
        {
            killCharacter();
        }
    }
    public void killCharacter()
    {
        SceneManager.LoadScene("Scoreboard", LoadSceneMode.Single);
    }
}