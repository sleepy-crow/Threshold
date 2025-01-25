using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    public Color colorA;
    public Color colorB;
    public float duration = 2f;
    public RawImage backgroundImage;
    
    private float timer = 0f;
    public void StartGame()
    {
        SceneManager.LoadScene("Level1");
    }

    private void FixedUpdate()
    {
        if (backgroundImage != null)
        {
            timer += Time.deltaTime / duration;
            float t = Mathf.PingPong(timer, 1f);
            
            backgroundImage.material.color = Color.Lerp(colorA, colorB, t);
        }
    }
}
