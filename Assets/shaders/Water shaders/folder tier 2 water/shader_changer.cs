using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
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

    [Header("params")]
    public float ChnageSpeed = 0f;

    private void Start()
    {
        WaterTier2 = this.GetComponent<MeshRenderer>().material;
    }


    private void Update()
    {
        if (BlueColor == true)
        {
            //WaterTier2.SetColor("_Base_Color", BaseBlue);
            //WaterTier2.SetColor("_Deep_Color", DeepBlue);
            //WaterTier2.SetColor("_secondary_color", CellBlue);
            WaterTier2.SetColor("_Base_Color", Color.Lerp(WaterTier2.GetColor("_Base_Color"), BaseBlue, ChnageSpeed * Time.deltaTime));
            WaterTier2.SetColor("_Deep_Color", Color.Lerp(WaterTier2.GetColor("_Deep_Color"), DeepBlue, ChnageSpeed * Time.deltaTime));
            WaterTier2.SetColor("_secondary_color", Color.Lerp(WaterTier2.GetColor("_secondary_color"),CellBlue, ChnageSpeed * Time.deltaTime));


        }
        else if (GreenColor == true)
        {
            //WaterTier2.SetColor("_Base_Color", BaseGreen);
            //WaterTier2.SetColor("_Deep_Color", DeepGreen);
            //WaterTier2.SetColor("_secondary_color", CellGreen);
            WaterTier2.SetColor("_Base_Color", Color.Lerp(WaterTier2.GetColor("_Base_Color"), BaseGreen, ChnageSpeed * Time.deltaTime));
            WaterTier2.SetColor("_Deep_Color", Color.Lerp(WaterTier2.GetColor("_Deep_Color"), DeepGreen, ChnageSpeed * Time.deltaTime));
            WaterTier2.SetColor("_secondary_color", Color.Lerp(WaterTier2.GetColor("_secondary_color"),CellGreen, ChnageSpeed * Time.deltaTime));
        }
        else if (nighttime == true)
        {
            //WaterTier2.SetColor("_Base_Color", BaseNight);
            //WaterTier2.SetColor("_Deep_Color", DeepNight);
            //WaterTier2.SetColor("_secondary_color", CellNight);

            WaterTier2.SetColor("_Base_Color", Color.Lerp(WaterTier2.GetColor("_Base_Color"), BaseNight, ChnageSpeed * Time.deltaTime));
            WaterTier2.SetColor("_Deep_Color", Color.Lerp(WaterTier2.GetColor("_Deep_Color"), DeepNight, ChnageSpeed * Time.deltaTime));
            WaterTier2.SetColor("_secondary_color", Color.Lerp(WaterTier2.GetColor("_secondary_color"), CellNight, ChnageSpeed * Time.deltaTime));
        }
        else
        {
            //WaterTier2.SetColor("_Base_Color", baseColor);
            //WaterTier2.SetColor("_Deep_Color", DeepColor);
            //WaterTier2.SetColor("_secondary_color", CellColor);
            WaterTier2.SetColor("_Base_Color", Color.Lerp(WaterTier2.GetColor("_Base_Color"), baseColor, ChnageSpeed * Time.deltaTime));
            WaterTier2.SetColor("_Deep_Color", Color.Lerp(WaterTier2.GetColor("_Deep_Color"), DeepColor, ChnageSpeed * Time.deltaTime));
            WaterTier2.SetColor("_secondary_color", Color.Lerp(WaterTier2.GetColor("_secondary_color"),CellColor, ChnageSpeed * Time.deltaTime));
        }
        //WaterTier2.SetColor("_Base_Color", Color.Lerp(BaseBlue,BaseNight,Mathf.PingPong(Time.time,1)));
        //WaterTier2.SetColor("_Deep_Color", Color.Lerp(DeepBlue, DeepNight, Mathf.PingPong(Time.time, 1)));
        //WaterTier2.SetColor("_secondary_color", Color.Lerp(CellBlue, CellNight, Mathf.PingPong(Time.time, 1)));

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
