using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.VFX;

public class SceneManger : MonoBehaviour
{
    [SerializeField] private Button meteorButton;
    bool isMeteor=false;
    [SerializeField] GameObject vfx;
    // Start is called before the first frame update
    void Start()
    {
        meteorButton.onClick.AddListener(ChangeMeteor);
    }

    void ChangeMeteor()
    {
        if(isMeteor == false)
        {
            vfx.SetActive(true);
            isMeteor = true;
        } else
        {
            vfx.SetActive(false);
            isMeteor = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
