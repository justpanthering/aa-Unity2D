using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinSpawn : MonoBehaviour
{
    public GameObject pinPrefab;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Spawn();
        }
    }

    void Spawn()
    {
        Instantiate(pinPrefab, transform.position, transform.rotation);
    }
}
