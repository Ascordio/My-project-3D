using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Re : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform reaspawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.transform.position = reaspawnPoint.transform.position;
            Physics.SyncTransforms();
        }
    }
}
