using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class rightFingerStretches : MonoBehaviour
{
    //UI colours
    public Color unpressedColour;
    public Color pressedColour;
    public Color lockedColour;

    //UI keys
    public Image t;
    public Image y;
    public Image u;
    public Image i;
    public Image m;
    public Image n;
    public Image b;
    public Image v;
    public Image Spacebar;

    //Counter
    int count = 0;
    public TMP_Text onScreenCount;

    //bools for key presses
    bool pressedT;
    bool pressedY;
    bool pressedU;
    bool pressedI;
    bool pressedM;
    bool pressedN;
    bool pressedB;
    bool pressedV;
    bool spaceDown;
    bool tFirstPress;
    bool yFirstPress;
    bool uFirstPress;
    bool iFirstPress;

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
        pressedY = false;
        pressedU = false;
        pressedI = false;
        pressedM = false;
        pressedN = false;
        pressedB = false;
        pressedV = false;
        tFirstPress = false;
        yFirstPress = false;
        uFirstPress = false;
        iFirstPress = false;
        spaceDown = false;
        indexText.SetActive(false);
        middleText.SetActive(false);
        ringText.SetActive(false);
        littleText.SetActive(false);
        onScreenCount.SetText("");
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
                yColour(pressedY);
                bColour(pressedB);
                indexText.SetActive(false);
                middleText.SetActive(true);
                encourageText.SetText("Great Start!");
                if(Input.GetKeyDown(KeyCode.Y) && pressedY == false)
                {
                    pressedY = true;
                    yFirstPress = true;
                    pressedB = false;
                    yColour(pressedY);
                    bColour(pressedB);
                    count++;
                    audioSource.Play();
                    onScreenCount.SetText("Counter: " + count);
                }
                if(Input.GetKeyDown(KeyCode.B) && pressedY == true)
                {
                    pressedB = true;
                    pressedY = false;
                    yColour(pressedY);
                    bColour(pressedB);
                    count++;
                    audioSource.Play();
                    onScreenCount.SetText("Counter: " + count);
                }
            }
            if(count >=20 && count <=29)
            {
                pressedY = true;
                pressedB = true;
                yColour(pressedY);
                bColour(pressedB);
                uColour(pressedU);
                nColour(pressedN);
                tColour(pressedT);
                vColour(pressedV);
                middleText.SetActive(false);
                ringText.SetActive(true);
                encourageText.SetText("Halfway There! Keep Going!");
                if(Input.GetKeyDown(KeyCode.U) && pressedU == false)
                {
                    pressedU = true;
                    uFirstPress = true;
                    pressedN = false;
                    uColour(pressedU);
                    nColour(pressedN);
                    count++;
                    audioSource.Play();
                    onScreenCount.SetText("Counter: " + count);
                }
                if(Input.GetKeyDown(KeyCode.N) && pressedU == true)
                {
                    pressedN = true;
                    pressedU = false;
                    uColour(pressedU);
                    nColour(pressedN);
                    count++;
                    audioSource.Play();
                    onScreenCount.SetText("Counter: " + count);
                }
            }
            if(count >=30 && count <=39)
            {
                pressedU = true;
                pressedN = true;
                yColour(pressedY);
                bColour(pressedB);
                tColour(pressedT);
                vColour(pressedV);
                uColour(pressedU);
                nColour(pressedN);
                iColour(pressedI);
                mColour(pressedM);
                ringText.SetActive(false);
                littleText.SetActive(true);
                encourageText.SetText("Almost Finished! You Got This!");
                if(Input.GetKeyDown(KeyCode.I) && pressedI == false)
                {
                    pressedI = true;
                    iFirstPress = true;
                    pressedM = false;
                    iColour(pressedI);
                    mColour(pressedM);
                    count++;
                    audioSource.Play();
                    onScreenCount.SetText("Counter: " + count);
                }
                if(Input.GetKeyDown(KeyCode.M) && pressedI == true)
                {
                    pressedM = true;
                    pressedI = false;
                    iColour(pressedI);
                    mColour(pressedM);
                    count++;
                    audioSource.Play();
                    onScreenCount.SetText("Counter: " + count);
                }
            }
            if(count == 40)
            {
                pressedI = true;
                pressedM = true;
                iColour(pressedI);
                mColour(pressedM);
                tColour(pressedT);
                vColour(pressedV);
                uColour(pressedU);
                nColour(pressedN);
                yColour(pressedY);
                bColour(pressedB);
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
            y.color = lockedColour;
            u.color = lockedColour;
            i.color = lockedColour;
            m.color = lockedColour;
            n.color = lockedColour;
            b.color = lockedColour;
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

    void yColour(bool pressedY)
    {
        if(pressedY == true)
        {
            y.color = pressedColour;
        }
        else
        {
            y.color = unpressedColour;
        }
    }

    void bColour(bool pressedB)
    {
        if(yFirstPress == false)
        {
            b.color = lockedColour;
        }
        else
        {
            if(pressedB == true)
            {
                b.color = pressedColour;
            }
            else
            {
                b.color = unpressedColour;
            }
        }
    }

    void uColour(bool pressedU)
    {
        if(pressedU == true)
        {
            u.color = pressedColour;
        }
        else
        {
            u.color = unpressedColour;
        }
    }

    void nColour(bool pressedN)
    {
        if(uFirstPress == false)
        {
            n.color = lockedColour;
        }
        else
        {
            if(pressedN == true)
            {
                n.color = pressedColour;
            }
            else
            {
                n.color = unpressedColour;
            }
        }
    }

    void iColour(bool pressedI)
    {
        if(pressedI == true)
        {
            i.color = pressedColour;
        }
        else
        {
            i.color = unpressedColour;
        }
    }

    void mColour(bool pressedM)
    {
        if(iFirstPress == false)
        {
            m.color = lockedColour;
        }
        else
        {
            if(pressedM == true)
            {
                m.color = pressedColour;
            }
            else
            {
                m.color = unpressedColour;
            }
        }
    }

    public void NextExercise()
    {
        currentEx.SetActive(false);
        nextEx.SetActive(true);
    }
}
