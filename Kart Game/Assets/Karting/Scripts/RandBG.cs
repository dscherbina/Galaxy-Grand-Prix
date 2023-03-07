using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandBG : MonoBehaviour
{
    public Material[] materialsskybox;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Skybox>().material = materialsskybox[Random.Range(0, materialsskybox.Length)];
    }

   
}
