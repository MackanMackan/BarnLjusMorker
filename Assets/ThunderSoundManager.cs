using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThunderSoundManager : MonoBehaviour
{

    public List<AudioClip> audioClips;
    public AudioSource audioSource;
    void Start()
    {
        //audioClips = new List<AudioClip>();
    }


    public void PlayThunderSFX()
    {
        AudioSource audio = Instantiate(audioSource);
        audio.clip = audioClips[Random.Range(0, 2)];
        audio.pitch = Random.Range(0.8f, 1.2f);
        audio.Play();
    }
}
