using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEXTO : MonoBehaviour
{
    public GameObject panel;
    // Start is called before the first frame update
    private void Start()
    {
        PanelOff();
    }

    // Update is called once per frame
    public void PanelOn()
    {
        panel.SetActive(true);
    }
    public void PanelOff()
    {
        panel.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PanelOn();
        }
    }
    private void OntriggerExit(Collider other)
    {
        PanelOff();
    }
}
