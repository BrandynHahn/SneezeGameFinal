using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSneezeHit : MonoBehaviour
{
    public GameObject SneezeSplatterPrefab;
    public float SneezeRange; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(SneezeSplatterPrefab, transform.position, transform.rotation);
            SneezeSplatterPrefab.GetComponent<CircleCollider2D>().enabled = false; 
        }
    }






}
