﻿using UnityEngine;
using UnityEngine.UI;
using EazyTools.SoundManager;

[RequireComponent(typeof(Image))]
/// <summary>Singleton class for controlling pause functions.</summary>
public class SumPause : MonoBehaviour {

    // Event managers
    public delegate void PauseAction(bool paused);
    public static event PauseAction pauseEvent;	

    // Variables set via inspector
    [SerializeField]
    bool useEvent = false, detectEscapeKey = true;
    [SerializeField]
    Sprite pausedSprite, playingSprite;

    // Link to button's image
    Image image;

    static bool status = false;
    /// <summary>
    /// Sets/Returns current pause state (true for paused, false for normal)
    /// </summary>
    public static bool Status {
        get { return status; }
        set {
            status = value;

            OnChange();

            // Change image to the proper sprite if everything is set
            if (CheckLinks())
                instance.image.sprite = status ? instance.pausedSprite : instance.playingSprite;
            else
                Debug.LogError("Links missing on SumPause component. Please check the sumPauseButton object for missing references.");

            // Notify other objects of change
            if (instance.useEvent && pauseEvent != null)
                pauseEvent(status);
        }
    }

    // Instance used for singleton
    public static SumPause instance;

	Vector2 pausePos = new Vector2(307,-222);

	public GameObject pausedText;
	static bool showPausedText; 

	public AudioClip fx_click;

    void Awake () {

		pausedText.SetActive (false);
        image = GetComponent<Image>();
    }

    void Start () {
        // Ensure singleton
        if (SumPause.instance == null)
            SumPause.instance = this;
        else
            Destroy(this);
    }

    void Update() {
        // Listen for escape key and pause if needed
        if (detectEscapeKey && Input.GetKeyDown(KeyCode.Escape))
            TogglePause();

		if(showPausedText) pausedText.SetActive(true);
			else pausedText.SetActive(false);
    }

    /// <summary>
    /// Flips the current pause status. Called from the attached button in 
    /// the inspector.
    /// </summary>
    public void TogglePause () {
		SoundManager.PlayUISound (fx_click);
        Status = !Status; // Flip current status
    }

    /// <summary>Checks if all links are properly connected</summary>
    /// <returns>False means links are missing</returns>
    static bool CheckLinks () {
        return (instance.image != null && instance.playingSprite != null && instance.pausedSprite != null);
    }

    /// <summary>This is what we want to do when the game is paused or unpaused.</summary>
    static void OnChange() {
        if(status) {
            // What to do when paused
			showPausedText = true;
            Time.timeScale = 0; // Set game speed to 0
        }
        else {
            // What to do when unpaused
			showPausedText = false;
			Time.timeScale = 1; // Resume normal game speed
        }
    }
}
