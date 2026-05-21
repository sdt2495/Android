using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class FadeOut : MonoBehaviour
{
    public float duration = 1f;
    public string nextScene = "GameScene";
    Image img;

    void Start()
    {
        img = GetComponent<Image>();
        StartCoroutine(Fade());
    }

    IEnumerator Fade()
    {
        float t = 0;
        Color c = img.color;

        while (t < duration)
        {
            t += Time.deltaTime;
            c.a = t / duration;
            img.color = c;
            yield return null;
        }

        SceneManager.LoadScene(nextScene);
    }
}
