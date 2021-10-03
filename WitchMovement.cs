using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WitchMovement : MonoBehaviour
{

    public bool upDown;
    private int countUp;
    // Start is called before the first frame update
    void Start()
    {
        upDown = true;
        countUp = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //witchIdleBounce();
        //countUp++;
    }

    public void witchIdleBounce()
    {
        if (upDown && countUp % 10 == 0)
        {
            transform.position = new Vector3(transform.position.x, -0.1f);
            upDown = false;
        }
        else
        {
            transform.position = new Vector3(transform.position.x, 0f);
            upDown = true;
        }
        
        

    }
}
