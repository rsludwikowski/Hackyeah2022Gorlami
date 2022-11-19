using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform toFollow;
    public Vector3 offset = new Vector3(0, 0, 0);
    public float lerpTime = 20f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = toFollow.position + offset;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, toFollow.position + offset, lerpTime);
    }
}