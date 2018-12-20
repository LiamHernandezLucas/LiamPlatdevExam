using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TargetTest : MonoBehaviour {
    [SerializeField]
    GameObject _target;

    NavMeshAgent _agent;

    private void Start()
    {
        _agent = this.GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        _agent.destination = _target.transform.position;
    }
}
