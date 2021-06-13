using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Text scoreText;
    public Text HP;

    void ScoreToUI(GameObject GameController)
    {
        scoreText.text = "Points " + GameController.GetComponent<CharacterStats>().Score.ToString();
        HP.text = "Health " + GameController.GetComponent<CharacterStats>().Health.ToString();
    }

}
