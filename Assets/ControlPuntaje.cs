using UnityEngine;
using TMPro;

public class ControlPuntaje : MonoBehaviour
{
    // Las variables estáticas NO se reinician al cargar la escena
    public static int puntosKaren = 0;
    public static int puntosNahum = 0;

    public TextMeshProUGUI textoMarcador;

    void Start()
    {
        ActualizarInterfaz();
    }

    public void SumarPunto(string ganador)
    {
        if (ganador == "AZUL") puntosKaren++;
        else if (ganador == "ROJO") puntosNahum++;

        ActualizarInterfaz();
    }

    void ActualizarInterfaz()
    {
        if (textoMarcador != null)
        {
            textoMarcador.text = "KAREN: " + puntosKaren + "    NAHUM: " + puntosNahum;
        }
    }

    // Esta función la usaremos para resetear cuando salgamos al menú
    public static void ReiniciarMarcadorGlobal()
    {
        puntosKaren = 0;
        puntosNahum = 0;
    }
}