using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuPopUp : MonoBehaviour
{
    public GameObject popUp;

    public void closePopUp()
    {
        popUp.SetActive(false);
    }

    public void openPopUp()
    {
        popUp.SetActive(true);
    }
    

}

    


