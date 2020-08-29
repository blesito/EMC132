using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIEngine : MonoBehaviour
{
    private List<Transform> nodes;

    public Transform Path;
    
    private int CrntNode = 0;
    private float newSteer;
    public float MaxStrAngle = 100f;

    public WheelCollider wheelFL; 
    public WheelCollider WheelFR;
    
    
    // Start is called before the first frame update
    void Start()
    {
        Transform[] PaTra = Path.GetComponentsInChildren<Transform>();

        nodes = new List<Transform>();
        // gets the index for each child in the system
        for(int i = 0; i < PaTra.Length; i++)
        {
            if (PaTra[i] != Path.transform)
            {
                nodes.Add(PaTra[i]);
            }
        }
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        ApplySteer();
        Drive();
        NodeDist();
    }

    private void ApplySteer()
    {   
        Vector3 relativeVector = transform.InverseTransformPoint(nodes[CrntNode].position);
        newSteer = (relativeVector.x / relativeVector.magnitude) * MaxStrAngle;
        wheelFL.steerAngle = newSteer;
        WheelFR.steerAngle = newSteer;
    }

    private void Drive()
    {
        wheelFL.motorTorque = 100f;
        WheelFR.motorTorque = 100f;
    }

    private void NodeDist()
    {
        
        if (Vector3.Distance(transform.position, nodes[CrntNode].position) < 2f)
        {
           
            if (CrntNode == nodes.Count - 1){
                CrntNode = 0;

            }else{
                CrntNode += 1;
                
            }
        }
    }
}
