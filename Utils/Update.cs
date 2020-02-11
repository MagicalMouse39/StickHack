#region " Imports "
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using InControl;
using System.Collections.ObjectModel;
using System.Collections;
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
// - Assembly-CSharp v0.0.0.0
#endregion 

class Controller
{
	// Limited support!
	// You can only reference methods or fields defined in the class (not in ancestors classes)
	// Fields and methods stubs are needed for compilation purposes only.
	// Reflexil will automaticaly map current type, fields or methods to original references.
	private void Update()
	{
		if (Input.GetKeyDown("G"))
			this.canFly = !this.canFly;
	}
	
	#region " Methods stubs "
	// Do not add or update any method. If compilation fails because of a method declaration, comment it
	Controller()
	{
	}
	
	CharacterActions get_PlayerActions()
	{
		return default(CharacterActions);
	}
	
	bool get_HasControl()
	{
		return default(bool);
	}
	
	System.Byte get_MovementState()
	{
		return default(System.Byte);
	}
	
	UnityEngine.Vector2 get_LookRotation()
	{
		return default(UnityEngine.Vector2);
	}
	
	void Start()
	{
	}
	
	void OnDisabled()
	{
	}
	
	void OnRoundKillCounterChanged(string key, int newValue)
	{
	}
	
	void OnMultiKill(string key, int killCount)
	{
	}
	
	void OnKillingSpreeChanged(string key, int newValue)
	{
	}
	
	void TakeLocalControl(CharacterActions actions)
	{
	}
	
	void SetCollision(bool enabled)
	{
	}
	
	void LateUpdate()
	{
	}
	
	void CheckForKick()
	{
	}
	
	void IncrementKickTimer()
	{
	}
	
	void KickMySelf()
	{
	}
	
	bool CheckForInput()
	{
		return default(bool);
	}
	
	void ResetKickTimer()
	{
	}
	
	void AssignNewDevice(InControl.InputDevice inputDevice, bool keyBoard)
	{
	}
	
	void Move(float direction)
	{
	}
	
	void Left()
	{
	}
	
	void Right()
	{
	}
	
	void Fly(UnityEngine.Vector3 flyDirection, float speed)
	{
	}
	
	void Jump(bool force, bool forceWallJump)
	{
	}
	
	void Down()
	{
	}
	
	void Attack()
	{
	}
	
	void StartBlock()
	{
	}
	
	void EndBlock()
	{
	}
	
	void Throw()
	{
	}
	
	void ActivateEnergy(bool active)
	{
	}
	
	void UserAim()
	{
	}
	
	void RotateTowardsMouse(UnityEngine.Transform trans)
	{
	}
	
	void SetNewMovementType(System.Byte movementType)
	{
	}
	
	void SetNewLookRotation(UnityEngine.Vector2 rot)
	{
	}
	
	void ApplyMovementState()
	{
	}
	
	void OnDeath()
	{
	}
	
	void OnUnloadMap()
	{
	}
	
	void OnTakeDamage(float damageTaken)
	{
	}
	
	void OnFallOut()
	{
	}
	
	static Controller()
	{
	}
	
	#endregion 
	
	#region " Fields stubs "
	// Do not add or update any field. If compilation fails because of a field declaration, comment it
	static bool allowMouse;
	Movement movement;
	Rotation rotation;
	Animations animation;
	CharacterInformation info;
	bool isAI;
	UnityEngine.Transform playerTarget;
	Fighting fighting;
	CharacterActions mPlayerActions;
	UnityEngine.Transform aimer;
	UnityEngine.Transform helpAimer;
	BlockHandler blockHandler;
	int playerID;
	UnityEngine.ParticleSystem jumpPart;
	UnityEngine.Transform torso;
	GrabHandler grabHandler;
	bool inactive;
	bool canFly;
	float flySpeed;
	static bool mIsNetworkMatch;
	bool mHasControl;
	UnityEngine.Vector2 mLookRotation;
	MemoryBucket TransientMemory;
	MemoryBucket PersistentMemory;
	float m_KickCounter;
	static float m_KickTime;
	#endregion 

}
