using UnityEngine;

public class ObjetoMundo : MonoBehaviour
{
   public string nomeObjeto;
   
    public virtual void AlContacto(Jugador jugador)
    {
        // Lógica para cuando el jugador entra en contacto con el objeto
        Debug.Log(jugador.name + " ha entrado en contacto con " + nomeObjeto);
    }
}
