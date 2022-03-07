using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SneezeSplatterCollision : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(.2f);
        (gameObject.GetComponent(typeof(Collider)) as Collider).isTrigger = true;


    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
