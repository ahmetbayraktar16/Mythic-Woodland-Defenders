using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] GameObject towerPrefab;
    float yOffset = 2;

    [SerializeField] bool isPlaceable;
    public bool IsPlaceable { get => isPlaceable; }

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
