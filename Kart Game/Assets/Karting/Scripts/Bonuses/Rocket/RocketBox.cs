using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketBox : MonoBehaviour
{
    public static int CarImport;

    public bool ShootingState = false;
    void Start()
    {
        CarImport = GlobalCar.CarType;
        ShootingState = false;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && CarImport == 1)
        {
            //ShootingState = true;
            
            GameObject.Find("KartClassic_Player").GetComponent<RocketControl>().enabled = true;
            Destroy(gameObject);
        }
        if (other.tag == "Player" && CarImport == 2)
        {
            GameObject.Find("KartClassic_Player_Car1").GetComponent<RocketControl>().enabled = true;
            Destroy(gameObject);
        }
        

    }
    
}
