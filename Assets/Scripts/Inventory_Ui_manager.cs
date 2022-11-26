using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory_Ui_manager : MonoBehaviour
{
    public GameObject Background;
    public GameObject TemplateObject;
    public GameObject TemplateObjectBackground;
    public List<GameObject> inventoryitems;
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
        originWidth = (-backgroundWidth / 2) + (objecthieght / 2) + padding;
        WidthAmount =(int)(backgroundWidth / objectwidth);
        //TemplateObject.GetComponent<RectTransform>().localPosition = new Vector3(originWidth, 410,0);
        DisplayInventory();
    }

    // Update is called once per frame
    void Update()
    {
        inventoryitems = player.GetComponent<Inventory>().InventoryObjects;
    }

    void updateInventory()
    {

    }

    void DisplayInventory()
    {


        int objects = 0;
        foreach (GameObject i in inventoryitems) 
        { 
            GameObject temp =
            Instantiate(TemplateObject);
            temp.transform.SetParent(Background.transform);
            temp.GetComponent<RectTransform>().localPosition
            = new Vector3(originWidth + (objectwidth * objects), originHieght, 0);
            if(objects > WidthAmount)
            {
                objects = 0;
                originHieght = originHieght - objecthieght + 5;
            }
            objects++;

        }
    }
}
