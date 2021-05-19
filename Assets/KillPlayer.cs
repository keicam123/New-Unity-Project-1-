using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    public int health = 3;

    public void OnTriggerEnter2D(Collider2D Player)
    {
        if (Player.CompareTag("spike"))
        {
            health -= 1;
        }
        if (Player.CompareTag("void"))
        {
            health -= 10;
        }
    }
    void Update()
    {
        if (health < 1)
        {
            SceneManager.LoadScene("Scoreboard", LoadSceneMode.Single);
        }
    }
}
