using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControls : MonoBehaviour
{
    public FadeOut fadeOut;
    public string sceneName;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("NextLevel"))
        {
            GameObject cam = transform.GetChild(0).gameObject;
            cam.transform.SetParent(null);
            fadeOut.Fade();
        }
    }
}
