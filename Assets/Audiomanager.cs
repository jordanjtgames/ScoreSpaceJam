using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audiomanager : MonoBehaviour
{
    [SerializeField] AudioSource Player;
    public void MoveAudio()
    {
        Player.Play();

    }
}
