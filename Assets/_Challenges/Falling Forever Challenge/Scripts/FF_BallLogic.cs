using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FF_BallLogic : MonoBehaviour
{
   [SerializeField] Renderer _renderer;

   private void OnCollisionEnter(Collision other)
   {
      if (other.gameObject.tag == "Floor")
      {
         Hide();
      }
   }

   private void Hide()
   {
      this.gameObject.SetActive(false);
      FallingForever_Spawner.Instance.ResetBall(this.gameObject.transform, _renderer);
   }
}
