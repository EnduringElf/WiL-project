using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FIshingControls : MonoBehaviour
{
    public GameObject Slider;
    public GameObject PerfectZone;

    public float value;
    public float sliderValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnEnter()
    {
        Slider.GetComponent<Slider>().value = Slider.GetComponent<Slider>().minValue;
    }

    // Update is called once per frame
    void Update()
    {
        sliderValue = Slider.GetComponent<Slider>().value;
        if (Input.GetMouseButton(0))
        {
            Slider.GetComponent<Slider>().value += value * Time.smoothDeltaTime;
        }
        else
        {
            Slider.GetComponent<Slider>().value -= value * Time.smoothDeltaTime;
        }
        PerfectZone.GetComponent<PerfectZoneController>().playerValue = Slider.GetComponent<Slider>().value;
        //Debug.Log(Slider.GetComponent<Slider>().value -= value * Time.deltaTime);
        
    }
}
