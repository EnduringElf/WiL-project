using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Shop_ui_manager : MonoBehaviour
{
    public GameObject Background;
    public GameObject Template;
    public List<Fish> fish;
    public GameObject TemplateObjectBackground;
    public List<GameObject> CurrentPageObjects;
    public float padding;
    public GameObject player;

    public float backgroundWidth;
    public float objectwidth;
    public float objecthieght;
    public int WidthAmount;
    public float originWidth;
    public float originHieght = 33.8f;
    public int max_objects_per_page = 5;
    public int current_page = 0;



    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
        backgroundWidth = Background.GetComponent<RectTransform>().rect.width;
        objectwidth = TemplateObjectBackground.GetComponent<RectTransform>().rect.width + 5;
        objecthieght = TemplateObjectBackground.GetComponent<RectTransform>().rect.height + 5;
        fish = player.GetComponent<Inventory>().InventoryFish;
        DisplayPage();
    }

    // Update is called once per frame
    void Update()
    {
        fish = player.GetComponent<Inventory>().InventoryFish;
    }

    public void DisplayPage()
    {

        CurrentPageObjects = new List<GameObject>();
        float hieght = originHieght;
        int indexOrigin = current_page * max_objects_per_page;
        for(int i = 0; i + indexOrigin < max_objects_per_page * (current_page+1); i++)
        {
            if(indexOrigin + i < fish.Capacity)
            {
                if (fish[indexOrigin + i] != null)
                {
                    GameObject temp =
                    Instantiate(Template);
                    temp.transform.SetParent(Background.transform);
                    temp.GetComponent<RectTransform>().localPosition
                    = new Vector3(0, hieght - ((objecthieght + padding) * i), 0);
                    CurrentPageObjects.Add(temp);
                    temp.GetComponent<TemplateSellObject>().thisFish = fish[indexOrigin + i];

                }
            }
            
        }

    }

    public void DisplayPage(int currentpage)
    {
        fish = player.GetComponent<Inventory>().InventoryFish;
        CurrentPageObjects = new List<GameObject>();
        float hieght = originHieght;
        int indexOrigin = currentpage * max_objects_per_page;
        for (int i = 0; i + indexOrigin < max_objects_per_page * (current_page + 1); i++)
        {
            if (indexOrigin < 0)
            {
                indexOrigin = 0;
            }
            if (indexOrigin + i < fish.Capacity)
            {
                if (fish[indexOrigin + i] != null)
                {
                    GameObject temp =
                    Instantiate(Template);
                    temp.transform.SetParent(Background.transform);
                    temp.GetComponent<RectTransform>().localPosition
                    = new Vector3(0, hieght - ((objecthieght + padding) * i), 0);
                    CurrentPageObjects.Add(temp);
                    temp.GetComponent<TemplateSellObject>().thisFish = fish[indexOrigin + i];

                }
            }

        }

    }

    public void destroyPage()
    {
        foreach(GameObject i in CurrentPageObjects)
        {
            Destroy(i);
        }
    }

    public void NextPage()
    {
        current_page++;
        int indexOrigin = current_page * max_objects_per_page;
        if (indexOrigin < fish.Capacity && fish[indexOrigin] != null)
        {
            Debug.Log("showing next page");
            destroyPage();
            DisplayPage();
        }
        else
        {
            current_page--;
            Debug.Log("no items in next page");
        }
    }

    public void PrevPage()
    {
        current_page--;
        int indexOrigin = current_page * max_objects_per_page;
        if(indexOrigin < 0)
        {
            current_page++;
            indexOrigin = 0;
            Debug.Log("no items in prev page");
        }
        if (fish[indexOrigin] != null)
        {
            Debug.Log("showing prev page");
            destroyPage();
            DisplayPage();
        }
        else
        {
            current_page++;
            Debug.Log("no items in prev page");
        }
    }

    




}
