using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float maxspeed = 10f;

    float haxis;
    float vaxis;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        haxis = Input.GetAxis("Horizontal");
        vaxis = Input.GetAxis("Vertical");

        transform.Translate(haxis * maxspeed*Time.deltaTime, 0, vaxis * maxspeed * Time.deltaTime);
    }
}
