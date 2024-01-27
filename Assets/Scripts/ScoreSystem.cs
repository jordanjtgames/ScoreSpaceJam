using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] int score= 0 ;
    [SerializeField] Slider slider;
    private void Start()
    {
        slider.value = 0;
    }
    public void AddScore() 
    {
        score++;
        slider.value++;
    }
    private void Update()
    {
       
        if (slider.value >= slider.maxValue)
        {
            slider.value = 0f;
        
        }

    }

}
