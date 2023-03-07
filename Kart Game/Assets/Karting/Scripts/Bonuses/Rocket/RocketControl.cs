using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketControl : MonoBehaviour
{
    //public RocketBox rocketboxscript;
    //private bool ShootingState_;
    [SerializeField] public GameObject Rocket;
    
    void Start()
    {
        
        //rocketboxscript = gameObject.GetComponent<RocketBox>();
        //ShootingState_ = rocketboxscript.ShootingState;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rocket.SetActive(true);

        }
    }
   
}
