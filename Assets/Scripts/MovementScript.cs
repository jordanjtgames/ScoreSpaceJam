using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder;

public class MovementScript : MonoBehaviour
{
    [SerializeField]private float HorSpeed;
    [SerializeField] private float forwardSpeed;
    [SerializeField] private int ShapeIndex = 0;
    [SerializeField] GameObject[] Shapes;
    [SerializeField] float SpeedMul;
    [SerializeField] KeyCode ChangeKey;

    // Update is called once per frame
    void Update()
    {
        ShapeSet();
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
   void  ShapeSet()
    {

        if (Input.GetKeyDown(ChangeKey))
        {
            ShapeIndex++;

        }
        if (ShapeIndex > 2)
        {
            ShapeIndex = 0;

        }
        if (ShapeIndex == 0)
        {
            Shapes[0].SetActive(true);
            Shapes[1].SetActive(false);
            Shapes[2].SetActive(false);
        }
        if (ShapeIndex == 1)
        {
            Shapes[0].SetActive(false);
            Shapes[1].SetActive(true);
            Shapes[2].SetActive(false);
        }
        if (ShapeIndex == 2)
        {
            Shapes[0].SetActive(false);
            Shapes[1].SetActive(false);
            Shapes[2].SetActive(true);
        }
    }

}
