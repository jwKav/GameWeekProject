using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour
{
    [SerializeField]
    private float speed = 10;
    private float waitTime;
    public float startWaitTime;

    [SerializeField]
    public Transform[] movePoints;

    [SerializeField]
    public Transform playerPoint;

    private int randomPoint;

    public bool playerInRange;
    public static bool aiShoot = false;
    private void Start()
    {
        waitTime = startWaitTime;
        randomPoint = Random.Range(0, movePoints.Length);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerInRange"))
        {
            playerInRange = true;
        }
    }
    private void Update()
    {
        if (Vector3.Distance(transform.position, movePoints[randomPoint].position)< 0.5f)
        {
            if (waitTime<=0)
            {
                randomPoint = Random.Range(0, movePoints.Length);
                waitTime = startWaitTime;
            }
            else
            {
                waitTime += Time.deltaTime;
            }
        }
        
    }
    private void FixedUpdate()
    {
        if (playerInRange)
        {
            transform.position = Vector3.MoveTowards(transform.position, playerPoint.position, speed);
            transform.LookAt(playerPoint.position);
            aiShoot = true;
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, movePoints[randomPoint].position, speed);
            transform.LookAt(movePoints[randomPoint].position);
        }
        
    }
    
}
