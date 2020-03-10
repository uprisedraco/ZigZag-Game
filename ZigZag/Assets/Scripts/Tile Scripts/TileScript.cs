using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    private Rigidbody rb;
    private AudioSource audioSource;

    [SerializeField]
    private GameObject gem;

    [SerializeField]
    private float chanseForCollectable;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        if(Random.value < chanseForCollectable)
        {
            Vector3 temp = transform.position;
            temp.y += 2;
            Instantiate(gem, temp, Quaternion.identity);
        }
    }

    IEnumerator TriggerFallingDown()
    {
        yield return new WaitForSeconds(0.3f);
        rb.isKinematic = false;
        audioSource.Play();
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Ball")
        {
            StartCoroutine(TriggerFallingDown());
        }
    }
}
