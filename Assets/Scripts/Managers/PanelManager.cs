using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class PanelManager : Singleton<PanelManager>
{
    // List of all the panels the manager can use
    public List<PanelModel> Panels;

    //Instances Holder
    private Queue<PanelInstanceModel> _queue = new Queue<PanelInstanceModel>();

    //fucntion for instatiating panels
    public void ShowPanel(string panelId)
    {
        PanelModel panelModel = Panels.FirstOrDefault(panel => panel.PanelID == panelId);

        if (panelModel != null)
        {
            //create a new panel instance
            var newPanelInstance = Instantiate(panelModel.PanelPrefab, transform);

            newPanelInstance.transform.localPosition = Vector3.zero;
            //Add this item to the queue
            _queue.Enqueue(new PanelInstanceModel
            {
                PanelId = panelId,
                PanelInstance = newPanelInstance
            });
            Debug.Log("Panel Instantiated");
        }
        else
        {
            Debug.LogWarning($"Trying to use pane ID = {panelId}, but is not found in Panels list");
        }
    }
    //Function for hiding the last instantiated panel
    public void HideLastPanel(string panelId)
    {
        if (AnyPanelShowing())
        {
            var lastPanel = _queue.Dequeue();

            //Destroy the last panel instance
            Destroy(lastPanel.PanelInstance);
        }
    }

    public bool AnyPanelShowing()
    {
        return GetAmountPanelsInQueue() > 0;
    }

    public int GetAmountPanelsInQueue()
    {
        return _queue.Count;
    }
}
