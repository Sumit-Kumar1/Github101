using UnityEngine;
using UnityEngine.AI;

public class CPUPLAYERSCRIPT : MonoBehaviour
{
      public Transform goal;
       private NavMeshAgent agent;
       void Start () {
            agent = GetComponent<NavMeshAgent>();
            Vector3 position = goal.position;
            agent.destination = position; 
       }
       void Update () {
           agent.speed ++;
       }
}