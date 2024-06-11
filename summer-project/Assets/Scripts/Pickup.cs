using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    // Start is called before the first frame update
    public int points;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other){
       if(other.gameObject.CompareTag("Player")){
        points++;
        Debug.Log(points);
        Destroy(this.gameObject);
       }
    }
    
}
