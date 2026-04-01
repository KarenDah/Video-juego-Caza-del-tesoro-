using UnityEngine;

public class PruebaSonido : MonoBehaviour
{
    public AudioSource miAudio;

    void Update()
    {
        // If the SPACE key is pressed, the footstep should play
        if (Input.GetKeyDown(KeyCode.Space))
        {
            miAudio.Play();
            Debug.Log("¡El sonido debería sonar!");
        }
    }
}
