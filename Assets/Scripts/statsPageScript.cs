using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class statsPageScript : MonoBehaviour
{
    // UI text data
    public TMP_Text dateLastExercised;
    public TMP_Text dailyCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ReturnToMenu.instance.finished == true) //uses instance of ReturnToMenu script from when user finished
        //exercise to update UI of statistics page
        {
            dateLastExercised.SetText("Date Last Exercised: " + ReturnToMenu.instance.time);
            dailyCount.SetText("Daily Counter: " + ReturnToMenu.instance.dailyCounter);
        }
        else
        {
            dateLastExercised.SetText("Date Last Exercised: ");
            dailyCount.SetText("Daily Counter: 0");
        }
        
    }
}
