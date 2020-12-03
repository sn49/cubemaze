using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class MoveCar : MonoBehaviour
{
    bool upmove=true;
    float maxtime = 3000;
    public float move = 0;
    Stopwatch stopwatch = new Stopwatch();
    // Start is called before the first frame update
    void Start()
    {
        stopwatch.Start();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("walls"))
        {
            upmove=!upmove;
        }
    }

    // Update is called once per frame
    void Update()
    {
        float time = stopwatch.ElapsedMilliseconds;

        if (time > maxtime)
        {
            upmove = !upmove;
            stopwatch.Restart();
        }

        move = time / maxtime;


        if (upmove)
        {
            transform.Translate(0, 0, time/maxtime);
        }
        else
        {
            transform.Translate(0, 0, -time / maxtime);
        }
    }
}
