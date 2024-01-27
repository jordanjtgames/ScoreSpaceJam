using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject Tile;
    Vector3 nextSpawnPoint= new(0,-0.5f,-1);
    void Start()
    {

       for(int i = 0; i < 10; i++)
        {
            SpawnTiles();
        }
        
    }

   public void SpawnTiles()
    {
        GameObject temp = Instantiate(Tile,nextSpawnPoint,Quaternion.identity);
        nextSpawnPoint= temp.transform.GetChild(1).transform.position;


    }
}
