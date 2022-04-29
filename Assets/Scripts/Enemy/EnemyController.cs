using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyController : MonoBehaviour
{
    public HealthBar healthBar;
    public CharacterMovement characterMovement;
    public NavMeshAgent agent;               
    public float startWaitTime = 3;               
    public float timeToRotate = 1;                
    public float walkSpeed = 6;                    
    public float runSpeed = 15;
    public float enemyHealth = 5;

    public float viewRadius = 15;                 
    public float viewAngle = 180;                   
    public LayerMask playerMask;                   
    public LayerMask obstacleMask;                 
    public float meshResolution = 1.0f;            
    public int edgeIterations = 4;                 
    public float edgeDistance = 0.5f;

    public int kills;

    public Transform[] waypoints;                  
    int m_CurrentWaypointIndex;                 

    Vector3 playerLastPosition = Vector3.zero;     
    Vector3 m_PlayerPosition;                   

    float m_WaitTime;                           
    float m_TimeToRotate;                     
    bool m_playerInRange;                       
    bool m_PlayerNear;                            
    bool m_IsPatrol;                               
    bool m_CaughtPlayer;
    bool attacking;

    void Start()
    {
        m_PlayerPosition = Vector3.zero;
        m_IsPatrol = true;
        m_CaughtPlayer = false;
        m_playerInRange = false;
        m_PlayerNear = false;
        attacking = false;
        m_WaitTime = startWaitTime;            
        m_TimeToRotate = timeToRotate;

        m_CurrentWaypointIndex = 0;                 
        agent = GetComponent<NavMeshAgent>();

        agent.isStopped = false;
        agent.speed = walkSpeed;    
        agent.SetDestination(waypoints[m_CurrentWaypointIndex].position);   
    }

    private void Update()
    {
        EnviromentView();                       

        if (!m_IsPatrol)
        {
            Chasing();
        }
        else
        {
            Patroling();
        }
        if (characterMovement.enemyTakeDamage)
        {
            enemyHealth = enemyHealth - 2;
        }
        if (enemyHealth <= 0)
        {
            enemyHealth = 0;
            Destroy(agent);
            kills = kills + 1;
        }
    }

    private void Chasing()
    {
        m_PlayerNear = false;     
        playerLastPosition = Vector3.zero;        

        if (!m_CaughtPlayer)
        {
            Move(runSpeed);
            agent.SetDestination(m_PlayerPosition);
        }
        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            if (m_WaitTime <= 0 && !m_CaughtPlayer && Vector3.Distance(transform.position, GameObject.FindGameObjectWithTag("Player").transform.position) >= 6f)
            {
                m_IsPatrol = true;
                m_PlayerNear = false;
                Move(walkSpeed);
                m_TimeToRotate = timeToRotate;
                m_WaitTime = startWaitTime;
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
        if (m_PlayerNear)
        {
            if (m_TimeToRotate <= 0)
            {
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
            m_PlayerNear = false;          
            playerLastPosition = Vector3.zero;
            agent.SetDestination(waypoints[m_CurrentWaypointIndex].position);   
            if (agent.remainingDistance <= agent.stoppingDistance)
            {
                
                if (m_WaitTime <= 0)
                {
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
        if (!attacking)
        {
            attacking = true;
            healthBar.currentHealth = healthBar.currentHealth - 4;
            yield return new WaitForSeconds(1f);
            attacking = false;
        }
    }
}
