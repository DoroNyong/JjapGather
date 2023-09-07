using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelScripts : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private Text PanelName;
    [SerializeField] private Text GameName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetOnPanel()
    {
        panel.SetActive(true);
    }

    public void SetOffPanel()
    {
        if (PanelName.text.Length >= 2 && PanelName.text.Length <= 10)
        {
            GameName.text = PanelName.text;
            panel.SetActive(false);
        }
    }
}
