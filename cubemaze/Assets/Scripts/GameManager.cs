using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static Stopwatch timer = new Stopwatch();
    public static int score;
    public int stagescore = 3;

    public Text scoreText;
    public Text timerText;
    public Text stageScoreText;

    public Text answerText;
    public Text questionText;
    public GameObject quizPanel;

    public static int stopcase = 0;
    bool clear = false;
    // Start is called before the first frame update
    void Start()
    {
        stageScoreText.text="";
        quizPanel.SetActive(false);
    }

// Update is called once per frame
    void Update()
    {
        if (!timer.IsRunning && !clear)
        {

            clear = true;
            GetStageScore();
        }
        else
        {
            scoreText.text = score.ToString();
            timerText.text = (timer.ElapsedMilliseconds / 1000).ToString();
        }

        if (stopcase == 2&&!quizPanel.activeSelf)
        {
            quizPanel.SetActive(true);
            questionText.text = quiz.question;
        }
        else if(stopcase == 0 && quizPanel.activeSelf)
        {
            quizPanel.SetActive(false);
            
        }
    }

    public void GetStageScore()
    {
        int timescore;
        int scorescore;

        int checktime = Mathf.FloorToInt(timer.ElapsedMilliseconds / 1000 / 30);

        if (checktime < 4)
        {
            timescore = 3;
        }
        else if (checktime < 5)
        {
            timescore = 2;
        }
        else if (checktime < 6)
        {
            timescore = 1;
        }
        else
        {
            timescore = 0;
        }


        if (score >=2200)
        {
            scorescore = 3;
        }
        else if (score >= 1300)
        {
            scorescore = 2;
        }
        else if (score >= 200)
        {
            scorescore = 1;
        }
        else
        {
            scorescore = 0;
        }

        


        stageScoreText.text="Your score is...  "+(scorescore+timescore).ToString();
    }

    public void SubmitClick()
    {
        answerText.text = "";
        answersubmit.SubmitAnswer(answerText.text);
    }
}
