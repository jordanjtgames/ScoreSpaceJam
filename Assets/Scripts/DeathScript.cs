using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
     PlayerManager player;
    MovementScript Shape;

    private void Start()
    {
        player = GameObject.FindObjectOfType<PlayerManager>();  
        Shape = GameObject.FindObjectOfType<MovementScript>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (player.Shapes != 0)
            {
                player.isDead = true;
                Debug.Log("I KILLED AT"+player.transform.position);

            }
        }
    }
}
