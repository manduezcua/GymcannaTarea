using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConntrolVidaDuende : MonoBehaviour
{
    public Slider slider;
    public float vida;
    public float vidaMax;
    private Animator anima;
    private ControlAtaque controlAtaqueDes;

    // Start is called before the first frame update
    void Start()
    {
        vidaMax = 2;
        vida = vidaMax;
        anima = this.gameObject.GetComponent<Animator>();
        controlAtaqueDes = this.gameObject.GetComponent<ControlAtaque>();
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = vida / vidaMax;

        if (vida == 0)
        {
            Destroy(controlAtaqueDes);
            anima.Play("Morir");
        }
    }
    public void QuitarVidas(int cantidadVidas)
    {
        vida -= cantidadVidas;
    }


}
