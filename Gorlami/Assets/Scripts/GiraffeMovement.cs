using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiraffeMovement : MonoBehaviour
{


    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb  = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        Vector3 MoveVec = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));



    }
}
