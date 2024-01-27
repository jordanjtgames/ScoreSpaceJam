using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    [SerializeField]private int HorSpeed;
    [SerializeField] private int forwardSpeed;

    // Update is called once per frame
    void Update()
    {
        Move();

    }
    void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
       

        // Calculate the movement direction
        Vector3 movement = new Vector3(horizontal, 0f, forwardSpeed).normalized;

        // Move the character based on the input
        transform.Translate(movement * HorSpeed * Time.deltaTime);
    }

}
