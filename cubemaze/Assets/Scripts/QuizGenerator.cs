using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizGenerator : MonoBehaviour
{
    public GameObject quizObject;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(transform.position.x, 0.7f, transform.position.z);
        int random = Random.Range(0, 20);

        if (random < 17)
        {
            Instantiate(quizObject, transform.position, Quaternion.identity);

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
