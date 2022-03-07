using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSneezeHit : MonoBehaviour
{
    public float infectionTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "SneezeSplatter")
        {
            transform.gameObject.tag = "Infected";

        }

    }


}
