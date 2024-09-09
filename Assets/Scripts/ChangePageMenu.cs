using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePageMenu : MonoBehaviour
{
    public GameObject StartPage;
    public GameObject StatisticsPage;

    // Start is called before the first frame update
    void Start()
    {
        //chooses which canvas is selected when the program starts
        StartPage.SetActive(true);
        StatisticsPage.SetActive(false);
    }

    //changes to the statistics page
    public void ToStatisticsPage()  
    {
        StartPage.SetActive(false);
        StatisticsPage.SetActive(true);
    }

    //changes to the start page
    public void ToStartPage()
    {
        StartPage.SetActive(true);
        StatisticsPage.SetActive(false);
    }
}
