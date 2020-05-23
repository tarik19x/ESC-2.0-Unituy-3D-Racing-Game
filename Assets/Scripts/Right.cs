using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Right : MonoBehaviour
{
    public Rigidbody rb;

    public float forwadForces=2000f;
    public float sidewaysForce=500f;

    public void right(){
         rb.AddForce(sidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
    }


}
