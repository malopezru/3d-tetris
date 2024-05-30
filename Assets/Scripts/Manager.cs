using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static bool _backgound;
    public static int _screenWidthOffset;
    public static int _screenHeightOffset;
    public static int _playerGUIFontSize;
    public static float _currentTimerValue;

    public float[] _dropTimer = new float[]
    {
        0.2f,
        0.4f,
        0.6f,
        0.8f,
        1.0f,
        1.2f,
        1.4f,
        1.6f,
        1.8f,
        2.0f
    };

    void Start()
    {
        _currentTimerValue = _dropTimer[9];
        UpdateSettings();
    }

    void Update()
    {

    }

    private void UpdateSettings()
    {
        _screenWidthOffset = (int)(Screen.width/70);
        _screenHeightOffset = (int)(Screen.height/40);
        _playerGUIFontSize = (int)(Screen.width/40);
    }
}
