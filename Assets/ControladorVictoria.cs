using UnityEngine;

public class ControladorVictoria : MonoBehaviour
{
    public GameObject cofreAbierto; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Jugador"))
        {
            Animator anim = other.GetComponent<Animator>();
            if (anim != null)
            {
            // Trigger the dance animation
                anim.SetTrigger("Bailar");

               //If you want the chest to open at this moment
                if (cofreAbierto != null) cofreAbierto.SetActive(true);

                // Disable the closed chest to avoid collisions
                gameObject.SetActive(false);
            }
        }
    }
}
