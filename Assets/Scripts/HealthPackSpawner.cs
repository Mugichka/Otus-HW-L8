using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPackSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject healthPackPrefab;

    [SerializeField]
    private List<Transform> spawnPoints;

    public void SpawnHealthPack()
    {
        foreach (var point in spawnPoints)
        {
            SpawnHealthPackAtPoint(point.position);
        }
    }

    private void SpawnHealthPackAtPoint(Vector3 position)
    {
        Instantiate(healthPackPrefab, position, healthPackPrefab.transform.rotation,this.transform);
    }
}
