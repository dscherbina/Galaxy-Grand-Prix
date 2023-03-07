using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour
{
    public GameObject FirstCar;
    public GameObject FistCarCam;
    public AudioSource FirstCarEngine;
    public GameObject SecondCar;
    public static int CarImport;
    public GameObject SecondCarCam;
    public AudioSource SecondCarEngine;

    private void Start()
    {
        CarImport = GlobalCar.CarType;
        if(CarImport == 1)
        {
            FirstCar.SetActive(true);
            FistCarCam.SetActive(true);
            FirstCarEngine.Play();
        }
        if(CarImport == 2)
        {
            SecondCar.SetActive(true);
            SecondCarCam.SetActive(true);
            SecondCarEngine.Play();
        }
    }
}
