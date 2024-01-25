using UnityEngine;

public class MainManager : MonoBehaviour
{
	public static MainManager Instance;

	//DATA
	private static readonly Color DefaultPlayerColor = Color.white;
	private Color _playerColor = DefaultPlayerColor;
	private string _playerName = "Player";
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
}
