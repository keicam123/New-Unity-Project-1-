using UnityEngine;
using UnityEngine.UI;
public class Score : CharacterStats
{
    public Text scoreText;
    public Text HP;
   // public CharacterStats stats;
    public void Update()
    {
        scoreText.text = "Points " + Points.ToString();
        HP.text = "Health " + Health.ToString();
    }
    private void FixedUpdate()
    {/*
        scoreText.text = "Points " + stats.GetComponent<CharacterStats>().Points.ToString();
        HP.text = "Health " + stats.GetComponent<CharacterStats>().Health.ToString();*/
    }
}
