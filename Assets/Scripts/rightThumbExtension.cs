using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class rightThumbExtension : MonoBehaviour
{
    public Color unpressedColour;
    public Color pressedColour;
    public Color lockedColour;
    public Image O;
    public Image I;
    public Image V;
    int count = 0;
    public TMP_Text onScreenCount;
    bool pressedO;
    bool pressedI;
    bool pressedV;
    bool iFirstPress;
    public GameObject nextButton;
    public GameObject currentEx;
    public GameObject nextEx;
    public GameObject thumbI;
    public GameObject thumbV;
    public TMP_Text encourageText;

    public AudioClip pressSoundEffect;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        unpressedColour.a = 1;
        pressedColour.a = 1;
        lockedColour.a = 1;
        O.color = unpressedColour;
        I.color = lockedColour;
        V.color = lockedColour;
        onScreenCount.SetText("");
        pressedI = false;
        pressedV = false;
        iFirstPress = false;
        nextButton.SetActive(false);
        thumbI.SetActive(false);
        thumbV.SetActive(false);
        encourageText.SetText("Let's Get Started!");

        audioSource = GetComponent<AudioSource>();
        audioSource.clip = pressSoundEffect;     
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.O))
        {
            if(count < 20)
            {
            O.color = pressedColour;
            iColour(pressedI);
            vColour(pressedV);
            onScreenCount.SetText("Counter: " + count);
            if(I.color == unpressedColour)
            {
                thumbI.SetActive(true);
            }
                if(Input.GetKeyDown(KeyCode.I) && pressedI == false)
                {
                    pressedI = true;
                    pressedV = false;
                    iFirstPress = true;
                    iColour(pressedI);
                    vColour(pressedV);
                    count++;
                    audioSource.Play();
                    onScreenCount.SetText("Counter: " + count);
                    thumbI.SetActive(false);
                    thumbV.SetActive(true);
                }
                if(Input.GetKeyDown(KeyCode.V) && pressedI == true)
                {
                    pressedV = true;
                    pressedI = false;
                    iColour(pressedI);
                    vColour(pressedV);
                    count++;
                    audioSource.Play();
                    onScreenCount.SetText("Counter: " + count);
                    thumbI.SetActive(true);
                    thumbV.SetActive(false);
                }
            }
            if(count == 20)
            {
                pressedI = true;
                pressedV = true;
                O.color = pressedColour;
                iColour(pressedI);
                vColour(pressedV);
                encourageText.SetText("Done! Great Job");
                nextButton.SetActive(true);
                thumbI.SetActive(false);
                thumbV.SetActive(false);
            }
        }
        else
        {
            O.color = unpressedColour;
            I.color = lockedColour;
            V.color = lockedColour;
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

    void iColour(bool pressedI)
    {
        if(pressedI == false)
        {
            I.color = unpressedColour;
        }
        else
        {
            I.color = pressedColour;
        }
    }

    void vColour(bool pressedV)
    {
        if(iFirstPress == false)
        {
            V.color = lockedColour;
        }
        else
        {
            if(pressedV == false)
            {
                V.color = unpressedColour;
            }
            else
            {
                V.color = pressedColour;
            }
        }
    }

    public void NextExercise()
    {
        currentEx.SetActive(false);
        nextEx.SetActive(true);
    }
}
