using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop_Controller : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.GetComponent<GameState>().PromptShop();
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponent<GameState>().ClosePromptShop();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && other.GetComponent<GameState>().Shop_active == false)
        {
            other.GetComponent<GameState>().PromptShop();
        }
        else if(other.gameObject.tag == "Player")
        {
            other.GetComponent<GameState>().ClosePromptShop();
        }
    }
}
