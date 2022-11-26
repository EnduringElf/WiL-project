using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameState : MonoBehaviour
{
    public bool IsFishing;
    [Header("Ui prompts")]
    public GameObject EnterPrompt;
    public GameObject ExitPrompt;
    public GameObject FishGameUi;
    
    [Header("Controllers")]
    public GameObject PerfectZoneControls;
    public GameObject ZoneController;
    private FIshingControls FishContrls;
    public GameObject Player;

    [Header("Fish caught Ui")]
    public GameObject FishCaughtUi;
    public Image FishPortrait;
    public TMP_Text FishName;
    public TMP_Text FishWieght;
    public TMP_Text FishPrice;

    public bool CanContinue;
    

    





    //make new class object for fishing spot//

    // Start is called before the first frame update
    void Start()
    {
        FishContrls = Player.GetComponent<FIshingControls>();
        FishCaughtUi.SetActive(true);
        FishPortrait = GameObject.Find("FishPortrait").GetComponent<Image>();
        FishCaughtUi.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (IsFishing == false && Input.GetKeyDown(KeyCode.E))
        {
            Player.GetComponent<playerControls>().Active = false;
            ZoneController.GetComponent<FishSpotContrller>().Active = true;
            Prompt(0);
            StartFishingGame();
        }
        if(IsFishing == true && Input.GetKeyDown(KeyCode.Escape))
        {
            Player.GetComponent<playerControls>().Active = true;
            Prompt(1);
            LeaveMiniGAme();
            FishContrls.enabled = false;
            FishGameUi.SetActive(false);
        }
        if(CanContinue == true && Input.GetMouseButtonDown(0))
        {
            ContinueGame();
        }
        if(CanContinue == true && Input.GetKeyDown(KeyCode.Escape))
        {
            LeaveMiniGAme();
        }
        
    }

    public void CaughtFsih(Fish f)
    {
        Player.GetComponent<Inventory>().InventoryObjects.Add(f);
        FishCaughtUi.SetActive(true);
        FishPortrait.sprite = f.Portrait;
        FishName.text = f.Name;
        FishWieght.text ="Value: R" + f.FinalValue.ToString("n2");
        FishPrice.text = "Wieght:" + f.FinalWieght.ToString("n2") + "KG";
        f.valuescanChange = false;
        StartCoroutine(wait());
        CanContinue = true;

    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(2.0f);
    }

    public void ContinueGame()
    {
        if(CanContinue == true)
        {
            FishCaughtUi.SetActive(false);
            StartFishingGame();
            Prompt(0);
            IsFishing = true;
            CanContinue = false;
        }
    }

    public void LeaveMiniGAme()
    {
        if(CanContinue == true)
        {
            FishCaughtUi.SetActive(false);
            EndFishingGame();
            CanContinue = false;
        }
    }

    public void StartFishingGame()
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
        Player.GetComponent<playerControls>().Active = true;
        Prompt(1);
        FishContrls.enabled = false;
        FishGameUi.SetActive(false);
    }
}
