using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameManager : MonoBehaviour
{
    
    void Start()
    {
        LapComplete.RawTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        LapComplete.RawTime = 0;
        if (Input.GetKey("m") && PosUp.endRace == true)
        {
            SceneManager.LoadScene(0);
            Cursor.visible = true;
        
        }
    }
}
