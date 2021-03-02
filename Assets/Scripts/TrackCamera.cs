using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackCamera : DefaultTrackableEventHandler
{
    public Rigidbody rb;
    public GameObject playButton, pausePanel;
    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        rb.useGravity = true;

        Time.timeScale = 1;
        pausePanel.SetActive(false);
        if (!Gaming.isInGame)
            playButton.SetActive(true);

    }
    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        rb.useGravity = false;
        playButton.SetActive(false);
        if (Gaming.isInGame)
        {
            Time.timeScale = 0;
            pausePanel.SetActive(true);
        }
    }
}
