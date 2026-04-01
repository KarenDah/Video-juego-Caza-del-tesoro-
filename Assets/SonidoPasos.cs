using UnityEngine;

public class SonidoPasos : MonoBehaviour
{
    public AudioSource miAudio;

    // Esta es la función que "disparará" la animación
    public void PlayFootstep()
    {
        if (miAudio != null)
        {
            miAudio.Play();
        }
    }
}