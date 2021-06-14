using UnityEngine;
using UnityEngine.UI;
public class Score : CharacterStats
{
    public Text scoreText;
    public Text HP;

    public void ScoreToUI(GameObject GameController)
    {
        scoreText.text = "Points " + Score.ToString(); //+ GameController.GetComponent<CharacterStats>().Score.ToString();
        HP.text = "Health " + Health.ToString();//GameController.GetComponent<CharacterStats>().Health.ToString();
    }

}
