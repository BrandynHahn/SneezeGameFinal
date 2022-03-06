using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouseMovement : MonoBehaviour
{
    //private Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        //playerTransform = this.transform; 
    }

    //private void LookMouse()
   // {
       // Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - playerTransform.position;

       // float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        //Quaternion rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);

        //playerTransform.rotation = rotation; 
   // }


    void Update()
    {
        Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
