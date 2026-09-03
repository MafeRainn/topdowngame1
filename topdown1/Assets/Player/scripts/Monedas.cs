using UnityEngine;

public class Monedas : ObjetoMundo
{
   public int puntos = 1;
    public override void AlContacto(Jugador jugador)
    {
        jugador.monedas += puntos;
        Debug.Log(jugador.name + " ha recogido una moneda. Total de monedas: " + jugador.monedas);
        Destroy(this.gameObject);
    }
}
