using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSneezeHit : MonoBehaviour
{

    public GameObject SneezeSplatterPrefab;

    public Transform NPCsneezeArea;

    public float infectionTime;

    public GameObject NPCAdultPrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //private void OnTriggerEnter2D(Collider2D other)
    // {
    //   if (other.gameObject.CompareTag("SneezeSplatter"))
    //   {
    //       transform.gameObject.tag = "Infected";
    //      gameObject.GetComponent<Renderer>().material.color = new Color(50, 205, 50);
    //      Instantiate(SneezeSplatterPrefab, transform.position + new Vector3(0, 0 + 2, 0), Quaternion.identity);
    //     Destroy(GetComponent<NPCMovement>());

    // }



    void OnCollisionEnter(Collision collision)
    {
        
            transform.gameObject.tag = "Infected";
            NPCAdultPrefab.GetComponent<Renderer>().material.color = new Color(50, 205, 50);
            Instantiate(SneezeSplatterPrefab, NPCsneezeArea.position, NPCsneezeArea.rotation);
        

        
    }
}

