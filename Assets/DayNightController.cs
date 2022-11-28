using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;


public class DayNightController : MonoBehaviour
{
    public GameObject DaynightScript;
    public GameObject waterScript;

    public Volume global;
    

    public 

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
