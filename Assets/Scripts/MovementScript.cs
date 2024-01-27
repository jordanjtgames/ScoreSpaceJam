using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder;

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
       

        transform.Translate((new Vector3(horizontal * forwardSpeed, 0f, forwardSpeed * 1f) * Time.deltaTime));
    }
    private void FixedUpdate()
    {
       forwardSpeed += forwardSpeed * Time.deltaTime * SpeedMul;
        forwardSpeed = Mathf.Clamp(forwardSpeed, 10f, 60f);
    }

}
