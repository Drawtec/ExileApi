using System.Runtime.InteropServices;

namespace GameOffsets
{
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct IngameUElementsOffsets
    {
        [FieldOffset(0x250)] public long GetQuests;
        [FieldOffset(0x288)] public long GameUI;
        [FieldOffset(0x3C8)] public long Mouse;
        [FieldOffset(0x3D0)] public long SkillBar;
        [FieldOffset(0x3D8)] public long HiddenSkillBar;
        [FieldOffset(0x420)] public long BanditDialog;
        [FieldOffset(0x488)] public long ChatPanel;
        [FieldOffset(0x4B8)] public long QuestTracker;
        [FieldOffset(0x546)] public long OpenLeftPanel;
        [FieldOffset(0x554)] public long OpenRightPanel;
        [FieldOffset(0x578)] public long InventoryPanel;
        [FieldOffset(0x550)] public long StashElement;
        [FieldOffset(0x588)] public long GuildStashElement;
        [FieldOffset(0x628)] public long AtlasPanel;
        [FieldOffset(0x630)] public long AtlasSkillPanel;
        [FieldOffset(0x660)] public long WorldMap;
        [FieldOffset(0x6A0)] public long Map;
        [FieldOffset(0x6A8)] public long itemsOnGroundLabelRoot;
        [FieldOffset(0x730)] public long NpcDialog;
        [FieldOffset(0x738)] public long LeagueNpcDialog;
        [FieldOffset(0x748)] public long QuestRewardWindow;
        [FieldOffset(0x750)] public long PurchaseWindow;
        [FieldOffset(0x758)] public long ExpeditionPurchaseWindow;
        [FieldOffset(0x768)] public long SellWindow;
        [FieldOffset(0x768)] public long ExpeditionSellWindow;
        [FieldOffset(0x770)] public long TradeWindow;
        [FieldOffset(0x780)] public long LabyrinthDivineFontPanel;
        [FieldOffset(0x7A0)] public long MapDeviceWindow;
        [FieldOffset(0x7F8)] public long IncursionWindow;
        [FieldOffset(0x818)] public long DelveWindow;
        [FieldOffset(0x828)] public long ZanaMissionChoice;
        [FieldOffset(0x838)] public long BetrayalWindow;
        [FieldOffset(0x848)] public long CraftBenchWindow;
        [FieldOffset(0x850)] public long UnveilWindow;
        [FieldOffset(0x878)] public long SynthesisWindow;
        [FieldOffset(0x890)] public long MetamorphWindow;
        [FieldOffset(0x898)] public long HorticraftingSacredGrovePanel;
        [FieldOffset(0x8A0)] public long HorticraftingHideoutPanel;
        [FieldOffset(0x8A8)] public long HeistContractPanel;
        [FieldOffset(0x8B0)] public long HeistRevealPanel;
        [FieldOffset(0x8B8)] public long HeistAllyEquipmentPanel;
        [FieldOffset(0x8C0)] public long HeistBlueprintPanel;
        [FieldOffset(0x8C8)] public long HeistLockerPanel;
        [FieldOffset(0x8D0)] public long RitualWindow;
        [FieldOffset(0x8D8)] public long RitualFavourPanel;
        [FieldOffset(0x8E0)] public long UltimatumProgressPanel;
        [FieldOffset(0x908)] public long ArchNemesis;
        [FieldOffset(0x920)] public long DelveDarkness;
        [FieldOffset(0x988)] public long AreaInstanceUi;
        [FieldOffset(0xA80)] public long InvitesPanel;
        [FieldOffset(0xAC8)] public long GemLvlUpPanel;
        [FieldOffset(0xBB0)] public long ItemOnGroundTooltip;

        [FieldOffset(0xA80)] public long MapTabWindowStartPtr; // Todo: Find if you need it.

        // 3.18.0c Layout
        // [FieldOffset(0x250)] public readonly long GetQuests;
        // [FieldOffset(0x288)] public readonly long GameUI;
        // [FieldOffset(0x290)] public readonly long LeftGameUI;
        // [FieldOffset(0x298)] public readonly long RightGameUI;
        // [FieldOffset(0x2A0)] public readonly long HealthPanel;
        // [FieldOffset(0x2A8)] public readonly long ManaPanel;
        // [FieldOffset(0x2C8)] public readonly long FlaskPanel;
        // [FieldOffset(0x2D0)] public readonly long XPBarPanel;
        // [FieldOffset(0x2D8)] public readonly long RageBarPanel;
        // [FieldOffset(0x2E0)] public readonly long MenuPanel;
        // [FieldOffset(0x2E8)] public readonly long MenuButton;
        // [FieldOffset(0x300)] public readonly long ClockPanel;
        // [FieldOffset(0x308)] public readonly long OptionsMenuOption;
        // [FieldOffset(0x310)] public readonly long SocialMenuOption;
        // [FieldOffset(0x318)] public readonly long CharacterScreenMenuOption;
        // [FieldOffset(0x320)] public readonly long PassiveSkillTreeMenuOption;
        // [FieldOffset(0x328)] public readonly long InventoryMenuOption;
        // [FieldOffset(0x330)] public readonly long CosmeticsMenuOption;
        // [FieldOffset(0x338)] public readonly long MtxListMenuOption;
        // [FieldOffset(0x340)] public readonly long ChallengesMenuOption;
        // [FieldOffset(0x348)] public readonly long EventsMenuOption;
        // [FieldOffset(0x350)] public readonly long WorldScreenMenuOption;
        // [FieldOffset(0x358)] public readonly long AtlasScreenMenuOption;
        // [FieldOffset(0x360)] public readonly long KiracsPassMenuOption;
        // [FieldOffset(0x368)] public readonly long KiracsPassMenuButton;
        // [FieldOffset(0x370)] public readonly long OverlayMapMenuOption;
        // [FieldOffset(0x388)] public readonly long MtxShopButton;
        // [FieldOffset(0x390)] public readonly long OpenHelpPanelButton;
        // [FieldOffset(0x3A0)] public readonly long SkipAllTutorialsButton;
        // [FieldOffset(0x3B8)] public readonly long ToggleChatButton;
        // [FieldOffset(0x3C8)] public readonly long Mouse;
        // [FieldOffset(0x3D0)] public readonly long Skillbar;
        // [FieldOffset(0x3D8)] public readonly long HiddenSkillBar;
        // [FieldOffset(0x3E8)] public readonly long Child[20];
        // [FieldOffset(0x3F0)] public readonly long Child[19];
        // [FieldOffset(0x3F8)] public readonly long PvpTimerPanel;
        // [FieldOffset(0x400)] public readonly long PvpFightAnnouncePanel;
        // [FieldOffset(0x408)] public readonly long PvpReadyForNextRoundPanel;
        // [FieldOffset(0x410)] public readonly long PvpStopSpectatingPanel;
        // [FieldOffset(0x418)] public readonly long Child[59];
        // [FieldOffset(0x420)] public readonly long PvpTimerPanel2;
        // [FieldOffset(0x428)] public readonly long Child[23][6];
        // [FieldOffset(0x430)] public readonly long PvpSpectatingPanel;
        // [FieldOffset(0x438)] public readonly long Child[115];
        // [FieldOffset(0x440)] public readonly long EditingNotificationPanel;
        // [FieldOffset(0x448)] public readonly long ButtonNotificationPanel;
        // [FieldOffset(0x450)] public readonly long PassiveSkillPointNotification;
        // [FieldOffset(0x458)] public readonly long QuestNotification;
        // [FieldOffset(0x460)] public readonly long UnknownNotificationPanel1;
        // [FieldOffset(0x468)] public readonly long UnknownNotificationPanel2;
        // [FieldOffset(0x470)] public readonly long AtlasPassivePointNotification;
        // [FieldOffset(0x478)] public readonly long UnknownNotificationPanel3;
        // [FieldOffset(0x480)] public readonly long ChatPanel;
        // [FieldOffset(0x488)] public readonly long HideoutStashPanel;
        // [FieldOffset(0x490)] public readonly long BestiaryMissionCompletePanel;
        // [FieldOffset(0x498)] public readonly long BestiaryNewBeastNotifyPanel;
        // [FieldOffset(0x4A0)] public readonly long JuiceBarsPanel;
        // [FieldOffset(0x4A8)] public readonly long ScourgeJuiceBar;
        // [FieldOffset(0x4B0)] public readonly long DelveJuiceBar;
        // [FieldOffset(0x4B8)] public readonly long QuestTrackerPanel;
        // [FieldOffset(0x4C0)] public readonly StdVector UnknownKVList;
        // [FieldOffset(0x4D8)] public readonly StdVector AwardNotifyList;
        // [FieldOffset(0x4F8)] public readonly long HideoutUnlockedNotifyPanel;
        // [FieldOffset(0x500)] public readonly long QuestStateNotifyPanel;
        // [FieldOffset(0x508)] public readonly Vector4F ViewPortDimensions;
        // [FieldOffset(0x518)] public readonly StdVector UnknownList;
        // [FieldOffset(0x530)] public readonly long IngameStateKey;
        // [FieldOffset(0x540)] public readonly long OpenLeftPanel;
        // [FieldOffset(0x548)] public readonly long OpenRightPanel;
        // [FieldOffset(0x550)] public readonly long OpenLeftPanel2;
        // [FieldOffset(0x558)] public readonly long OpenRightPanel2;
        // [FieldOffset(0x568)] public readonly long OldMtxInventoryPanel;
        // [FieldOffset(0x570)] public readonly long MtxShopPanel;
        // [FieldOffset(0x578)] public readonly long InventoryPanel;
        // [FieldOffset(0x580)] public readonly long StashPanel;
        // [FieldOffset(0x588)] public readonly long GuildStashPanel;
        // [FieldOffset(0x590)] public readonly long HideoutStashPanel;
        // [FieldOffset(0x598)] public readonly long SocialPanel;
        // [FieldOffset(0x628)] public readonly long AtlasPanel;
        // [FieldOffset(0x630)] public readonly long AtlasSkillPanel;
        // [FieldOffset(0x638)] public readonly long CharacterPanel;
        // [FieldOffset(0x640)] public readonly long OptionsPanel;
        // [FieldOffset(0x648)] public readonly long ChallengesPanel;
        // [FieldOffset(0x650)] public readonly long PantheonPanel;
        // [FieldOffset(0x658)] public readonly long EventsPanel;
        // [FieldOffset(0x660)] public readonly long WorldMapPanel;
        // [FieldOffset(0x668)] public readonly long MtxPanel;
        // [FieldOffset(0x670)] public readonly long DecorationsPanel;
        // [FieldOffset(0x678)] public readonly long HelpPanel;
        // [FieldOffset(0x680)] public readonly long BloodCruciblePanel;
        // [FieldOffset(0x688)] public readonly long SentinelControllerPanel;
        // [FieldOffset(0x690)] public readonly long SentinelAssemblyPanel;
        // [FieldOffset(0x698)] public readonly long OverlayMapsPanel;
        // [FieldOffset(0x6A0)] public readonly long ItemsOnGroundLabelRoot;
        // [FieldOffset(0x6A8)] public readonly long BanditDialog;
        // [FieldOffset(0x6B0)] public readonly long Child[8];
        // [FieldOffset(0x6B8)] public readonly long Child[9];
        // [FieldOffset(0x6C0)] public readonly long Child[11];
        // [FieldOffset(0x6C8)] public readonly long Child[10];
        // [FieldOffset(0x6D8)] public readonly long Child[2];
        // [FieldOffset(0x6E0)] public readonly long Child[138];
        // [FieldOffset(0x728)] public readonly long BuffsRootPanel;
        // [FieldOffset(0x730)] public readonly long NpcDialogPanel;
        // [FieldOffset(0x738)] public readonly long LeagueNpcDialogPanel;
        // [FieldOffset(0x740)] public readonly long LeagueInteractButtonPanel;
        // [FieldOffset(0x748)] public readonly long RewardPanel;
        // [FieldOffset(0x750)] public readonly long PurchasePanel;
        // [FieldOffset(0x758)] public readonly long LeaguePurchasePanel;
        // [FieldOffset(0x760)] public readonly long SellPanel;
        // [FieldOffset(0x768)] public readonly long LeagueSellPanel;
        // [FieldOffset(0x770)] public readonly long TradePanel;
        // [FieldOffset(0x778)] public readonly long MapReceptaclePanel;
        // [FieldOffset(0x780)] public readonly long LabyrinthDivineFontPanel;
        // [FieldOffset(0x788)] public readonly long TalismanStoneCirclePanel;
        // [FieldOffset(0x790)] public readonly long LabyrinthTrialPlaquePanel;
        // [FieldOffset(0x798)] public readonly long LabyrinthAscendencySelectPanel;
        // [FieldOffset(0x7A0)] public readonly long MapDevicePanel;
        // [FieldOffset(0x7A8)] public readonly long DarkshrinePanel;
        // [FieldOffset(0x7B0)] public readonly long BestiaryBloodAltarPanel;
        // [FieldOffset(0x7B8)] public readonly long LabyrinthSelectPanel;
        // [FieldOffset(0x7C0)] public readonly long LabyrinthMapPanel;
        // [FieldOffset(0x7C8)] public readonly long GuildTagEditor;
        // [FieldOffset(0x7D0)] public readonly long BroadcastMessagePanel;
        // [FieldOffset(0x7D8)] public readonly long FriendNoteEditorPanel;
        // [FieldOffset(0x7E0)] public readonly long PvpLadderPanel;
        // [FieldOffset(0x7E8)] public readonly long PvpScoreboardPanel;
        // [FieldOffset(0x7F0)] public readonly long CardTradePanel;
        // [FieldOffset(0x7F8)] public readonly long IncursionMapPanel;
        // [FieldOffset(0x800)] public readonly long IncursionCorruptionAltarPanel;
        // [FieldOffset(0x808)] public readonly long IncursionAltarOfSacrificePanel;
        // [FieldOffset(0x810)] public readonly long IncursionLapidaryLensPanel;
        // [FieldOffset(0x818)] public readonly long DelveSubterraneanChartPanel;
        // [FieldOffset(0x820)] public readonly long DelveOldSubterraneanChartPanel;
        // [FieldOffset(0x828)] public readonly long KiracMissionPanel;
        // [FieldOffset(0x830)] public readonly long SupportGemsTutorialPanel;
        // [FieldOffset(0x838)] public readonly long SyndicatePanel;
        // [FieldOffset(0x840)] public readonly long OldSyndicatePanel;
        // [FieldOffset(0x848)] public readonly long CraftingBenchPanel;
        // [FieldOffset(0x850)] public readonly long UnveilItemPanel;
        // [FieldOffset(0x858)] public readonly long SyndicateTrappedStashPanel;
        // [FieldOffset(0x860)] public readonly long SyndicateTinysTrialPanel;
        // [FieldOffset(0x868)] public readonly long SyndicateCraftingBenchPanel;
        // [FieldOffset(0x870)] public readonly long SynthesisSynthesiserPanel;
        // [FieldOffset(0x878)] public readonly long SynthesisMapPanel;
        // [FieldOffset(0x880)] public readonly long BlightAnointItemPanel;
        // [FieldOffset(0x888)] public readonly long OldMetamorphPanel;
        // [FieldOffset(0x890)] public readonly long MetamorphPanel;
        // [FieldOffset(0x898)] public readonly long HorticraftingSacredGrovePanel;
        // [FieldOffset(0x8A0)] public readonly long HorticraftingHideoutPanel;
        // [FieldOffset(0x8A8)] public readonly long HeistContractPanel;
        // [FieldOffset(0x8B0)] public readonly long HeistRevealPanel;
        // [FieldOffset(0x8B8)] public readonly long HeistAllyEquipmentPanel;
        // [FieldOffset(0x8C0)] public readonly long HeistBlueprintPanel;
        // [FieldOffset(0x8C8)] public readonly long HeistLockerPanel;
        // [FieldOffset(0x8D0)] public readonly long RitualRewardsPanel;
        // [FieldOffset(0x8D8)] public readonly long RitualFavoursPanel;
        // [FieldOffset(0x8E0)] public readonly long UltimatumProgressPanel;
        // [FieldOffset(0x8E8)] public readonly long ExpeditionSelectPanel;
        // [FieldOffset(0x8F0)] public readonly long LogbookReceptaclePanel;
        // [FieldOffset(0x8F8)] public readonly long ExpeditionLockerPanel;
        // [FieldOffset(0x900)] public readonly long OpenItemBoxPanel;
        // [FieldOffset(0x908)] public readonly long ArchnemesisMapPanel;
        // [FieldOffset(0x910)] public readonly long ArchnemesisStashPanel;
        // [FieldOffset(0x918)] public readonly long SentinelInteractPanel;
        // [FieldOffset(0x920)] public readonly long SentinelLockerPanel;
        // [FieldOffset(0x928)] public readonly long SentinelInteractPanel;
        // [FieldOffset(0x930)] public readonly long BuffsMinionPanel;
        // [FieldOffset(0x938)] public readonly long BuffsUnknownPanel1;
        // [FieldOffset(0x940)] public readonly long BuffsPanel;
        // [FieldOffset(0x948)] public readonly long DebuffsPanels;
        // [FieldOffset(0x950)] public readonly long AlliesBuffsPanel;
        // [FieldOffset(0x958)] public readonly long BuffsUnknownPanel2;
        // [FieldOffset(0x960)] public readonly long BuffsUnknownPanel3;
        // [FieldOffset(0x968)] public readonly long EditStashTabPanel;
        // [FieldOffset(0x970)] public readonly long EditStashItemPanel;
        // [FieldOffset(0x978)] public readonly long UnknownEditPanel;
        // [FieldOffset(0x988)] public readonly long AreaInstancePanel;
        // [FieldOffset(0x990)] public readonly long PendingTradeRequestPanel;
        // [FieldOffset(0x998)] public readonly long DestroyOnGroundRequestPanel;
        // [FieldOffset(0x9A0)] public readonly long MysteryBoxPanel;
        // [FieldOffset(0x9A8)] public readonly long MtxSalvagePanel;
        // [FieldOffset(0x9B0)] public readonly long MtxReclaimPanel;
        // [FieldOffset(0x9B8)] public readonly long MtxCombinePanel;
        // [FieldOffset(0x9C0)] public readonly long ReportPlayerPanel;
        // [FieldOffset(0x9C8)] public readonly long Child[132];
        // [FieldOffset(0x9D0)] public readonly long YouHaveDiedNotifyPanel;
        // [FieldOffset(0x9D8)] public readonly long ResurrectInTownPanel;
        // [FieldOffset(0x9E0)] public readonly long ResurrectAtCheckpointPanel;
        // [FieldOffset(0x9E8)] public readonly long ReviveAtCheckpointPanel;
        // [FieldOffset(0x9F0)] public readonly long SpectateAfterDeathPanel;
        // [FieldOffset(0x9F8)] public readonly long SkipAheadPanel;
        // [FieldOffset(0xA00)] public readonly long SyndicateHelpPanel;
        // [FieldOffset(0xA08)] public readonly long InteractButtonWrapper;
        // [FieldOffset(0xA10)] public readonly long SkipAheadButton;
        // [FieldOffset(0xA18)] public readonly long SyndicateHelpButton;
        // [FieldOffset(0xA20)] public readonly long SyndicateReleasePanel;
        // [FieldOffset(0xA28)] public readonly long LeagueInteractPanel;
        // [FieldOffset(0xA30)] public readonly long MetamorphInteractPanel;
        // [FieldOffset(0xA38)] public readonly long RitualInteractPanel;
        // [FieldOffset(0xA40)] public readonly long ExpeditionInteractPanel;
        // [FieldOffset(0xA48)] public readonly long ScourgeInteractPanel;
        // [FieldOffset(0xA50)] public readonly long Child[1];
        // [FieldOffset(0xA58)] public readonly long HideoutEditPanel;
        // [FieldOffset(0xA60)] public readonly long HideoutMusicPanel;
        // [FieldOffset(0xA68)] public readonly long PvpCancelPanel;
        // [FieldOffset(0xA70)] public readonly long AreaTravelNotifyPanel;
        // [FieldOffset(0xA78)] public readonly long Child[124];
        // [FieldOffset(0xA80)] public readonly long PartyInvitePanel;
        // [FieldOffset(0xAC8)] public readonly long GemLevelPanel;
        // [FieldOffset(0xAD0)] public readonly long Child[119];
        // [FieldOffset(0xAD8)] public readonly long Child[120];
        // [FieldOffset(0xAE0)] public readonly long SkillBarNotifyPanel1;
        // [FieldOffset(0xAE8)] public readonly long SkillBarNotifyPanel2;
        // [FieldOffset(0xAF8)] public readonly long CursorMTX;
        // [FieldOffset(0xB10)] public readonly long Child[118][13];
        // [FieldOffset(0xB18)] public readonly long Child[0];
        // [FieldOffset(0xB20)] public readonly long RampageProgressPanel;
        // [FieldOffset(0xB28)] public readonly long IncursionProgressPanel;
        // [FieldOffset(0xB30)] public readonly long BetrayalResearchProgressPanel;
        // [FieldOffset(0xB38)] public readonly long BetrayalTransportProgressPanel;
        // [FieldOffset(0xB40)] public readonly long SynthesisStabilizerProgressPanel;
        // [FieldOffset(0xB48)] public readonly long SynthesisRewardNotifyPanel;
        // [FieldOffset(0xB50)] public readonly long RootProgressPanel;
        // [FieldOffset(0xB58)] public readonly long RoyaleWaitingNotifyPanel;
        // [FieldOffset(0xB60)] public readonly long RoyaleAnnounceNotifyPanel;
        // [FieldOffset(0xB68)] public readonly long BlightProgressPanel;
        // [FieldOffset(0xB78)] public readonly long Child[118][15];
        // [FieldOffset(0xB80)] public readonly long Child[15];
        // [FieldOffset(0xB88)] public readonly long HeistProgressPanel;
        // [FieldOffset(0xB90)] public readonly long UltimatumProgressPanel;
        // [FieldOffset(0xB98)] public readonly long UltimatumWarningPanel;
        // [FieldOffset(0xBA0)] public readonly long KiracsPassPanel;
        // [FieldOffset(0xBA8)] public readonly long UnknownRewardPanel;
        // [FieldOffset(0xBB0)] public readonly long ItemOnGroundTooltip;
        // [FieldOffset(0xBB8)] public readonly long Child[133];
    }
}
