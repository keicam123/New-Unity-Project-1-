using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mainmenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Level1", LoadSceneMode.Single);
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void Scoreboard()
    {
        SceneManager.LoadScene("Scoreboard", LoadSceneMode.Single);
    }
    public void Back()
    {
        SceneManager.LoadScene("0", LoadSceneMode.Single);
    }
}
