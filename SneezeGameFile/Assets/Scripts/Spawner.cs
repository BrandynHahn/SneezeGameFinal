using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //Adding adult character prefab
    public GameObject AdultPrefab;

    //Adding child character prefab
    public GameObject ChildPrefab;

    //Adding old character prefab
    public GameObject OldPrefab;

    public int spawnSpacing; 

    void Start()
    {
        //Random x location for prefabs spawned
        //var randomX = Random.Range(-8, 8);

        //Random y location for prefabs spawned
        //var randomY = Random.Range(-4, 4);
        spawnSpacing = Random.Range(1, 3);

        for (int i=0; i< Random.Range(7, 12); i++)
        {
            Vector2 pos = new Vector2(Random.Range(-8, 8), Random.Range(-4, 4));
            GameObject Adult = Instantiate(AdultPrefab) as GameObject;
            GameObject Old = Instantiate(OldPrefab) as GameObject;
            GameObject Child = Instantiate(ChildPrefab) as GameObject;

            //Vector2 pos = Vector2.zero; 
            //pos.x = randomX;
            //pos.y = randomY; 
        }

    }

    void Update()
    {
        
    }
}
