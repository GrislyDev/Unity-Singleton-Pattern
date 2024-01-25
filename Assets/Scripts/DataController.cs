using System;
using System.IO;
using UnityEngine;

public class DataController
{
	private string _path;
	private GameData _gameData;

	public DataController()
	{
		_path = Path.Combine(Application.persistentDataPath, "savefile.json");
		_gameData = new GameData();
	}

	public void SaveData()
	{
		string json = JsonUtility.ToJson(_gameData);
		File.WriteAllText(_path, json);
	}

	public void LoadData()
	{
		if (File.Exists(_path))
		{
			string json = File.ReadAllText(_path);
			_gameData = JsonUtility.FromJson<GameData>(json);
		}
	}

	public GameData GetGameData()
	{
		return _gameData;
	}
}
