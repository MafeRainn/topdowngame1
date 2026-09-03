using UnityEngine;

public class Personaje : MonoBehaviour
{
    public string nome;
    public int health;
    public int velocidad;

    public virtual void Morir()
    {
        // Lógica para cuando el personaje muere
        Debug.Log(name + " ha muerto.");
    }
}
