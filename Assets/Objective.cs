using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Objective : MonoBehaviour
{
    public float currentDebt = -2600000;
    public float DaysDebt = -120000;
    public int day = 543;

    public GameObject dept;
    public GameObject currentdept;
    public GameObject daydept;

    public GameObject pauseUi;
    public GameObject pauseText;
    bool pause = false;

    private void Update()
    {
        dept.GetComponent<TMP_Text>().text = day.ToString();
        currentdept.GetComponent<TMP_Text>().text = "Debt:R " + currentDebt.ToString();
        daydept.GetComponent<TMP_Text>().text = "Today:R " + DaysDebt.ToString();
        if (Input.GetKeyDown(KeyCode.P) && pause == false)
        {
            pauseUi.SetActive(true);
            pause = true;
        }
        else if(Input.GetKeyDown(KeyCode.P) && pause == true)
        {
            pauseUi.SetActive(false);
            pause = false;
        }
        
    }

    public void updatedebt()
    {
        if (DaysDebt < 0)
        {
            GameOver();
        }
        else
        {
            day++;
            currentDebt += DaysDebt;
            DaysDebt = -day * 200;
        }
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void GameOver()
    {
        pauseUi.SetActive(true);
        pauseText.GetComponent<TMP_Text>().text = "Game Over";
        Time.timeScale = 0f;
    }

    public void Pause()
    {

    }

}
