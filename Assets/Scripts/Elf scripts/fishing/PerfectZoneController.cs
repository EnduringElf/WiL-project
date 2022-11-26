using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;


public class PerfectZoneController : MonoBehaviour
{
    public GameObject Startpoint;
    public GameObject EndPoint;
    public GameObject FillZone;
    public GameObject GameState;
    public GameObject FishingCntls;

    public  float min;
    public float max;

    public float MTimer;
    private float timer = 0;

    public float playerValue;
    public float progress;
    public float progressValue;
    public float proegreeM;

    float rand;
    float endRand;

    public GameObject completionSlider;


    // Start is called before the first frame update
    void Start()
    {
        min = -350;
        
        max = 350;
    }

    public void NewGame()
    {
        FishingCntls.GetComponent<FIshingControls>().Slider.GetComponent<UnityEngine.UI.Slider>().value = FishingCntls.GetComponent<FIshingControls>().Slider.GetComponent<UnityEngine.UI.Slider>().minValue;
        progress = 0;
        completionSlider.GetComponent<UnityEngine.UI.Slider>().value = 0;
        GetnewPerfectZone();
    }

    private void Update()
    {
        if(progress > proegreeM - 1)
        {
            
            GameState.GetComponent<GameState>().EndFishingGame();
        }
        else
        {
            if (playerValue > rand && playerValue < rand + endRand && progress < proegreeM)
            {
                progress += progressValue;
                completionSlider.GetComponent<UnityEngine.UI.Slider>().value = progress;
                //Debug.Log("progress gained");
            }
            else if (progress > 0)
            {
                progress -= progressValue;
                completionSlider.GetComponent<UnityEngine.UI.Slider>().value = progress;
            }

            if (timer >= MTimer)
            {
                GetnewPerfectZone();
            }
            else
            {
                timer += Time.deltaTime;
            }
        }
        

    }

    private void GetnewPerfectZone()
    {
        rand = Random.Range(min, max - 200);
        //Debug.Log(min);
        endRand = Random.Range(100, 400);


        if (rand + endRand > max)
        {
            endRand = 200;
        }
        //Debug.Log(endRand);

        Startpoint.GetComponent<RectTransform>().localPosition = new Vector3(rand, 0, 0);
        EndPoint.GetComponent<RectTransform>().localPosition = new Vector3(rand + endRand, 0, 0);
        timer = 0;
    }
}
