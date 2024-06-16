using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float playerSpeed;

    Rigidbody rigidbody;

    GameObject focalPoint;


    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("FocalPoint");
    }

    void FixedUpdate()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        float vertical = Input.GetAxis("Vertical");
        rigidbody.AddForce(focalPoint.transform.forward * vertical * playerSpeed);
    }
}
