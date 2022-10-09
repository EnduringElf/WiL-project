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
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.GetComponent<GameState>().Prompt(true);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {

            other.GetComponent<GameState>().Prompt(false);
        }
    }
}
