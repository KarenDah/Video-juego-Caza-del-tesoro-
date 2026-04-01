using UnityEngine;
using UnityEngine.SceneManagement; 
public class LogicaMenu : MonoBehaviour
{
    public void Jugar()
    {
       // "SampleScene" is the default name of your forest scene
        SceneManager.LoadScene("SampleScene");
    }

    public void Salir()
    {
        Debug.Log("Saliendo del juego...");
        Application.Quit();
    }
}
