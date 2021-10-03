using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountdownToSummoning : MonoBehaviour
{
    public bool refreshCountdown;
    public float timerCountdown;
    public DemonCircle demonCirc;
    // Start is called before the first frame update
    void Start()
    {
        timerCountdown = 5;
        refreshCountdown = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (refreshCountdown)
        {
            StartCoroutine(ExampleCoroutine());
            refreshCountdown = false;
        }
        
    }

    IEnumerator ExampleCoroutine()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(timerCountdown);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
        demonCirc.turnOffLatest();
        refreshCountdown = true;
    }

    public void interruptAndResetCountdown()
    {
        //StopCoroutine(ExampleCoroutine());
        StopAllCoroutines();
        Debug.Log("This should stop the coroutine and start up the next one.");
        refreshCountdown = true;
    }
}
