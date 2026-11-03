using UnityEngine;
using UnityEngine.AI;

// Write your DeerW5 class in here :)
// Hint: if you don't remember what a class is supposed to look like,
//      maybe check out CatW5...
// If you copied the class declaration from CatW5, you'd only need to change one thing...
public class DeerW5 : MonoBehaviour
{
   private float _MoveSpeed = 1.0f;
   private NavMeshAgent __NavMeshAgent;
  [SerializeField] private Transform __Transform;
private Vector3 movement = Vector3.zero;
private void Start()
    {
       __NavMeshAgent = GetComponent<NavMeshAgent>();

    }
private void Update()
    {
     movement = Vector3.zero;
        transform.Translate(movement * _MoveSpeed * Time.deltaTime);
        SetDestination(__Transform);
    }
public bool SetDestination(Transform Mushroom_red)
    {
        return __NavMeshAgent.SetDestination(Mushroom_red.position);
    }


}