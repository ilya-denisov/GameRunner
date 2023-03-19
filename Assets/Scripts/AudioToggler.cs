using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioToggler : MonoBehaviour
{
    public bool OnOffSound = true;
    public void OnOffAudio()
    {
        if (OnOffSound)
        {
            OnOffSound = false;
            AudioListener.volume = 0f;
        }
        else
        {
            OnOffSound = true;
            AudioListener.volume = 1f;
        }
    }
}
