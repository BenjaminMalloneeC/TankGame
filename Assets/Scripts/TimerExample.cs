using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerExample : MonoBehaviour
{
    public float timeBetweenBooms;
    public float countdown;
    public float timeForNextBoom;
    public float timeOfLastBoom;

    // Start is called before the first frame update
    void Start()
    {
        //Start our countdown at max
        countdown = timeBetweenBooms;

        //Set the time that we are allowed to boom
        timeForNextBoom = Time.time + timeBetweenBooms;

        //Set the time we last boomed
        timeOfLastBoom = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        /*if( Time.time >= timeOfLastBoom + timeBetweenBooms)
        {
            timeOfLastBoom = Time.time;

            Debug.Log(" Boom ");
            timeForNextBoom = Time.time + timeBetweenBooms;
        }*/
        //Countdown version

        //Countdown the countdown timer
        countdown -= Time.deltaTime;

        if (Input.GetButtonDown("Fire1"))
        {
            if (countdown <= 0)
            {
                Debug.Log(" Boom ");
                countdown = timeBetweenBooms;
            }
        }
    }
}
