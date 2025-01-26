using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void StGame()
    {
        StartCoroutine(Intit());
    }

    private IEnumerator Intit()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Level3");
    }
}
