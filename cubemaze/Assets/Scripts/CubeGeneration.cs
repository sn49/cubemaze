using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CubeGeneration : MonoBehaviour
{

    public List<GameObject> cubedatabase;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(transform.position.x, 0.7f, transform.position.z);
        int random = Random.Range(0, 3);
        Instantiate(cubedatabase[random],transform.position,Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
