using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class senseComponent : entIPlacedComponent
	{
		[Ordinal(5)] 
		[RED("enableBeingDetectable")] 
		public CBool EnableBeingDetectable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("visibleObject")] 
		public CHandle<senseVisibleObject> VisibleObject
		{
			get => GetPropertyValue<CHandle<senseVisibleObject>>();
			set => SetPropertyValue<CHandle<senseVisibleObject>>(value);
		}

		[Ordinal(7)] 
		[RED("sensorObject")] 
		public CHandle<senseSensorObject> SensorObject
		{
			get => GetPropertyValue<CHandle<senseSensorObject>>();
			set => SetPropertyValue<CHandle<senseSensorObject>>(value);
		}

		[Ordinal(8)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("forceDisableUI")] 
		public CBool ForceDisableUI
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("highLevelCb")] 
		public CHandle<redCallbackObject> HighLevelCb
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(11)] 
		[RED("reactionCb")] 
		public CHandle<redCallbackObject> ReactionCb
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(12)] 
		[RED("wantedLevelChangedCb")] 
		public CHandle<redCallbackObject> WantedLevelChangedCb
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(13)] 
		[RED("highLevelState")] 
		public CEnum<gamedataNPCHighLevelState> HighLevelState
		{
			get => GetPropertyValue<CEnum<gamedataNPCHighLevelState>>();
			set => SetPropertyValue<CEnum<gamedataNPCHighLevelState>>(value);
		}

		[Ordinal(14)] 
		[RED("mainPreset")] 
		public TweakDBID MainPreset
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(15)] 
		[RED("secondaryPreset")] 
		public TweakDBID SecondaryPreset
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(16)] 
		[RED("puppetBlackboard")] 
		public CWeakHandle<gameIBlackboard> PuppetBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(17)] 
		[RED("hideUIElements")] 
		public CBool HideUIElements
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(18)] 
		[RED("enabledSenses")] 
		public CBool EnabledSenses
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(19)] 
		[RED("shouldStartDetectingPlayerCached")] 
		public CBool ShouldStartDetectingPlayerCached
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("wasPlayerLastReactionTarget")] 
		public CBool WasPlayerLastReactionTarget
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(21)] 
		[RED("logSource")] 
		public CEnum<ESenseLogSource> LogSource
		{
			get => GetPropertyValue<CEnum<ESenseLogSource>>();
			set => SetPropertyValue<CEnum<ESenseLogSource>>(value);
		}

		[Ordinal(22)] 
		[RED("playerTakedownStateCallbackID")] 
		public CHandle<redCallbackObject> PlayerTakedownStateCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(23)] 
		[RED("playerUpperBodyStateCallbackID")] 
		public CHandle<redCallbackObject> PlayerUpperBodyStateCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(24)] 
		[RED("playerCarryingStateCallbackID")] 
		public CHandle<redCallbackObject> PlayerCarryingStateCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(25)] 
		[RED("playerInPerception")] 
		public CWeakHandle<PlayerPuppet> PlayerInPerception
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		public senseComponent()
		{
			Name = "Component";
			LocalTransform = new WorldTransform { Position = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() }, Orientation = new Quaternion { R = 1.000000F } };
			EnableBeingDetectable = true;
			IsEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
