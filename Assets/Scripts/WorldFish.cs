using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldFish : MonoBehaviour
{
    public FishPool[] FishPools;
    public bool newGame;

    public GameObject[] SpawnSpots;
    

    // Start is called before the first frame update
    void Start()
    {
        SpawnSpots = GameObject.FindGameObjectsWithTag("Fishing Spot");
        if (newGame == true)
        {
            for (int i = 0; i > SpawnSpots.Length;i++)
            {
                SpawnSpots[i].GetComponent<FishSpotContrller>().Fishpool = FishPools[Random.Range(0, FishPools.Length)].ArrayAllfish();
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
