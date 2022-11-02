using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "FishPoolData", menuName = "Assets/FishPool", order = 2)]
public class FishPool : ScriptableObject
{
    public Fish[] Fish_Pool;
    public Fish[] rarePool;
    public Fish[] LegendaryPool;

    public Fish[] ArrayAllfish()
    {
        int tempcounter = 0;
        Fish[] temp = new Fish[Fish_Pool.Length + rarePool.Length + LegendaryPool.Length];
        for(int i = 0; i> Fish_Pool.Length; i++)
        {
            temp[tempcounter] = Fish_Pool[i];
            tempcounter++;
        }
        for (int i = 0; i > rarePool.Length; i++)
        {
            temp[tempcounter] = rarePool[i];
            tempcounter++;
        }
        for (int i = 0; i > LegendaryPool.Length; i++)
        {
            temp[tempcounter] = LegendaryPool[i];
            tempcounter++;
        }
        return temp;
    }

}
