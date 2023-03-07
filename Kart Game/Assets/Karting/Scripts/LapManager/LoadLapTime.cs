using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadLapTime : MonoBehaviour
{
    [SerializeField] public int MinCount;
    public int SecCount;
    public float MilliCount;
    public GameObject MinDisplay;
    public GameObject SecDisplay;
    public GameObject MilliDisplay;

    void Start()
    {
        //MinCount = PlayerPrefs.GetInt("MinSave");
        //SecCount = PlayerPrefs.GetInt("SecSave");
        //MilliCount = PlayerPrefs.GetFloat("MilliSave");

        MinDisplay.GetComponent<Text>().text = "0" + MinCount + ":";
        SecDisplay.GetComponent<Text>().text = "0" + SecCount + ".";
        MilliDisplay.GetComponent<Text>().text = "" + MilliCount;
    }
}
