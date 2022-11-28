using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateFishing : MonoBehaviour
{
    
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<playerControls>().GameManager.GetComponent<GameState>().Prompt(true);
            addthisZonetoGameState(other.gameObject);
        }
        else
        {
            //other.GetComponent<playerControls>().GameManager.GetComponent<GameState>().Prompt(false);
        }
    }

    private void addthisZonetoGameState(GameObject t)
    {
        t.GetComponent<playerControls>().GameManager.GetComponent<GameState>().ZoneController = this.gameObject.GetComponentInParent<FishSpotContrller>().gameObject;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.GetComponent<playerControls>().GameManager.GetComponent<GameState>().Prompt(true);
            addthisZonetoGameState(other.gameObject);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {

            other.GetComponent<playerControls>().GameManager.GetComponent<GameState>().Prompt(false);
            other.GetComponent<playerControls>().GameManager.GetComponent<GameState>().ZoneController = null;
        }
    }
}
