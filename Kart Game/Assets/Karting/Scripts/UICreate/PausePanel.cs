using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public  class PausePanel : MonoBehaviour
{
    private static bool isMuted;
    void Start()
    {
        isMuted = PlayerPrefs.GetInt("MUTED") == 1;
    }
    public static void RestartScene()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
    public static void MainMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
    public static void MutePressed()
    {
        isMuted = !isMuted;
        AudioListener.pause = isMuted;
        PlayerPrefs.SetInt("MUTED", isMuted ? 1 : 0);
    }
}
