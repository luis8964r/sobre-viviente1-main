using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camaraController : MonoBehaviour
{
    public Transform personaje;

    private float tama�oCamara;
    private float alturaPantalla;
    // Start is called before the first frame update
    void Start()
    {
        tama�oCamara = Camera.main.orthographicSize;
        alturaPantalla = tama�oCamara * 2;
    }

    // Update is called once per frame
    void Update()
    {
        CalcularPosicionCamara();
    }
    void CalcularPosicionCamara()
    { 
        int pantallaPersonaje = (int)(personaje.position.y  / alturaPantalla);
        float alturaCamara = (pantallaPersonaje * alturaPantalla) + tama�oCamara;

        transform.position = new Vector3(transform.position.x, alturaCamara, transform.position.z);
    }
}
