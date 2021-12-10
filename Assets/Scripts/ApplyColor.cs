using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyColor : MonoBehaviour
{
    // Obtiene la c�mara y el color asignado
    public Camera camera;
    public Color color;

    // Cambia el color al gameObject al iniciar
    private void Start()
    {
        GetComponent<MeshRenderer>().material.color = color;
    }

    // Al hacer click encima, cambia el color de fondo de la c�mara
    private void OnMouseDown()
    {
        camera.backgroundColor = color;
    }
}
