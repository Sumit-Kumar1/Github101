using UnityEngine;
using UnityEngine.AI;

public class CPUPLAYERSCRIPT : MonoBehaviour
{
      public Transform goal;
       private NavMeshAgent agent;
       void Start () {
          agent = GetComponent<NavMeshAgent>();
          agent.destination = goal.position; 
       }
       void Update () {
           agent.speed ++;
       }
}