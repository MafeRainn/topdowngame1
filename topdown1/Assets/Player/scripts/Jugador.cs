using UnityEngine;

public class Jugador : Personaje
{
    public float fuerzaSalto = 8f;
    public int monedas = 0;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        transform.Translate(x * velocidad * Time.deltaTime, 0, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
        }
    }

    public void Recibirdano( int cantidad)
    {
        health -= cantidad;
        Debug.Log(name + " ha recibido daño. Salud actual: " + health);
        if (health <= 0)
        {
            Morir();
        }
    }

    public override void Morir()
    {
        // Lógica para cuando el jugador muere
        Debug.Log(name + " ha muerto.");
      
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Moneda"))
        {
            ObjetoMundo obj = other.GetComponent<ObjetoMundo>();
            if (obj != null) obj.AlContacto(this);
        }
    }
}
