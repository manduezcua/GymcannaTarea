using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ControlAtaque : MonoBehaviour
{
    public GameObject bolaPrefab;
    public float velocidadBola;
    public Transform punntoAtaque;
    public float frecuenciaDisparo;
    Animator anima;
    private void Start()
    {
        anima = this.gameObject.GetComponent<Animator>();
    }

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine("Atacar");
            Debug.Log("personaje ha entrado");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StopCoroutine("Atacar");
            Debug.Log("personaje ha salido");
        }
    }
    public IEnumerator Atacar()
    {
        while (true)
        {
            transform.LookAt(GameObject.FindGameObjectWithTag("Player").transform);
            yield return new WaitForSeconds(0.2f);
            anima.Play("atacar");
            //yield return new WaitForSeconds(1.8f);
            //GameObject bola = Instantiate(bolaPrefab, punntoAtaque.position, punntoAtaque.rotation);
            //bola.GetComponent<Rigidbody>().velocity = (punntoAtaque.forward * velocidadBola);
        }
    }

    public void lanzarBola()
    {
        GameObject bola = Instantiate(bolaPrefab, punntoAtaque.position, punntoAtaque.rotation);
        bola.GetComponent<Rigidbody>().velocity = (punntoAtaque.forward * velocidadBola);
    }
}
