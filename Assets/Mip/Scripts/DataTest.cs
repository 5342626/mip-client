using UnityEngine;
using System.Collections;
using GameDataEditor;

public class DataTest : MonoBehaviour
{

    GDEeventsData eventsData;

    // Use this for initialization
    void Start()
    {
        if (!GDEDataManager.Init("gde_data"))
        {
            Debug.Log("GDEData init failed");
        }
        GDEDataManager.DataDictionary.TryGetCustom(GDEItemKeys.events_GoogleItem, out eventsData);
        
        Debug.Log("inttest = " + eventsData.inttest);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
