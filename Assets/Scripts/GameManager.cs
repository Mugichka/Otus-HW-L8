using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] HealthPackSpawner healthPackSpawner;
    // Start is called before the first frame update
    void Start()
    {
        healthPackSpawner.SpawnHealthPack();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
