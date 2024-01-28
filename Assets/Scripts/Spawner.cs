using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] Tile;
    [SerializeField] private GameObject Slime;
    [SerializeField]public Vector3 nextSpawnPoint= new(0,-0.5f,0);
    void Start()
    {

       for(int i = 0; i < 3; i++)
        {
            SpawnTiles();
            SpawnSlime();
            SpawnSlime();
            SpawnSlime();

        }

    }

   public void SpawnTiles()
    {
        int i = Random.Range(0, Tile.Length);
        GameObject temp = Instantiate(Tile[i],nextSpawnPoint,Quaternion.identity);
        nextSpawnPoint= temp.transform.GetChild(1).transform.position;


    }

    public void SpawnSlime()
    {
        float x, z;
        x= Random.Range(-4.5f, 4.5f);
        z= Random.Range(0, 40);
        Instantiate(Slime,new(nextSpawnPoint.x -x,0,nextSpawnPoint.z-z),Quaternion.identity);

    }
}
