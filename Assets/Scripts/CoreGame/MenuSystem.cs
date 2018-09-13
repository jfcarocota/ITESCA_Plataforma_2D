using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using CoreGame.MemorySystem;

namespace CoreGame
{
    namespace MenuSystem
    {
        public class MenuSystem
        {
            public void NewGame()
            {

            }

            public static void LoadGame(int sceneIndex)
            {
                //GameData gd = MemorySystem.LoadData();
                SceneManager.LoadScene(sceneIndex);
            }

            public void Erase()
            {

            }
        }
    }
}
