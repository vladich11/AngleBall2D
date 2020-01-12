using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fieldanimator : MonoBehaviour
{
    
    public void animateField()
    {
        StartCoroutine(scalefield());
    }
    //feild animator when get hit
    IEnumerator scalefield()
    {
        iTween.ScaleTo(gameObject, iTween.Hash("scale",new Vector3(1.38f, 1.38f, 1.38f),"time",0.15f,"easetype",iTween.EaseType.linear));
        yield return new WaitForSeconds(0.15f);
        iTween.ScaleTo(gameObject, iTween.Hash("scale", new Vector3(1.3f, 1.3f, 1.3f), "time", 0.15f, "easetype", iTween.EaseType.linear));
    }
}
