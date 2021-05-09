using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseButton : MonoBehaviour
{
    public void onPauseClick()
    {
        SceneManager.LoadScene(3);
    }
}
