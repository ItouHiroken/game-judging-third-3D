using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(Rigidbody))]
public class MoveToClickPoint : MonoBehaviour
{
    NavMeshAgent _agent;
    Rigidbody _rigidbody;
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            
            _rigidbody.velocity= Vector3.zero;//条件文で自分がノックアップだったりの条件がなかったらって書く
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                _agent.destination = hit.point;
            }
        }
    }
}
