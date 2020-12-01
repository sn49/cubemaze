using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quiz : MonoBehaviour
{
    public static int answer = 0;
    public static string question = "";


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
        
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.stopcase = 2;
            int number1 = Random.Range(0, 250);
            int number2 = Random.Range(0, 150);
            int number3 = Random.Range(0, 50);

            int calcase;

            float result= Random.Range(0.0f, 100.0f);

            int docount;

            if (result < 10)
            {
                docount = 2;
            }
            else
            {
                docount = 1;
            }

            for(int i=0; i<docount; i++)
            {
                result = Random.Range(0.0f, 100.0f);

                if (result < 40)
                {
                    calcase = 1;
                }
                else if (result < 70)
                {
                    calcase = 2;

                }
                else if (result < 85)
                {
                    calcase = 3;

                }
                else
                {
                    calcase = 4;

                }

                if (i == 0)
                {
                    switch (calcase)
                    {
                        case 1:answer = number1 + number2; question = $"({number1}+{number2})"; break;
                        case 2:answer = number1 - number2; question = $"({number1}-{number2})"; break;
                        case 3:answer = number1 * number2; question = $"({number1}*{number2})"; break;
                        case 4:answer = Mathf.FloorToInt(number1 / number2); question = $"({number1}//{number2})"; break;
                    }
                }
                else
                {
                    switch (calcase)
                    {
                        case 1: answer = answer + number3; question += $"+{number3}"; break;
                        case 2: answer = answer - number3; question += $"-{number3}"; break;
                        case 3: answer = answer * number3; question += $"*{number3}"; break;
                        case 4: answer = Mathf.FloorToInt(answer / number3); question += $"//{number3}"; break;
                    }
                }
                
            }

            
        }
    }
}
