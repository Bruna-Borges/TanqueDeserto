using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;


public class AgentManager : MonoBehaviour
{
    //
    public NavMeshAgent agent;
   
    // 
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {
                    agent.SetDestination(hit.point);
            }
        }
    }
}
