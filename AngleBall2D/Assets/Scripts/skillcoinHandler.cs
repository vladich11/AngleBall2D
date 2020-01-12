using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skillcoinHandler : MonoBehaviour
{
    //public Transform particles;
    
  
    private void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            collider.gameObject.GetComponent<BallMove>().StartShieldSkill();
            //Instantiate(particles,new Vector3(transform.position.x, transform.position.y,-0.2f), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
