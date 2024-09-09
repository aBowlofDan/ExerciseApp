using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class rightThumbStretches : MonoBehaviour
{
    //colours for UI keys
    public Color unpressedColour;
    public Color pressedColour;

    //UI keys
    public Image t;
    public Image y;
    public Image u;
    public Image i;
    public Image x;
    public Image m;

    //Check if keys have been pressed/last key that was pressed
    bool pressedT;
    bool pressedY;
    bool pressedU;
    bool pressedI;
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
        pressedY = false;
        pressedU = false;
        pressedI = false;
        pressedX = false;
        pressedM = false;
        flag = false;
        onScreenCount.SetText("Counter: " + count);
        thumbTextX.SetActive(false);
        thumbTextM.SetActive(false);
        instructionText.SetActive(true);
        encourageText.SetText("Let's Get Started!");

        //gets the audio source component and sets the clip to chosen sound effect
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
            {//Changes colours when each starter button is pressed
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

            if(Input.GetKeyDown(KeyCode.Y))
            {
                y.color = pressedColour;
                pressedY = true;
            }

            if(Input.GetKeyDown(KeyCode.U))
            {
                u.color = pressedColour;
                pressedU = true;
            }

            if(Input.GetKeyDown(KeyCode.I))
            {
                i.color = pressedColour;
                pressedI = true;
            }

            //checks if all starter buttons hve been pressed
            if(pressedT == true && pressedY == true && pressedU == true && pressedI == true)
            {
                if(flag == false) //makes x the first button to turn red, looped once so as to not cause issues when pressing buttons later
                {
                    x.color = unpressedColour;
                    flag = true;
                    thumbTextX.SetActive(true);
                    instructionText.SetActive(false);
                }

                if(Input.GetKeyDown(KeyCode.X) && pressedX == false) //code for when user pressed x
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

                if(Input.GetKeyDown(KeyCode.M) && pressedX == true)//code for when user presses m
                {
                    pressedM = true;
                    pressedX = false;
                    m.color = pressedColour;
                    x.color = unpressedColour;
                    thumbTextX.SetActive(true);
                    thumbTextM.SetActive(false);
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

