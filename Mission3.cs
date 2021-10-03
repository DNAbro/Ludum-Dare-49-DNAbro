using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mission3 : MonoBehaviour
{
    public float timerCountdown;
    public DemonCircle demonCirc;
    public GameObject mission3;
    // Start is called before the first frame update
    void Start()
    {
        timerCountdown = 10;

    }

    // Update is called once per frame
    void Update()
    {


    }

    IEnumerator missionCoroutine()
    {
        //Print the time of when the function is first called.
        Debug.Log("Starting mission 3 timer");

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(timerCountdown);

        //After we have waited 5 seconds print the time again.
        mission3.SetActive(false);
        demonCirc.turnOffLatest();
    }

    public void startMission()
    {
        StartCoroutine(missionCoroutine());
    }

    public void interruptCountdown()
    {
        //StopCoroutine(ExampleCoroutine());
        StopAllCoroutines();
        mission3.SetActive(false);

    }

    
}
