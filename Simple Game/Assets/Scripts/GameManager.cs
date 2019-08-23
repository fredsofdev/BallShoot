using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject wintText;
    public GameObject restartBtn;

    int score = 0;



    // Update is called once per frame
    void Update()
    {

    }

    public void ScoreUp()
    {
        score++;
        if (score >= 5)
        {
            Win();
        }
    }

    void Win()
    {
        wintText.SetActive(true);
        restartBtn.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleGame");
    }
}
