using System.Collections;
using UnityEngine;
using UnityEngine.Events;

[DisallowMultipleComponent]
public class GameManager : MonoBehaviour
{
    public UnityEvent onAwake, onStart, onLateInit, onGameStart, onGameOver, onGameWin, onRestartGame;
    private readonly WaitForFixedUpdate _wffu = new();

    private void Awake()
    {
        onAwake.Invoke();
    }
    
    private void Start()
    {
        onStart.Invoke();
        StartCoroutine(LateInit());
    }
    
    private IEnumerator LateInit()
    {
        yield return _wffu;
        yield return _wffu;
        yield return _wffu;
        onLateInit.Invoke();
    }

    public void StartGame()
    {
        onGameStart.Invoke();
    }

    public void GameOver()
    {
        onGameOver.Invoke();
    }

    public void GameWin()
    {
        onGameWin.Invoke();
    }

    public void RestartGame()
    {
        onRestartGame.Invoke();
    }
}