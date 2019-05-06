using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickSound : MonoBehaviour
{
    public AudioClip clickSound;

    private Button button { get { return GetComponent<Button>(); } }
    private AudioSource source { get { return GetComponent<AudioSource>(); } }

    void Start()
    {
        gameObject.AddComponent<AudioSource>();
        source.clip = clickSound;
        source.volume = 0.5f;
        source.playOnAwake = false;

        button.onClick.AddListener(() => PlayClickSound());
    }

    void PlayClickSound()
    {
        source.PlayOneShot(clickSound);
    }   
}
