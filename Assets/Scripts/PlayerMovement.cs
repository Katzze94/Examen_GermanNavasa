using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rBody;

    public float jumpForce = 5;

    public float movementSpeed = 10;

    public bool jump = false;

    public SpriteRenderer render;

    public float inputHorizontal;

    public GroundSensor sensor;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        rBody = GetComponent<Rigidbody2D>();
        render = GetComponent<SpriteRenderer>();
    }


    // Update is called once per frame
    void Update()
    {
        inputHorizontal = Input.GetAxis("Horizontal");

        if(Input.GetButtonDown("Jump") && sensor.isGrounded == true)
       
        {
        rBody.AddForce(new Vector2(0,1) * jumpForce, ForceMode2D.Impulse);
        }

        if(inputHorizontal < 0)
        {render.flipX = true;}
   
       
        if(inputHorizontal > 0)
       
       {render.flipX = false;}
        

    

    }

    
    void FixedUpdate()
    {
        rBody.velocity = new Vector2(inputHorizontal * movementSpeed, rBody.velocity.y);
    }
}
