using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Inventory : MonoBehaviour
{
    public List<GameObject> InventoryObjects;
    public GameObject Inventoryui;
    private bool MenuOpen;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab) && MenuOpen == false)
        {
            Inventoryui.SetActive(true);
            MenuOpen = true;

        }else if(Input.GetKeyDown(KeyCode.Tab) && MenuOpen == true)
        {
            Inventoryui.SetActive(false);

            MenuOpen = false;
        }
    }






}
