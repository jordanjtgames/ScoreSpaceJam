using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandGen : MonoBehaviour
{
    Spawner spawner;
    private void Start()
    {
        spawner = GameObject.FindObjectOfType<Spawner>();
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Spawning");
        spawner.SpawnTiles();
        spawner.SpawnSlimeRed();
        spawner.SpawnSlimeGreen();
        spawner.SpawnSlimeGreen();

        Destroy(gameObject,2f);
        
    }
}
