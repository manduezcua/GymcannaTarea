using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControlVidas : MonoBehaviour
{
    
    public Slider slider;
    public float vida;
    public float vidaMax;

    // Start is called before the first frame update
    void Start()
    {
        vidaMax = 5;
        vida = vidaMax;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = vida / vidaMax;

        if (vida == 0)
        {
            Perder();
        }
    }
    public void Perder()
    {
        SceneManager.LoadScene(0);
    }
    public void QuitarVidas(int cantidadVidas)
    {
        vida -= cantidadVidas;
    }
}
