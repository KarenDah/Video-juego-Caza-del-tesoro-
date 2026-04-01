using UnityEngine;
using UnityEngine.SceneManagement; // Importante para cambiar de escenas

public class LogicaMenu : MonoBehaviour
{
    public void Jugar()
    {
        // "SampleScene" es el nombre de tu escena del bosque por defecto
        SceneManager.LoadScene("SampleScene");
    }

    public void Salir()
    {
        Debug.Log("Saliendo del juego...");
        Application.Quit();
    }
}