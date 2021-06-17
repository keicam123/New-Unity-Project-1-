using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterStats : MonoBehaviour
{
    public Animator animator;

    public int Health = 3;
    public int Points = 0;
    public void takeDamage(int dmg = 1)
    {
        Health -= dmg;
        animator.SetBool("IsHurt", true);
        if (Health <= 0)
        {
            killCharacter();
        }
    }
    public void killCharacter()
    {
        SceneManager.LoadScene("Scoreboard", LoadSceneMode.Single);
    }
}