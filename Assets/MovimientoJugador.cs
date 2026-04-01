using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    public float velocidad = 5f;
    public string ejeHorizontal = "Horizontal";
    public string ejeVertical = "Vertical";

    private Animator anim;

    void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        float movH = Input.GetAxis(ejeHorizontal);
        float movV = Input.GetAxis(ejeVertical);

        // 1. Calculamos la dirección basándonos en el mundo (Global)
        Vector3 movimiento = new Vector3(movH, 0, movV);

        // 2. CAMBIO CLAVE: Añadimos "Space.World" al final. 
        // Esto hace que Arriba sea siempre el Norte, no el frente del personaje.
        transform.Translate(movimiento * velocidad * Time.deltaTime, Space.World);

        // 3. Animación
        if (anim != null)
        {
            anim.SetFloat("Velocidad", movimiento.magnitude);
        }

        // 4. Rotación: El personaje mira hacia donde te mueves
        if (movimiento != Vector3.zero)
        {
            transform.forward = movimiento;
        }
    }
}