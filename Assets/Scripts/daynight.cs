using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class daynight : MonoBehaviour
{
    [SerializeField] private Light DirectionalLight;
    [SerializeField] private lightingpresets presets;
    [SerializeField, Range(0, 900)] private float TimeOfDay;

    public GameObject obj;

    public bool morning;
    public bool midday;
    public bool afternoon;
    public bool night;
  

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

        morning = true;
        TimeOfDay = 215;
      
    }

    // Update is called once per frame
    void Update()
    {
        
        //DontDestroyOnLoad(daynightPreserve);
        if (Input.GetKeyDown(KeyCode.L))

        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);

            Debug.Log("L pressed");
         
        }
        if (presets == null)
        {
            return;

        }
        if (TimeOfDay == 890)
        {
            obj.GetComponent<Objective>().day++;
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
        
        

        ReportTimeOfDay();
    }



    public void ReportTimeOfDay()

    {
        if (TimeOfDay >= 200 )

        {
            night = false;
            afternoon = false;
            morning = true;
            midday = false;
            

            
        }

        if (TimeOfDay >= 270)

        {
            morning = false;
            night = false;
            midday = true;

            

        }

        if (TimeOfDay >= 620)

        {
            morning = false;
            night = false;
            afternoon = true;
            midday = false;

           

        }
        if (TimeOfDay >= 670)
        {

            afternoon = false;
            night = true;
            midday = false;
            morning = false;
            
         
        }



    }
   
}

