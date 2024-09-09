using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class leftThumbExtension : MonoBehaviour
{
    public Color unpressedColour;
    public Color pressedColour;
    public Color lockedColour;
    public Image E;
    public Image R;
    public Image M;
    int count = 0;
    public TMP_Text onScreenCount;
    bool pressedE;
    bool pressedR;
    bool pressedM;
    bool rFirstPress;
    public GameObject nextButton;
    public GameObject currentEx;
    public GameObject nextEx;
    public GameObject thumbR;
    public GameObject thumbM;
    public TMP_Text encourageText;

    public AudioClip pressSoundEffect;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        unpressedColour.a = 1;
        pressedColour.a = 1;
        lockedColour.a = 1;
        E.color = unpressedColour;
        R.color = lockedColour;
        M.color = lockedColour;
        onScreenCount.SetText("");
        pressedR = false;
        pressedM = false;
        rFirstPress = false;
        nextButton.SetActive(false);
        thumbR.SetActive(false);
        thumbM.SetActive(false);
        encourageText.SetText("Let's Get Started!");

        audioSource = GetComponent<AudioSource>();
        audioSource.clip = pressSoundEffect;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.E))
        {
            if(count < 20)
            {
            E.color = pressedColour;
            rColour(pressedR);
            mColour(pressedM);
            onScreenCount.SetText("Counter: " + count);
            if(R.color == unpressedColour)
            {
                thumbR.SetActive(true);
            }
                if(Input.GetKeyDown(KeyCode.R) && pressedR == false)
                {
                    pressedR = true;
                    pressedM = false;
                    rFirstPress = true;
                    rColour(pressedR);
                    mColour(pressedM);
                    count++;
                    audioSource.Play();
                    onScreenCount.SetText("Counter: " + count);
                    thumbR.SetActive(false);
                    thumbM.SetActive(true);
                }
                if(Input.GetKeyDown(KeyCode.M) && pressedR == true)
                {
                    pressedM = true;
                    pressedR = false;
                    rColour(pressedR);
                    mColour(pressedM);
                    count++;
                    audioSource.Play();
                    onScreenCount.SetText("Counter: " + count);
                    thumbR.SetActive(true);
                    thumbM.SetActive(false);
                }
            }
            if(count == 20)
            {
                pressedR = true;
                pressedM = true;
                E.color = pressedColour;
                rColour(pressedR);
                mColour(pressedM);
                encourageText.SetText("Done! Great Job");
                nextButton.SetActive(true);
                thumbR.SetActive(false);
                thumbM.SetActive(false);
            }
        }
        else
        {
            E.color = unpressedColour;
            R.color = lockedColour;
            M.color = lockedColour;
        }  
        
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

    void rColour(bool pressedR)
    {
        if(pressedR == false)
        {
            R.color = unpressedColour;
        }
        else
        {
            R.color = pressedColour;
        }
    }

    void mColour(bool pressedM)
    {
        if(rFirstPress == false)
        {
            M.color = lockedColour;
        }
        else
        {
            if(pressedM == false)
            {
                M.color = unpressedColour;
            }
            else
            {
                M.color = pressedColour;
            }
        }
    }

    public void NextExercise()
    {
        currentEx.SetActive(false);
        nextEx.SetActive(true);
    }
}
