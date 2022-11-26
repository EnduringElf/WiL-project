using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shader_changer : MonoBehaviour
{
    public Material WaterTier2;
    [Header("Override colors")]
    public Color baseColor;
    public Color DeepColor;
    public Color CellColor;

    [Header("Presets: Blue")]
    public bool BlueColor;
    public Color BaseBlue;
    public Color DeepBlue;
    public Color CellBlue;
    [Header("Presets: Green")]
    public bool GreenColor;
    public Color BaseGreen;
    public Color DeepGreen;
    public Color CellGreen;
    [Header("Presets: Night")]
    public bool nighttime;
    public Color BaseNight;
    public Color DeepNight;
    public Color CellNight;
    public float ChangeSpeed;
    public float aplha;
    public float Min_alpha;




    private void Update()
    {
        if(BlueColor == true)
        {
            WaterTier2.SetColor("_Base_Color", BaseBlue);
            WaterTier2.SetColor("_Deep_Color", DeepBlue);
            WaterTier2.SetColor("_secondary_color", CellBlue);
        }
        else if(GreenColor == true)
        {
            WaterTier2.SetColor("_Base_Color", BaseGreen);
            WaterTier2.SetColor("_Deep_Color", DeepGreen);
            WaterTier2.SetColor("_secondary_color", CellGreen);
        }
        else if (nighttime == true)
        {
            WaterTier2.SetColor("_Base_Color", BaseNight);
            WaterTier2.SetColor("_Deep_Color", DeepNight);
            WaterTier2.SetColor("_secondary_color", CellNight);
        }
        else
        {
            WaterTier2.SetColor("_Base_Color", baseColor);
            WaterTier2.SetColor("_Deep_Color", DeepColor);
            WaterTier2.SetColor("_secondary_color", CellColor);
        }

        if (nighttime & aplha > Min_alpha)
        {
            aplha -= ChangeSpeed * Time.deltaTime;
        }
        else if (!nighttime && aplha < 1)
        {
            aplha += ChangeSpeed * Time.deltaTime;
        }

        //WaterTier2.SetFloat("_Alpha", aplha);





    }
}
