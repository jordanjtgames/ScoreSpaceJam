using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder;

public class MovementScript : MonoBehaviour
{
    [SerializeField]private float HorSpeed;
    [SerializeField] private float forwardSpeed;
    public int ShapeIndex = 0;
    [SerializeField] GameObject[] Shapes;
    [SerializeField] float SpeedMul;
    [SerializeField] KeyCode ChangeKey;
   [SerializeField] PlayerManager player;
    Rigidbody rb;

    private void Start()
    {
        rb= GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        if (!player.isDead)
        {
            ShapeSet();
            Move();
        }
        if (player.isDead)
        {
            rb.isKinematic = true;
        }
    }
    void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
       

        rb.velocity = ((new Vector3(horizontal * forwardSpeed, 0f, forwardSpeed * 1f) * Time.deltaTime));
    }
    private void FixedUpdate()
    {
       forwardSpeed += forwardSpeed * Time.deltaTime * SpeedMul;
        forwardSpeed = Mathf.Clamp(forwardSpeed, 1000f, 600000f);
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
