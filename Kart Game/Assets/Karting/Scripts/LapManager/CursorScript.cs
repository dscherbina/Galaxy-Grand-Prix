using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorScript : MonoBehaviour
{
    public GameObject Target;
    

    // Update is called once per frame
    void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        transform.position = Vector3.Lerp(transform.position, Target.transform.position, Time.deltaTime * 5f);
        
        //rb.constraints = RigidbodyConstraints.FreezePositionY;
        
        //rb.constraints = RigidbodyConstraints.FreezeRotationY;
    }
}
