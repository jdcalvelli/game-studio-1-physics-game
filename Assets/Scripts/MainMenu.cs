using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //get the current active scene and add 1 to go to next scene
    }


    public void QuitGame()
    {
        Debug.Log("QUIT!"); //Message to show the button is working
        Application.Quit(); //Won't work in Unity Scene
    }

}


    