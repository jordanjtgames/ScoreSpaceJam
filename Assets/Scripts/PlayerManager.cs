using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] MovementScript Shape;
    public bool isDead = false;
    public int Shapes;
    private void Update()
    {
        Shapes = Shape.ShapeIndex;   
    }

}
