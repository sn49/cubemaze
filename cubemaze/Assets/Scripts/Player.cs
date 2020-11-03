using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Player : MonoBehaviour
{
    float maxspeed = 10f;//최대 속도

    float haxis;
    float vaxis;

    Stopwatch moveCheck = new Stopwatch();//움직일수 없게 하는 스톱워치
    float cantmove = 1000;//움직일 수 없는 시간

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (moveCheck.IsRunning)//moveCheck 타이머가 작동중이면
        {
            //움직이지 못함
            haxis = 0;
            vaxis = 0;
        }
        else
        {
            haxis = Input.GetAxis("Horizontal");
            vaxis = Input.GetAxis("Vertical");
        }

        if (moveCheck.ElapsedMilliseconds > 1000)//움직이지 못하는 시간=cantmove변수
        {
            moveCheck.Reset();
        }

        transform.Translate(haxis * maxspeed*Time.deltaTime, 0, vaxis * maxspeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("StopCube"))
        {
            moveCheck.Start();
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("GoodCube"))
        {
            //좋은 영향을 주는 거



            Destroy(collision.gameObject);
        }
    }
}
