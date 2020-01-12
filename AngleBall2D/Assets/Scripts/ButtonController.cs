using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public void playButton()
    {
       Application.LoadLevelAsync(1);
    }
}
