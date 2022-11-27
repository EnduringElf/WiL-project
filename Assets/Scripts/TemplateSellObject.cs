using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TemplateSellObject : MonoBehaviour
{
    public GameObject Tm_Name;
    public GameObject Tm_Portrait;
    public GameObject Tm_wieght;
    public GameObject Tm_value;
    public Fish thisFish = null;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (thisFish != null)
        {
            Tm_Name.GetComponent<TMP_Text>().text = thisFish.Name;
            Tm_wieght.GetComponent<TMP_Text>().text = thisFish.Wieght.ToString() + " KG";
            Tm_value.GetComponent<TMP_Text>().text = "R " + thisFish.FinalValue.ToString();
            Tm_Portrait.GetComponent<Image>().sprite = thisFish.Portrait;
        }
    }

    public void SellFish()
    {
        if(
        GameObject.Find("player").GetComponent<Inventory>().InventoryFish.Contains(thisFish))
        {
            GameObject.Find("player").GetComponent<Inventory>().InventoryFish.Remove(thisFish);
            GameObject.Find("ShopUi").GetComponent<Shop_ui_manager>().fish.Capacity--;
        }
        GameObject.Find("ShopUi").GetComponent<Shop_ui_manager>().destroyPage();
        GameObject.Find("ShopUi").GetComponent<Shop_ui_manager>().DisplayPage(0);
        Destroy(this.gameObject);
        //return thisFish.FinalValue;
    }
}
