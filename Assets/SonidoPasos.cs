using UnityEngine;

public class SonidoPasos : MonoBehaviour
{
    public AudioSource miAudio;

    // This is the function that will "trigger" the animation
    public void PlayFootstep()
    {
        if (miAudio != null)
        {
            miAudio.Play();
        }
    }
}
