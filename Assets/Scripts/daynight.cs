using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteAlways]
public class daynight : MonoBehaviour
{
    [SerializeField] private Light DirectionalLight;
    [SerializeField] private lightingpresets presets;
    [SerializeField, Range(0,60)] private float TimeOfDay;

    private void UpdateLighting(float timepercent)

    {
        RenderSettings.ambientLight = presets.AmbientColor.Evaluate(timepercent);
        RenderSettings.fogColor = presets.fogcolor.Evaluate(timepercent);

        if (DirectionalLight != null)

        {
            DirectionalLight.color = presets.Directionalcolor.Evaluate(timepercent);
            DirectionalLight.transform.localRotation = Quaternion.Euler(new Vector3((timepercent * 360) - 90, 170, 90));
        }                                //dont mess with this rotation of day and night 
    }
    private void OnValidate()
    {
        if (DirectionalLight != null)

        {
            return;
        }

        if (RenderSettings.sun)

        {
            DirectionalLight = RenderSettings.sun;
        }
        else
        {
            Light[] lights = GameObject.FindObjectsOfType<Light>();

            foreach (Light light in lights)

            {
                if (light.type == LightType.Directional)

                {
                    DirectionalLight = light;
                    return;
                }
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (presets == null)

        {
            return;

        }

        if (Application.isPlaying)

        {
            TimeOfDay += Time.deltaTime;
            TimeOfDay %= 60;                          // add time to day night cycle here and
            UpdateLighting(TimeOfDay / 60f);          // here
        }

        
        else
        {
            UpdateLighting(TimeOfDay / 60f);
        }

        if (TimeOfDay > 46)                        // turns light off at night

        {
            DirectionalLight.intensity = 0f;
        }

        if (TimeOfDay < 46)               //turns light back on at dawn

        {
            DirectionalLight.intensity = 0.7f;
        }
    }
}
