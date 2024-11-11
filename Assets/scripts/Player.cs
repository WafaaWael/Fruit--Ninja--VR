using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Player : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Score;
    [SerializeField] private TextMeshProUGUI Hp;

    public float score = 0;
    public float HP = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = $"Score:{score}";
        Hp.text = $"HP:{HP}";

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("apple"))
        {
            score = score + 1;
            Debug.Log("This on trigger");


        }
        if (other.CompareTag("banana"))
        {
            score = score + 2;
            Debug.Log("This on trigger");



        }
        if (other.CompareTag("romana"))
        {
            score = score + 3;
            Debug.Log("This on trigger");



        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bomb"))
        {

            HP = HP - 1;
            if(HP <= 0)
            {
                HP = 20;
                score = 0;
            }
        }
    }
}

