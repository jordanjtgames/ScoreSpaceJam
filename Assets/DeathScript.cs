using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
     PlayerManager player;

    private void Start()
    {
        player = GameObject.FindObjectOfType<PlayerManager>();  
    }
    private void OnTriggerEnter(Collider other)
    {
        if(player.Shapes != 0)
        {
            player.isDead = true;
        }
    }
}
