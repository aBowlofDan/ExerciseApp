using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class progressBarScript : MonoBehaviour
{
    //progress bar data
    public Slider progressBar;
    public TMP_Text progressPercent;
    int progressValue = 0;

    
    // Start is called before the first frame update
    void Start()
    {
        //sets progress bar max value and current value
        progressBar.maxValue = 10;
        progressBar.value = progressValue;
        
    }

    public void IncreaseProgressBar() //method for increasing progress bar and progress bar percent text 
    {
        progressValue++;
        progressBar.value = progressValue;

        progressPercent.SetText(((progressValue*100)/10) + "%");
    }
}
