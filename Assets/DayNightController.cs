using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightController : MonoBehaviour
{
    public GameObject DaynightScript;
    public GameObject waterScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(DaynightScript.GetComponent<daynight>().morning == true || DaynightScript.GetComponent<daynight>().night)
        {
            waterScript.GetComponent<shader_changer>().BlueColor = false;
            waterScript.GetComponent<shader_changer>().nighttime = true;
        }else if(DaynightScript.GetComponent<daynight>().midday == true || DaynightScript.GetComponent<daynight>().afternoon == true)
        {
            waterScript.GetComponent<shader_changer>().BlueColor = true;
        }





    }
}
