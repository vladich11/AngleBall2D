using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
   
    public bool turn=false;
    public bool startgame = false;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(countdown());
    }

    // Update is called once per frame
    void Update()
    {
        if (!turn)
        {
            if(startgame)
            transform.Translate(0, BallMain.getBallSpeed() * Time.deltaTime, 0);
        }
        else
        {
            if(startgame)
                transform.Translate(0, -BallMain.getBallSpeed() * Time.deltaTime, 0);
        }
        
    }
    public void StartShieldSkill()
    {
        StartCoroutine(Shield());
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            collision.gameObject.GetComponent<fieldanimator>().animateField();
            StartCoroutine(ballscale());
            if (turn)
            {
                turn = false;
            }
            else
            {
                turn = true;
            }
        }
    }
    IEnumerator ballscale()
    {
        iTween.ScaleTo(gameObject, iTween.Hash("scale", new Vector3(0.15f, 0.15f, 0.15f), "time", 0.15f, "easetype", iTween.EaseType.linear));
        yield return new WaitForSeconds(0.15f);
        iTween.ScaleTo(gameObject, iTween.Hash("scale", new Vector3(0.13f, 0.13f, 0.13f), "time", 0.15f, "easetype", iTween.EaseType.linear));
    }
    IEnumerator countdown()
    {
        yield return new WaitForSeconds(3f);
            startgame = true;
        
    }
    IEnumerator Shield()
    {
        BallMain.ballState = BallMain.BallStateEnum.shielded;
        yield return new WaitForSeconds(8f);
        BallMain.ballState = BallMain.BallStateEnum.vulnerable;
    }
}
