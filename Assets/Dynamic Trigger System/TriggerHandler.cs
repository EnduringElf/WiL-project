using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerHandler : MonoBehaviour
{
    public List<string> onTriggerEnterTag;
    public List<UnityEvent> onTriggerEnter;

    public List<string> onTriggerExitTag;
    public List<UnityEvent> onTriggerExit;
    private void OnTriggerEnter(Collider other)
    {
        if(onTriggerEnter.Count == 1 && onTriggerEnterTag.Count == 0)
        {
            onTriggerEnter[0].Invoke();
            return;

        }
        if (onTriggerEnter.Count != onTriggerEnterTag.Count)
        {
            Debug.LogError("On trigger enter events don't match tags");
            return;
        }
        for(int i = 0; i < onTriggerEnterTag.Count; i++)
        {
            if (other.CompareTag(onTriggerEnterTag[i]))
            {
                onTriggerEnter[i].Invoke();
            } 
                

        }
        
    }


    private void OnTriggerStay(Collider other)
    {
        

    }

    private void OnTriggerExit(Collider other)
    {
        if (onTriggerExit.Count == 1 && onTriggerExitTag.Count == 0)
        {
            onTriggerExit[0].Invoke();
            return;

        }
        if (onTriggerExit.Count != onTriggerExitTag.Count)
        {
            Debug.LogError("On trigger exit events don't match tags");
            return;
        }
        for (int i = 0; i < onTriggerExitTag.Count; i++)
        {
            if (other.CompareTag(onTriggerExitTag[i]))
            {
                onTriggerExit[i].Invoke();
            }


        }


    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
