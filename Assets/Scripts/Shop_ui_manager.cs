using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop_ui_manager : MonoBehaviour
{
    public GameObject Background;
    public GameObject Template;
    public List<Fish> fish;
    public GameObject TemplateObjectBackground;
    public List<GameObject> inventory_objects;
    public float padding;
    public GameObject player;

    public float backgroundWidth;
    public float objectwidth;
    public float objecthieght;
    public int WidthAmount;
    public float originWidth;
    public float originHieght = 410;



    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
        backgroundWidth = Background.GetComponent<RectTransform>().rect.width;
        objectwidth = TemplateObjectBackground.GetComponent<RectTransform>().rect.width + 5;
        objecthieght = TemplateObjectBackground.GetComponent<RectTransform>().rect.height + 5;
        fish = player.GetComponent<Inventory>().InventoryFish;
    }

    // Update is called once per frame
    void Update()
    {
        
    }



}
