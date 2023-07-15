using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CustomDialogViewController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("messagesList")] 
		public inkCompoundWidgetReference MessagesList
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("messagesListController")] 
		public CWeakHandle<CustomEntriesListController> CustomEntriesListController
		{
			get => GetPropertyValue<CWeakHandle<CustomEntriesListController>>();
			set => SetPropertyValue<CWeakHandle<CustomEntriesListController>>(value);
		}

		[Ordinal(3)] 
		[RED("scrollController")] 
		public CWeakHandle<inkScrollController> ScrollController
		{
			get => GetPropertyValue<CWeakHandle<inkScrollController>>();
			set => SetPropertyValue<CWeakHandle<inkScrollController>>(value);
		}

		[Ordinal(4)] 
		[RED("journalManager")] 
		public CWeakHandle<gameJournalManager> JournalManager
		{
			get => GetPropertyValue<CWeakHandle<gameJournalManager>>();
			set => SetPropertyValue<CWeakHandle<gameJournalManager>>(value);
		}

		[Ordinal(5)] 
		[RED("messages")] 
		public CArray<CWeakHandle<gameJournalEntry>> Messages
		{
			get => GetPropertyValue<CArray<CWeakHandle<gameJournalEntry>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gameJournalEntry>>>(value);
		}

		[Ordinal(6)] 
		[RED("parentEntry")] 
		public CWeakHandle<gameJournalEntry> ParentEntry
		{
			get => GetPropertyValue<CWeakHandle<gameJournalEntry>>();
			set => SetPropertyValue<CWeakHandle<gameJournalEntry>>(value);
		}

		[Ordinal(7)] 
		[RED("singleThreadMode")] 
		public CBool SingleThreadMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("newMessageAninmProxy")] 
		public CHandle<inkanimProxy> NewMessageAninmProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public CustomDialogViewController()
		{
			Messages = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
