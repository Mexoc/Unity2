using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Geekbrains.AI
{
    [RequireComponent (typeof(NavMeshAgent))]
    public class AICharacterController : MonoBehaviour
    {
        private NavMeshAgent _agent;
        [SerializeField]
        private Transform _target;

        // Start is called before the first frame update
        void Start()
        {
            _agent = GetComponent<NavMeshAgent>();
        }

        // Update is called once per frame
        void Update()
        {
            if (_target != null)
            {
                //if (_agent.stoppingDistance < Vector3.Distance(transform.position, _target.position))
                    _agent.SetDestination(_target.position);
            }           
        }

        public void SetTarget(Transform target)
        {
            _target = target;
        }
    }
}
