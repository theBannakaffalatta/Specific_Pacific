using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static AudioClip WalkingGrass, WalkingSand, CollideTree, Sang;
    static AudioSource audioSrc;

    // Use this for initialization
    void Start()
    {
        WalkingGrass = Resources.Load<AudioClip>("GrassWalk");
        WalkingSand = Resources.Load<AudioClip>("SandWalk");
        CollideTree = Resources.Load<AudioClip>("TreeSound");
        Sang = Resources.Load<AudioClip>("Bakgrunnsang");

        audioSrc = GetComponent<AudioSource>();

        //PlaySound("Bakgrunnsang");

        //DontDestroyOnLoad(gameObject);
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "GrassWalk":
                audioSrc.PlayOneShot(WalkingGrass);
                //audioSrc.pitch = (Random.Range(.9f, 1.2f));
                break;

            case "SandWalk":
                audioSrc.PlayOneShot(WalkingSand);
                //audioSrc.pitch = (Random.Range(.9f, 1.2f));
                break;

            case "TreeSound":
                audioSrc.PlayOneShot(CollideTree);
                //audioSrc.pitch = (Random.Range(.9f, 1.2f));
                break;

            case "Bakgrunnsang":
                audioSrc.PlayOneShot(Sang);
                break;
        }
    }
}
