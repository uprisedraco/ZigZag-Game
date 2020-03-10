using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemScript : MonoBehaviour
{
    [SerializeField]
    private GameObject sparkleFx;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ball")
        {
            Instantiate(sparkleFx, transform.position, Quaternion.identity);
            GameplayController.instance.CollectableSound();
            Destroy(gameObject);
        }
    }
}
