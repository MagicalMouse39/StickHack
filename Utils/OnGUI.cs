#region " Imports "
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine.Events;
using TMPro;
using Steamworks;
using UnityEngine.Analytics;
using UnityEngine.UI;
#endregion 

#region " Referenced assemblies "
// - UnityEngine v0.0.0.0
// - UnityEngine.UI v1.0.0.0
// - TextMeshPro-1.0.55.56.0b9 v0.0.0.0
// - mscorlib v2.0.0.0
// - System.Core v3.5.0.0
// - Assembly-CSharp-firstpass v0.0.0.0
// - Lidgren.Network v2012.1.7.0
// - System v2.0.0.0
// - UnityEngine.Analytics v0.0.0.0
// - System.Xml v2.0.0.0
// - mscorlib v2.0.5.0
// - Assembly-CSharp v0.0.0.0
#endregion 

class GameManager
{
	// Limited support!
	// You can only reference methods or fields defined in the class (not in ancestors classes)
	// Fields and methods stubs are needed for compilation purposes only.
	// Reflexil will automaticaly map current type, fields or methods to original references.
	void OnGUI()
	{
		GUI.TextField(new Rect(5, 5, 200, 20), "Magical");
	}
	
	#region " Methods stubs "
	// Do not add or update any method. If compilation fails because of a method declaration, comment it
	GameManager()
	{
	}
	
	System.Collections.Generic.List<UnityEngine.Rigidbody> get_SpawnedWeapons()
	{
		return default(System.Collections.Generic.List<UnityEngine.Rigidbody>);
	}
	
	void Awake()
	{
	}
	
	void Start()
	{
	}
	
	void InitAnalytics()
	{
	}
	
	void Update()
	{
	}
	
	MapWrapper GetCurrentMap()
	{
		return default(MapWrapper);
	}
	
	void RestartGame()
	{
	}
	
	void SpawnRandomWeapon()
	{
	}
	
	void DissarmPlayers()
	{
	}
	
	void ReviveAllPlayers(bool newMap)
	{
	}
	
	UnityEngine.GameObject FindWeaponByIndex(int weaponIndex)
	{
		return default(UnityEngine.GameObject);
	}
	
	int GetPlayersAlive()
	{
		return default(int);
	}
	
	System.Collections.Generic.List<CharacterActions> get_SavedDevicesForNetwork()
	{
		return default(System.Collections.Generic.List<CharacterActions>);
	}
	
	int KillAllPlayers(bool network)
	{
		return default(int);
	}
	
	void AllButOnePlayersDied()
	{
	}
	
	void EnableObjects()
	{
	}
	
	void StartMatch(MapWrapper mapIndex, bool MovePlayers)
	{
	}
	
	void LoadMapCourotine(MapWrapper map)
	{
	}
	
	System.Collections.IEnumerator StartMapSequence(MapWrapper mapIndex, bool MovePlayers)
	{
		return default(System.Collections.IEnumerator);
	}
	
	void OnLevelFinishedLoading(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)
	{
	}
	
	void OnMapSizeChanged(float newSize)
	{
	}
	
	System.Collections.IEnumerator LoadMap(MapWrapper mapIndex)
	{
		return default(System.Collections.IEnumerator);
	}
	
	System.Collections.IEnumerator RemoveMap(MapWrapper mapIndex)
	{
		return default(System.Collections.IEnumerator);
	}
	
	System.Collections.IEnumerator PrepareMapForTravel(UnityEngine.GameObject map, bool comingIn)
	{
		return default(System.Collections.IEnumerator);
	}
	
	System.Collections.IEnumerator StartCountdownAfterSeconds(float seconds)
	{
		return default(System.Collections.IEnumerator);
	}
	
	void StartCountDown()
	{
	}
	
	System.Collections.IEnumerator CountDownCoroutine()
	{
		return default(System.Collections.IEnumerator);
	}
	
