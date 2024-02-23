using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] GameObject towerPrefab;
    [SerializeField] bool isPlaceable;
    float yOffset = 2;

    void OnMouseDown()
    {
        if (isPlaceable)
        {
            Vector3 spawnPosition = new Vector3(transform.position.x, yOffset, transform.position.z);
            Instantiate(towerPrefab, spawnPosition, Quaternion.identity);
            isPlaceable = false;
        }
    }
}
