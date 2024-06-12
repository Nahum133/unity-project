using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
   
public static GameManager Instance {
    get; private set;
}
public void Awake()
{
    if (Instance == null)
    {
        Instance = this;
    }   else {
        Debug.LogWarning("Cannot hve more than once instance of 'Gamemanager' in the scene!");
        Destroy(this.gameObject);
    }   
 }
}
