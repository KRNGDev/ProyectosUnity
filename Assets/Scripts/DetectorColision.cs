using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DetectorColision : MonoBehaviour
{
    public GameObject prefabExplosion;
    void OnCollisionEnter()
    {
        Instantiate(prefabExplosion, transform.position, prefabExplosion.transform.rotation);
        Destroy(gameObject);
    }
}