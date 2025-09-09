using UnityEngine;

public class GameBootstrap : MonoBehaviour
{
    [SerializeField] 
    private int targetFps = 60;

    void Awake()
    {
        QualitySettings.vSyncCount = 0;          // VSync ��Ȱ��
        Application.targetFrameRate = targetFps;  // 60fps Ÿ��
        Screen.sleepTimeout = SleepTimeout.NeverSleep;

        DontDestroyOnLoad(gameObject);
    }
}
