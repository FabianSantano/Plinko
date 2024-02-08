using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab;

    public Transform spawnTransform;
    // Start is called before the first frame update


    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown((KeyCode.Space)))
        {
            Vector3 spawnPosition = new Vector3(0,5,Random.Range(4,8));
            Instantiate(ballPrefab, spawnPosition, Quaternion.identity);
        }
    }
    

    
}
