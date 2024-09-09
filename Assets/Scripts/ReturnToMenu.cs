using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnToMenu : MonoBehaviour
{
    public static ReturnToMenu instance; //creates an instance of this code

    public GameObject returnButton;
    public string time;
    public int dailyCounter;
    public bool finished;

    private void Awake() 
    {
        instance = this;

        DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        //data to be used in the statistics screen
        finished = true; //states user has fnished exercise
        returnButton.SetActive(false); //removes the return button on the top right of game screen
        time = System.DateTime.UtcNow.ToLocalTime().ToString("dd-MM-yyyy"); //gets time user finished
        dailyCounter = 1; //sets daily counter data
    }
}
