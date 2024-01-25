using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
	[SerializeField] private TMP_InputField _playerNameInput;
	[SerializeField] private Slider _rSlider;
	[SerializeField] private Slider _gSlider;
	[SerializeField] private Slider _bSlider;
	[SerializeField] private GameObject _mainPanel;
	[SerializeField] private GameObject _settingsPanel;
	[SerializeField] private Image _image;

	private MainManager _mainManager;

	private void Start()
	{
		_mainManager = GameObject.Find("MainManager").GetComponent<MainManager>();
	}

	public void StartGame()
	{
		// Load new game scene
		SceneManager.LoadScene(1);
	}

	public void Settings()
	{
		// Open settings
		_mainPanel.SetActive(false);
		_settingsPanel.SetActive(true);
	}

	public void Exit()
	{
		// Close app
#if UNITY_EDITOR
		EditorApplication.ExitPlaymode();
#else
		Application.Quit();
#endif
	}

	public void SettingsBack()
	{
		// Back to main menu
		_mainPanel.SetActive(true);
		_settingsPanel.SetActive(false);
	}

	public void SettingsSave()
	{
		//Save settings
		_mainManager.SetPlayerName(_playerNameInput.text);
		_mainManager.SetPlayerColor(_rSlider.value,_gSlider.value,_bSlider.value,1f);
	}

	public void UpdateImageColor()
	{
		_image.color = new Color(_rSlider.value, _gSlider.value, _bSlider.value, 1f);
	}
}
