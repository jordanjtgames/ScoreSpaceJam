using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    [SerializeField]private float HorSpeed;
    [SerializeField] private float forwardSpeed;

    [SerializeField] float SpeedMul;

    // Update is called once per frame
    void Update()
    {
        Move();

    }
    void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
       

        // Calculate the movement direction
       // Vector3 movement = new Vector3(horizontal, 0f, 1f).normalized;

        // Move the character based on the input
        transform.Translate(new Vector3(horizontal * HorSpeed, 0f, forwardSpeed * 1f) * Time.deltaTime);
    }
    private void FixedUpdate()
    {
       forwardSpeed += forwardSpeed * Time.deltaTime * SpeedMul;
    }

}
