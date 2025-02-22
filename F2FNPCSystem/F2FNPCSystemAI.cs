using UnityEngine;
using UnityEngine.AI;

public class F2FNPCSystemAI : MonoBehaviour
{


    NavMeshAgent agent;

    Animator animator;

    public GameObject ObjectToFollow;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        agent = GetComponent<NavMeshAgent>();

        animator = GetComponent<Animator>();

        
    }

    // Update is called once per frame
    void Update()
    {


        float Distance = Vector3.Distance(transform.position, ObjectToFollow.transform.position);

        if(Distance < 5)
        {

            // IDLE 

            agent.isStopped = true;

            animator.SetInteger("C", 0);


        }
        else if(Distance >= 5 && Distance < 12)
        {


            // Walk

            agent.isStopped = false;

            animator.SetInteger("C", 1);

            agent.speed = 3;

            agent.SetDestination(ObjectToFollow.transform.position);

        }
        else if(Distance >= 12)
        {


            // Run

            agent.isStopped = false;

            animator.SetInteger("C", 2);

            agent.speed = 6;

            agent.SetDestination(ObjectToFollow.transform.position);

        }



        
    }
}
