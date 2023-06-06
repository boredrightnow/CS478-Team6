using UnityEngine;
using UnityEngine.AI;
using System.Collections;


public class Patrol : MonoBehaviour
{

    // Array of waypoints to walk from one to the next one
    [SerializeField]
    private Transform[] waypoints;

    // Walk speed that can be set in Inspector
    [SerializeField]
    private float moveSpeed = 2f;

    // Index of current waypoint from which Enemy walks
    // to the next one
    private int waypointIndex = 0;
    private Animator animator;
    bool collided;
    public GameObject player;

    // Use this for initialization
    private void Start()
    {

        // Set position of Enemy as position of the first waypoint
        transform.position = waypoints[waypointIndex].transform.position;
    }
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {

        // Move Enemy
        Move();

        if (collided == true)
        {
            
            Vector2 tele = new Vector2(-7, -12);
            player.transform.position = tele;
            
            collided = false;
        }


    }

    // Method that actually make Enemy walk
    private void Move()
    {
        

            // Move Enemy from current waypoint to the next one
            // using MoveTowards method
            transform.position = Vector2.MoveTowards(transform.position,
               waypoints[waypointIndex].transform.position,
               moveSpeed * Time.deltaTime);
        animator.SetBool("IsWalk", true);

        // If Enemy reaches position of waypoint he walked towards
        // then waypointIndex is increased by 1
        // and Enemy starts to walk to the next waypoint
        if (transform.position == waypoints[waypointIndex].transform.position)
            {
                
                if(waypointIndex>=waypoints.Length-1)
                {
                waypointIndex = 0;
                }
                else
                    waypointIndex += 1;
            }
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            collided = true;
        }
    }
}