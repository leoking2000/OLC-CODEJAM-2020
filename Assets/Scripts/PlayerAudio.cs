using UnityEngine;

public class PlayerAudio : MonoBehaviour
{

    public AudioClip Die;
    public AudioClip Jump;

    AudioSource source;


    private void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void PlayJump()
    {
        source.clip = Jump;
        source.Play();
    }

    public void PlayDie()
    {
        source.clip = Die;
        source.Play();
    }


}
