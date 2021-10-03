using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public bool inMenu, inGame;
    //public DemonCircle demonCirc;
    public CountdownToSummoning countdown;
    public Countdown2 countdown2;
    public AudioClip sound1, sound2, sound3;
    public AudioSource audSource;
    public DemonHolder demonHold;
    private int danceCount,xCount, mission5Count, mission6Count, mission9Count;

    public bool mission1Active, mission2Active, mission3Active, mission4Active,mission5Active, mission6Active, mission7Active, mission8Active, mission9Active, mission10Active;
    // Start is called before the first frame update
    void Start()
    {
        inMenu = false;
        inGame = true;
        danceCount = 1;
        mission1Active = false;
        mission2Active = false;
        mission3Active = false;
        mission4Active = false;
        mission5Active = false;
        mission6Active = false;
        mission7Active = false;
        mission8Active = false;
        mission9Active = false;
        mission10Active = false;
        xCount = 1;
        mission5Count = 1;
        mission6Count = 1;
        mission9Count = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (inGame)
        {
            controlGame();
        }

        if(inMenu)
        {
            controlMenu();
        }
    }

    public void controlMenu()
    {

    }

    public void controlGame()
    {
        Debug.Log("HEY WE STARTING HERE.");
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
        restartCommand();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space key was pressed.");
            audSource.clip = sound1;
            audSource.Play();
            countdown.interruptAndResetCountdown();
        }

        switch (danceCount)
        {
            case 1:
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    Debug.Log("Up Arrow key was pressed.");
                    danceCount = 2;
                }
                break;
            case 2:
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    Debug.Log("Right Arrow key was pressed.");
                    danceCount = 3;
                }
                break;
            case 3:
                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    Debug.Log("Down Arrow key was pressed.");
                    danceCount = 4;
                }
                break;
            case 4:
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    Debug.Log("Left Arrow key was pressed.");
                    audSource.clip = sound2;
                    audSource.Play();
                    danceCount = 1;
                    countdown2.interruptAndResetCountdown();
                }
                break;

        }

        mission1();
        mission2();
        mission3();
        mission4();
        mission5();
        mission6();
        mission7();
        mission8();
        mission9();
        mission10();
    }

    public void mission1()
    {
        if (mission1Active)
        {
            if (Input.GetKeyDown(KeyCode.X) && xCount < 4)
            {
                Debug.Log("X pressed");
                xCount++;
            }

            if(xCount == 4)
            {
                //send back mission success
                mission1Active = false;
                FindObjectOfType<Mission1>().interruptCountdown();
                Debug.Log("Mission 1 succeded");
                audSource.clip = sound3;
                audSource.Play();

            }
        }
    }

    public void mission2()
    {
        if (mission2Active)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                //lose
                mission2Active = false;
                FindObjectOfType<Mission2>().interruptCountdownFailure();
                Debug.Log("Mission 2 failed lol nerd get rekt.");
            }

            if (Input.GetKeyDown(KeyCode.B))
            {
                //win
                mission2Active = false;
                FindObjectOfType<Mission2>().interruptCountdown();
                Debug.Log("Mission 2 succeeded.");
                audSource.clip = sound3;
                audSource.Play();
                demonHold.changeToDemon2();
            }

        }
    }

    public void mission3()
    {
        if (mission3Active)
        {
            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                mission3Active = false;
                Debug.Log("Mission 3 Succeeded!");
                FindObjectOfType<Mission3>().interruptCountdown();
                audSource.clip = sound3;
                audSource.Play();
                demonHold.changeToDemon3();
            }

            
        }
    }

    public void mission4()
    {
        if (mission4Active)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                //lose
                mission4Active = false;
                Debug.Log("Mission 4 failed lol nerd get rekt.");
                FindObjectOfType<Mission4>().interruptCountdownFailure();
                Debug.Log("Mission 2 failed lol nerd get rekt.");
            }

            if (Input.GetKeyDown(KeyCode.B))
            {
                //win
                mission4Active = false;
                Debug.Log("Mission 4 succeeded.");
                FindObjectOfType<Mission4>().interruptCountdown();
                Debug.Log("Mission 4 succeeded.");
                audSource.clip = sound3;
                audSource.Play();
                demonHold.changeToDemon4();
            }

        }
    }

    public void restartCommand()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            FindObjectOfType<GameMaster>().restartItAll();
            Debug.Log("Reset it");
            danceCount = 1;
            mission1Active = false;
            mission2Active = false;
            mission3Active = false;
            mission4Active = false;
            mission5Active = false;
            mission6Active = false;
            mission7Active = false;
            mission8Active = false;
            mission9Active = false;
            mission10Active = false;
            xCount = 1;
            mission5Count = 1;
            mission6Count = 1;
            mission9Count = 1;
        }
    }

    public void mission5()
    {
        if (mission5Active)
        {
            if (Input.GetKeyDown(KeyCode.H) && mission5Count % 2 == 1)
            {
                Debug.Log("H pressed");
                mission5Count++;
            }

            if (Input.GetKeyDown(KeyCode.J) && mission5Count % 2 == 0)
            {
                Debug.Log("J pressed");
                mission5Count++;
            }

            if (mission5Count == 11)
            {
                //send back mission success
                mission5Active = false;
                FindObjectOfType<Mission5>().interruptCountdown();
                Debug.Log("Mission 5 succeded");
                audSource.clip = sound3;
                audSource.Play();

            }
        }
    }

    public void mission6()
    {
        if (mission6Active)
        {
            if (Input.GetKeyDown(KeyCode.P) && mission6Count == 1)
            {
                Debug.Log("P pressed");
                mission6Count++;
            }

            if (Input.GetKeyDown(KeyCode.O) && (mission6Count == 2 || mission6Count == 6))
            {
                Debug.Log("O pressed");
                mission6Count++;
            }

            if (Input.GetKeyDown(KeyCode.T) && (mission6Count == 3 || mission6Count == 5))
            {
                Debug.Log("T pressed");
                mission6Count++;
            }

            if (Input.GetKeyDown(KeyCode.A) && mission6Count == 4)
            {
                Debug.Log("A pressed");
                mission6Count++;
            }


            if (mission6Count == 7)
            {
                //send back mission success
                mission6Active = false;
                FindObjectOfType<Mission6>().interruptCountdown();
                Debug.Log("Mission 6 succeded");
                audSource.clip = sound3;
                audSource.Play();
                demonHold.changeToDemon5();

            }
        }
    }

    public void mission7()
    {
        if (mission7Active)
        {
            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                mission7Active = false;
                Debug.Log("Mission 7 Succeeded!");
                FindObjectOfType<Mission7>().interruptCountdown();
                audSource.clip = sound3;
                audSource.Play();
            }


        }
    }

    public void mission8()
    {
        if (mission8Active)
        {
            if (Input.GetKeyDown(KeyCode.Alpha8))
            {
                mission8Active = false;
                Debug.Log("Mission 8 Succeeded!");
                FindObjectOfType<Mission8>().interruptCountdown();
                audSource.clip = sound3;
                audSource.Play();
                demonHold.changeToDemon6();
            }


        }
    }

    public void mission9()
    {
        if (mission9Active)
        {
            if (Input.GetKeyDown(KeyCode.X) && mission9Count < 4)
            {
                Debug.Log("X pressed");
                mission9Count++;
            }

            if (mission9Count == 4)
            {
                //send back mission success
                mission9Active = false;
                FindObjectOfType<Mission9>().interruptCountdown();
                Debug.Log("Mission 9 succeded");
                audSource.clip = sound3;
                audSource.Play();

            }
        }
    }

    public void mission10()
    {
        if (mission10Active)
        {
            if (Input.GetKeyDown(KeyCode.B))
            {
                //lose
                mission10Active = false;
                FindObjectOfType<Mission10>().interruptCountdownFailure();
                Debug.Log("Mission 10 failed lol nerd get rekt.");
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                //win
                mission10Active = false;
                FindObjectOfType<Mission10>().interruptCountdown();
                Debug.Log("Mission 10 succeeded.");
                audSource.clip = sound3;
                audSource.Play();
                
            }

        }
    }
}
