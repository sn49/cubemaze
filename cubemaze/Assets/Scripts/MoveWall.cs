using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWall : MonoBehaviour
{
    public float speed = 5.0f;
    private float z1, z2;

    // Start is called before the first frame update
    void Start()
    {
        z1 = 0;
        z2 = speed * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(z1, 0, -z2);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BottomWall"))
        {
            Debug.Log("dfedfdsfds");
            speed = 0;
            z2 *= -1;
        }
    }
}
