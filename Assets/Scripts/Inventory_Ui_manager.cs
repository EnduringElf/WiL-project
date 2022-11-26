using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Inventory_Ui_manager : MonoBehaviour
{
    public GameObject Background;
    public GameObject TemplateObject;
    public GameObject TemplateObjectBackground;
    public List<Fish> inventoryitems;
    public List<GameObject> inventory_objects;
    public float padding;

    public GameObject player;


    [Header("temp")]
    public GameObject test_fish;
    public bool test;

    public float backgroundWidth;
    public float objectwidth;
    public float objecthieght;
    public int WidthAmount;
    public float originWidth;
    public float originHieght = 410;





    // Start is called before the first frame update
    void Start()
    {
        backgroundWidth = Background.GetComponent<RectTransform>().rect.width;
        objectwidth = TemplateObjectBackground.GetComponent<RectTransform>().rect.width + 5;
        objecthieght = TemplateObjectBackground.GetComponent<RectTransform>().rect.height + 5;
        originWidth = (-backgroundWidth / 2) + (objecthieght / 2);
        originWidth += padding;
        WidthAmount =(int)(backgroundWidth / objectwidth);
        inventoryitems = player.GetComponent<Inventory>().InventoryObjects;
        //TemplateObject.GetComponent<RectTransform>().localPosition = new Vector3(originWidth, 410,0);
        DisplayInventory();
        
    }

    // Update is called once per frame
    void Update()
    {
        inventoryitems = player.GetComponent<Inventory>().InventoryObjects;
    }

    public void DisplayInventory()
    {
        float hieght = originHieght;
        int objects = 0;
        foreach (Fish i in inventoryitems) 
        { 
            GameObject temp =
            Instantiate(TemplateObject);
            temp.transform.SetParent(Background.transform);
            if (objects > WidthAmount - 2)
            {
                objects = 0;
                hieght = originHieght - (objecthieght + padding);
            }
            temp.GetComponent<RectTransform>().localPosition
            = new Vector3(originWidth + ((objectwidth+padding) * objects), hieght, 0);
            inventory_objects.Add(temp);
            objects++;
            
            temp.GetComponent<TemplateObjectHolder>().Portrait.GetComponent<Image>().sprite = i.Portrait;
            temp.GetComponent<TemplateObjectHolder>().Name.GetComponent<TMP_Text>().text = i.Name;
            
        }
    }

    public void DestroyInventroy()
    {
        foreach(GameObject i in inventory_objects)
        {
            Destroy(i.gameObject);
        }
    }
}
