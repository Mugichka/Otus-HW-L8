using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformMove : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float rotationSpeed = 720f;

    private InteractionHandler interactionHandler;

    void Start()
    {
        interactionHandler = new InteractionHandler(transform, 2f);
    }

    void Update()
    {
        interactionHandler.Tick();
        Move();
        Rotate();
    }

    private void Move()
    {
        
        float moveInput = Input.GetAxis("Vertical"); 
        Vector3 moveDirection = transform.forward * moveInput;
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }

    private void Rotate()
    {
        float rotationInput = Input.GetAxis("Horizontal");
        float rotationAmount = rotationInput * rotationSpeed * Time.deltaTime;

        transform.Rotate(0, rotationAmount, 0);
    }
}
