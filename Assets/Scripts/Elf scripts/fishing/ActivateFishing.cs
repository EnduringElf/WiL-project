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

            other.GetComponent<GameState>().Prompt(true);
            addthisZonetoGameState(other.gameObject);
            
        }
    }

    private void addthisZonetoGameState(GameObject t)
    {
        t.GetComponent<GameState>().ZoneController = this.gameObject.GetComponentInParent<FishSpotContrller>().gameObject;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.GetComponent<GameState>().Prompt(true);
            addthisZonetoGameState(other.gameObject);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {

            other.GetComponent<GameState>().Prompt(false);
            other.GetComponent<GameState>().ZoneController = null;
        }
    }
}
