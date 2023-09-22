using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public List<Sound> sounds;

    public void Play(GameObject thisObj, string name,int volume, bool loop)
    {
        foreach(Sound sound in sounds)
        {
            if (sound.name.Equals(name))
            {
                AudioSource source = thisObj.AddComponent<AudioSource>();
                source.clip = sound.clip;
                source.volume = volume;
                source.loop = loop;
                source.spatialBlend = 1;
                source.Play();
                break;
            }
        }
    }
}
