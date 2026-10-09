using UnityEngine;
using TMPro;

public class UpdateScore : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text FinalScoreText;
    private int currentScore = 0;

    public void addScore()
    {
        currentScore++;
        scoreText.text = currentScore.ToString();
        FinalScoreText.text = "Score: " + currentScore.ToString();
    }
}
