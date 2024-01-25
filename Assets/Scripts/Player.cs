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
		Init();
    }


	private void Update()
	{
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
	}

    private void Init()
    {
		// Get Main Manager object
		_mainManager = GameObject.Find("MainManager").GetComponent<MainManager>();

		// Set player color
		_playerColor.color = _mainManager.GetPlayerColor();

		// Set player name
		if (_mainManager.GetPlayerName() != string.Empty)
		{

			_playerName.text = _mainManager.GetPlayerName();
		}
		else
		{
			_playerName.text = "Player";
		}
	}
}
