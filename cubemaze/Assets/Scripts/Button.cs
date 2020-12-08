
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public GameObject explain1, explain2, nextbtn1, nextbtn2, redobtn1, redobtn2;
    public void next1()
    {
        explain1.SetActive(false);
        explain2.SetActive(true);
        nextbtn1.SetActive(false);
        nextbtn2.SetActive(true);
        redobtn1.SetActive(false);
        redobtn2.SetActive(true);
    }
    public void redo2()
    {
        explain1.SetActive(true);
        explain2.SetActive(false);
        nextbtn1.SetActive(true);
        nextbtn2.SetActive(false);
        redobtn1.SetActive(true);
        redobtn2.SetActive(false);

    }
    public void mainScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
