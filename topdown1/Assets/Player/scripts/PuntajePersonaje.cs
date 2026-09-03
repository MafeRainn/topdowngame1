using UnityEngine;

public class PuntajePersonaje 
{
    private int puntos = 0;

    public void AgregarPuntos(int cantidad)
    {
        if (cantidad > 0)
        {
            puntos += cantidad;
            Debug.Log("Puntos actuales: " + puntos);
            return;
        }
        
    }


}
