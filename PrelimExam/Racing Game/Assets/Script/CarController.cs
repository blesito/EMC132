using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{

    public Rigidbody TheRB;
    public float  FrwrdAccl = 8f, RvrsAccl = 4f, MaxSpd = 70f, TrnStrgt = 180, GravForce = 10f;
    private float SpdInpt, TrnInpt;

    private bool grounded;
    public LayerMask WhatIsGround;
    public float GroundRayLength = .5f;
    public Transform GroundRayPoint;

    // Start is called before the first frame update
    void Start()
    {
        TheRB.transform.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        SpdInpt = 0f;
        if(Input.GetAxis("Vertical") > 0)
        {
            SpdInpt = Input.GetAxis("Vertical") * FrwrdAccl * 1000f;
        }else if(Input.GetAxis("Vertical") < 0)
        {
            SpdInpt = Input.GetAxis("Vertical") * RvrsAccl * 1000f;
        }

        TrnInpt = Input.GetAxis("Horizontal");
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, TrnInpt * TrnStrgt * Time.deltaTime * Input.GetAxis("Vertical"), 0f));

        transform.position = TheRB.transform.position;
    }

    private void FixedUpdate()
    {
        if(Mathf.Abs(SpdInpt) > 0 )
        {
            TheRB.AddForce(transform.forward * SpdInpt);
        }
    }
}
