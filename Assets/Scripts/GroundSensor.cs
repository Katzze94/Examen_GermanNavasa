using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
   public bool isGrounded;
   PlayerMovement playerScript;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Awake()
    {
        playerScript = GetComponentInParent<PlayerMovement>();
    }


    void OnTriggerEnter2D(Collider2D Collider)

    {
        isGrounded = true;
    }

    void OnTriggerExit2D(Collider2D Collider)

    {
        isGrounded = false;
    }




}
