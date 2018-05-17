using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

[RequireComponent(typeof(NavMeshAgent))]
public class Hero : MonoBehaviour {

    private NavMeshAgent _agent;
    public UnityAction OnRun;

    private void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    public void Update()
    {

    }

    public void MoveTo(Vector3 pos)
    {
        _agent.SetDestination(pos);
    }
}