using UnityEngine;
using System.Collections;

public class PrintWatchable : MonoBehaviour, IWatchable
{
    public void onStoppedWatching()
    {
        Debug.Log("onStoppedWatching");
        
        MeshRenderer mesh = GetComponent<MeshRenderer>();
        mesh.material.color = Color.white;
    }

    public void onWatched()
    {
        Debug.Log("onWatched");
        
        MeshRenderer mesh = GetComponent<MeshRenderer>();
        mesh.material.color = Color.red;
    }
}