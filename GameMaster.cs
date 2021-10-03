using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    //Keeps new stuff happening, add as much as we can. After the first 10 seconds it spawns a new command and then every 10 and then every 5.
    // Start is called before the first frame update
     public GameObject mission1, mission2, mission3, mission4, mission5, mission6, mission7, mission8, mission9, mission10;
    void Start()
    {
        StartCoroutine(waitABitToStartCommandsCoroutine());
        StartCoroutine(waitABitToStartCommandsCoroutine2());
        StartCoroutine(waitABitToStartCommandsCoroutine3());
        StartCoroutine(waitABitToStartCommandsCoroutine4());
        StartCoroutine(waitABitToStartCommandsCoroutine5());
        StartCoroutine(waitABitToStartCommandsCoroutine6());
        StartCoroutine(waitABitToStartCommandsCoroutine7());
        StartCoroutine(waitABitToStartCommandsCoroutine8());
        StartCoroutine(waitABitToStartCommandsCoroutine9());
        StartCoroutine(waitABitToStartCommandsCoroutine10());
        StartCoroutine(waitABitToStartCommandsCoroutineFinal());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void restartItAll()
    {
        StopAllCoroutines();
        FindObjectOfType<DemonCircle>().restartIt();

        FindObjectOfType<Mission1>().interruptCountdown();
        FindObjectOfType<Mission2>().interruptCountdown();
        FindObjectOfType<Mission3>().interruptCountdown();
        FindObjectOfType<Mission4>().interruptCountdown();
        FindObjectOfType<Mission5>().interruptCountdown();
        FindObjectOfType<Mission6>().interruptCountdown();
        FindObjectOfType<Mission7>().interruptCountdown();
        FindObjectOfType<Mission8>().interruptCountdown();
        FindObjectOfType<Mission9>().interruptCountdown();
        FindObjectOfType<Mission10>().interruptCountdown();
        // mission1.SetActive(false);
        //mission2.SetActive(false);
        //mission3.SetActive(false);
        //mission4.SetActive(false);
        StartCoroutine(waitABitToStartCommandsCoroutine());
        StartCoroutine(waitABitToStartCommandsCoroutine2());
        StartCoroutine(waitABitToStartCommandsCoroutine3());
        StartCoroutine(waitABitToStartCommandsCoroutine4());
        StartCoroutine(waitABitToStartCommandsCoroutine5());
        StartCoroutine(waitABitToStartCommandsCoroutine6());
        StartCoroutine(waitABitToStartCommandsCoroutine7());
        StartCoroutine(waitABitToStartCommandsCoroutine8());
        StartCoroutine(waitABitToStartCommandsCoroutine9());
        StartCoroutine(waitABitToStartCommandsCoroutine10());
        StartCoroutine(waitABitToStartCommandsCoroutineFinal());


    }

    public void loseSoStop()
    {
        StopAllCoroutines();
        FindObjectOfType<Mission1>().interruptCountdown();
        FindObjectOfType<Mission2>().interruptCountdown();
        FindObjectOfType<Mission3>().interruptCountdown();
        FindObjectOfType<Mission4>().interruptCountdown();
        FindObjectOfType<Mission5>().interruptCountdown();
        FindObjectOfType<Mission6>().interruptCountdown();
        FindObjectOfType<Mission7>().interruptCountdown();
        FindObjectOfType<Mission8>().interruptCountdown();
        FindObjectOfType<Mission9>().interruptCountdown();
        FindObjectOfType<Mission10>().interruptCountdown();
    }

    public void activateFirstMission()
    {
        mission1.SetActive(true);
        FindObjectOfType<PlayerController>().mission1Active = true;
        FindObjectOfType<Mission1>().startMission();
    }

    IEnumerator waitABitToStartCommandsCoroutine()
    {
        //Print the time of when the function is first called.
        Debug.Log("Waiting 11 seconds to start up the commands");

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(11.0f);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Activaed the first mission: " + Time.time);
        activateFirstMission();
        
        //demonCirc.turnOffLatest();
        //refreshCountdown = true;
    }

    IEnumerator waitABitToStartCommandsCoroutine2()
    {
        //Print the time of when the function is first called.
        Debug.Log("Waiting 11 seconds to start up the commands");

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(21.0f);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Activaed the 2 mission: " + Time.time);
        mission2.SetActive(true);
        FindObjectOfType<PlayerController>().mission2Active = true;
        FindObjectOfType<Mission2>().startMission();
        //demonCirc.turnOffLatest();
        //refreshCountdown = true;
    }

    IEnumerator waitABitToStartCommandsCoroutine3()
    {
        Debug.Log("mission 3 starting: ");
        yield return new WaitForSeconds(31.0f);

        Debug.Log("Activaed the 3 mission: " + Time.time);
        mission3.SetActive(true);
        FindObjectOfType<PlayerController>().mission3Active = true;
        FindObjectOfType<Mission3>().startMission();

    }

    IEnumerator waitABitToStartCommandsCoroutine4()
    {
        Debug.Log("mission 4 starting: ");
        yield return new WaitForSeconds(41.0f);

        Debug.Log("Activaed the 4 mission: " + Time.time);
        mission4.SetActive(true);
        FindObjectOfType<PlayerController>().mission4Active = true;
        FindObjectOfType<Mission4>().startMission();

    }

    IEnumerator waitABitToStartCommandsCoroutine5()
    {
        Debug.Log("mission 5 starting: ");
        yield return new WaitForSeconds(47.0f);

        Debug.Log("Activaed the 5 mission: " + Time.time);
        mission5.SetActive(true);
        FindObjectOfType<PlayerController>().mission5Active = true;
        FindObjectOfType<Mission5>().startMission();

    }

    IEnumerator waitABitToStartCommandsCoroutine6()
    {
        Debug.Log("mission 6 starting: ");
        yield return new WaitForSeconds(52.0f);

        Debug.Log("Activaed the 6 mission: " + Time.time);
        mission6.SetActive(true);
        FindObjectOfType<PlayerController>().mission6Active = true;
        FindObjectOfType<Mission6>().startMission();

    }

    IEnumerator waitABitToStartCommandsCoroutine7()
    {
        Debug.Log("mission 7 starting: ");
        yield return new WaitForSeconds(57.0f);

        Debug.Log("Activaed the 7 mission: " + Time.time);
        mission7.SetActive(true);
        FindObjectOfType<PlayerController>().mission7Active = true;
        FindObjectOfType<Mission7>().startMission();

    }

    IEnumerator waitABitToStartCommandsCoroutine8()
    {
        Debug.Log("mission 8 starting: ");
        yield return new WaitForSeconds(62.0f);

        Debug.Log("Activaed the 8 mission: " + Time.time);
        mission8.SetActive(true);
        FindObjectOfType<PlayerController>().mission8Active = true;
        FindObjectOfType<Mission8>().startMission();

    }

    IEnumerator waitABitToStartCommandsCoroutine9()
    {
        Debug.Log("mission 9 starting: ");
        yield return new WaitForSeconds(67.0f);

        Debug.Log("Activaed the 9 mission: " + Time.time);
        mission9.SetActive(true);
        FindObjectOfType<PlayerController>().mission9Active = true;
        FindObjectOfType<Mission9>().startMission();

    }

    IEnumerator waitABitToStartCommandsCoroutine10()
    {
        Debug.Log("mission 10 starting: ");
        yield return new WaitForSeconds(67.2f);

        Debug.Log("Activaed the 10 mission: " + Time.time);
        mission10.SetActive(true);
        FindObjectOfType<PlayerController>().mission10Active = true;
        FindObjectOfType<Mission10>().startMission();

    }

    IEnumerator waitABitToStartCommandsCoroutineFinal()
    {
        Debug.Log("Final starting: ");
        yield return new WaitForSeconds(75f);

        Debug.Log("Summoning the final demon.");
        FindObjectOfType<DemonCircle>().summonFinalDemon();
        
        

    }
}
