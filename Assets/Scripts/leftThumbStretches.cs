using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class leftThumbStretches : MonoBehaviour
{
    //colours for UI keys
    public Color unpressedColour;
    public Color pressedColour;

    //UI keys
    public Image t;
    public Image r;
    public Image e;
    public Image w;
    public Image x;
    public Image m;

    //boolean for checking if keys have been pressed/last key that was pressed
    bool pressedT;
    bool pressedR;
    bool pressedE;
    bool pressedW;
    bool pressedX;
    bool pressedM; 

    //counter data
    int count = 0;
    public TMP_Text onScreenCount;

    //flag for looping method 1 time
    bool flag;

    //next exercise button data
    public GameObject nextButton;
    public GameObject currentEx;
    public GameObject nextEx;

    //UI text
    public GameObject thumbTextX;
    public GameObject thumbTextM;
    public GameObject instructionText;
    public TMP_Text encourageText;

    //Audio
    public AudioClip pressSoundEffect;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        unpressedColour.a = 1;
        pressedColour.a = 1;   
        pressedT = false;
        pressedR = false;
        pressedE = false;
        pressedW = false;
        pressedX = false;
        pressedM = false;
        flag = false;
        onScreenCount.SetText("Counter: " + count);
        thumbTextX.SetActive(false);
        thumbTextM.SetActive(false);
        instructionText.SetActive(true);
        encourageText.SetText("Let's Get Started!");

        audioSource = GetComponent<AudioSource>();
        audioSource.clip = pressSoundEffect;
    }

    // Update is called once per frame
    void Update()
    {
        if(count == 19) //for final button press, doesn't change alternate buttons colour
        {
            if(Input.GetKeyDown(KeyCode.X))
            {
                pressedX = true;
                x.color = pressedColour;
                count++;
                onScreenCount.SetText("Counter: " + count);
                audioSource.Play();
            }

            if(Input.GetKeyDown(KeyCode.M))
            {
                pressedM = true;
                m.color = pressedColour;
                count++;
                onScreenCount.SetText("Counter: " + count);
                audioSource.Play();
            }
        }
        if(count == 20) //finishes exercise and activate button to take user to next exercise
        {
            if(pressedM == true && pressedX == true)
            {
                encourageText.SetText("Done! Great Job");
                nextButton.SetActive(true);
            }
        }
        else
        {
            //Changes colours when each starter button is pressed
            if(Input.GetKeyDown(KeyCode.T))
            {
                t.color = pressedColour;
                pressedT = true;
            }

            if(Input.GetKeyDown(KeyCode.R))
            {
                r.color = pressedColour;
                pressedR = true;
            }

            if(Input.GetKeyDown(KeyCode.E))
            {
                e.color = pressedColour;
                pressedE = true;
            }

            if(Input.GetKeyDown(KeyCode.W))
            {
                w.color = pressedColour;
                pressedW = true;
            }

            //checks if all starter buttons hve been pressed
            if(pressedT == true && pressedR == true && pressedE == true && pressedW == true)
            {
                if(flag == false) //makes m the first button to turn red, looped once so as to not cause issues when pressing buttons later
                {
                    m.color = unpressedColour;
                    flag = true;
                    thumbTextM.SetActive(true);
                    instructionText.SetActive(false);
                }

                if(Input.GetKeyDown(KeyCode.X) && pressedM == true) //code for when user pressed x
                {
                    pressedX = true;
                    pressedM = false;
                    x.color = pressedColour;
                    m.color = unpressedColour;
                    thumbTextX.SetActive(false);
                    thumbTextM.SetActive(true);
                    count++;
                    audioSource.Play();
                    //Debug.Log("You have done " + count + " stretches");
                    onScreenCount.SetText("Counter: " + count);
                }

                if(Input.GetKeyDown(KeyCode.M) && pressedM == false) //code for when user presses m
                {
                    pressedM = true;
                    pressedX = false;
                    m.color = pressedColour;
                    x.color = unpressedColour;
                    thumbTextM.SetActive(false);
                    thumbTextX.SetActive(true);
                    count++;
                    audioSource.Play();
                    //Debug.Log("You have done " + count + " stretches");
                    onScreenCount.SetText("Counter: " + count);
                }

            }

        }

        //encouragement UI text changes when counter increases
        if(count == 5)
        {
            encourageText.SetText("Great Start!");
        }
        if(count == 10)
        {
            encourageText.SetText("Halfway There! Keep Going!");
        }
        if(count == 15)
        {
            encourageText.SetText("Almost Finished! You Got This!");
        }
        
    }

    //method for taking user to next exercise thorugh button 
    public void NextExercise()
    {
        currentEx.SetActive(false);
        nextEx.SetActive(true);
    }

}
