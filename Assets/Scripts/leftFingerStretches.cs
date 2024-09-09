using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class leftFingerStretches : MonoBehaviour
{
    //UI colours
    public Color unpressedColour;
    public Color pressedColour;
    public Color lockedColour;

    //UI keys
    public Image t;
    public Image r;
    public Image e;
    public Image w;
    public Image z;
    public Image x;
    public Image c;
    public Image v;
    public Image Spacebar;

    //Counter
    int count = 0;
    public TMP_Text onScreenCount;

    //bools for key presses
    bool pressedT;
    bool pressedR;
    bool pressedE;
    bool pressedW;
    bool pressedZ;
    bool pressedX;
    bool pressedC;
    bool pressedV;
    bool spaceDown;
    bool tFirstPress;
    bool rFirstPress;
    bool eFirstPress;
    bool wFirstPress;

    //next exercise button
    public GameObject nextButton;
    public GameObject currentEx;
    public GameObject nextEx;

    //UI text
    public GameObject indexText;
    public GameObject middleText;
    public GameObject ringText;
    public GameObject littleText;
    public TMP_Text encourageText;

    //Audio
    public AudioClip pressSoundEffect;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        unpressedColour.a = 1;
        pressedColour.a = 1; 
        lockedColour.a = 1;
        Spacebar.color = unpressedColour;
        pressedT = false;
        pressedR = false;
        pressedE = false;
        pressedW = false;
        pressedZ = false;
        pressedX = false;
        pressedC = false;
        pressedV = false;
        tFirstPress = false;
        rFirstPress = false;
        eFirstPress = false;
        wFirstPress = false;
        spaceDown = false;
        indexText.SetActive(false);
        middleText.SetActive(false);
        ringText.SetActive(false);
        littleText.SetActive(false);
        encourageText.SetText("Let's Get Started!");

        audioSource = GetComponent<AudioSource>();
        audioSource.clip = pressSoundEffect;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Spacebar.color = pressedColour;
            spaceDown = true;
            if(count <= 9)
            {
                tColour(pressedT);
                vColour(pressedV);
                indexText.SetActive(true);
                onScreenCount.SetText("Counter: " + count);
                if(Input.GetKeyDown(KeyCode.T) && pressedT == false)
                {
                    pressedT = true;
                    tFirstPress = true;
                    pressedV = false;
                    tColour(pressedT);
                    vColour(pressedV);
                    count++;
                    audioSource.Play();
                    onScreenCount.SetText("Counter: " + count);
                } 
                if(Input.GetKeyDown(KeyCode.V) && pressedT == true)
                {
                    pressedV = true;
                    pressedT = false;
                    tColour(pressedT);
                    vColour(pressedV);
                    count++;
                    audioSource.Play();
                    onScreenCount.SetText("Counter: " + count);
                }
            }
            if(count >=10 && count <=19)
            {
                pressedT = true;
                pressedV = true;
                tColour(pressedT);
                vColour(pressedV);
                rColour(pressedR);
                cColour(pressedC);
                indexText.SetActive(false);
                middleText.SetActive(true);
                encourageText.SetText("Great Start!");
                if(Input.GetKeyDown(KeyCode.R) && pressedR == false)
                {
                    pressedR = true;
                    rFirstPress = true;
                    pressedC = false;
                    rColour(pressedR);
                    cColour(pressedC);
                    count++;
                    audioSource.Play();
                    onScreenCount.SetText("Counter: " + count);
                }
                if(Input.GetKeyDown(KeyCode.C) && pressedR == true)
                {
                    pressedC = true;
                    pressedR = false;
                    rColour(pressedR);
                    cColour(pressedC);
                    count++;
                    audioSource.Play();
                    onScreenCount.SetText("Counter: " + count);
                }
            }
            if(count >=20 && count <=29)
            {
                pressedR = true;
                pressedC = true;
                rColour(pressedR);
                cColour(pressedC);
                eColour(pressedE);
                xColour(pressedX);
                tColour(pressedT);
                vColour(pressedV);
                middleText.SetActive(false);
                ringText.SetActive(true);
                encourageText.SetText("Halfway There! Keep Going!");
                if(Input.GetKeyDown(KeyCode.E) && pressedE == false)
                {
                    pressedE = true;
                    eFirstPress = true;
                    pressedX = false;
                    eColour(pressedE);
                    xColour(pressedX);
                    count++;
                    audioSource.Play();
                    onScreenCount.SetText("Counter: " + count);
                }
                if(Input.GetKeyDown(KeyCode.X) && pressedE == true)
                {
                    pressedX = true;
                    pressedE = false;
                    eColour(pressedE);
                    xColour(pressedX);
                    count++;
                    audioSource.Play();
                    onScreenCount.SetText("Counter: " + count);
                }
            }
            if(count >=30 && count <=39)
            {
                pressedE = true;
                pressedX = true;
                rColour(pressedR);
                cColour(pressedC);
                tColour(pressedT);
                vColour(pressedV);
                eColour(pressedE);
                xColour(pressedX);
                wColour(pressedW);
                zColour(pressedZ);
                ringText.SetActive(false);
                littleText.SetActive(true);
                encourageText.SetText("Almost Finished! You Got This!");
                if(Input.GetKeyDown(KeyCode.W) && pressedW == false)
                {
                    pressedW = true;
                    wFirstPress = true;
                    pressedZ = false;
                    wColour(pressedW);
                    zColour(pressedZ);
                    count++;
                    audioSource.Play();
                    onScreenCount.SetText("Counter: " + count);
                }
                if(Input.GetKeyDown(KeyCode.Z) && pressedW == true)
                {
                    pressedZ = true;
                    pressedW = false;
                    wColour(pressedW);
                    zColour(pressedZ);
                    count++;
                    audioSource.Play();
                    onScreenCount.SetText("Counter: " + count);
                }
            }
            if(count == 40)
            {
                pressedW = true;
                pressedZ = true;
                wColour(pressedW);
                zColour(pressedZ);
                tColour(pressedT);
                vColour(pressedV);
                xColour(pressedX);
                eColour(pressedE);
                rColour(pressedR);
                cColour(pressedC);
                littleText.SetActive(false);
                encourageText.SetText("Done! Great Job");
                nextButton.SetActive(true);
            }
        }
        else
        {
            Spacebar.color = unpressedColour;
            spaceDown = false;
            t.color = lockedColour;
            r.color = lockedColour;
            e.color = lockedColour;
            w.color = lockedColour;
            z.color = lockedColour;
            x.color = lockedColour;
            c.color = lockedColour;
            v.color = lockedColour;
            indexText.SetActive(false);
            middleText.SetActive(false);
            ringText.SetActive(false);
            littleText.SetActive(false);
        }
        
    }


    void tColour(bool pressedT)
    {
        if(pressedT == true)
        {
            t.color = pressedColour;
        }
        else
        {
            t.color = unpressedColour;
        }
    }

    void vColour(bool pressedV)
    {
        if(tFirstPress == false)
        {
            v.color = lockedColour;
        }
        else
        {
            if(pressedV == true)
            {
                v.color = pressedColour;
            }
            else
            {
                v.color = unpressedColour;
            }
        }
    }

    void rColour(bool pressedR)
    {
        if(pressedR == true)
        {
            r.color = pressedColour;
        }
        else
        {
            r.color = unpressedColour;
        }
    }

    void cColour(bool pressedC)
    {
        if(rFirstPress == false)
        {
            c.color = lockedColour;
        }
        else
        {
            if(pressedC == true)
            {
                c.color = pressedColour;
            }
            else
            {
                c.color = unpressedColour;
            }
        }
    }

    void eColour(bool pressedE)
    {
        if(pressedE == true)
        {
            e.color = pressedColour;
        }
        else
        {
            e.color = unpressedColour;
        }
    }

    void xColour(bool pressedX)
    {
        if(eFirstPress == false)
        {
            x.color = lockedColour;
        }
        else
        {
            if(pressedX == true)
            {
                x.color = pressedColour;
            }
            else
            {
                x.color = unpressedColour;
            }
        }
    }

    void wColour(bool pressedW)
    {
        if(pressedW == true)
        {
            w.color = pressedColour;
        }
        else
        {
            w.color = unpressedColour;
        }
    }

    void zColour(bool pressedZ)
    {
        if(wFirstPress == false)
        {
            z.color = lockedColour;
        }
        else
        {
            if(pressedZ == true)
            {
                z.color = pressedColour;
            }
            else
            {
                z.color = unpressedColour;
            }
        }
    }

    public void NextExercise()
    {
        currentEx.SetActive(false);
        nextEx.SetActive(true);
    }
}
