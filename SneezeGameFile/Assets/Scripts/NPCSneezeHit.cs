using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSneezeHit : MonoBehaviour
{

    public GameObject SneezeSplatterPrefab;

    public Transform NPCsneezeArea;

    public float infectionTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

     IEnumerator OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("SneezeSplatter"))
        {
            transform.gameObject.tag = "Infected";
            gameObject.GetComponent<Renderer>().material.color = new Color(50, 205, 50);
            yield return new WaitForSeconds(5);
            Instantiate(SneezeSplatterPrefab, transform.position + new Vector3(0, 0 + 2, 0), Quaternion.identity);

            

        }

    }


}
