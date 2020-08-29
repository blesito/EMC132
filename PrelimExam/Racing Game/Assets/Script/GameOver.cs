using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{
    public GameObject Car;
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name == "TheEnd")
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
  