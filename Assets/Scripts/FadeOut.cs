using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour
{
    public GameObject fadeOut;
    public RawImage fadeOutImage;
    public float fadeOutTime;

    
    public void Fade()
    {
        StartCoroutine(FadeIn());
    }

    private IEnumerator FadeIn()
    {
        fadeOut.SetActive(true);
        float elapsedTime = 0f;
        Color color = fadeOutImage.color;

        while (elapsedTime < fadeOutTime)
        {
            elapsedTime += Time.deltaTime;
            float alpha = Mathf.Clamp01(elapsedTime / fadeOutTime);
            color.a = alpha;
            fadeOutImage.color = color;
            yield return null;
        }
        
        color.a = 1;
        fadeOutImage.color = color;
    }
}
