using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool paused;
    
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!paused)
            {
                PauseGame();
            }
            
            pauseMenu.SetActive(!pauseMenu.activeSelf);
            
        }
    }

    private void PauseGame()
    {
        Time.timeScale = 0;
        paused = !paused;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        paused = !paused;
    }

    public void Close()
    {
        Application.Quit();
    }

    public void Menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
}
