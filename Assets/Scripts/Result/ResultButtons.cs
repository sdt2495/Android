using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultButtons : MonoBehaviour
{
    // リトライ（メインゲームに戻る）
    public void OnRetryButton()
    {
        SceneManager.LoadScene("MainScene");
    }

    // タイトルへ戻る
    public void OnTitleButton()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
