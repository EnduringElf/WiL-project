using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldFish : MonoBehaviour
{
    public FishPool[] FishPools;
    public bool newGame;

    public GameObject[] SpawnSpots;
    public GameObject FishingSpotSpawn;
    

    // Start is called before the first frame update
    void Start()
    {
        SpawnSpots = GameObject.FindGameObjectsWithTag("Fishing Spot");
        foreach(GameObject i in SpawnSpots)
        {
            //Debug.Log("spawning fishing spots at " + i.transform.position);
            Instantiate(FishingSpotSpawn, i.transform);
        }
        
        if (newGame == true)
        {
            for (int i = 0; i < SpawnSpots.Length;i++)
            {
                if(FishPools[Random.Range(0, FishPools.Length)] != null)
                {
                    SpawnSpots[i].GetComponentInChildren<FishSpotContrller>().Fishpool =
                        FishPools[0].Fish_Pool;
                }
                else
                {
                    i--;
                }
                
            }
        }
        GameObject.Find("PerfectZone").SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
