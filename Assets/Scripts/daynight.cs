using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class daynight : MonoBehaviour
{
    [SerializeField] private Light DirectionalLight;
    [SerializeField] private lightingpresets presets;
    [SerializeField, Range(0, 900)] private float TimeOfDay;
   
    //spawn spots
 
    GameObject a;
    GameObject b;
    GameObject c;
    GameObject d;
    GameObject e;
    GameObject f;
    GameObject g;
    GameObject h;
    GameObject i;
    public GameObject DarkFishWater;
    public bool IsFIshing = false;
  

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
    
 
        TimeOfDay = 215;
        a = GameObject.Find("FishingSpotSpawner");
        b = GameObject.Find("FishingSpotSpawner (1)");
        c = GameObject.Find("FishingSpotSpawner (2)");
        d = GameObject.Find("FishingSpotSpawner (3)");
        e = GameObject.Find("FishingSpotSpawner (4)");
        f = GameObject.Find("FishingSpotSpawner (5)");
        g = GameObject.Find("FishingSpotSpawner (6)");
        h = GameObject.Find("FishingSpotSpawner (7)");
        i = GameObject.Find("FishingSpotSpawner (8)");

        Instantiate(DarkFishWater, a.transform.position, Quaternion.identity);

        float randomNumber = Random.Range(1, 4);
      

      


        if (randomNumber == 1)

        {
            Instantiate(DarkFishWater, a.transform.position, Quaternion.identity);
            Instantiate(DarkFishWater, e.transform.position, Quaternion.identity);
            Instantiate(DarkFishWater, g.transform.position, Quaternion.identity);
        }
        else if (randomNumber == 2)
        {
            Instantiate(DarkFishWater, b.transform.position, Quaternion.identity);
            Instantiate(DarkFishWater, i.transform.position, Quaternion.identity);
            Instantiate(DarkFishWater, d.transform.position, Quaternion.identity);
        }
        else if (randomNumber == 3)
        {
            Instantiate(DarkFishWater, c.transform.position, Quaternion.identity);
            Instantiate(DarkFishWater, h.transform.position, Quaternion.identity);
            Instantiate(DarkFishWater, f.transform.position, Quaternion.identity);
        }
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
            TimeOfDay %= 900;                          // add time to day night cycle here and
            UpdateLighting(TimeOfDay / 900f);          // here
        }


        else
        {
            UpdateLighting(TimeOfDay / 900f);
        }

        if (TimeOfDay > 46)                        // turns light off at night

        {
            DirectionalLight.intensity = 0f;
        }

        if (TimeOfDay < 700)               //turns light back on at dawn

        {
            DirectionalLight.intensity = 0.7f;
        }
    }

   
}

