using UnityEngine;
using UnityEngine.SceneManagement; 

public class ManejadorNivel : MonoBehaviour
{
    // This function will be called from the button
    public void ReiniciarJuego()
    {
       // Debug.Log to verify the click is working
        Debug.Log("Reiniciando el juego...");

        // Get the name of the current scene
        string nombreEscenaActual = SceneManager.GetActiveScene().name;
        
        // Tell Unity to load that scene again
        SceneManager.LoadScene(nombreEscenaActual);
    }
    // Return to the menu
    public void VolverAlMenu()
    {
        ControlPuntaje.ReiniciarMarcadorGlobal();

        Debug.Log("Cargando el Menú Principal...");
        SceneManager.LoadScene("MenuPrincipal");
    }
}
