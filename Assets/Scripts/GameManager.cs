using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{

   public GameObject[] objects;
   private void Update()
   {
      if (Input.GetKeyDown(KeyCode.Space))
      {
         Spawn();
      }
   }

   private void Spawn()
   {
      int i = Random.Range(0, 3);
      Instantiate(objects[i]);
      Vector3 objPosition = new Vector2(Random.Range(-8.4f, 8.4f), Random.Range(-3.3f,3.3f));
      objects[i].transform.position = objPosition;
   }
   
}
