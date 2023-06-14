using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueJugador1 : MonoBehaviour
{
    public GameObject bolaPrefab;
    public float velocidadBola;
    public Transform punntoAtaque;
    public float frecuenciaDisparo;
    private void Start()
    {
        
    }

    // Start is called before the first frame update
    public void Disparar()
    {
        GameObject bola = Instantiate(bolaPrefab, punntoAtaque.position, punntoAtaque.rotation);
        bola.GetComponent<Rigidbody>().velocity = (punntoAtaque.forward * velocidadBola);
    }
            
    
}
