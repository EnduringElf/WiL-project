using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Inventory : MonoBehaviour
{
    public Fish[] InventoryFish;
    public GameObject InventoryUiWindow;
    public GameObject BackgroundUi;
    public GameObject TemplateObject;
    private GameObject[] InventoryItems;

    public bool MenuOpen;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab) && MenuOpen == false)
        {
            MenuOpen = true;

        }else if(Input.GetKeyDown(KeyCode.Tab) && MenuOpen == true)
        {
            MenuOpen = false;
        }
    }






}
