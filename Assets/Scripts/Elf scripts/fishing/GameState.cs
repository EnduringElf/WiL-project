using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameState : MonoBehaviour
{
    public bool IsFishing;

    public GameObject EnterPrompt;
    public GameObject ExitPrompt;

    public GameObject FishGameUi;

    public GameObject PerfectZoneControls;

    public GameObject ZoneController;

    private FIshingControls FishContrls;
    
    

    

    //make new class object for fishing spot//

    // Start is called before the first frame update
    void Start()
    {
        FishContrls = GetComponent<FIshingControls>();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsFishing == false && Input.GetKeyDown(KeyCode.E))
        {
            gameObject.GetComponent<playerControls>().Active = false;
            ZoneController.GetComponent<FishSpotContrller>().Active = true;
            Prompt(0);
            StartFishingGame();
        }
        if(IsFishing == true && Input.GetKeyDown(KeyCode.Escape))
        {
            gameObject.GetComponent<playerControls>().Active = true;
            Prompt(1);
            FishContrls.enabled = false;
            FishGameUi.SetActive(false);
        }
    }

    private void StartFishingGame()
    {
        FishGameUi.SetActive(true);
        PerfectZoneControls.GetComponent<PerfectZoneController>().NewGame();
        FishContrls.enabled = true;
        
        
    }

    public void Prompt(bool activate)
    {
        if (IsFishing == false && activate == true)
        {
            if (activate == true)
            {
                EnterPrompt.SetActive(true);
                
            }
            else
            {
                EnterPrompt.SetActive(false);
                
            }
        }
        else
        {
            EnterPrompt.SetActive(false);
        }
    }

    public void Prompt(int i)
    {
        if(i == 0)
        {
            ExitPrompt.SetActive(true);
            IsFishing = true;
        }
        else
        {
            ExitPrompt.SetActive(false);
            IsFishing = false;
        }
    }

    public void EndFishingGame()
    {
        gameObject.GetComponent<playerControls>().Active = true;
        Prompt(1);
        FishContrls.enabled = false;
        FishGameUi.SetActive(false);
    }
}
