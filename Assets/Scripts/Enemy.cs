using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] float secondSpawn;
    [SerializeField] float minBound;
    [SerializeField] float maxBound;

    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    IEnumerator SpawnEnemy()
    {   while(true)
        {
            var x = Random.Range(minBound, maxBound);
            var position = new Vector3(x,transform.position.y);
            GameObject gameObject = Instantiate(enemyPrefab, position, Quaternion.identity);
            yield return new WaitForSeconds(secondSpawn);
            Destroy(gameObject, 5f);
        }
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("OnCollisionEnter2D");
    }
}
