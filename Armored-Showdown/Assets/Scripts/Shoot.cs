using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private GameObject misilPrefab;
    [SerializeField] private GameObject pointShoot;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(misilPrefab, pointShoot.transform.position, pointShoot.transform.rotation);
        }
    }
  

}
