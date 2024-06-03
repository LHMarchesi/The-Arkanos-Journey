using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScreensManager : MonoBehaviour
{
    public static ScreensManager Instance { get; private set; }
    [SerializeField] private GameObject winingCanvas;
    [SerializeField] private GameObject losingCanvas;
    [SerializeField] private GameObject PauseCanvas;

    private float previusTimeScale = 1;
    public static bool isPaused;

    public TextMeshProUGUI pointsTextWinMenu;
    public TextMeshProUGUI pointsRecordText;
    public TextMeshProUGUI pointsTextLoseMenu;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        winingCanvas.SetActive(false);
        losingCanvas.SetActive(false);
        PauseCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            TogglePause();
        }
    }

    public void ShowLoseScreen()
    {
        pointsTextLoseMenu.text = "Puntos totales : " + BattleManager.totalpoints.ToString();
        losingCanvas.SetActive(true);
    }

    public void ShowWinScreen()
    {
        int recordPoints = PlayerPrefs.GetInt("RecordPoints", 0);
        if (BattleManager.totalpoints > recordPoints)  // Guardar mejor puntaje
        {
            PlayerPrefs.SetInt("RecordPoints", BattleManager.totalpoints);
            recordPoints = BattleManager.totalpoints;
        }

        pointsRecordText.text = "Best Record: " + recordPoints.ToString();
        pointsTextWinMenu.text = "Puntos totales: " + BattleManager.totalpoints.ToString();
        winingCanvas.SetActive(true);
    }
    private void TogglePause()
    {
        if (Time.timeScale > 0)
        {
            previusTimeScale = Time.timeScale;
            Time.timeScale = 0;
            AudioListener.pause = true;
            PauseCanvas.SetActive(true);
            isPaused = true;
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = previusTimeScale;
            AudioListener.pause = false;
            PauseCanvas.SetActive(false);
            isPaused = false;
        }
    }
}
