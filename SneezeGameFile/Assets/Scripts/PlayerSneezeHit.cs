using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSneezeHit : MonoBehaviour
{
    public GameObject SneezeSplatterPrefab;

    //The space in between the sneeze and player
    public int sneezeSpace;

    public GameObject Player;

    private Vector3 savedPosition;
    
    public float newPosition; 



    // Start is called before the first frame update
    void Start()
    {
        
        //savedPosition = Player.transform.position;
        //newPosition = savedPosition + sneezeSpace;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            //Add sneezesplatter to the scene

            //GameObject sneeze = Instantiate(SneezeSplatterPrefab) as GameObject;

            //SneezeSplatterPrefab.tranform.position = newPosition;

            Instantiate(SneezeSplatterPrefab, transform.position + (transform.forward *2), transform.rotation);

        }
    }






}
