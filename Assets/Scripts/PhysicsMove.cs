using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[RequireComponent(typeof(Rigidbody))]
public class PhysicsMove : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float rotationSpeed = 720f;

    private Rigidbody rb;
    private InteractionHandler interactionHandler;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        interactionHandler = new InteractionHandler(transform, 2f);
    }

    private void FixedUpdate()
    {
        Move();
        Rotate();
    }
    private void Update()
    {
        interactionHandler.Tick();
    }

    private void Move()
    {
        float moveInput = Input.GetAxis("Vertical");
        Vector3 moveDirection = transform.forward * moveInput;

        rb.MovePosition(rb.position + moveDirection * moveSpeed * Time.fixedDeltaTime);
    }

    private void Rotate()
    {
        float rotationInput = Input.GetAxis("Horizontal"); // A и D (или стрелки)
        float rotationAmount = rotationInput * rotationSpeed * Time.fixedDeltaTime;

        Quaternion deltaRotation = Quaternion.Euler(0, rotationAmount, 0);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }
}
