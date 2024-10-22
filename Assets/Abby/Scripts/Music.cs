using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Music
{
    public string musicID;
    public AudioClip clip;
    [HideInInspector]public AudioSource source;

    public float maxDistance = 15f;
    public float minDistance = 1f;

    public void SetupSource(GameObject obj)
    {
        source = obj.AddComponent<AudioSource>();
        source.clip = clip;
        source.spatialBlend = 1f;     // Set to 3D sound
        source.minDistance = minDistance;
        source.maxDistance = maxDistance;
        source.playOnAwake = false;   // Avoid playing automatically
    }
}
