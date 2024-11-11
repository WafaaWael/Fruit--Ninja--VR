using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
{
   
    private IEnumerator Death()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            StartCoroutine(Death());

        }
        else
        {
            StartCoroutine(Death2());
        }
    }
    private IEnumerator Death2()
    {
        yield return new WaitForSeconds(10);
        Destroy(gameObject);
    }
}
