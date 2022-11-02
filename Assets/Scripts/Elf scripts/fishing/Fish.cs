using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "FishData", menuName = "Assets/Fish", order = 1)]
public class Fish : ScriptableObject
{
    public string Name;
    public float BaseCurrency;
    public float Wieght;
    public float RandomWieght;

    public float FinalValue;

    public Fish(string name, float baseCurrency, float wieght)
    {
        Name = name;
        BaseCurrency = baseCurrency;
        Wieght = wieght;
    }

    public float GetvariableWieght()
    {
        Wieght = Wieght + Random.Range(0, RandomWieght);
        return Wieght;
    }

    public void GetFinalValue()
    {
        FinalValue = BaseCurrency * GetvariableWieght();
    }

    


    
}
