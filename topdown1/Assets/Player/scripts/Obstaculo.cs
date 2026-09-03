using UnityEngine;

public class Obstaculo : ObjetoMundo
{
    public int dano = 1;

    public override void AlContacto(Jugador jugador)
    {
        jugador.Recibirdano(dano)
        Destroy(this.gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log(collision.gameObject.name + " ha colisionado con " + this.gameObject.name);

        }
    }
}
