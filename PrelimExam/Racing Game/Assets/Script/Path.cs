using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    public Color LineColor;
    private List<Transform> Nodes = new List<Transform>();

    void OnDrawGizmos()
    {
        Gizmos.color = LineColor;
        Transform[] PathTransform = GetComponentsInChildren<Transform>();
        Nodes = new List<Transform>();

        for(int i = 0; i < PathTransform.Length; i++)
        {
            if(PathTransform[i] != transform)
            {
                Nodes.Add(PathTransform[i]);
            }
        }
        for(int i = 0; i <Nodes.Count; i++)
        {
            Vector3 CurrentNode = Nodes[i].position;
            Vector3 PreviuosNode = Vector3.zero;

            if (i > 0 )
            {
                PreviuosNode = Nodes[i - 1].position;
            } else if(i == 0 && Nodes.Count > 1)
            {
                PreviuosNode = Nodes[Nodes.Count - 1].position;
            }
            Gizmos.DrawLine(PreviuosNode, CurrentNode);
            Gizmos.DrawWireSphere(CurrentNode, 0.3f);

        }

        
    }
}
