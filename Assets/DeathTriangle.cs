using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrianlge : MonoBehaviour
{
    PlayerManager player;

    private void Start()
    {
        player = GameObject.FindObjectOfType<PlayerManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (player.Shapes != 1)
        {
            player.isDead = true;
        }
    }
}
