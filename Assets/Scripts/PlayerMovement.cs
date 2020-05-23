
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;



    public float forwadForces=2000f;
    public float sidewaysForce=500f;

    public void RightMove(){
         rb.AddForce(sidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
    }
    public void LeftMove(){
         rb.AddForce(-sidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
    }


    // // Start is called before the first frame update
    // void Start()
    // {
    //    rb.AddForce(0,300,500);
    // }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,forwadForces*Time.deltaTime);

        if(Input.GetKey("d"))
        {
            RightMove();
        }
    if(Input.GetKey("a"))
        {
            LeftMove();
        }

        if(rb.position.y < -1f || rb.position.x>20f || rb.position.x<-12f )
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
 