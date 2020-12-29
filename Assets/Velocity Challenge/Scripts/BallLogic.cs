using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLogic : MonoBehaviour
{
   private Rigidbody _rigidBody;
   float _ballVelocity;
   [SerializeField] float _velocityIncrease;

   // Start is called before the first frame update
   void Start()
   {
      _rigidBody = GetComponent<Rigidbody>();
      _ballVelocity = _velocityIncrease;
   }

   // Update is called once per frame
   void Update()
   {

   }

   private void OnCollisionEnter(Collision other)
   {
      if (other.gameObject.tag == "Floor")
      {
         _ballVelocity += _velocityIncrease;
         _rigidBody.velocity = new Vector3(0f, _ballVelocity, 0f);
      }
   }
}
