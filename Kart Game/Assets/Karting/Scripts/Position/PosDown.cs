using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PosDown : MonoBehaviour
{
    public GameObject positionDisplay;
   

    private void Start()
    {
        
        
    }
    private void Update()
    {
        

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            
            positionDisplay.GetComponent<Text>().text = "2nd Place";
        }
        
    }
}
