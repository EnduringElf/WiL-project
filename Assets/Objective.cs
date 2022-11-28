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

    private void Update()
    {
        dept.GetComponent<TMP_Text>().text = day.ToString();
        currentdept.GetComponent<TMP_Text>().text = "Debt:R " + currentDebt.ToString();
        daydept.GetComponent<TMP_Text>().text = "Today:R " + DaysDebt.ToString();

        
    }

    public void updatedebt()
    {
        if (DaysDebt! > 0)
        {
            GameOver();
        }
        else
        {
            day++;
            currentDebt += DaysDebt;
        }
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void GameOver()
    {

    }

    public void Pause()
    {

    }

}
