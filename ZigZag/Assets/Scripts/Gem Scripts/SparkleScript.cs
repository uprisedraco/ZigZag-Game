using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SparkleScript : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(DestroySparkle());
    }

    IEnumerator DestroySparkle()
    {
        yield return new WaitForSeconds(1.5f);
        Destroy(gameObject);
    }
}
