using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisolveChange : MonoBehaviour
{
    [SerializeField] private Button runShaderButton;
    private Material material;
    private bool shaderUp = true;
    private float shaderValue = 6.5f;
    void Start()
    {
        runShaderButton.onClick.AddListener(RunShader);
        material = GetComponent<MeshRenderer>().sharedMaterial; 
    }

    void RunShader()
    {
        if (shaderUp == true)
        {
            StartCoroutine(ShaderDown());
            shaderUp = false;
        } else
        {
            StartCoroutine(ShaderUp());
            shaderUp = true;
        }
        
    }
    IEnumerator ShaderDown()
    {
        while (shaderValue >= -1f)
        {
            yield return new WaitForSeconds(0.05f);
            shaderValue -= 0.1f;
            material.SetFloat("_Cutoff_height", shaderValue);
        }
    }
    IEnumerator ShaderUp()
    {
        while (shaderValue <= 6.6f)
        {
            yield return new WaitForSeconds(0.05f);
            shaderValue += 0.1f;
            material.SetFloat("_Cutoff_height", shaderValue);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
