using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public enum GameMode {
    preGame,
    loading, 
    makeLevel, 
    levelPrep,
    inLevel
}

public class WordGame : MonoBehaviour {
    static public WordGame S;

    [Header("Set Dynamically")]
    public GameMode mode = GameMode.preGame;
    void Awake() {
        S = this;
    }

    void Start() {
        mode = GameMode.loading;

        WordList.INIT();
    }

    public void WordListParseComplete()
    {
        mode = GameMode.makeLevel;
    }
}