using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cointween : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        iTween.RotateTo(gameObject, iTween.Hash("rotation", new Vector3(0f, 0f, 180f), "time", 1f, "looptype", iTween.LoopType.pingPong,"easetype",iTween.EaseType.easeInBack));
    }

    
}
