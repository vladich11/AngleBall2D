using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class badcoinhandler : MonoBehaviour
{
    public Transform badparticles;
    void Start()
    {
        Destroy(gameObject, 8f);
    }

    private void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Instantiate(badparticles, new Vector3(transform.position.x, transform.position.y, -0.2f), Quaternion.identity);
            Destroy(gameObject);
            //lose game if 0 lives.
            if (BallMain.getLife() == 0 && BallMain.ballState== BallMain.BallStateEnum.vulnerable)
            {
                Application.LoadLevel(0);
            }
        }
    }
    
    
}
