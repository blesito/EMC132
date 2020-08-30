using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
   public void Play() // to load the scene 
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       
   }

   

   public void Quit() // for quiting the application once it is build.
   {
       Debug.Log("QUIT");
       Application.Quit();
   }
}
