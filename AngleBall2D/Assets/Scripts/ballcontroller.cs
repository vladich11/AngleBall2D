
using UnityEngine;

public class ballcontroller : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount>0 && Input.GetTouch(0).phase==TouchPhase.Began&& GetComponent<BallMove>().startgame)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.position.y <= Screen.height / 2)
            {
                if(touch.position.x< Screen.width /2)
                {
                    transform.Rotate(0, 0, 90f);
                }
                else
                {
                    transform.Rotate(0, 0, -90f);
                }
            }
        }
    }
}
