using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] int score= 0 ;
    public void AddScore() 
    {
        score = score + 1;
    }

}
