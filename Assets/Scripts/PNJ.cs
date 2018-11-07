using UnityEngine.AI;
using UnityEngine;

public class PNJ : Character {


    public NavMeshAgent agent;
    public Transform target;

    public PNJ(bool isInteractable, string name) :
        base(isInteractable, name) {}

    public override void Moving()
    {
        
    }

    public override void SetIsInteractable()
    {
        
    }

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = target.position;    
    }

    void Update()
    {

    }
}
