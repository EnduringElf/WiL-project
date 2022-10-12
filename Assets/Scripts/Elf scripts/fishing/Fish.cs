using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    public string Name;
    public float BaseCurrency;
    public float Wieght;
    public float RandomWieght;

    public float FinalValue;
    
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
