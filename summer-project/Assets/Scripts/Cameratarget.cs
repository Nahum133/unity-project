using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameratarget : MonoBehaviour
{
    // Start is called before the first frame update
   public Transform target; //Camerea Position 

   public Vector3 posOffset; //target Distance from the Camera
    void Start()
    {
        
    }

    // Update is called once per frame
    private void LateUpdate()
    {
     transform.position = target.position + posOffset;
    
    }
}
