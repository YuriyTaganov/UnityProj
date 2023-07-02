using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Radio : MonoBehaviour
{
    public Material DefaultMaterial;
    public Material ActiveMaterial;
    private MeshRenderer meshRenderer = new MeshRenderer();


    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material = DefaultMaterial;
    }


    public void SetNewMaterial()
    {
        meshRenderer.material = ActiveMaterial;
    }

    public void SetDefaultMaterial()
    {
        meshRenderer.material = DefaultMaterial;
    }
}
