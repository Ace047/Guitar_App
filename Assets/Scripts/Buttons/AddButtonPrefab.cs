using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddButtonPrefab : MonoBehaviour
{
    public Transform PanelPrefab;
    public GameObject ContentPrefab;
    
    public void AddContent()
    {
        GameObject newContent = Instantiate(ContentPrefab, transform);
        newContent.transform.SetParent(PanelPrefab, false);
        
        
    }
}
