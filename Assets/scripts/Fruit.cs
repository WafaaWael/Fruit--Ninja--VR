using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    [SerializeField] private GameObject fruit;
    [SerializeField] private GameObject Fruit2;
    //[SerializeField] private Creator creator;
    //[SerializeField] private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
      //  rb.g
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            Debug.Log("This on trigger");
            Instantiate(fruit, transform.position, Quaternion.identity);
            Instantiate(Fruit2, transform.position, Quaternion.identity);
            Destroy(gameObject);

        
        }

    }
}
