using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    public  GameObject Player;
    
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name == "FinishLine")
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
