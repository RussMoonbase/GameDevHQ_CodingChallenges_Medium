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

   private Renderer _renderer;

   [SerializeField] private GameObject _ballPrefab;
   [SerializeField] private List<GameObject> _ballPool;
   [SerializeField] private int _ballSpawnAmount = 1;
   [SerializeField] private Vector3 _startPosition;

   private void Awake()
   {
      _instance = this;
   }

   private void Start()
   {
      _ballPool = GenerateBalls(_ballSpawnAmount);
      _renderer = GetComponent<Renderer>();
   }

   private List<GameObject> GenerateBalls(int ballAmount)
   {
      for (int i = 0; i < ballAmount; i++)
      {
         GameObject ball = Instantiate(_ballPrefab);
         _ballPool.Add(ball);
      }

      return _ballPool;
   }

   public void ResetBall(Transform ballTransform, Renderer ballRenderer)
   {
      ResetBallToStartPosition(ballTransform);
      AssignRandomColorToBall(ballRenderer);

      foreach (var aBall in _ballPool)
      {
         if (!aBall.activeInHierarchy)
         {
            aBall.SetActive(true);
            break;
         }
      }
   }

   private void ResetBallToStartPosition(Transform theBall)
   {
      theBall.position = _startPosition;
   }

   private void AssignRandomColorToBall(Renderer theBallRenderer)
   {
      //Random.seed = System.DateTime.Now.Millisecond;
      if (theBallRenderer)
      {
         theBallRenderer.material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
      }
   }

   //public GameObject RequestBall()
   //{
   //   foreach (var aBall in _ballPool)
   //   {
   //      if (!aBall.activeInHierarchy)
   //      {

   //      }
   //   }
   //}
}
