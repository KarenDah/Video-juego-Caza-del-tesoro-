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

        //Calculate the direction based on the world (Global)
        Vector3 movimiento = new Vector3(movH, 0, movV);
        
        // KEY CHANGE: We added "Space.World" at the end
        // This ensures that Up is always North, not the character's forward direction
        transform.Translate(movimiento * velocidad * Time.deltaTime, Space.World);

        // Animatión
        if (anim != null)
        {
            anim.SetFloat("Velocidad", movimiento.magnitude);
        }

        // Rotation: The character looks in the direction they are moving
        if (movimiento != Vector3.zero)
        {
            transform.forward = movimiento;
        }
    }
}
