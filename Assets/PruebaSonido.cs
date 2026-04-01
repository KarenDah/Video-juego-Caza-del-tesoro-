using UnityEngine;

public class PruebaSonido : MonoBehaviour
{
    public AudioSource miAudio;

    void Update()
    {
        // Si presionas la tecla ESPACIO, debería sonar el paso
        if (Input.GetKeyDown(KeyCode.Space))
        {
            miAudio.Play();
            Debug.Log("¡El sonido debería sonar!");
        }
    }
}
