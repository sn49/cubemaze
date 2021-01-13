using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PushCube"))
        {
            GameManager.score += 1000;
            Destroy(collision.gameObject);
        }
    }
}
