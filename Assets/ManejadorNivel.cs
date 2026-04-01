using UnityEngine;
using UnityEngine.SceneManagement; // cambio de escena

public class ManejadorNivel : MonoBehaviour
{
    // Esta función la llamaremos desde el botón
    public void ReiniciarJuego()
    {
        // Debug.Log para verificar que el clic funciona
        Debug.Log("Reiniciando el juego...");

        // Obtenemos el nombre de la escena actual
        string nombreEscenaActual = SceneManager.GetActiveScene().name;

        // Le decimos a Unity que cargue esa escena de nuevo
        SceneManager.LoadScene(nombreEscenaActual);
    }
    // volver al menú
    public void VolverAlMenu()
    {
        ControlPuntaje.ReiniciarMarcadorGlobal();

        Debug.Log("Cargando el Menú Principal...");
        SceneManager.LoadScene("MenuPrincipal");
    }
}