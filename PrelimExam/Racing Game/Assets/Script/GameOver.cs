using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{
    public GameObject Car;
    void OnTriggerEnter(Collider col)  // to let car collide in the collider and load the next scene
    
    {
        if(col.gameObject.name == "TheEnd")
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
  