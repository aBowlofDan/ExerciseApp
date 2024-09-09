using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class leftWrist : MonoBehaviour
{
    public Color unpressedColour;
    public Color pressedColour;
    public Color lockedColour;
    public Image G;
    public Image A;
    public Image L;
    int count = 0;
    public TMP_Text onScreenCount;
    bool pressedG;
    bool pressedA;
    bool pressedL;
    bool lFirstPress;
    public GameObject nextButton;
    public GameObject currentEx;
    public GameObject nextEx;
    public GameObject thumbA;
    public GameObject thumbL;
    public TMP_Text encourageText;

    public AudioClip pressSoundEffect;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        unpressedColour.a = 1;
        pressedColour.a = 1;
        lockedColour.a = 1;
        G.color = unpressedColour;
        A.color = lockedColour;
        L.color = lockedColour;
        onScreenCount.SetText("");
        pressedA = false;
        pressedL = false;
        lFirstPress = false;
        nextButton.SetActive(false);
        thumbA.SetActive(false);
        thumbL.SetActive(false);
        encourageText.SetText("Let's Get Started!");

        audioSource = GetComponent<AudioSource>();
        audioSource.clip = pressSoundEffect;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.G))
        {
            if(count < 20)
            {
            G.color = pressedColour;
            aColour(pressedA);
            lColour(pressedL);
            onScreenCount.SetText("Counter: " + count);
            if(L.color == unpressedColour)
            {
                thumbL.SetActive(true);
            }
                if(Input.GetKeyDown(KeyCode.A) && pressedL == true)
                {
                    pressedA = true;
                    pressedL = false;
                    aColour(pressedA);
                    lColour(pressedL);
                    count++;
                    audioSource.Play();
                    onScreenCount.SetText("Counter: " + count);
                    thumbA.SetActive(false);
                    thumbL.SetActive(true);
                }
                if(Input.GetKeyDown(KeyCode.L) && pressedL == false)
                {
                    pressedL = true;
                    pressedA = false;
                    lFirstPress = true;
                    aColour(pressedA);
                    lColour(pressedL);
                    count++;
                    audioSource.Play();
                    onScreenCount.SetText("Counter: " + count);
                    thumbA.SetActive(true);
                    thumbL.SetActive(false);
                }
            }
            if(count == 20)
            {
                pressedA = true;
                pressedL = true;
                G.color = pressedColour;
                aColour(pressedA);
                lColour(pressedL);
                encourageText.SetText("Done! Great Job");
                nextButton.SetActive(true);
            }
        }
        else
        {
            G.color = unpressedColour;
            A.color = lockedColour;
            L.color = lockedColour;
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

    void aColour(bool pressedA)
    {
        if(lFirstPress == false)
        {
            A.color = lockedColour;
        }
        else
        {
            if(pressedA == false)
            {
                A.color = unpressedColour;
            }
            else
            {
                A.color = pressedColour;
            }
        }
    }

    void lColour(bool pressedL)
    {
        if(pressedL == false)
        {
            L.color = unpressedColour;
        }
        else
        {
            L.color = pressedColour;
        }
    }

    public void NextExercise()
    {
        currentEx.SetActive(false);
        nextEx.SetActive(true);
    }

}
