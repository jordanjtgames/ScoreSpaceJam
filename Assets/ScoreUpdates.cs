using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUpdates : MonoBehaviour
{
    [SerializeField] TMP_Text Scoretext;
    void Start()
    {
        Scoretext.text = ("Score: ")+StaticScore.Score.ToString();
    }

} 
