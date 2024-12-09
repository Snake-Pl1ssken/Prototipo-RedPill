using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SiguienteNivel : MonoBehaviour
{
    void Lvl1aLvl2()
    {
        SceneManager.LoadScene("Level2");
    }
    void Lvl2aLvl3()
    {
        SceneManager.LoadScene("Level3");
    }
    void Lvl3aMainMenu()
    {
        SceneManager.LoadScene("Main_Menu");
    }
}
