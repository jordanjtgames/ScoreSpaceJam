
using UnityEngine;


public class ScoreAdder : MonoBehaviour
{
    ScoreSystem score;
    Audiomanager audio;
   
    private void Start()
    {
        score= GameObject.FindObjectOfType<ScoreSystem>();
        audio = GameObject.FindObjectOfType<Audiomanager>();
    }
    private void OnTriggerExit(Collider other)
    {
        score.AddScore();
        Destroy(gameObject);
        audio.GreenSlimeCollect();
    }
}
