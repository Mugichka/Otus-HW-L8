using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPack : MonoBehaviour, IIntractable
{
    [SerializeField] float RotationSpeed = 30f;
    public float HealthAmount = 25f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rotation(RotationSpeed);
    }

    void Rotation(float rotationSpeed)
    {
        float rotationAmount = rotationSpeed * Time.deltaTime;
        transform.Rotate(0, 0, rotationAmount);
    }

    public void Interact()
    {
        Debug.Log($"+{HealthAmount} здоровья");
        gameObject.SetActive(false);
    }
}
