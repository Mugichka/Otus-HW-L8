using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionHandler
{
    private Transform playerTransform;
    private float interactionRadius;



    public InteractionHandler(Transform transform, float radius)
    {
        // Проверяем, что transform не равен null
        if (transform == null)
        {
            throw new System.ArgumentNullException(nameof(transform), "Transform не может быть null.");
        }

        playerTransform = transform;
        interactionRadius = radius;
    }

    public void Tick()
    {
        DetectAndInteract();
    }

    public void DetectAndInteract()
    {
        // Находим все объекты в заданном радиусе вокруг позиции игрока
        Collider[] hitColliders = Physics.OverlapSphere(playerTransform.position, interactionRadius);

        foreach (var hitCollider in hitColliders)
        {
            IIntractable intractable = hitCollider.GetComponent<IIntractable>();
            if (intractable != null)
            {
                intractable.Interact();
                break; // Прекращаем после первого найденного взаимодействия
            }
        }
    }
}
