using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void PLAY()
    {
        SceneManager.LoadScene(1);
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void QualityLevel(int _int)
    {
        QualitySettings.SetQualityLevel(_int);
    }
    public void Fullscreen(bool _bool)
    {
        Screen.fullScreen = _bool;
    }
}
