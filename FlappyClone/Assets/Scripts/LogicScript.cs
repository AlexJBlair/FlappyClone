using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
	public int playerScore;
	public Text ScoreText;

	public void addScore()
	{
		playerScore = playerScore + 1;
		
        ScoreText.text = playerScore.ToString();
	}
}
