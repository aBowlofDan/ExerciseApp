using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class leftClenchedFinger : MonoBehaviour
{
    public Color unpressedColour;
    public Color pressedColour;
    public Color lockedColour;
    int count = 0;
    public Image T;
    public Image G;
    public Image R;
    public Image F;
    public Image E;
    public Image D;
    public Image W;
    public Image S;
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
        R.color = lockedColour;
        F.color = lockedColour;
        E.color = lockedColour;
        D.color = lockedColour;
        W.color = lockedColour;
        S.color = lockedColour;
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
            R.color = unpressedColour;
            F.color = unpressedColour;
            if(Input.GetKey(KeyCode.R) && Input.GetKey(KeyCode.F))
            {  
                middleFirstPress = true;
                if(gotStartTime == false)
                {
                    getStartTime();
                }
                R.color = pressedColour;
                F.color = pressedColour;
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
            if(Input.GetKeyUp(KeyCode.R) || Input.GetKeyUp(KeyCode.F))
            {
                gotStartTime = false;
                R.color = unpressedColour;
                F.color = unpressedColour;
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
            R.color = pressedColour;
            F.color = pressedColour;
            E.color = unpressedColour;
            D.color = unpressedColour;
            if(Input.GetKey(KeyCode.E) && Input.GetKey(KeyCode.D))
            {  
                ringFirstPress = true;
                if(gotStartTime == false)
                {
                    getStartTime();
                }
                E.color = pressedColour;
                D.color = pressedColour;
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
            if(Input.GetKeyUp(KeyCode.E) || Input.GetKeyUp(KeyCode.D))
            {
                gotStartTime = false;
                E.color = unpressedColour;
                D.color = unpressedColour;
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
            E.color = pressedColour;
            D.color = pressedColour;
            W.color = unpressedColour;
            S.color = unpressedColour;
            if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.S))
            {  
                littleFirstPress = true;
                if(gotStartTime == false)
                {
                    getStartTime();
                }
                W.color = pressedColour;
                S.color = pressedColour;
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
            if(Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S))
            {
                gotStartTime = false;
                W.color = unpressedColour;
                S.color = unpressedColour;
                onScreenTimer.SetText("Timer: Released too soon!");
            }
        }
        if(count == 4)
        {
            littleText.SetActive(false);
            W.color = pressedColour;
            S.color = pressedColour;
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
