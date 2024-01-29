using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathSphere : MonoBehaviour
{
    PlayerManager player;

    private void Start()
    {
        player = GameObject.FindObjectOfType<PlayerManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag =="Player")
        {
            if (player.Shapes != 2)
            {
                player.isDead = true;
                Debug.Log("I KILLED");
            }
        }
    }
}
