using UnityEngine;

public class GameBootstrap : MonoBehaviour
{
    [SerializeField] 
    private int targetFps = 60;

    void Awake()
    {
        QualitySettings.vSyncCount = 0;          // VSync ∫Ò»∞º∫
        Application.targetFrameRate = targetFps;  // 60fps ≈∏±Í
        Screen.sleepTimeout = SleepTimeout.NeverSleep;

        DontDestroyOnLoad(gameObject);
    }
}
