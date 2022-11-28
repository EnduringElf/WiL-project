using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop_Barrel : MonoBehaviour
{
    public GameObject drop_off_point;
    public GameObject Object_to_drop;

    public int amountDropped;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Drop_barrel();
        }
    }
    public void Drop_barrel()
    {
        GameObject temp =
        Instantiate(Object_to_drop);
        temp.transform.position = drop_off_point.transform.position;
    }
}
