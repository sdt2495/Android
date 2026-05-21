using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // Text を使う場合

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public float score;
    private bool isGameOver;

    public Text timerText; // ← 追加
    public Text scoreText; // ← 追加

    void Awake()
    {
        Instance = this;
    }

    void Update()
    {
        if (!isGameOver)
        {
            score += Time.deltaTime;

            // UI 更新
            timerText.text = "Time: " + score.ToString("F2");
            scoreText.text = "Score: " + Mathf.FloorToInt(score);
        }
    }

    public void GameOver()
    {
        if (isGameOver) return;
        isGameOver = true;

        // 今回のスコアを保存
        PlayerPrefs.SetFloat("lastScore", score);

        // 既存のベストスコアを取得
        float best = PlayerPrefs.GetFloat("bestScore", 0);

        // 今回のスコアがベストを超えたら更新
        if (score > best)
        {
            PlayerPrefs.SetFloat("bestScore", score);
        }

        // 結果画面へ
        SceneManager.LoadScene("ResultScene");
    }


}
