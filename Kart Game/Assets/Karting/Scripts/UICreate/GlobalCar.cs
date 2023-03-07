using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalCar : MonoBehaviour
{
    public GameObject CarSelectionMenu;
    public static int CarType; // 1-First Car 2-Second ...
    //public GameObject TrackWindow;

    public void FirstCar()
    {
        CarType = 1;
        //TrackWindow.SetActive(true);
        SceneManager.LoadScene(1);
        Cursor.visible = false;
    }
    public void SecondCar()
    {
        CarType = 2;
        //TrackWindow.SetActive(true);
        SceneManager.LoadScene(1);
        Cursor.visible = false;
    }
    public void CarMenu()
    {
        CarSelectionMenu.SetActive(false);
    }
}
