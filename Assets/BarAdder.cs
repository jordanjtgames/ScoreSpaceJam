using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarAdder : MonoBehaviour
{
    ScoreSystem score;
    Audiomanager audio;

    private void Start()
    {
        score = GameObject.FindObjectOfType<ScoreSystem>();
        audio = GameObject.FindObjectOfType<Audiomanager>();
    }
    private void OnTriggerExit(Collider other)
    {
        score.AddBar();
        Destroy(gameObject);
        audio.RedSlimeCollect();


    }
}
