using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "FishData", menuName = "Assets/Fish", order = 1)]
public class Fish : ScriptableObject
{
    [Header("Name")]
    public string Name;
    [Header("Portrait")]
    public Image Portrait;
    [Header("Values")]
    public float BaseCurrency;
    public float Wieght;
    public float MAxRandomWieght;
    public float FinalWieght;
    public float FinalValue;

    public bool valuescanChange = true;

    public Fish(string name, float baseCurrency, float wieght)
    {
        Name = name;
        BaseCurrency = baseCurrency;
        Wieght = wieght;
    }

    

    public float GetvariableWieght()
    {
        if(valuescanChange == true)
        {
            FinalWieght = Wieght + Random.Range(0, MAxRandomWieght);
            FinalWieght = (float)Mathf.Round(FinalWieght * 100f) / 100f;
            return FinalWieght;
        }
        return FinalWieght;

    }

    public float GetFinalValue()
    {
        if (valuescanChange == true)
        {
            FinalValue = BaseCurrency * GetvariableWieght();
            FinalValue = (float)Mathf.Round(FinalValue * 100f) / 100f;
            return FinalValue;
        }
        return FinalValue;
           
    }

    


    
}
