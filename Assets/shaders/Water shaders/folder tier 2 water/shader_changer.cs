using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shader_changer : MonoBehaviour
{
    public Material WaterTier2;
    public float distance;
    public float maxdistance;

    private void Start()
    {
        Color color = new Color(0, 0, 0);
        WaterTier2.SetColor("Base Color",color);
    }
}
