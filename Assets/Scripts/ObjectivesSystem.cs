using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectivesSystem : MonoBehaviour
{
    private int objectiveCounter = 0;
    public TextMeshProUGUI objectiveScoreText;

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Fishing Spot")
        {
            Debug.Log("Entered Fishing Spot");
            Destroy(other.gameObject);

            objectiveCounter++;
            Debug.Log(objectiveCounter);

            objectiveScoreText.text = $"Score: {objectiveCounter}";
            
        }
    }

}
