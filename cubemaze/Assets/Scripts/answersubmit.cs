using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class answersubmit : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void SubmitAnswer(string answer)
    {
        print(answer);
        print(quiz.answer.ToString());
        GameManager.stopcase = 0;
        if (answer.Equals(quiz.answer.ToString()))
        {
            GameManager.score += 50;
            Destroy(GameManager.quizObject);
        }
    }
}
