using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

    public Transform spawnPoint;
    public GameObject spawnObj;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Instantiate(spawnObj, spawnPoint.position, spawnPoint.rotation);
        }
    }
}