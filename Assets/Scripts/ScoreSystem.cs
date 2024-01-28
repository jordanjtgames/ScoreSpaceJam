using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] int Slime= 0 ;
    [SerializeField] Slider slider;
    [SerializeField] TMP_Text ScoreText;
    [SerializeField] float ScoreCount = 0 ;
    [SerializeField] MovementScript Shape;
    private void Start()
    {
        ScoreCount= 0 ;
        slider.value = 0;
    }
    public void AddScore() 
    {
        Slime +=10;
        slider.value += 10;
    }
    private void Update()
    {
        ScoreCount = (gameObject.transform.position.z);
        if (slider.value >= slider.maxValue)
        {
            slider.value = 0f;
            Shape.ShapeIndex = Random.Range(0, 2);

        
        }
        ScoreText.SetText(ScoreCount.ToString());

    }

}