	System.Collections.IEnumerator MovePlayer(UnityEngine.Rigidbody player, UnityEngine.Vector3 targetPosition)
	{
		return default(System.Collections.IEnumerator);
	}
	
	void NetworkAllPlayersDiedButOne(MapWrapper newlevel, System.Byte winner)
	{
	}
	
	System.Byte FindWeaponIdByName(string weaponName)
	{
		return default(System.Byte);
	}
	
	UnityEngine.GameObject GetWeaponWithIndexAndOverFlow(System.Byte weaponID)
	{
		return default(UnityEngine.GameObject);
	}
	
	CharacterActions GetNextSavedDeviceForNetwork()
	{
		return default(CharacterActions);
	}
	
	CharacterActions GetDefaultBindings()
	{
		return default(CharacterActions);
	}
	
	void DisableAllPlayers()
	{
	}
	
	bool IsInLobby()
	{
		return default(bool);
	}
	
	static GameManager()
	{
	}
	
	#endregion 
	
	#region " Fields stubs "
	// Do not add or update any field. If compilation fails because of a field declaration, comment it
	static int playersBeingMoved;
	static bool inFight;
	static bool stillInMenu;
	static bool spawnWeaponsAsPresents;
	CodeStateAnimation mapAnimation;
	UnityEngine.AnimationCurve movePlayerCurve;
	float movePlayerTime;
	ControllerHandler controllerHandler;
	System.Collections.Generic.List<UnityEngine.Rigidbody> mSpawnedWeapons;
	MultiplayerManager mMultiplayerManager;
	P2PPackageHandler P2PPackageHandler;
	MapInfo[] maps;
	MapInfo currentMapInfo;
	MapInfo oldMap;
	UnityEngine.GameObject mapHolder;
	MapWrapper lastMapNumber;
	UnityEngine.GameObject[] weapons;
	UnityEngine.GameObject[] weaponsT2;
	UnityEngine.GameObject[] weaponsT3;
	UnityEngine.GameObject[] weaponSpeciaTier;
	UnityEngine.GameObject[] GodWeapons;
	UnityEngine.GameObject[] poolRanged;
	UnityEngine.GameObject[] poolMeele;
	UnityEngine.GameObject[] poolSniper;
	UnityEngine.GameObject[] poolHandguns;
	UnityEngine.GameObject[] poolExplosive;
	UnityEngine.GameObject[] poolSnakes;
	UnityEngine.GameObject[] poolLava;
	TMPro.TextMeshProUGUI winText;
	float randomWeaponCounter;
	UnityEngine.AudioSource au;
	UnityEngine.AudioClip[] winClips;
	bool isLoading;
	bool isLoadingInternal;
	bool dontSpawnItems;
	float secondsBeforeSuddendeath;
	float matchTime;
	HoardHandler hoardHandler;
	Crown crown;
	Vicotory vicotory;
	bool testing;
	bool loadSuccessful;
	int numberOfMaps;
	CountDown mCountDownHandler;
	CodeStateAnimation mWaitTextAnimator;
	LevelSelection levelSelector;
	OnlineRoom onlineRoom;
	WeaponSelectionHandler m_WeaponSelectionHandler;
	MultiplayerManager mNetworkManager;
	TMPro.TMP_InputField chatInputField;
	UnityEngine.GameObject[] enableOnStart;
	UnityEngine.GameObject[] disableOnStart;
	CustomMapInfoSubscriberHandler m_CustomMapInfoHandler;
	bool spawnedLastWeaponOnLeftSide;
	float extraSpawnWeaponTime;
	System.Action OnMatchEnded;
	UnityEngine.GameObject GameCanvas;
	static AnalytcisTrigger m_AnalyticsTrigger;
	System.Collections.Generic.List<CharacterActions> mSavedDevicesForNetwork;
	AspectFix m_CameraAspectFix;
	UnityEngine.Transform m_Bars;
	float LastAppliedScale;
	bool mPlayingCountdown;
	#endregion 

}
