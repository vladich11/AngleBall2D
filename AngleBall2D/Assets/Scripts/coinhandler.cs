using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class coinhandler : MonoBehaviour
{
    public Transform particles;
    private void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {

            Instantiate(particles, new Vector3(transform.position.x, transform.position.y, -0.2f), Quaternion.identity);
            BallMain.IncreaseSpeed();
            BallMain.IncreaseLives();
            GameObject.FindWithTag("coinUI").GetComponent<Text>().text=BallMain.getPoints().ToString();
            Destroy(gameObject);
        }
    }
}
