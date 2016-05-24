using UnityEngine;
using System.Collections.Generic;

public class VoyeurScript : MonoBehaviour {
    private float maxDistance;
    private HashSet<IWatchable> previouslyWatched = new HashSet<IWatchable>();

    // Use this for initialization
    void Start () {
        Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit[] hits;
        hits = Physics.RaycastAll(transform.position, transform.forward, 100.0F);

        HashSet<IWatchable> currentlyWatched = new HashSet<IWatchable>();
        foreach (RaycastHit hit in hits)
        {
            //hit.collider.gameObject
            IWatchable watchable = hit.collider.gameObject.GetComponent<IWatchable>();
            if (watchable != null)
            {
                currentlyWatched.Add(watchable);
                watchable.onWatched();
            }
        }
        
        previouslyWatched.ExceptWith(currentlyWatched);
        foreach (IWatchable watchable in previouslyWatched)
        {
            watchable.onStoppedWatching();
        }

        previouslyWatched = currentlyWatched;
    }
}
