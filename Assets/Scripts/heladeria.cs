using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heladeria : MonoBehaviour
{
    public float precioPorKilo= 1250;
    public float inputGramos;
    public string codigo;

    string frutiCode = "FRU";
    string chocoCode = "CHO";
    string ddlCode = "DDL";
    float precioPorGramo;
    float precioFinal;
    float gramosMinimos = 250;
    float gramosMaximos = 3000;


    void Start()
    {
        precioPorGramo = precioPorKilo / 1000;

        if (codigo != chocoCode && codigo != frutiCode && codigo != ddlCode)
        {
            Debug.Log("codigo invalido");
        }
        if (inputGramos > 250 || inputGramos > 3000)
        {
            Debug.Log("candidad minima: " + gramosMinimos + " cantidad maxima: " + gramosMaximos);
            
        } else
        {
            if (codigo == chocoCode || codigo == ddlCode)
            {
                precioFinal = inputGramos * precioPorGramo;
                Debug.Log(precioFinal);
            }
            else if (codigo == "FRU")
            {
                precioPorGramo = precioPorGramo * 0.9f;
                precioFinal = precioPorGramo * inputGramos;
                Debug.Log(precioFinal);
            }
            else
            {
                return;
            }
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
