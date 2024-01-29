using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] Tile;
    [SerializeField] private GameObject Slime;
    [SerializeField]public Vector3 nextSpawnPoint= new(0,-0.424f,69.458f);
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
        nextSpawnPoint= temp.transform.GetChild(0).transform.position;


    }

    public void SpawnSlime()
    {
        float x, z;
        x= Random.Range(-1f, 1f);
        z= Random.Range(0,15);
        Instantiate(Slime,new(nextSpawnPoint.x -x,-0,nextSpawnPoint.z-z),Quaternion.identity);

    }
}
