using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    float maxspeed = 20f;//최대 속도

    float haxis;
    float vaxis;

    Stopwatch moveCheck = new Stopwatch();//움직일수 없게 하는 스톱워치
    float cantmove = 1000;//움직일 수 없는 시간

    Vector3 firstpositoin;

    // Start is called before the first frame update
    void Start()
    {
        firstpositoin = transform.position;
        GameManager.score = 0;
        GameManager.timer.Start();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.stopcase!=0)//moveCheck 타이머가 작동중이면
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

        if (moveCheck.ElapsedMilliseconds > 1000 && GameManager.stopcase==1)//움직이지 못하는 시간=cantmove변수
        {
            GameManager.stopcase = 0;
        }

        transform.Translate(haxis * maxspeed*Time.deltaTime, 0, vaxis * maxspeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Car"))
        {
            transform.position = firstpositoin;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        haxis *= 0.7f;
        vaxis *= 0.7f;
        if (collision.gameObject.CompareTag("StopCube"))
        {
            moveCheck.Start();
            Destroy(collision.gameObject);
            GameManager.stopcase = 1;
        }

        if (collision.gameObject.CompareTag("GoodCube"))
        {
            //좋은 영향을 주는 거
            GameManager.score += 100;


            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("FinishCube"))
        {

            //좋은 영향을 주는 거
            GameManager.timer.Stop();

            print(GameManager.timer.ElapsedMilliseconds);

            Destroy(collision.gameObject);
        }
    }
}
