using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       // StartCoroutine(Death2());

    }

    // Update is called once per frame
    void Update()
    {

    }
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
    }
    private IEnumerator Death2()
    {
        yield return new WaitForSeconds(10);
        Destroy(gameObject);
    }
}
