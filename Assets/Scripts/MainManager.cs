using UnityEngine;

public class MainManager : MonoBehaviour
{
	public static MainManager Instance { get; private set; }
	private DataController dataController;

	//DATA
	private Color _playerColor;
	private string _playerName;
	//END_DATA

	private void Awake()
	{
		if (Instance != null)
		{
			Destroy(gameObject);
			return;
		}

		Instance = this;
		DontDestroyOnLoad(gameObject);

		dataController = new DataController();
		LoadData();
	}

	public void SetPlayerColor(float r, float g, float b, float a)
	{
		_playerColor = new Color(r, g, b, a);
	}
	public Color GetPlayerColor()
	{
		return _playerColor;
	}

	public void SetPlayerName(string name)
	{
		_playerName = name;
	}
	public string GetPlayerName()
	{
		return _playerName;
	}
	public DataController GetDataManager()
	{
		return dataController;
	}

	private void LoadData()
	{
		dataController.LoadData();
		var gameData = dataController.GetGameData();

		if (gameData.playerColor != null)
		{
			_playerColor = gameData.playerColor;
		}
		if (gameData.playerName != null)
		{
			_playerName = gameData.playerName;
		}
	}
}
