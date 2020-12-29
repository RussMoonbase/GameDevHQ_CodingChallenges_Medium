using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingForever_Spawner : MonoBehaviour
{
   private static FallingForever_Spawner _instance;
   public static FallingForever_Spawner Instance
   {
      get
      {
         if (!_instance)
         {
            Debug.Log("Spawner didn't load");
         }

         return _instance;
      }
   }

   [SerializeField] private GameObject _theBall;

   private void Awake()
   {
      _instance = this;
   }
}
