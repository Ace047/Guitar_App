using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPanelButton : MonoBehaviour
{
    //The id of the panel to show
    public string PanelId;

    //Cached panel manager
    private PanelManager _panelManager;

    //The main panel of the ui
    [SerializeField]
    private GameObject mainPanel;


    private void Start()
    {
        //Cache
        _panelManager = PanelManager.Instance; 
    }
    public void DoShowPanel()
    {
        _panelManager.ShowPanel(PanelId);
    }



}
