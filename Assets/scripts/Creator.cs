using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Creator : MonoBehaviour
{

    [SerializeField] private GameObject apple;
    [SerializeField] private GameObject banana;
    [SerializeField] private GameObject romana;

    [SerializeField] private GameObject bomb;


    float spawnRadius = 0.50f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(creat());

    }

    // Update is called once per frame
    void Update()
    {
    }
    private IEnumerator creat()
    {
 
        Instantiate(apple, GetRandomPosition(), Quaternion.identity);
        Instantiate(banana, GetRandomPosition(), Quaternion.identity);
        Instantiate(romana, GetRandomPosition(), Quaternion.identity);
        Instantiate(bomb, GetRandomPosition(), Quaternion.identity);

        yield return new WaitForSeconds(2);
    
        StartCoroutine(creat());
    }

    Vector3 GetRandomPosition()
    {
        Vector3 playerPosition =transform.position;
        Vector2 randomCircle = Random.insideUnitCircle * spawnRadius;
        Vector3 randomPosition = playerPosition + new Vector3(randomCircle.x, 0f, randomCircle.y);
        return randomPosition;
    }
}
