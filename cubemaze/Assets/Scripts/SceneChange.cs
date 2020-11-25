﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void ShowExplain()
    {
        SceneManager.LoadScene("ExplainScene");
    }
}
