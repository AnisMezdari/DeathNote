using UnityEngine.AI;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

[RequireComponent(typeof(NavMeshAgent))]
public class PNJ : Character {

    public NavMeshAgent agent;
    public Transform target;
    private Object prefab;
    private const float DISTANCE_TARGET_BC = 3.0f;

    public PNJ(bool isInteractable, string name, Object prefab, Transform target)
        : base(isInteractable, name)
    {
        this.prefab = prefab;
        this.target = target;
    }

    public GameObject Instantiate(Vector3 initialPosition)
    {
        GameObject gameObjectPnj =  Instantiate(prefab, initialPosition, Quaternion.identity) as GameObject;
        gameObjectPnj.GetComponent<PNJ>().target = this.target;
        gameObjectPnj.GetComponent<PNJ>().isInteractable = this.isInteractable;
        gameObjectPnj.GetComponent<PNJ>().name = this.name;

        return gameObjectPnj;
    }

    public override void Moving()
    {
        
    }

    public override void SetIsInteractable()
    {
        
    }
    public void SetTarget(Transform target )
    {
        this.target = target;
    }

    public bool HasSamePositionOfTarget()
    {
        return Vector3.Distance(this.transform.position, target.position) < DISTANCE_TARGET_BC;
    }

    void Start()
    {
        // PathFinfing, permit to initiate the target of moving
        this.agent = GetComponent<NavMeshAgent>();
        this.agent.destination = this.target.position;
        this.transform.GetChild(0).GetChild(0).GetComponent<Text>().text = this.name ;   
    }

    void Update()
    {

        if (HasSamePositionOfTarget())
        {
            transform.Translate(0, 0, 0);
            int randomNumber = Random.Range(1, 10 - 1);
            target = GameObject.Find("Cube" + randomNumber).transform;
            agent.destination = target.position;
        }
        
    }
}
