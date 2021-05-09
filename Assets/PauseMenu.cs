using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public void resumeGame()
    {
        SceneManager.LoadScene(1);
    }

    public void goToOptions()
    {
        SceneManager.LoadScene(2);
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
