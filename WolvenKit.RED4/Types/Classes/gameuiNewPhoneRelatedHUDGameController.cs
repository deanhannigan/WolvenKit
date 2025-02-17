using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiNewPhoneRelatedHUDGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("isNewPhoneEnabled")] 
		public CBool IsNewPhoneEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(11)] 
		[RED("visibilityFact1ListenerId")] 
		public CUInt32 VisibilityFact1ListenerId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(12)] 
		[RED("visibilityFact2ListenerId")] 
		public CUInt32 VisibilityFact2ListenerId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public gameuiNewPhoneRelatedHUDGameController()
		{
			IsNewPhoneEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
