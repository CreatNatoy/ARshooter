using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Text _scoreDisplay; 

    private void OnEnable()
    {
        _player.ScoreAdded += OnScoreAdded; 
    }

    private void OnDisable()
    {
        _player.ScoreAdded -= OnScoreAdded;
    }

    private void OnScoreAdded(int score)
    {
        _scoreDisplay.text = score.ToString(); 
    }
}
