using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class rightClenchedFinger : MonoBehaviour
{
    public Color unpressedColour;
    public Color pressedColour;
    public Color lockedColour;
    int count = 0;
    public Image T;
    public Image G;
    public Image Y;
    public Image H;
    public Image U;
    public Image J;
    public Image I;
    public Image K;
    public TMP_Text onScreenCount;
    public TMP_Text onScreenTimer;

    float startTime = 0f;
    float holdTime = 10.0f;
    float timer = 0f;
    bool gotStartTime;
    bool middleReset;
    bool ringReset;
    bool littleReset;

    bool indexFirstPress;
    bool middleFirstPress;
    bool ringFirstPress;
    bool littleFirstPress;

    public GameObject indexText;
    public GameObject middleText;
    public GameObject ringText;
    public GameObject littleText;
    
    public GameObject nextButton;
    public GameObject currentEx;
    public GameObject nextEx;

    public AudioClip pressSoundEffect;
    private AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        unpressedColour.a = 1;
        pressedColour.a = 1;
        lockedColour.a = 1;
        T.color = unpressedColour;
        G.color = unpressedColour;
        Y.color = lockedColour;
        H.color = lockedColour;
        U.color = lockedColour;
        J.color = lockedColour;
        I.color = lockedColour;
        K.color = lockedColour;
        onScreenCount.SetText("");
        onScreenTimer.SetText("");
        gotStartTime = false;
        middleReset = false;
        nextButton.SetActive(false);
        indexText.SetActive(true);
        middleText.SetActive(false);
        ringText.SetActive(false);
        littleText.SetActive(false);
        indexFirstPress = false;
        middleFirstPress = false;
        ringFirstPress = false;
        littleFirstPress = false;

        audioSource = GetComponent<AudioSource>();
        audioSource.clip = pressSoundEffect;
    }

    // Update is called once per frame
    void Update()
    {
        if(count == 0)
        {
            if(indexFirstPress == false)
            {
                onScreenTimer.SetText("Timer: 10");
            }
            if(Input.GetKey(KeyCode.T) && Input.GetKey(KeyCode.G))
            {  
                indexFirstPress = true;
                if(gotStartTime == false)
                {
                    getStartTime();
                }
                T.color = pressedColour;
                G.color = pressedColour;
                onScreenCount.SetText("Counter: " + count);
                timer = Time.time - startTime;
                onScreenTimer.SetText("Timer: " + (10.0f - timer));
                if(timer >= 10)
                {
                    onScreenTimer.SetText("Timer: 0");
                }
                if((startTime + holdTime) <= Time.time)
                {
                    count++;
                    onScreenCount.SetText("Counter: " + count);
                    audioSource.Play();
                }
            }
            if(Input.GetKeyUp(KeyCode.T) || Input.GetKeyUp(KeyCode.G))
            {
                gotStartTime = false;
                T.color = unpressedColour;
                G.color = unpressedColour;
                onScreenTimer.SetText("Timer: Released too soon!");
            }
        }
        if(count == 1)
        {
            indexText.SetActive(false);
            middleText.SetActive(true);
            if(middleReset == false)
            {
                gotStartTime = false;
                middleReset = true;
            }
            if(middleFirstPress == false)
            {
                onScreenTimer.SetText("Timer: 10");
            }
            T.color = pressedColour;
            G.color = pressedColour;
            Y.color = unpressedColour;
            H.color = unpressedColour;
            if(Input.GetKey(KeyCode.Y) && Input.GetKey(KeyCode.H))
            {  
                middleFirstPress = true;
                if(gotStartTime == false)
                {
                    getStartTime();
                }
                Y.color = pressedColour;
                H.color = pressedColour;
                onScreenCount.SetText("Counter: " + count);
                timer = Time.time - startTime;
                onScreenTimer.SetText("Timer: " + (10.0f - timer));
                if(timer >= 10)
                {
                    onScreenTimer.SetText("Timer: 0");
                }
                if((startTime + holdTime) <= Time.time)
                {
                    count++;
                    onScreenCount.SetText("Counter: " + count);
                    audioSource.Play();
                }
            }
            if(Input.GetKeyUp(KeyCode.Y) || Input.GetKeyUp(KeyCode.H))
            {
                gotStartTime = false;
                Y.color = unpressedColour;
                H.color = unpressedColour;
                onScreenTimer.SetText("Timer: Released too soon!");
            }
        }
        if(count == 2)
        {
            middleText.SetActive(false);
            ringText.SetActive(true);
            if(ringReset == false)
            {
                gotStartTime = false;
                ringReset = true;
            }
            if(ringFirstPress == false)
            {
                onScreenTimer.SetText("Timer: 10");
            }
            Y.color = pressedColour;
            H.color = pressedColour;
            U.color = unpressedColour;
            J.color = unpressedColour;
            if(Input.GetKey(KeyCode.U) && Input.GetKey(KeyCode.J))
            {  
                ringFirstPress = true;
                if(gotStartTime == false)
                {
                    getStartTime();
                }
                U.color = pressedColour;
                J.color = pressedColour;
                onScreenCount.SetText("Counter: " + count);
                timer = Time.time - startTime;
                onScreenTimer.SetText("Timer: " + (10.0f - timer));
                if(timer >= 10)
                {
                    onScreenTimer.SetText("Timer: 0");
                }
                if((startTime + holdTime) <= Time.time)
                {
                    count++;
                    onScreenCount.SetText("Counter: " + count);
                    audioSource.Play();
                }
            }
            if(Input.GetKeyUp(KeyCode.U) || Input.GetKeyUp(KeyCode.J))
            {
                gotStartTime = false;
                U.color = unpressedColour;
                J.color = unpressedColour;
                onScreenTimer.SetText("Timer: Released too soon!");
            }
        }
        if(count == 3)
        {
            ringText.SetActive(false);
            littleText.SetActive(true);
            if(littleReset == false)
            {
                gotStartTime = false;
                littleReset = true;
            }
            if(littleFirstPress == false)
            {
                onScreenTimer.SetText("Timer: 10");
            }
            U.color = pressedColour;
            J.color = pressedColour;
            I.color = unpressedColour;
            K.color = unpressedColour;
            if(Input.GetKey(KeyCode.I) && Input.GetKey(KeyCode.K))
            {  
                littleFirstPress = true;
                if(gotStartTime == false)
                {
                    getStartTime();
                }
                I.color = pressedColour;
                K.color = pressedColour;
                onScreenCount.SetText("Counter: " + count);
                timer = Time.time - startTime;
                onScreenTimer.SetText("Timer: " + (10.0f - timer));
                if(timer >= 10)
                {
                    onScreenTimer.SetText("Timer: 0");
                }
                if((startTime + holdTime) <= Time.time)
                {
                    count++;
                    onScreenCount.SetText("Counter: " + count);
                    audioSource.Play();
                }
            }
            if(Input.GetKeyUp(KeyCode.I) || Input.GetKeyUp(KeyCode.K))
            {
                gotStartTime = false;
                I.color = unpressedColour;
                K.color = unpressedColour;
                onScreenTimer.SetText("Timer: Released too soon!");
            }
        }
        if(count == 4)
        {
            littleText.SetActive(false);
            I.color = pressedColour;
            K.color = pressedColour;
            nextButton.SetActive(true);
        }
    }

    void getStartTime()
    {
        startTime = Time.time;
        gotStartTime = true;
    }

    public void NextExercise()
    {
        currentEx.SetActive(false);
        nextEx.SetActive(true);
    }

}
