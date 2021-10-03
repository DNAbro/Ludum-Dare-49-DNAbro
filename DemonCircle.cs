using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonCircle : MonoBehaviour
{

    public GameObject circle4, circle3, circle2, circle1;
    public int count;
    private bool gameActive;
    public float speedRotate;
    public AudioSource aud;
    public AudioClip failSound, summonSound;
    public GameObject demonHolder;
    // Start is called before the first frame update
    void Start()
    {
        speedRotate = 20f;
        count = 4;
        gameActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        spinEffect();
    }

    public void spinEffect()
    {
        //this.gameObject.transform.rotation = Quaternion.Euler(Vector3.forward * 60f);
        transform.Rotate(Vector3.forward * speedRotate * Time.deltaTime);
    }

    public void turnOffLatest()
    {
        if (gameActive)
        {
            switch (count)
            {
                case (4):
                    turnOffCircle4();
                    count--;
                    aud.clip = failSound;
                    aud.Play();
                    break;
                case (3):
                    turnOffCircle3();
                    count--;
                    aud.clip = failSound;
                    aud.Play();
                    break;
                case (2):
                    turnOffCircle2();
                    count--;
                    aud.clip = failSound;
                    aud.Play();
                    break;
                case (1):
                    turnOffCircle1();
                    count--;
                    gameActive = false;
                    summonDemon();
                    FindObjectOfType<GameMaster>().loseSoStop();
                    break;
            }
            
        }
    }

    public void turnOffCircle4()
    {
        circle4.SetActive(false);
    }

    public void turnOffCircle3()
    {
        circle3.SetActive(false);
    }

    public void turnOffCircle2()
    {
        circle2.SetActive(false);
    }

    public void turnOffCircle1()
    {
        circle1.SetActive(false);
    }

    public void restartIt()
    {
        circle1.SetActive(true);
        circle2.SetActive(true);
        circle3.SetActive(true);
        circle4.SetActive(true);
        FindObjectOfType<DemonHolder>().turnOffDemonBox();
        count = 4;
        gameActive = true;
        demonHolder.SetActive(false);
    }
    public void summonDemon()
    {
        //Instantiate(demon1);
        demonHolder.SetActive(true);
        FindObjectOfType<DemonHolder>().turnOnDemonDialogue();
        aud.clip = summonSound;
        aud.Play();
    }

    public void summonFinalDemon()
    {
        //Instantiate(demon1);
        demonHolder.SetActive(true);
        gameActive = false;
        circle1.SetActive(false);
        circle2.SetActive(false);
        circle3.SetActive(false);
        circle4.SetActive(false);
        if (count == 4)
        {
            FindObjectOfType<DemonHolder>().changeToFinalDemon();
        }
        FindObjectOfType<DemonHolder>().turnOnDemonDialogue();
        aud.clip = summonSound;
        aud.Play();
        
    }
}
