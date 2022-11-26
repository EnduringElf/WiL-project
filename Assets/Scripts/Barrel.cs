using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BarrelData", menuName = "Assets/barrel", order = 2)]
public class Barrel : Item
{
    public float wieght;
    public float minW;
    public float maxW;
    public Barrel()
    {
        
    }
    
    public void Oncreate()
    {
        wieght = Random.Range(minW, maxW);
    }
    
}
