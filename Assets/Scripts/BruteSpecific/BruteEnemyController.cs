using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BruteEnemyController : MonoBehaviour
{
    // public references to other scripts
    public BruteHealthBar healthBar;
    public BruteMovement characterMovement;
    public UnityEngine.AI.NavMeshAgent agent;
    public XPBar xPBar;

    // public float variables
    public float startWaitTime = 3;
    public float timeToRotate = 1;
    public float walkSpeed = 6;
    public float runSpeed = 15;
    public float enemyHealth = 5;
    public float viewRadius = 15;
    public float viewAngle = 180;
    public float meshResolution = 1.0f;
    public float edgeDistance = 0.5f;

    public LayerMask playerMask;
    public LayerMask obstacleMask;

    // public integer variables
    public int edgeIterations = 4;
    public int kills;

    public Transform[] waypoints;
    int m_CurrentWaypointIndex;

    Vector3 playerLastPosition = Vector3.zero;
    Vector3 m_PlayerPosition;

    // private float variables
    float m_WaitTime;
    float m_TimeToRotate;

    // private bool variables
    bool m_playerInRange;
    bool m_PlayerNear;
    bool m_IsPatrol;
    bool m_CaughtPlayer;
    bool attacking;

    void Start()
    {
        // assigning variables with values
        m_PlayerPosition = Vector3.zero;
        m_IsPatrol = true;
        m_CaughtPlayer = false;
        m_playerInRange = false;
        m_PlayerNear = false;
        attacking = false;
        m_WaitTime = startWaitTime;
        m_TimeToRotate = timeToRotate;

        m_CurrentWaypointIndex = 0;
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();

        agent.isStopped = false;
        agent.speed = walkSpeed;
        agent.SetDestination(waypoints[m_CurrentWaypointIndex].position);
    }

    private void Update()
    {
        EnviromentView();

        // if enemy is not patrolling
        if (!m_IsPatrol)
        {
            // execute chasing function
            Chasing();
        }
        else
        {
            // execute patrolling function
            Patroling();
        }
        if (characterMovement.enemyTakeDamage)
        {
            enemyHealth = enemyHealth - 2;
        }
        // if enemy health is 0
        if (enemyHealth <= 0)
        {
            enemyHealth = 0;
            // destroy the agent
            Destroy(agent);
            // add 1 to player kill variable
            kills = kills + 1;
            // add 20 Xp to player
            xPBar.currentXP = xPBar.currentXP + 20;
        }
    }

    private void Chasing()
    {
        // player if not within specified distance of player
        m_PlayerNear = false;
        playerLastPosition = Vector3.zero;

        // if player has not been reached
        if (!m_CaughtPlayer)
        {
            // execute move function using the run speed variable
            Move(runSpeed);
            // set agent destination to the last known player position
            agent.SetDestination(m_PlayerPosition);
        }
        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            if (m_WaitTime <= 0 && !m_CaughtPlayer && Vector3.Distance(transform.position, GameObject.FindGameObjectWithTag("Player").transform.position) >= 6f)
            {
                // enemy return to patrolling
                m_IsPatrol = true;
                // player not in enemies line of sight
                m_PlayerNear = false;
                // execute move function using walk speed variable
                Move(walkSpeed);
                m_TimeToRotate = timeToRotate;
                m_WaitTime = startWaitTime;
                // set agent destination to the next waypoint in the array
                agent.SetDestination(waypoints[m_CurrentWaypointIndex].position);
            }
            else
            {
                if (Vector3.Distance(transform.position, GameObject.FindGameObjectWithTag("Player").transform.position) >= 2.5f)
                    Stop();
                m_WaitTime -= Time.deltaTime;
            }
        }
    }

    private void Patroling()
    {
        // if player is near the enemy
        if (m_PlayerNear)
        {
            if (m_TimeToRotate <= 0)
            {
                // execute move function using walk speed variable
                Move(walkSpeed);
                LookingPlayer(playerLastPosition);
            }
            else
            {
                Stop();
                m_TimeToRotate -= Time.deltaTime;
            }
        }
        else
        {
            // player is not near enemy
            m_PlayerNear = false;
            playerLastPosition = Vector3.zero;
            agent.SetDestination(waypoints[m_CurrentWaypointIndex].position);
            if (agent.remainingDistance <= agent.stoppingDistance)
            {

                if (m_WaitTime <= 0)
                {
                    // execute nex point function causing the enemy to move to the next waypoint
                    NextPoint();
                    Move(walkSpeed);
                    m_WaitTime = startWaitTime;
                }
                else
                {
                    Stop();
                    m_WaitTime -= Time.deltaTime;
                }
            }
        }
    }

    private void OnAnimatorMove()
    {

    }

    public void NextPoint()
    {
        m_CurrentWaypointIndex = (m_CurrentWaypointIndex + 1) % waypoints.Length;
        // set agent destination to the next waypoint in the array
        agent.SetDestination(waypoints[m_CurrentWaypointIndex].position);
    }

    void Stop()
    {
        agent.isStopped = true;
        agent.speed = 0;
    }

    void Move(float speed)
    {
        agent.isStopped = false;
        agent.speed = speed;
    }

    void CaughtPlayer()
    {
        m_CaughtPlayer = true;
    }

    void LookingPlayer(Vector3 player)
    {
        // set agent position to player position
        agent.SetDestination(player);
        if (Vector3.Distance(transform.position, player) <= 0.3)
        {
            if (m_WaitTime <= 0)
            {
                m_PlayerNear = false;
                Move(walkSpeed);
                agent.SetDestination(waypoints[m_CurrentWaypointIndex].position);
                m_WaitTime = startWaitTime;
                m_TimeToRotate = timeToRotate;
            }
            else
            {
                Stop();
                m_WaitTime -= Time.deltaTime;
            }
        }
    }

    void EnviromentView()
    {
        Collider[] playerInRange = Physics.OverlapSphere(transform.position, viewRadius, playerMask);

        for (int i = 0; i < playerInRange.Length; i++)
        {
            Transform player = playerInRange[i].transform;
            Vector3 dirToPlayer = (player.position - transform.position).normalized;
            if (Vector3.Angle(transform.forward, dirToPlayer) < viewAngle / 2)
            {
                float dstToPlayer = Vector3.Distance(transform.position, player.position);
                if (!Physics.Raycast(transform.position, dirToPlayer, dstToPlayer, obstacleMask))
                {
                    m_playerInRange = true;
                    m_IsPatrol = false;
                }
                else
                {
                    m_playerInRange = false;
                }
            }
            if (Vector3.Distance(transform.position, player.position) > viewRadius)
            {
                m_playerInRange = false;
            }
            if (m_playerInRange)
            {
                m_PlayerPosition = player.transform.position;
            }
        }
    }

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            StartCoroutine(EnemyAttack());
        }
    }

    IEnumerator EnemyAttack()
    {
        // if enemy is not attacking
        if (!attacking)
        {
            attacking = true;
            // damage player health by 4
            healthBar.currentHealth = healthBar.currentHealth - 4;
            // wait 1 second before attacking again
            yield return new WaitForSeconds(1f);
            attacking = false;
        }
    }
}
