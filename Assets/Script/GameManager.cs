using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public int PuntosTotales { get { return puntosTotales; } }
    public HUB Hub;
    private int puntosTotales;
    private int vidas = 3;

    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.Log("Mas de un manager en escena");
        }
    }

    public void SumarPuntos ( int puntosASumar)
    {
        puntosTotales += puntosASumar;
        Hub.ActualizarPuntos(PuntosTotales);
    }

    public void PerderVida()
    {
        vidas -= 1;
        Hub.DesactivarVida(vidas);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
