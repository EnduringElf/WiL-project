using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpotContrller : MonoBehaviour
{

    public Fish[] Fishpool;
    public float TimeLeft;
    public bool Active;

    public GameObject Gamestate;
    public GameObject FishingControls;
    public GameObject PerfectZonecontroller;
    public GameObject Triigger;





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Active)
        {
            TimeLeft -= Time.deltaTime;
        }
        if(TimeLeft < 0)
        {
            Gamestate.GetComponent<GameState>().EndFishingGame();
            Destroy(this.gameObject);
        }
    }
}
