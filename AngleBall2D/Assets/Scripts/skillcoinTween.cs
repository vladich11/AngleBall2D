using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skillcoinTween : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        iTween.ScaleTo(gameObject, iTween.Hash("scale", new Vector3(0.15f, 0.15f, 0.15f), "time", 0.5f, "looptype", iTween.LoopType.pingPong, "easetype", iTween.EaseType.easeInOutBounce));
    }

    
}
