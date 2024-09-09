using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toGameScene : MonoBehaviour
{
    public void toGame()
    {
        SceneManager.LoadScene("MainGame"); // Loads the game scene 
    }
}
