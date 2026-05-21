using UnityEngine;
using UnityEngine.UI;

public class ResultScore : MonoBehaviour
{
    public Text timeText;
    public Text scoreText;
    public Text bestScoreText;

    void Start()
    {
        float time = PlayerPrefs.GetFloat("lastScore", 0);
        float best = PlayerPrefs.GetFloat("bestScore", 0);

        timeText.text = "Time: " + time.ToString("F2");
        scoreText.text = "Score: " + Mathf.FloorToInt(time);
        bestScoreText.text = "Best: " + best.ToString("F2");
    }
}
