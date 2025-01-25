using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public PlayerController playerController;
    public PlayerMovement playerMovement;
    public bool paused = false;
    
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.SetActive(!pauseMenu.activeSelf);
            playerMovement.enabled = false;
            if (paused)
            {
                PauseGame();
            }
            else
            {
                ResumeGame();
            }
        }
    }

    private void PauseGame()
    {
        Time.timeScale = 0;
        paused = !paused;
    }

    private void ResumeGame()
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
        SceneManager.LoadScene("MainMenu");
    }
}
