using TMPro;
using UnityEngine;

public class LogicaTesoro : MonoBehaviour
{
    
    public GameObject cofreCerrado;
    public GameObject cofreAbierto;
    public TextMeshProUGUI textoVictoria;

    void Start()
    {
        float xAleatorio = Random.Range(-20f, 20f);
        float zAleatorio = Random.Range(-20f, 20f);
        transform.position = new Vector3(xAleatorio, 0.02f, zAleatorio);
        Debug.Log("Tesoro escondido en una nueva ubicación");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Jugador_Azul")
        {
            Debug.Log("EL JUGADOR AZUL HA ENCONTRADO EL TESORO!");
            TerminarJuego("AZUL");
        }
        else if (other.gameObject.name == "Jugador_Rojo")
        {
            Debug.Log("EL JUGADOR ROJO HA ENCONTRADO EL TESORO!");
            TerminarJuego("ROJO");
        }
    }


    void TerminarJuego(string ganador)
    {
        // mensaje personalizado
        if (textoVictoria != null)
        {
            textoVictoria.gameObject.SetActive(true); // Muestra el letrero

            if (ganador == "AZUL")
            {
                textoVictoria.text = "¡KAREN HA ENCONTRADO EL TESORO!";
            }
            else if (ganador == "ROJO")
            {
                textoVictoria.text = "¡NAHUM HA ENCONTRADO EL TESORO!";
            }
        }

        // CONTROLADOR DE PUNTOS Y SUMA
        ControlPuntaje marcador = FindObjectOfType<ControlPuntaje>();
        if (marcador != null)
        {
            marcador.SumarPunto(ganador);
        }
        // Lógica visual y de audio
        if (cofreCerrado != null) cofreCerrado.SetActive(false);

        GetComponent<BoxCollider>().enabled = false;

        if (cofreAbierto != null)
        {
            cofreAbierto.transform.position = transform.position;
            cofreAbierto.SetActive(true);
        }

        AudioSource miAudio = GetComponent<AudioSource>();
        if (miAudio != null) miAudio.Play();

        // Destruimos después de 5 segundos para que la música termine
        Destroy(gameObject, 5.0f);
    }
}