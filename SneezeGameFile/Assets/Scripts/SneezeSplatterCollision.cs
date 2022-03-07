using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SneezeSplatterCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        (gameObject.GetComponent(typeof(Collider)) as CapsuleCollider).isTrigger = true;


    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
