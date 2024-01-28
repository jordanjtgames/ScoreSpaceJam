using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] MovementScript Shape;
    [SerializeField] Spawner spawner;
    [SerializeField] KeyCode ResetKey;
    GameObject[] Tiles;
    public bool isDead = false;
    public int Shapes;
    private void Update()
    {
        Shapes = Shape.ShapeIndex;
        ResetPlayer();
       
    }
    public void ResetPlayer()
    {
        if (Input.GetKeyDown(ResetKey))
        {
            /*
            spawner.nextSpawnPoint = new(0, -0.5f, 0);
            Tiles = GameObject.FindGameObjectsWithTag("Tiles");
            for (int i = 0; i < Tiles.Length; i++)
            {
                Destroy(Tiles[i]);

            }
            for (int i = 0; i < 4; i++)
            {
                spawner.SpawnSlime();
                spawner.SpawnTiles();
            }*/
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);

        }
    

    }
}
