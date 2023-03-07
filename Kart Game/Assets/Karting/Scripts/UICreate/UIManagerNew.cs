using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KartGame.KartSystems;

public class UIManagerNew : MonoBehaviour
{
    public GameObject PausePanel;
    private bool isPaused = false;
    public GameObject EngineSoundsCar1;
    public GameObject EngineSoundsCar2;
    public GameObject EngineSoundsEnemy1;

    public void Update()
    {
        if (Input.GetKeyDown("tab") && PosUp.endRace == false)
        {
            if (!isPaused)
            {
                PausePanel.SetActive(true);
                Time.timeScale = 0;
                Cursor.visible = true;
                isPaused = true;
                EngineSoundsCar1.SetActive(false);
                EngineSoundsCar2.SetActive(false);
                EngineSoundsEnemy1.SetActive(false);

            }
            else if(Input.GetKeyDown("tab") && PosUp.endRace == false && isPaused == true)
            {
                Time.timeScale = 1;
                PausePanel.SetActive(false);
                Cursor.visible = false;
                isPaused = false;
                EngineSoundsCar1.SetActive(true);
                EngineSoundsCar2.SetActive(true);
                EngineSoundsEnemy1.SetActive(true);
            }
        }
        
    }
    
    public void ResumeGame()
    {
        Time.timeScale = 1;
        PausePanel.SetActive(false);
        Cursor.visible = false;
        isPaused = false;
        EngineSoundsCar1.SetActive(true);
        EngineSoundsCar2.SetActive(true);
        EngineSoundsEnemy1.SetActive(true);
    }
}
