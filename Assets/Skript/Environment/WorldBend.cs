using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldBend : MonoBehaviour
{
    // Start is called before the first frame update
    [Range(0f, 0.01f)]
    [Tooltip("For life preview go to Assets>Materials and mark all materials and change the bend amount")]
    [Header("Bend Amount [Hover for more info]")]
    [SerializeField] float bend = 0;
    void Start()
    {
        // Finde alle Materialien mit dem Shader "worldBend"
        Material[] materials = FindMaterialsByShader("Shader Graphs/WorldBend");

        // Setze den BendAmount-Wert für jedes Material auf den Zielwert.
        foreach (Material material in materials)
        {
            Debug.Log("yo");
            material.SetFloat("_BendAmount", bend);
        }
    }

    // Methode zum Finden von Materialien mit einem bestimmten Shader
    private Material[] FindMaterialsByShader(string shaderName)
    {
        Renderer[] allRenderers = FindObjectsOfType<Renderer>();
        // Eine Liste zum Speichern der gefundenen Materialien
        List<Material> foundMaterials = new List<Material>();

        // Iteriere über alle Renderer
        foreach (Renderer renderer in allRenderers)
        {
            // Iteriere über alle Materialien jedes Renderers
            foreach (Material material in renderer.sharedMaterials)
            {
                // Überprüfe, ob das Material den gewünschten Shader hat
                if (material.shader.name.Contains(shaderName))
                {
                    Debug.Log("foundSomeThing");
                    foundMaterials.Add(material);
                }
            }
        }

        return foundMaterials.ToArray();
    }
 
}
