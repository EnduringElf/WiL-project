using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Objective : MonoBehaviour
{
    public int currentDebt = -2600000;
    public int DaysDebt = -120000;
    public int day = 543;

    public GameObject dept;
    public GameObject currentdept;
    public GameObject daydept;

    private void Update()
    {
        dept.GetComponent<TMP_Text>().text = day.ToString();
        currentdept.GetComponent<TMP_Text>().text = "Curtrent Debt: R " + currentDebt.ToString();
        daydept.GetComponent<TMP_Text>().text = "Todays debt: R " + DaysDebt.ToString();
    }

}
