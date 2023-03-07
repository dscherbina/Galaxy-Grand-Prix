using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject SelectionPanel;
    
    public void StartGame()
    {
        SelectionPanel.SetActive(true);
        

    }
    public void Quit()
    {
        Application.Quit();
    }
}
