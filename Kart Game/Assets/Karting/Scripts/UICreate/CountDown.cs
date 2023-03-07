using KartGame.KartSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public GameObject Countdown;
    public AudioSource GetReagySound;
    public AudioSource GoSound;
    public GameObject LapTimer;
    private static int CarSelect;

    private void Start()
    {
        CarSelect = CarChoice.CarImport;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = false;
        StartCoroutine(CountStart());
    }
    IEnumerator CountStart()
    {
        yield return new WaitForSeconds(0.5f);
        Countdown.GetComponent<Text>().text = "3";
        GetReagySound.Play();
        Countdown.SetActive(true);

        yield return new WaitForSeconds(1);
        Countdown.SetActive(false);
        Countdown.GetComponent<Text>().text = "2";
        Countdown.SetActive(true);

        yield return new WaitForSeconds(1);
        Countdown.SetActive(false);
        Countdown.GetComponent<Text>().text = "1";
        Countdown.SetActive(true);

        yield return new WaitForSeconds(1);
        Countdown.SetActive(false);
        Countdown.GetComponent<Text>().text = "GO!";
        Countdown.SetActive(true);
        GoSound.Play();
        
        GameObject.Find("KartClassic_MLAgent").GetComponent<ArcadeKart>().enabled = true;
        //GameObject.Find("LapCompleteTrigger").GetComponent<LapComplete>().enabled = true;
        LapTimer.SetActive(true);
        if (CarSelect == 1)
        {
            GameObject.Find("KartClassic_Player").GetComponent<ArcadeKart>().enabled = true;
        }
        else if(CarSelect == 2)
        {
            GameObject.Find("KartClassic_Player_Car1").GetComponent<ArcadeKart>().enabled = true;
        }
    }
}
