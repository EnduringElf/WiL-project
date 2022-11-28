using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;


public class DayNightController : MonoBehaviour
{
    public GameObject DaynightScript;
    public GameObject waterScript;

    public GameObject player;
    

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<Drop_Barrel>().amountDropped >= 50)
        {
            if (DaynightScript.GetComponent<daynight>().morning == true || DaynightScript.GetComponent<daynight>().night)
            {
                waterScript.GetComponent<shader_changer>().GreenColor = false;
                waterScript.GetComponent<shader_changer>().nighttime = true;
            }
            else if (DaynightScript.GetComponent<daynight>().midday == true || DaynightScript.GetComponent<daynight>().afternoon == true)
            {
                waterScript.GetComponent<shader_changer>().GreenColor = true;
            }
        }
        else
        {
            if (DaynightScript.GetComponent<daynight>().morning == true || DaynightScript.GetComponent<daynight>().night)
            {
                waterScript.GetComponent<shader_changer>().BlueColor = false;
                waterScript.GetComponent<shader_changer>().nighttime = true;
            }
            else if (DaynightScript.GetComponent<daynight>().midday == true || DaynightScript.GetComponent<daynight>().afternoon == true)
            {
                waterScript.GetComponent<shader_changer>().BlueColor = true;
            }
        }
        

        



    }
}
