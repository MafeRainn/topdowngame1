using UnityEngine;

public class Enemigo : Personaje
{
   public Vector3 direccion = Vector3.left; //-1,0,0

    private void Update()
    {
        transform.Translate(direccion * velocidad * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pared"))
        {
            // Lógica para cuando el enemigo colisiona con la pared
            direccion = -direccion; // Cambiar la dirección del enemigo
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            // Lógica para cuando el enemigo colisiona con el jugador
            Jugador jugador = collision.gameObject.GetComponent<Jugador>();
            if (jugador != null) { jugador.Morir(); } // Llamar al método Morir del jugador
            
        }
    }


    public override void Morir()
    {
        // Lógica para cuando el enemigo muere
        Debug.Log("El enemigo ha muerto.");
        Destroy(gameObject); // Destruir el objeto del enemigo
    }
}
