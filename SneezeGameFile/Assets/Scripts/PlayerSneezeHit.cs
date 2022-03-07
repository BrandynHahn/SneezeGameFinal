using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSneezeHit : MonoBehaviour
{
    public GameObject SneezeSplatterPrefab;

    public Transform sneezeArea; 

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Instantiate(SneezeSplatterPrefab, sneezeArea.position, sneezeArea.rotation);
            GetComponent(PlayerSneezeHitScript).enabled = false;
        }
        
    }






}
