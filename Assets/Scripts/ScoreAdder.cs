
using UnityEngine;

public class ScoreAdder : MonoBehaviour
{
    ScoreSystem score;
    private void Start()
    {
        score= GameObject.FindObjectOfType<ScoreSystem>();
    }
    private void OnTriggerExit(Collider other)
    {
        score.AddScore();
        Destroy(gameObject);
        
    }
}
