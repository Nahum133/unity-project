using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotateSpeed = 5f; // A variable to changfe the rotation speed of the pickup

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.Rotate(new Vector3(15, 30, 45) * rotateSpeed * Time.deltaTime); 
    }
    
    void OnTriggerEnter(Collider collider){
        if(collider.gameObject.CompareTag("Player")){
            GameManager.Instance.UpdateScore(1);
        }
    }
}
