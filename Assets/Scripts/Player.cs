using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private TMP_Text _playerName;
    [SerializeField] private Material _playerColor;
    private MainManager _mainManager;

    private void Start()
    {
        _mainManager = GameObject.Find("MainManager").GetComponent<MainManager>();
        _playerName.text = _mainManager.GetPlayerName();
        _playerColor.color = _mainManager.GetPlayerColor();
    }


	private void Update()
	{
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
	}
}
