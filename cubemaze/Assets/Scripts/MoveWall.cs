using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWall : MonoBehaviour
{
    float speed = 5.0f;
    private float sign = -1;

    // Start is called before the first frame update
    void Start()
    {
        //z1 = 0;
        //z2 = speed * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, sign * speed * Time.deltaTime, 0);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BottomWall"))
        {
            sign = sign * (-1);
        }
        if (other.gameObject.CompareTag("TopWall"))
        {
            sign = 0;
            StartCoroutine(DelayCoroutine());
        }
    }
    IEnumerator DelayCoroutine()
    {
        yield return new WaitForSecondsRealtime(5f);
        sign = -1;
    }
}