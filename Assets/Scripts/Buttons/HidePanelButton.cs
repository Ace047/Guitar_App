using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidePanelButton : MonoBehaviour
{
    public string PanelId;

    //Cached panel manager
    private PanelManager _panelManager;

    private void Start()
    {
        //Cache
        _panelManager = PanelManager.Instance;
    }
    public void DoHidePanel ()
    {
        _panelManager.HideLastPanel(PanelId);
    }
}
