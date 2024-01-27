using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] Tile;
    [SerializeField]Vector3 nextSpawnPoint= new(0,-0.5f,0);
    void Start()
    {

       for(int i = 0; i < 10; i++)
        {
            SpawnTiles();
        }
        
    }

   public void SpawnTiles()
    {
        int i = Random.Range(0, Tile.Length);
        GameObject temp = Instantiate(Tile[i],nextSpawnPoint,Quaternion.identity);
        nextSpawnPoint= temp.transform.GetChild(1).transform.position;


    }
}
