using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitGame : MonoBehaviour
{
    public void quitGame()
    {
        Application.Quit(); //closes the application
        UnityEditor.EditorApplication.isPlaying = false; //stops the application in the editor for testing purposes
        //Debug.Log("Exiting Game");
    }

}
