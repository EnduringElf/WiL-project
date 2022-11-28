using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpotContrller : MonoBehaviour
{

    public Fish[] Fishpool;
    public float TimeLeft;
    public float minusProgress;
    public bool Active;

    public GameObject Gamestate;
    public GameObject FishingControls;
    public GameObject PerfectZonecontroller;
    public GameObject Triigger;

    public int temp = 0;

    public Fish GetrandomFish()
    {
        Fish t;
        t = Fishpool[Random.Range(0, Fishpool.Length)];
        t.GetFinalValue();
        t.GetvariableWieght();
        return t;
    }





    // Start is called before the first frame update
    void Start()
    {
        Gamestate = GameObject.Find("player").gameObject;
        FishingControls = GameObject.Find("player").gameObject;
        PerfectZonecontroller = GameObject.Find("PerfectZone");
        


    }

    // Update is called once per frame
    void Update()
    {
        if (Active)
        {
            TimeLeft -= minusProgress * Time.deltaTime;
        }
        if(TimeLeft < 0)
        {
            Gamestate.GetComponent<GameState>().EndFishingGame();
            Destroy(this.gameObject);
        }
    }
}
