using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class uiTimer : MonoBehaviour
{
    private float textTime=3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        if (textTime > 0)
        {
            textTime -= Time.deltaTime;
            int tempTime = Mathf.RoundToInt(textTime);
            GetComponent<Text>().text = tempTime.ToString();
        }
        else
        {
            Destroy(gameObject);
        }
    
        
    }
}
