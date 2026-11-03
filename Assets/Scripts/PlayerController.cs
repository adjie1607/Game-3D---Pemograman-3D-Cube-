using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof (BoxCollider))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private FixedJoystick joystick;
    [SerializeField] private Animator animator;

    [SerializeField] private float movespeed;

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector3(joystick.Horizontal * movespeed, rb.linearVelocity.y, joystick.Vertical * movespeed);
    }
}
