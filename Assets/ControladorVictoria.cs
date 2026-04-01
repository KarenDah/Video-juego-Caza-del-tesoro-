using UnityEngine;

public class ControladorVictoria : MonoBehaviour
{
    public GameObject cofreAbierto; // Arrastra aquí tu chest_open en el inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Jugador"))
        {
            Animator anim = other.GetComponent<Animator>();
            if (anim != null)
            {
                // Activa el baile
                anim.SetTrigger("Bailar");

                // OPCIONAL: Si quieres que el cofre se abra en este momento
                if (cofreAbierto != null) cofreAbierto.SetActive(true);

                // Desactivamos el cofre cerrado para que no se choquen
                gameObject.SetActive(false);
            }
        }
    }
}