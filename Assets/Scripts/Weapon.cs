using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField]
    Camera fpCamera;
    [SerializeField]
    float range = 100f;
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        Physics.Raycast(fpCamera.transform.position, fpCamera.transform.forward, out hit, range);

        Debug.Log($"we hit : {hit.transform.name}");
    }
}
