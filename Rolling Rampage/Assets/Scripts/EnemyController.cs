using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] float enemySpeed;

    Rigidbody rigidbody;

    GameObject playerPosition;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();

        playerPosition = GameObject.Find("Player");
    }


    private void FixedUpdate()
    {
        Vector3 lookDirection = (playerPosition.transform.position - transform.position).normalized;

        rigidbody.AddForce(lookDirection * enemySpeed);
    }
}
