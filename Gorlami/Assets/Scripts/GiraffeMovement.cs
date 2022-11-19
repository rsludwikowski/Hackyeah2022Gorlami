using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class GiraffeMovement : MonoBehaviour
{

    public float speed = 5f;
    Rigidbody rb;

    [SerializeField] int HP;

    // Start is called before the first frame update
    void Awake()
    {
        
        rb = gameObject.GetComponent<Rigidbody>();
        Assert.IsNotNull(rb, "The following object is not fully set up: " + name);
        HP = 100;
    }

    // Update is called once per frame
    void FixedUpdate()
    {


        if (Input.GetButton("Fire1"))
        {
            Debug.Log("FIRE!");
        }



        Vector3 MoveVec = new Vector3(Input.GetAxis("Horizontal"),0, Input.GetAxis("Vertical")).normalized;

        MoveVec *= speed * Time.deltaTime;


        rb.MovePosition(rb.position + MoveVec);

    }
}
