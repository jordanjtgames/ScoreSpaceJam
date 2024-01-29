using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarAdder : MonoBehaviour
{
    ScoreSystem score;

    private void Start()
    {
        score = GameObject.FindObjectOfType<ScoreSystem>();
    }
    private void OnTriggerExit(Collider other)
    {
        score.AddBar();
        Destroy(gameObject);

    }
}
