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
            m.SetupSource(gameObject);
        }
    }

    private void Start()
    {
        currentMusicID = musics[0].musicID;
        PlayMusic();
    }

    public void ChangeMusic(string newMusic)
    {
        foreach (Music m in musics)
        {
            if (m.musicID == currentMusicID)
            {
                m.source.Stop();
                break;
            }
        }

        currentMusicID = newMusic;
    }

    public void StopMusic()
    {
        foreach (Music m in musics)
        {
            if (m.musicID == currentMusicID)
            {
                m.source.Stop();
                break;
            }
        }
    }

    public void PlayMusic()
    {
        foreach (Music m in musics)
        {
            if (m.musicID == currentMusicID)
            {
                m.source.Play();
                break;
            }
        }
    }
}
