using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CoreGame.MenuSystem;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    Button UI_Btn_loadGame;

    [SerializeField]
    int loadSceneIndex;

    private void Awake()
    {
        UI_Btn_loadGame.onClick.AddListener(delegate { MenuSystem.LoadGame(loadSceneIndex); });
    }
}
