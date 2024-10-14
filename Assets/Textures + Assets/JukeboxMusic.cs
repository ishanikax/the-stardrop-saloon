using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JukeboxMusic : MonoBehaviour
{
    public Music[] musics;
    private string currentMusicID;

    private void Awake()
    {
        foreach (Music m in musics)
        {
            m.source = gameObject.AddComponent<AudioSource>();
            m.source.clip = m.clip;
        }

    }

    public void ChangeMusic(string newMusic)
    {

    }
}
