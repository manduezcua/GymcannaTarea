using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ControlBola : MonoBehaviour
{
    public int cantidadVidas;
    private ControlVidas ControlVidasS;
    private ConntrolVidaDuende ControlVidasD;

    private void Start()
    {
        
        cantidadVidas = 1;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ControlVidasS=collision.gameObject.GetComponent<ControlVidas>();
            ControlVidasS.QuitarVidas(cantidadVidas);
            Destroy(this.gameObject);
        }
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            ControlVidasD = collision.gameObject.GetComponent<ConntrolVidaDuende>();
            ControlVidasD.QuitarVidas(cantidadVidas);
            Destroy(this.gameObject);
        }
    }
}
