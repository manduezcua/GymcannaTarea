using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionObjetos : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Colision Empezada!");
        Debug.Log(collision.gameObject.name);
    }

    private void OnCollisionStay(Collision collision)
    {
        //Debug.Log("Colision se mantine!");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Colision Final!");
        Debug.Log(collision.gameObject.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Colision Empezada!");
        Debug.Log(other.gameObject.name);
    }
    private void OnTriggerStay(Collider other)
    {
        //Debug.Log("Colision se mantine!");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Colision Final!");
        Debug.Log(other.gameObject.name);
    }
}
