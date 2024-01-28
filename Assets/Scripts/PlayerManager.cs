using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] MovementScript Shape;
   // [SerializeField] Spawner spawner;
    [SerializeField] KeyCode ResetKey;
    GameObject[] Tiles;
    public bool isDead = false;
    public int Shapes;
    private void Update()
    {
        Shapes = Shape.ShapeIndex;
        ResetPlayer();
        Debug.Log(isDead);
       
    }
    public void ResetPlayer()
    {
        if (Input.GetKeyDown(ResetKey))
        {
          
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);

        }
    

    }
}
