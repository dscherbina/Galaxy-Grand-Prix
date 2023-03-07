using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using KartGame.KartSystems;

public class PosUp : MonoBehaviour
{
    public GameObject positionDisplay;
    public GameObject WinPanel;
    public GameObject LosePanel;
    public GameObject LapPanel;
    public GameObject PosPanel;
    public GameObject LapCount;
    public GameObject MiniMap;
    public GameObject BorderMiniMap;
    public GameObject Particle1;
    public GameObject Particle2;
    public GameObject Particle3;
    public GameObject EndGameManager;
    public GameObject EndGameNotice;
    public static bool endRace = false;
    private void Start()
    {
        endRace = false;
    }
    private void FixedUpdate()
    {
        if(endRace == false)
        {
            MiniMap.SetActive(true);
            LapPanel.SetActive(true);
            PosPanel.SetActive(true);
            LapCount.SetActive(true);
            BorderMiniMap.SetActive(true);
            WinPanel.SetActive(false);
            LosePanel.SetActive(false);
            EndGameNotice.SetActive(false);
            EndGameManager.SetActive(false);
        }
    }
    private void Update()
    {
        if (LapComplete.LapsDone == 4 && positionDisplay.GetComponent<Text>().text == "1st Place" && GameObject.FindWithTag("Player") && endRace == false)
        {
            if(CarChoice.CarImport == 1)
            {
                WinPanel.SetActive(true);
                Particle1.SetActive(true);
                Particle2.SetActive(true);
                Particle3.SetActive(true);
                GameObject.Find("KartClassic_Player").GetComponent<ArcadeKart>().enabled = false;
                LapPanel.SetActive(false);
                endRace = true;
                PosPanel.SetActive(false);
                LapCount.SetActive(false);
                MiniMap.SetActive(false);
                BorderMiniMap.SetActive(false);
                EndGameManager.SetActive(true);
                EndGameNotice.SetActive(true);
                GameObject.Find("KartClassic_MLAgent").GetComponent<ArcadeKart>().enabled = false;
            }
            if(CarChoice.CarImport == 2)
            {
                WinPanel.SetActive(true);
                Particle1.SetActive(true);
                Particle2.SetActive(true);
                Particle3.SetActive(true);
                GameObject.Find("KartClassic_Player_Car1").GetComponent<ArcadeKart>().enabled = false;
                LapPanel.SetActive(false);
                endRace = true;
                PosPanel.SetActive(false);
                LapCount.SetActive(false);
                BorderMiniMap.SetActive(false);
                MiniMap.SetActive(false);
                EndGameManager.SetActive(true);
                EndGameNotice.SetActive(true);
                GameObject.Find("KartClassic_MLAgent").GetComponent<ArcadeKart>().enabled = false;
            }
        }
        else if(LapComplete.LapsDone == 4 && positionDisplay.GetComponent<Text>().text == "2nd Place" && GameObject.FindWithTag("Player") && endRace == false)
        {
            if (CarChoice.CarImport == 1)
            {
                LosePanel.SetActive(true);
                GameObject.Find("KartClassic_Player").GetComponent<ArcadeKart>().enabled = false;
                LapPanel.SetActive(false);
                PosPanel.SetActive(false);
                LapCount.SetActive(false);
                BorderMiniMap.SetActive(false);
                MiniMap.SetActive(false);
                EndGameManager.SetActive(true);
                endRace = true;
                EndGameNotice.SetActive(true);
                GameObject.Find("KartClassic_MLAgent").GetComponent<ArcadeKart>().enabled = false;
            }
            if (CarChoice.CarImport == 2)
            {
                LosePanel.SetActive(true);
                GameObject.Find("KartClassic_Player_Car1").GetComponent<ArcadeKart>().enabled = false;
                LapPanel.SetActive(false);
                PosPanel.SetActive(false);
                LapCount.SetActive(false);
                MiniMap.SetActive(false);
                BorderMiniMap.SetActive(false);
                EndGameManager.SetActive(true);
                endRace = true;
                EndGameNotice.SetActive(true);
                GameObject.Find("KartClassic_MLAgent").GetComponent<ArcadeKart>().enabled = false;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            positionDisplay.GetComponent<Text>().text = "1st Place";
        }
    }
}
