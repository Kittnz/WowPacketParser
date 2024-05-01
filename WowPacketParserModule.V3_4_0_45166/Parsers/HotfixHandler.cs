using System;
using System.Collections.Generic;
using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.Parsing;
using WowPacketParser.Store;
using WowPacketParser.Store.Objects;

namespace WowPacketParserModule.V3_4_0_45166.Parsers
{
    public static class HotfixHandler
    {
        public static void AchievementHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Description", indexes);
            packet.ReadCString("Title", indexes);
            packet.ReadCString("Reward", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt16("InstanceID", indexes);
            packet.ReadSByte("Faction", indexes);
            packet.ReadInt16("Supercedes", indexes);
            packet.ReadInt16("Category", indexes);
            packet.ReadSByte("MinimumCriteria", indexes);
            packet.ReadSByte("Points", indexes);
            packet.ReadInt32("Flags", indexes);
            packet.ReadInt16("UiOrder", indexes);
            packet.ReadInt32("IconFileID", indexes);
            packet.ReadUInt32("CriteriaTree", indexes);
            packet.ReadInt16("SharesCriteria", indexes);
        }

        public static void AchievementHandler343(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Description", indexes);
            packet.ReadCString("Title", indexes);
            packet.ReadCString("Reward", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt16("InstanceID", indexes);
            packet.ReadSByte("Faction", indexes);
            packet.ReadInt16("Supercedes", indexes);
            packet.ReadInt16("Category", indexes);
            packet.ReadSByte("MinimumCriteria", indexes);
            packet.ReadSByte("Points", indexes);
            packet.ReadInt32("Flags", indexes);
            packet.ReadInt16("UiOrder", indexes);
            packet.ReadInt32("IconFileID", indexes);
            packet.ReadUInt32("CriteriaTree", indexes);
            packet.ReadInt16("SharesCriteria", indexes);
        }

        public static void AchievementCategoryHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt16("Parent", indexes);
            packet.ReadSByte("UiOrder", indexes);
        }

        public static void AdventureJournalHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadCString("Description", indexes);
            packet.ReadCString("ButtonText", indexes);
            packet.ReadCString("RewardDescription", indexes);
            packet.ReadCString("ContinueDescription", indexes);
            packet.ReadByte("Type", indexes);
            packet.ReadUInt32("PlayerConditionID", indexes);
            packet.ReadInt32("Flags", indexes);
            packet.ReadByte("ButtonActionType", indexes);
            packet.ReadInt32("TextureFileDataID", indexes);
            packet.ReadUInt16("LfgDungeonID", indexes);
            packet.ReadUInt32("QuestID", indexes);
            packet.ReadUInt16("BattleMasterListID", indexes);
            packet.ReadByte("PriorityMin", indexes);
            packet.ReadByte("PriorityMax", indexes);
            packet.ReadInt32("ItemID", indexes);
            packet.ReadUInt32("ItemQuantity", indexes);
            packet.ReadUInt16("CurrencyType", indexes);
            packet.ReadByte("CurrencyQuantity", indexes);
            packet.ReadUInt16("UIMapID", indexes);

            for (int i = 0; i < 2; i++)
                packet.ReadUInt32("BonusPlayerConditionID", indexes, i);

            for (int i = 0; i < 2; i++)
                packet.ReadByte("BonusValue", indexes, i);
        }

        public static void AdventureMapPOIHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Title", indexes);
            packet.ReadCString("Description", indexes);
            packet.ReadSingle("WorldPositionX", indexes);
            packet.ReadSingle("WorldPositionY", indexes);
            packet.ReadSByte("Type", indexes);
            packet.ReadUInt32("PlayerConditionID", indexes);
            packet.ReadUInt32("QuestID", indexes);
            packet.ReadUInt32("LfgDungeonID", indexes);
            packet.ReadInt32("RewardItemID", indexes);
            packet.ReadUInt32("UiTextureAtlasMemberID", indexes);
            packet.ReadUInt32("UiTextureKitID", indexes);
            packet.ReadInt32("MapID", indexes);
            packet.ReadUInt32("AreaTableID", indexes);
        }

        public static void AnimationDataHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt16("Fallback", indexes);
            packet.ReadByte("BehaviorTier", indexes);
            packet.ReadInt32("BehaviorID", indexes);

            for (int i = 0; i < 2; i++)
               packet.ReadInt32("Flags", indexes, i);
        }

        public static void AnimKitHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("OneShotDuration", indexes);
            packet.ReadUInt16("OneShotStopAnimKitID", indexes);
            packet.ReadUInt16("LowDefAnimKitID", indexes);
        }

        public static void AreaGroupMemberHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt16("AreaID", indexes);
            packet.ReadInt32("AreaGroupID", indexes);
        }

        public static void AreaTableHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("ZoneName", indexes);
            packet.ReadCString("AreaName", indexes);
            packet.ReadUInt16("ContinentID", indexes);
            packet.ReadUInt16("ParentAreaID", indexes);
            packet.ReadInt16("AreaBit", indexes);
            packet.ReadByte("SoundProviderPref", indexes);
            packet.ReadByte("SoundProviderPrefUnderwater", indexes);
            packet.ReadUInt16("AmbienceID", indexes);
            packet.ReadUInt16("UwAmbience", indexes);
            packet.ReadUInt16("ZoneMusic", indexes);
            packet.ReadUInt16("UwZoneMusic", indexes);
            packet.ReadSByte("ExplorationLevel", indexes);
            packet.ReadUInt16("IntroSound", indexes);
            packet.ReadUInt32("UwIntroSound", indexes);
            packet.ReadByte("FactionGroupMask", indexes);
            packet.ReadSingle("AmbientMultiplier", indexes);
            packet.ReadByte("MountFlags", indexes);
            packet.ReadInt16("PvpCombatWorldStateID", indexes);
            packet.ReadByte("WildBattlePetLevelMin", indexes);
            packet.ReadByte("WildBattlePetLevelMax", indexes);
            packet.ReadByte("WindSettingsID", indexes);

            for (int i = 0; i < 2; i++)
                packet.ReadInt32("Flags", indexes, i);
            for (int i = 0; i < 4; i++)
                packet.ReadUInt16("LiquidTypeID", indexes, i);
        }

        public static void AreaTableHandler343(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("ZoneName", indexes);
            packet.ReadCString("AreaName", indexes);
            packet.ReadUInt16("ContinentID", indexes);
            packet.ReadUInt16("ParentAreaID", indexes);
            packet.ReadInt16("AreaBit", indexes);
            packet.ReadByte("SoundProviderPref", indexes);
            packet.ReadByte("SoundProviderPrefUnderwater", indexes);
            packet.ReadUInt16("AmbienceID", indexes);
            packet.ReadUInt16("UwAmbience", indexes);
            packet.ReadUInt16("ZoneMusic", indexes);
            packet.ReadUInt16("UwZoneMusic", indexes);
            packet.ReadSByte("ExplorationLevel", indexes);
            packet.ReadUInt16("IntroSound", indexes);
            packet.ReadUInt32("UwIntroSound", indexes);
            packet.ReadByte("FactionGroupMask", indexes);
            packet.ReadSingle("AmbientMultiplier", indexes);
            packet.ReadInt32("MountFlags", indexes);
            packet.ReadInt16("PvpCombatWorldStateID", indexes);
            packet.ReadByte("WildBattlePetLevelMin", indexes);
            packet.ReadByte("WildBattlePetLevelMax", indexes);
             packet.ReadByte("WindSettingsID", indexes);

            for (int i = 0; i < 2; i++)
                packet.ReadInt32("Flags", indexes, i);
            for (int i = 0; i < 4; i++)
                packet.ReadUInt16("LiquidTypeID", indexes, i);
        }

        public static void AreaTriggerHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Message", indexes);
            packet.ReadSingle("PosX", indexes);
            packet.ReadSingle("PosY", indexes);
            packet.ReadSingle("PosZ", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt16("ContinentID", indexes);
            packet.ReadSByte("PhaseUseFlags", indexes);
            packet.ReadInt16("PhaseID", indexes);
            packet.ReadInt16("PhaseGroupID", indexes);
            packet.ReadSingle("Radius", indexes);
            packet.ReadSingle("BoxLength", indexes);
            packet.ReadSingle("BoxWidth", indexes);
            packet.ReadSingle("BoxHeight", indexes);
            packet.ReadSingle("BoxYaw", indexes);
            packet.ReadSByte("ShapeType", indexes);
            packet.ReadInt16("ShapeID", indexes);
            packet.ReadInt16("AreaTriggerActionSetID", indexes);
            packet.ReadSByte("Flags", indexes);
        }

        public static void ArmorLocationHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadSingle("Clothmodifier", indexes);
            packet.ReadSingle("Leathermodifier", indexes);
            packet.ReadSingle("Chainmodifier", indexes);
            packet.ReadSingle("Platemodifier", indexes);
            packet.ReadSingle("Modifier", indexes);
        }

        public static void ArtifactHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadUInt16("UiTextureKitID", indexes);
            packet.ReadInt32("UiNameColor", indexes);
            packet.ReadInt32("UiBarOverlayColor", indexes);
            packet.ReadInt32("UiBarBackgroundColor", indexes);
            packet.ReadUInt16("ChrSpecializationID", indexes);
            packet.ReadByte("Flags", indexes);
            packet.ReadByte("ArtifactCategoryID", indexes);
            packet.ReadUInt32("UiModelSceneID", indexes);
            packet.ReadUInt32("SpellVisualKitID", indexes);
        }

        public static void ArtifactAppearanceHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadUInt16("ArtifactAppearanceSetID", indexes);
            packet.ReadByte("DisplayIndex", indexes);
            packet.ReadUInt32("UnlockPlayerConditionID", indexes);
            packet.ReadByte("ItemAppearanceModifierID", indexes);
            packet.ReadInt32("UiSwatchColor", indexes);
            packet.ReadSingle("UiModelSaturation", indexes);
            packet.ReadSingle("UiModelOpacity", indexes);
            packet.ReadByte("OverrideShapeshiftFormID", indexes);
            packet.ReadUInt32("OverrideShapeshiftDisplayID", indexes);
            packet.ReadUInt32("UiItemAppearanceID", indexes);
            packet.ReadUInt32("UiAltItemAppearanceID", indexes);
            packet.ReadByte("Flags", indexes);
            packet.ReadUInt16("UiCameraID", indexes);
        }

        public static void ArtifactAppearanceSetHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadCString("Description", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadByte("DisplayIndex", indexes);
            packet.ReadUInt16("UiCameraID", indexes);
            packet.ReadUInt16("AltHandUICameraID", indexes);
            packet.ReadSByte("ForgeAttachmentOverride", indexes);
            packet.ReadByte("Flags", indexes);
            packet.ReadInt32("ArtifactID", indexes);
        }

        public static void ArtifactCategoryHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt16("XpMultCurrencyID", indexes);
            packet.ReadInt16("XpMultCurveID", indexes);
        }

        public static void ArtifactPowerHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadSingle("DisplayPosX", indexes);
            packet.ReadSingle("DisplayPosY", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadByte("ArtifactID", indexes);
            packet.ReadByte("MaxPurchasableRank", indexes);
            packet.ReadInt32("Label", indexes);
            packet.ReadByte("Flags", indexes);
            packet.ReadByte("Tier", indexes);
        }

        public static void ArtifactPowerLinkHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt16("PowerA", indexes);
            packet.ReadUInt16("PowerB", indexes);
        }

        public static void ArtifactPowerPickerHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("PlayerConditionID", indexes);
        }

        public static void ArtifactPowerRankHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadByte("RankIndex", indexes);
            packet.ReadInt32("SpellID", indexes);
            packet.ReadUInt16("ItemBonusListID", indexes);
            packet.ReadSingle("AuraPointsOverride", indexes);
            packet.ReadInt32("ArtifactPowerID", indexes);
        }

        public static void ArtifactQuestXpHandler340(Packet packet, uint entry, params object[] indexes)
        {
            for (int i = 0; i < 10; i++)
                packet.ReadUInt32("Difficulty", indexes, i);
        }

        public static void ArtifactTierHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ArtifactTier", indexes);
            packet.ReadUInt32("MaxNumTraits", indexes);
            packet.ReadUInt32("MaxArtifactKnowledge", indexes);
            packet.ReadUInt32("KnowledgePlayerCondition", indexes);
            packet.ReadUInt32("MinimumEmpowerKnowledge", indexes);
        }

        public static void ArtifactUnlockHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("PowerID", indexes);
            packet.ReadByte("PowerRank", indexes);
            packet.ReadUInt16("ItemBonusListID", indexes);
            packet.ReadUInt32("PlayerConditionID", indexes);
            packet.ReadInt32("ArtifactID", indexes);
        }

        public static void AuctionHouseHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadUInt16("FactionID", indexes);
            packet.ReadByte("DepositRate", indexes);
            packet.ReadByte("ConsignmentRate", indexes);
        }

        public static void AzeriteEmpoweredItemHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("ItemID", indexes);
            packet.ReadUInt32("AzeriteTierUnlockSetID", indexes);
            packet.ReadUInt32("AzeritePowerSetID", indexes);
        }

        public static void AzeriteEssenceHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadCString("Description", indexes);
            packet.ReadInt32("SpecSetID", indexes);
        }

        public static void AzeriteEssencePowerHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("SourceAlliance", indexes);
            packet.ReadCString("SourceHorde", indexes);
            packet.ReadInt32("AzeriteEssenceID", indexes);
            packet.ReadByte("Tier", indexes);
            packet.ReadInt32("MajorPowerDescription", indexes);
            packet.ReadInt32("MinorPowerDescription", indexes);
            packet.ReadInt32("MajorPowerActual", indexes);
            packet.ReadInt32("MinorPowerActual", indexes);
        }

        public static void AzeriteItemHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("ItemID", indexes);
        }

        public static void AzeriteItemMilestonePowerHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("RequiredLevel", indexes);
            packet.ReadInt32("AzeritePowerID", indexes);
            packet.ReadInt32("Type", indexes);
            packet.ReadInt32("AutoUnlock", indexes);
        }

        public static void AzeriteKnowledgeMultiplierHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadSingle("Multiplier", indexes);
        }

        public static void AzeriteLevelInfoHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt64("BaseExperienceToNextLevel", indexes);
            packet.ReadUInt64("MinimumExperienceToNextLevel", indexes);
            packet.ReadInt32("ItemLevel", indexes);
        }

        public static void AzeritePowerHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("SpellID", indexes);
            packet.ReadInt32("ItemBonusListID", indexes);
            packet.ReadInt32("SpecSetID", indexes);
            packet.ReadInt32("Flags", indexes);
        }

        public static void AzeritePowerSetMemberHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("AzeritePowerSetID", indexes);
            packet.ReadInt32("AzeritePowerID", indexes);
            packet.ReadInt32("Class", indexes);
            packet.ReadByte("Tier", indexes);
            packet.ReadInt32("OrderIndex", indexes);
        }

        public static void AzeriteTierUnlockHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadByte("ItemCreationContext", indexes);
            packet.ReadByte("Tier", indexes);
            packet.ReadByte("AzeriteLevel", indexes);
            packet.ReadInt32("AzeriteTierUnlockSetID", indexes);
        }

        public static void AzeriteTierUnlockSetHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("Flags", indexes);
        }

        public static void BankBagSlotPricesHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("Cost", indexes);
        }

        public static void BannedAddonsHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadCString("Version", indexes);
            packet.ReadByte("Flags", indexes);
        }

        public static void BarberShopStyleHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("DisplayName", indexes);
            packet.ReadCString("Description", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadByte("Type", indexes);
            packet.ReadSingle("CostModifier", indexes);
            packet.ReadByte("Race", indexes);
            packet.ReadByte("Sex", indexes);
            packet.ReadByte("Data", indexes);
        }

        public static void BattlePetAbilityHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadCString("Description", indexes);
            packet.ReadInt32("IconFileDataID", indexes);
            packet.ReadSByte("PetTypeEnum", indexes);
            packet.ReadUInt32("Cooldown", indexes);
            packet.ReadUInt16("BattlePetVisualID", indexes);
            packet.ReadByte("Flags", indexes);
        }

        public static void BattlePetBreedQualityHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadSingle("StateMultiplier", indexes);
            packet.ReadByte("QualityEnum", indexes);
        }

        public static void BattlePetBreedStateHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadByte("BattlePetStateID", indexes);
            packet.ReadUInt16("Value", indexes);
            packet.ReadInt32("BattlePetBreedID", indexes);
        }

        public static void BattlePetSpeciesHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Description", indexes);
            packet.ReadCString("SourceText", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("CreatureID", indexes);
            packet.ReadInt32("SummonSpellID", indexes);
            packet.ReadInt32("IconFileDataID", indexes);
            packet.ReadByte("PetTypeEnum", indexes);
            packet.ReadUInt16("Flags", indexes);
            packet.ReadSByte("SourceTypeEnum", indexes);
            packet.ReadInt32("CardUIModelSceneID", indexes);
            packet.ReadInt32("LoadoutUIModelSceneID", indexes);
        }

        public static void BattlePetSpeciesHandler341(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Description", indexes);
            packet.ReadCString("SourceText", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("CreatureID", indexes);
            packet.ReadInt32("SummonSpellID", indexes);
            packet.ReadInt32("IconFileDataID", indexes);
            packet.ReadByte("PetTypeEnum", indexes);
            packet.ReadInt32("Flags", indexes);
            packet.ReadSByte("SourceTypeEnum", indexes);
            packet.ReadInt32("CardUIModelSceneID", indexes);
            packet.ReadInt32("LoadoutUIModelSceneID", indexes);
        }

        public static void BattlePetSpeciesStateHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadByte("BattlePetStateID", indexes);
            packet.ReadInt32("Value", indexes);
            packet.ReadInt32("BattlePetSpeciesID", indexes);
        }

        public static void BattlemasterListHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadCString("GameType", indexes);
            packet.ReadCString("ShortDescription", indexes);
            packet.ReadCString("LongDescription", indexes);
            packet.ReadSByte("InstanceType", indexes);
            packet.ReadSByte("MinLevel", indexes);
            packet.ReadSByte("MaxLevel", indexes);
            packet.ReadSByte("RatedPlayers", indexes);
            packet.ReadSByte("MinPlayers", indexes);
            packet.ReadInt32("MaxPlayers", indexes);
            packet.ReadSByte("GroupsAllowed", indexes);
            packet.ReadSByte("MaxGroupSize", indexes);
            packet.ReadInt16("HolidayWorldState", indexes);
            packet.ReadSByte("Flags", indexes);
            packet.ReadInt32("IconFileDataID", indexes);
            packet.ReadInt32("RequiredPlayerConditionID", indexes);
            for (int i = 0; i < 16; i++)
                packet.ReadInt16("MapID", indexes, i);
        }

        public static void BroadcastTextHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Text", indexes);
            packet.ReadCString("Text1", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("LanguageID", indexes);
            packet.ReadInt32("ConditionID", indexes);
            packet.ReadUInt16("EmotesID", indexes);
            packet.ReadByte("Flags", indexes);
            packet.ReadUInt32("ChatBubbleDurationMs", indexes);
            packet.ReadInt32("VoiceOverPriorityID", indexes);
            for (int i = 0; i < 2; i++)
                packet.ReadUInt32("SoundKitID", indexes, i);
            for (int i = 0; i < 3; i++)
                packet.ReadUInt16("EmoteID", indexes, i);
            for (int i = 0; i < 3; i++)
                packet.ReadUInt16("EmoteDelay", indexes, i);
        }

        public static void CfgCategoriesHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadUInt16("LocaleMask", indexes);
            packet.ReadByte("CreateCharsetMask", indexes);
            packet.ReadByte("ExistingCharsetMask", indexes);
            packet.ReadByte("Flags", indexes);
            packet.ReadSByte("Order", indexes);
        }

        public static void CfgRegionsHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Tag", indexes);
            packet.ReadUInt16("RegionID", indexes);
            packet.ReadUInt32("Raidorigin", indexes);
            packet.ReadByte("RegionGroupMask", indexes);
            packet.ReadUInt32("ChallengeOrigin", indexes);
        }

        public static void CharTitlesHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadCString("Name1", indexes);
            packet.ReadInt16("MaskID", indexes);
            packet.ReadSByte("Flags", indexes);
        }

        public static void CharacterLoadoutHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt64("Racemask", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadSByte("ChrClassID", indexes);
            packet.ReadInt32("Purpose", indexes);
            packet.ReadSByte("ItemContext", indexes);
        }

        public static void CharacterLoadoutItemHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt16("CharacterLoadoutID", indexes);
            packet.ReadUInt32("ItemID", indexes);
        }

        public static void ChatChannelsHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadCString("Shortcut", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("Flags", indexes);
            packet.ReadSByte("FactionGroup", indexes);
            packet.ReadInt32("Ruleset", indexes);
        }

        public static void ChatChannelsHandler343(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadCString("Shortcut", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("Flags", indexes);
            packet.ReadSByte("FactionGroup", indexes);
            packet.ReadInt32("Ruleset", indexes);
        }

        public static void ChrClassUiDisplayHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadByte("ChrClassesID", indexes);
            packet.ReadUInt32("AdvGuidePlayerConditionID", indexes);
            packet.ReadUInt32("SplashPlayerConditionID", indexes);
        }

        public static void ChrClassesHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadCString("Filename", indexes);
            packet.ReadCString("NameMale", indexes);
            packet.ReadCString("NameFemale", indexes);
            packet.ReadCString("PetNameToken", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadUInt32("CreateScreenFileDataID", indexes);
            packet.ReadUInt32("SelectScreenFileDataID", indexes);
            packet.ReadUInt32("IconFileDataID", indexes);
            packet.ReadUInt32("LowResScreenFileDataID", indexes);
            packet.ReadInt32("Flags", indexes);
            packet.ReadInt32("StartingLevel", indexes);
            packet.ReadUInt32("RolesMask", indexes);
            packet.ReadUInt32("ArmorTypeMask", indexes);
            packet.ReadUInt16("CinematicSequenceID", indexes);
            packet.ReadUInt16("DefaultSpec", indexes);
            packet.ReadByte("HasStrengthAttackBonus", indexes);
            packet.ReadByte("PrimaryStatPriority", indexes);
            packet.ReadByte("DisplayPower", indexes);
            packet.ReadByte("RangedAttackPowerPerAgility", indexes);
            packet.ReadByte("AttackPowerPerAgility", indexes);
            packet.ReadByte("AttackPowerPerStrength", indexes);
            packet.ReadByte("SpellClassSet", indexes);
            packet.ReadByte("DamageBonusStat", indexes);
            packet.ReadByte("HasRelicSlot", indexes);
        }

        public static void ChrClassesHandler343(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadCString("Filename", indexes);
            packet.ReadCString("NameMale", indexes);
            packet.ReadCString("NameFemale", indexes);
            packet.ReadCString("PetNameToken", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadUInt32("CreateScreenFileDataID", indexes);
            packet.ReadUInt32("SelectScreenFileDataID", indexes);
            packet.ReadUInt32("IconFileDataID", indexes);
            packet.ReadUInt32("LowResScreenFileDataID", indexes);
            packet.ReadInt32("Flags", indexes);
            packet.ReadInt32("StartingLevel", indexes);
            packet.ReadUInt32("ArmorTypeMask", indexes);
            packet.ReadUInt16("CinematicSequenceID", indexes);
            packet.ReadUInt16("DefaultSpec", indexes);
            packet.ReadByte("HasStrengthAttackBonus", indexes);
            packet.ReadByte("PrimaryStatPriority", indexes);
            packet.ReadByte("DisplayPower", indexes);
            packet.ReadByte("RangedAttackPowerPerAgility", indexes);
            packet.ReadByte("AttackPowerPerAgility", indexes);
            packet.ReadByte("AttackPowerPerStrength", indexes);
            packet.ReadByte("SpellClassSet", indexes);
            packet.ReadByte("RolesMask", indexes);
            packet.ReadByte("DamageBonusStat", indexes);
            packet.ReadByte("HasRelicSlot", indexes);
        }

        public static void ChrClassesXPowerTypesHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadSByte("PowerType", indexes);
            packet.ReadInt32("ClassID", indexes);
        }

        public static void ChrCustomizationChoiceHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("ChrCustomizationOptionID", indexes);
            packet.ReadInt32("ChrCustomizationReqID", indexes);
            packet.ReadUInt16("SortOrder", indexes);
            packet.ReadUInt16("UiOrderIndex", indexes);
            packet.ReadInt32("Flags", indexes);
            packet.ReadInt32("AddedInPatch", indexes);
            for (int i = 0; i < 2; i++)
                packet.ReadInt32("SwatchColor", indexes, i);
        }

        public static void ChrCustomizationChoiceHandler341(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("ChrCustomizationOptionID", indexes);
            packet.ReadInt32("ChrCustomizationReqID", indexes);
            packet.ReadInt32("ChrCustomizationVisReqID", indexes);
            packet.ReadUInt16("SortOrder", indexes);
            packet.ReadUInt16("UiOrderIndex", indexes);
            packet.ReadInt32("Flags", indexes);
            packet.ReadInt32("AddedInPatch", indexes);
            for (int i = 0; i < 2; i++)
                packet.ReadInt32("SwatchColor", indexes, i);
        }

        public static void ChrCustomizationChoiceHandler342(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("ChrCustomizationOptionID", indexes);
            packet.ReadInt32("ChrCustomizationReqID", indexes);
            packet.ReadInt32("ChrCustomizationVisReqID", indexes);
            packet.ReadUInt16("SortOrder", indexes);
            packet.ReadUInt16("UiOrderIndex", indexes);
            packet.ReadInt32("Flags", indexes);
            packet.ReadInt32("AddedInPatch", indexes);
            packet.ReadInt32("SoundKitID", indexes);
            for (int i = 0; i < 2; i++)
                packet.ReadInt32("SwatchColor", indexes, i);
        }

        public static void ChrCustomizationDisplayInfoHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("ShapeshiftFormID", indexes);
            packet.ReadInt32("DisplayID", indexes);
            packet.ReadSingle("BarberShopMinCameraDistance", indexes);
            packet.ReadSingle("BarberShopHeightOffset", indexes);
        }

        public static void ChrCustomizationElementHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("ChrCustomizationChoiceID", indexes);
            packet.ReadInt32("RelatedChrCustomizationChoiceID", indexes);
            packet.ReadInt32("ChrCustomizationGeosetID", indexes);
            packet.ReadInt32("ChrCustomizationSkinnedModelID", indexes);
            packet.ReadInt32("ChrCustomizationMaterialID", indexes);
            packet.ReadInt32("ChrCustomizationBoneSetID", indexes);
            packet.ReadInt32("ChrCustomizationCondModelID", indexes);
            packet.ReadInt32("ChrCustomizationDisplayInfoID", indexes);
            packet.ReadInt32("ChrCustItemGeoModifyID", indexes);
        }

        public static void ChrCustomizationElementHandler341(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("ChrCustomizationChoiceID", indexes);
            packet.ReadInt32("RelatedChrCustomizationChoiceID", indexes);
            packet.ReadInt32("ChrCustomizationGeosetID", indexes);
            packet.ReadInt32("ChrCustomizationSkinnedModelID", indexes);
            packet.ReadInt32("ChrCustomizationMaterialID", indexes);
            packet.ReadInt32("ChrCustomizationBoneSetID", indexes);
            packet.ReadInt32("ChrCustomizationCondModelID", indexes);
            packet.ReadInt32("ChrCustomizationDisplayInfoID", indexes);
            packet.ReadInt32("ChrCustItemGeoModifyID", indexes);
            packet.ReadInt32("ChrCustomizationVoiceID", indexes);
        }

        public static void ChrCustomizationElementHandler342(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("ChrCustomizationChoiceID", indexes);
            packet.ReadInt32("RelatedChrCustomizationChoiceID", indexes);
            packet.ReadInt32("ChrCustomizationGeosetID", indexes);
            packet.ReadInt32("ChrCustomizationSkinnedModelID", indexes);
            packet.ReadInt32("ChrCustomizationMaterialID", indexes);
            packet.ReadInt32("ChrCustomizationBoneSetID", indexes);
            packet.ReadInt32("ChrCustomizationCondModelID", indexes);
            packet.ReadInt32("ChrCustomizationDisplayInfoID", indexes);
            packet.ReadInt32("ChrCustItemGeoModifyID", indexes);
            packet.ReadInt32("ChrCustomizationVoiceID", indexes);
            packet.ReadInt32("AnimKitID", indexes);
        }

        public static void ChrCustomizationElementHandler343(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("ChrCustomizationChoiceID", indexes);
            packet.ReadInt32("RelatedChrCustomizationChoiceID", indexes);
            packet.ReadInt32("ChrCustomizationGeosetID", indexes);
            packet.ReadInt32("ChrCustomizationSkinnedModelID", indexes);
            packet.ReadInt32("ChrCustomizationMaterialID", indexes);
            packet.ReadInt32("ChrCustomizationBoneSetID", indexes);
            packet.ReadInt32("ChrCustomizationCondModelID", indexes);
            packet.ReadInt32("ChrCustomizationDisplayInfoID", indexes);
            packet.ReadInt32("ChrCustItemGeoModifyID", indexes);
            packet.ReadInt32("ChrCustomizationVoiceID", indexes);
            packet.ReadInt32("AnimKitID", indexes);
            packet.ReadInt32("ParticleColorID", indexes);
        }

        public static void ChrCustomizationOptionHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadUInt16("SecondaryID", indexes);
            packet.ReadInt32("Flags", indexes);
            packet.ReadInt32("ChrModelID", indexes);
            packet.ReadInt32("SortIndex", indexes);
            packet.ReadInt32("ChrCustomizationCategoryID", indexes);
            packet.ReadInt32("OptionType", indexes);
            packet.ReadSingle("BarberShopCostModifier", indexes);
            packet.ReadInt32("ChrCustomizationID", indexes);
            packet.ReadInt32("ChrCustomizationReqID", indexes);
            packet.ReadInt32("UiOrderIndex", indexes);
        }

        public static void ChrCustomizationReqHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("Flags", indexes);
            packet.ReadInt32("ClassMask", indexes);
            packet.ReadInt32("AchievementID", indexes);
            packet.ReadInt32("OverrideArchive", indexes);
            packet.ReadInt32("ItemModifiedAppearanceID", indexes);
        }

        public static void ChrCustomizationReqHandler341(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("ReqSource", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("Flags", indexes);
            packet.ReadInt32("ClassMask", indexes);
            packet.ReadInt32("AchievementID", indexes);
            packet.ReadInt32("QuestID", indexes);
            packet.ReadInt32("OverrideArchive", indexes);
            packet.ReadInt32("ItemModifiedAppearanceID", indexes);
        }

        public static void ChrCustomizationReqHandler343(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt64("RaceMask", indexes);
            packet.ReadCString("ReqSource", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("Flags", indexes);
            packet.ReadInt32("ClassMask", indexes);
            packet.ReadInt32("AchievementID", indexes);
            packet.ReadInt32("QuestID", indexes);
            packet.ReadInt32("OverrideArchive", indexes);
            packet.ReadInt32("ItemModifiedAppearanceID", indexes);
        }

        public static void ChrCustomizationReqChoiceHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("ChrCustomizationChoiceID", indexes);
            packet.ReadInt32("ChrCustomizationReqID", indexes);
        }

        public static void ChrModelHandler340(Packet packet, uint entry, params object[] indexes)
        {

            for (int i =0; i < 3; i++)
                packet.ReadSingle("FaceCustomizationOffset", indexes, i);
            for (int i = 0; i < 3; i++)
                packet.ReadSingle("CustomizeOffset", indexes, i);
            packet.ReadUInt32("ID", indexes);
            packet.ReadSByte("Sex", indexes);
            packet.ReadInt32("DisplayID", indexes);
            packet.ReadInt32("CharComponentTextureLayoutID", indexes);
            packet.ReadInt32("Flags", indexes);
            packet.ReadInt32("SkeletonFileDataID", indexes);
            packet.ReadInt32("ModelFallbackChrModelID", indexes);
            packet.ReadInt32("TextureFallbackChrModelID", indexes);
            packet.ReadInt32("HelmVisFallbackChrModelID", indexes);
            packet.ReadSingle("CustomizeScale", indexes);
            packet.ReadSingle("CustomizeFacing", indexes);
            packet.ReadSingle("CameraDistanceOffset", indexes);
            packet.ReadSingle("BarberShopCameraOffsetScale", indexes);
            packet.ReadSingle("BarberShopCameraHeightOffsetScale", indexes);
            packet.ReadSingle("BarberShopCameraRotationOffset", indexes);
        }

        public static void ChrModelHandler341(Packet packet, uint entry, params object[] indexes)
        {
            for (int i = 0; i < 3; i++)
                packet.ReadSingle("FaceCustomizationOffset", indexes, i);
            for (int i = 0; i < 3; i++)
                packet.ReadSingle("CustomizeOffset", indexes, i);
            packet.ReadUInt32("ID", indexes);
            packet.ReadSByte("Sex", indexes);
            packet.ReadInt32("DisplayID", indexes);
            packet.ReadInt32("CharComponentTextureLayoutID", indexes);
            packet.ReadInt32("Flags", indexes);
            packet.ReadInt32("SkeletonFileDataID", indexes);
            packet.ReadInt32("ModelFallbackChrModelID", indexes);
            packet.ReadInt32("TextureFallbackChrModelID", indexes);
            packet.ReadInt32("HelmVisFallbackChrModelID", indexes);
            packet.ReadSingle("CustomizeScale", indexes);
            packet.ReadSingle("CustomizeFacing", indexes);
            packet.ReadSingle("CameraDistanceOffset", indexes);
            packet.ReadSingle("BarberShopCameraOffsetScale", indexes);
            packet.ReadSingle("BarberShopCameraHeightOffsetScale", indexes);
            packet.ReadSingle("BarberShopCameraRotationOffset", indexes);
        }

        public static void ChrRaceXChrModelHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("ChrRacesID", indexes);
            packet.ReadInt32("ChrModelID", indexes);
        }

        public static void ChrRaceXChrModelHandler341(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("ChrRacesID", indexes);
            packet.ReadInt32("ChrModelID", indexes);
            packet.ReadInt32("Sex", indexes);
            packet.ReadInt32("AllowedTransmogSlots", indexes);
        }

        public static void ChrRacesHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("ClientPrefix", indexes);
            packet.ReadCString("ClientFileString", indexes);
            packet.ReadCString("Name", indexes);
            packet.ReadCString("NameFemale", indexes);
            packet.ReadCString("NameLowercase", indexes);
            packet.ReadCString("NameFemaleLowercase", indexes);
            packet.ReadCString("LoreName", indexes);
            packet.ReadCString("LoreNameFemale", indexes);
            packet.ReadCString("LoreNameLower", indexes);
            packet.ReadCString("LoreNameLowerFemale", indexes);
            packet.ReadCString("LoreDescription", indexes);
            packet.ReadCString("ShortName", indexes);
            packet.ReadCString("ShortNameFemale", indexes);
            packet.ReadCString("ShortNameLower", indexes);
            packet.ReadCString("ShortNameLowerFemale", indexes);
            packet.ReadInt32("Flags", indexes);
            packet.ReadUInt32("MaleDisplayID", indexes);
            packet.ReadUInt32("FemaleDisplayID", indexes);
            packet.ReadUInt32("HighResMaleDisplayID", indexes);
            packet.ReadUInt32("HighResFemaleDisplayID", indexes);
            packet.ReadInt32("ResSicknessSpellID", indexes);
            packet.ReadInt32("SplashSoundID", indexes);
            packet.ReadInt32("CreateScreenFileDataID", indexes);
            packet.ReadInt32("SelectScreenFileDataID", indexes);
            packet.ReadInt32("LowResScreenFileDataID", indexes);
            for (int i = 0; i < 3; i++)
                packet.ReadUInt32("AlteredFormStartVisualKitID", indexes, i);
            for (int i = 0; i < 3; i++)
                packet.ReadUInt32("AlteredFormFinishVisualKitID", indexes, i);
            packet.ReadInt32("HeritageArmorAchievementID", indexes);
            packet.ReadInt32("StartingLevel", indexes);
            packet.ReadInt32("UiDisplayOrder", indexes);
            packet.ReadInt32("PlayableRaceBit", indexes);
            packet.ReadInt32("FemaleSkeletonFileDataID", indexes);
            packet.ReadInt32("MaleSkeletonFileDataID", indexes);
            packet.ReadInt32("HelmetAnimScalingRaceID", indexes);
            packet.ReadInt32("TransmogrifyDisabledSlotMask", indexes);
            for (int i = 0; i < 3; i++)
                packet.ReadSingle("AlteredFormCustomizeOffsetFallback", indexes, i);
            packet.ReadSingle("AlteredFormCustomizeRotationFallback", indexes);
            for (int i = 0; i < 3; i++)
                packet.ReadSingle("Unknown910_1", indexes, i);
            for (int i = 0; i < 3; i++)
                packet.ReadSingle("Unknown910_2", indexes, i);
            packet.ReadInt16("FactionID", indexes);
            packet.ReadInt16("CinematicSequenceID", indexes);
            packet.ReadSByte("BaseLanguage", indexes);
            packet.ReadSByte("CreatureType", indexes);
            packet.ReadSByte("Alliance", indexes);
            packet.ReadSByte("RaceRelated", indexes);
            packet.ReadSByte("UnalteredVisualRaceID", indexes);
            packet.ReadSByte("DefaultClassID", indexes);
            packet.ReadSByte("NeutralRaceID", indexes);
            packet.ReadSByte("MaleModelFallbackRaceID", indexes);
            packet.ReadSByte("MaleModelFallbackSex", indexes);
            packet.ReadSByte("FemaleModelFallbackRaceID", indexes);
            packet.ReadSByte("FemaleModelFallbackSex", indexes);
            packet.ReadSByte("MaleTextureFallbackRaceID", indexes);
            packet.ReadSByte("MaleTextureFallbackSex", indexes);
            packet.ReadSByte("FemaleTextureFallbackRaceID", indexes);
            packet.ReadSByte("FemaleTextureFallbackSex", indexes);
            packet.ReadSByte("UnalteredVisualCustomizationRaceID", indexes);
        }

        public static void ChrSpecializationHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadCString("FemaleName", indexes);
            packet.ReadCString("Description", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadSByte("ClassID", indexes);
            packet.ReadSByte("OrderIndex", indexes);
            packet.ReadSByte("PetTalentType", indexes);
            packet.ReadSByte("Role", indexes);
            packet.ReadUInt32("Flags", indexes);
            packet.ReadInt32("SpellIconFileID", indexes);
            packet.ReadSByte("PrimaryStatPriority", indexes);
            packet.ReadInt32("AnimReplacements", indexes);
            for (int i = 0; i < 2; i++)
                packet.ReadInt32("MasterySpellID", indexes, i);
        }

        public static void CinematicCameraHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadSingle("OriginX", indexes);
            packet.ReadSingle("OriginY", indexes);
            packet.ReadSingle("OriginZ", indexes);
            packet.ReadUInt32("SoundID", indexes);
            packet.ReadSingle("OriginFacing", indexes);
            packet.ReadUInt32("FileDataID", indexes);
        }

        public static void CinematicSequencesHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("SoundID", indexes);
            for (int i = 0; i < 8; i++)
                packet.ReadUInt16("Camera", indexes, i);
        }

        public static void ConditionalChrModelHandler343(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("ID", indexes);
            packet.ReadUInt32("ChrModelID", indexes);
            packet.ReadInt32("ChrCustomizationReqID", indexes);
            packet.ReadInt32("PlayerConditionID", indexes);
            packet.ReadInt32("Flags", indexes);
            packet.ReadInt32("ChrCustomizationCategoryID", indexes);
        }

        public static void ConditionalContentTuningHandler343(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("OrderIndex", indexes);
            packet.ReadInt32("RedirectContentTuningID", indexes);
            packet.ReadInt32("RedirectFlag", indexes);
            packet.ReadInt32("ParentContentTuningID", indexes);
        }

        public static void ContentTuningHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("MinLevel", indexes);
            packet.ReadInt32("MaxLevel", indexes);
            packet.ReadInt32("Flags", indexes);
            packet.ReadInt32("ExpectedStatModID", indexes);
            packet.ReadInt32("DifficultyESMID", indexes);
        }

        public static void ConversationLineHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("BroadcastTextID", indexes);
            packet.ReadUInt32("SpellVisualKitID", indexes);
            packet.ReadInt32("AdditionalDuration", indexes);
            packet.ReadUInt16("NextConversationLineID", indexes);
            packet.ReadUInt16("AnimKitID", indexes);
            packet.ReadByte("SpeechType", indexes);
            packet.ReadByte("StartAnimation", indexes);
            packet.ReadByte("EndAnimation", indexes);
        }

        public static void CreatureDisplayInfoHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ID", indexes);
            packet.ReadUInt16("ModelID", indexes);
            packet.ReadUInt16("SoundID", indexes);
            packet.ReadSByte("SizeClass", indexes);
            packet.ReadSingle("CreatureModelScale", indexes);
            packet.ReadByte("CreatureModelAlpha", indexes);
            packet.ReadByte("BloodID", indexes);
            packet.ReadInt32("ExtendedDisplayInfoID", indexes);
            packet.ReadUInt16("NPCSoundID", indexes);
            packet.ReadUInt16("ParticleColorID", indexes);
            packet.ReadInt32("PortraitCreatureDisplayInfoID", indexes);
            packet.ReadInt32("PortraitTextureFileDataID", indexes);
            packet.ReadUInt16("ObjectEffectPackageID", indexes);
            packet.ReadUInt16("AnimReplacementSetID", indexes);
            packet.ReadByte("Flags", indexes);
            packet.ReadInt32("StateSpellVisualKitID", indexes);
            packet.ReadSingle("PlayerOverrideScale", indexes);
            packet.ReadSingle("PetInstanceScale", indexes);
            packet.ReadSByte("UnarmedWeaponType", indexes);
            packet.ReadInt32("MountPoofSpellVisualKitID", indexes);
            packet.ReadInt32("DissolveEffectID", indexes);
            packet.ReadSByte("Gender", indexes);
            packet.ReadInt32("DissolveOutEffectID", indexes);
            packet.ReadSByte("CreatureModelMinLod", indexes);
            for (int i = 0; i < 3; i++)
                packet.ReadInt32("TextureVariationFileDataID", indexes, i);
        }

        public static void CreatureDisplayInfoHandler341(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ID", indexes);
            packet.ReadUInt16("ModelID", indexes);
            packet.ReadUInt16("SoundID", indexes);
            packet.ReadSByte("SizeClass", indexes);
            packet.ReadSingle("CreatureModelScale", indexes);
            packet.ReadByte("CreatureModelAlpha", indexes);
            packet.ReadByte("BloodID", indexes);
            packet.ReadInt32("ExtendedDisplayInfoID", indexes);
            packet.ReadUInt16("NPCSoundID", indexes);
            packet.ReadUInt16("ParticleColorID", indexes);
            packet.ReadInt32("PortraitCreatureDisplayInfoID", indexes);
            packet.ReadInt32("PortraitTextureFileDataID", indexes);
            packet.ReadUInt16("ObjectEffectPackageID", indexes);
            packet.ReadUInt16("AnimReplacementSetID", indexes);
            packet.ReadByte("Flags", indexes);
            packet.ReadInt32("StateSpellVisualKitID", indexes);
            packet.ReadSingle("PlayerOverrideScale", indexes);
            packet.ReadSingle("PetInstanceScale", indexes);
            packet.ReadSByte("UnarmedWeaponType", indexes);
            packet.ReadInt32("MountPoofSpellVisualKitID", indexes);
            packet.ReadInt32("DissolveEffectID", indexes);
            packet.ReadSByte("Gender", indexes);
            packet.ReadInt32("DissolveOutEffectID", indexes);
            packet.ReadSByte("CreatureModelMinLod", indexes);
            for (int i = 0; i < 4; i++)
                packet.ReadInt32("TextureVariationFileDataID", indexes, i);
        }

        public static void CreatureDisplayInfoExtraHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ID", indexes);
            packet.ReadSByte("DisplayRaceID", indexes);
            packet.ReadSByte("DisplaySexID", indexes);
            packet.ReadSByte("DisplayClassID", indexes);
            packet.ReadSByte("SkinID", indexes);
            packet.ReadSByte("FaceID", indexes);
            packet.ReadSByte("HairStyleID", indexes);
            packet.ReadSByte("HairColorID", indexes);
            packet.ReadSByte("FacialHairID", indexes);
            packet.ReadSByte("Flags", indexes);
            packet.ReadInt32("BakeMaterialResourcesID", indexes);
            packet.ReadInt32("HDBakeMaterialResourcesID", indexes);
            for (int i = 0; i < 3; i++)
                packet.ReadByte("CustomDisplayOption", indexes, i);
        }

        public static void CreatureFamilyHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadSingle("MinScale", indexes);
            packet.ReadSByte("MinScaleLevel", indexes);
            packet.ReadSingle("MaxScale", indexes);
            packet.ReadSByte("MaxScaleLevel", indexes);
            packet.ReadInt16("PetFoodMask", indexes);
            packet.ReadSByte("PetTalentType", indexes);
            packet.ReadInt32("CategoryEnumID", indexes);
            packet.ReadInt32("IconFileID", indexes);
            for (int i = 0; i < 2; i++)
                packet.ReadInt16("SkillLine", indexes, i);
        }

        public static void CreatureModelDataHandler340(Packet packet, uint entry, params object[] indexes)
        {
            for (int i = 0; i < 6; i++)
                packet.ReadSingle("GeoBox", indexes, i);
            packet.ReadUInt32("Flags", indexes);
            packet.ReadUInt32("FileDataID", indexes);
            packet.ReadUInt32("BloodID", indexes);
            packet.ReadUInt32("FootprintTextureID", indexes);
            packet.ReadSingle("FootprintTextureLength", indexes);
            packet.ReadSingle("FootprintTextureWidth", indexes);
            packet.ReadSingle("FootprintParticleScale", indexes);
            packet.ReadUInt32("FoleyMaterialID", indexes);
            packet.ReadUInt32("FootstepCameraEffectID", indexes);
            packet.ReadUInt32("DeathThudCameraEffectID", indexes);
            packet.ReadUInt32("SoundID", indexes);
            packet.ReadUInt32("SizeClass", indexes);
            packet.ReadSingle("CollisionWidth", indexes);
            packet.ReadSingle("CollisionHeight", indexes);
            packet.ReadSingle("WorldEffectScale", indexes);
            packet.ReadUInt32("CreatureGeosetDataID", indexes);
            packet.ReadSingle("HoverHeight", indexes);
            packet.ReadSingle("AttachedEffectScale", indexes);
            packet.ReadSingle("ModelScale", indexes);
            packet.ReadSingle("MissileCollisionRadius", indexes);
            packet.ReadSingle("MissileCollisionPush", indexes);
            packet.ReadSingle("MissileCollisionRaise", indexes);
            packet.ReadSingle("MountHeight", indexes);
            packet.ReadSingle("OverrideLootEffectScale", indexes);
            packet.ReadSingle("OverrideNameScale", indexes);
            packet.ReadSingle("OverrideSelectionRadius", indexes);
            packet.ReadSingle("TamedPetBaseScale", indexes);
        }

        public static void CreatureTypeHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadByte("Flags", indexes);
        }

        public static void CriteriaHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt16("Type", indexes);
            packet.ReadInt32("Asset", indexes);
            packet.ReadUInt32("ModifierTreeID", indexes);
            packet.ReadByte("StartEvent", indexes);
            packet.ReadInt32("StartAsset", indexes);
            packet.ReadUInt16("StartTimer", indexes);
            packet.ReadByte("FailEvent", indexes);
            packet.ReadInt32("FailAsset", indexes);
            packet.ReadByte("Flags", indexes);
            packet.ReadInt16("EligibilityWorldStateID", indexes);
            packet.ReadSByte("EligibilityWorldStateValue", indexes);
        }

        public static void CriteriaHandler343(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt16("Type", indexes);
            packet.ReadInt32("Asset", indexes);
            packet.ReadUInt32("ModifierTreeID", indexes);
            packet.ReadInt32("StartEvent", indexes);
            packet.ReadInt32("StartAsset", indexes);
            packet.ReadUInt16("StartTimer", indexes);
            packet.ReadInt32("FailEvent", indexes);
            packet.ReadInt32("FailAsset", indexes);
            packet.ReadInt32("Flags", indexes);
            packet.ReadInt16("EligibilityWorldStateID", indexes);
            packet.ReadSByte("EligibilityWorldStateValue", indexes);
        }

        public static void CriteriaTreeHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Description", indexes);
            packet.ReadUInt32("Parent", indexes);
            packet.ReadUInt32("Amount", indexes);
            packet.ReadSByte("Operator", indexes);
            packet.ReadUInt32("CriteriaID", indexes);
            packet.ReadInt32("OrderIndex", indexes);
            packet.ReadInt16("Flags", indexes);
        }

        public static void CriteriaTreeHandler343(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Description", indexes);
            packet.ReadUInt32("Parent", indexes);
            packet.ReadUInt32("Amount", indexes);
            packet.ReadInt32("Operator", indexes);
            packet.ReadUInt32("CriteriaID", indexes);
            packet.ReadInt32("OrderIndex", indexes);
            packet.ReadInt32("Flags", indexes);
        }

        public static void CurrencyContainerHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("ContainerName", indexes);
            packet.ReadCString("ContainerDescription", indexes);
            packet.ReadInt32("MinAmount", indexes);
            packet.ReadInt32("MaxAmount", indexes);
            packet.ReadInt32("ContainerIconID", indexes);
            packet.ReadInt32("ContainerQuality", indexes);
            packet.ReadInt32("OnLootSpellVisualKitID", indexes);
            packet.ReadInt32("CurrencyTypesID", indexes);
        }

        public static void CurrencyTypesHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadCString("Description", indexes);
            packet.ReadByte("CategoryID", indexes);
            packet.ReadInt32("InventoryIconFileID", indexes);
            packet.ReadUInt32("SpellWeight", indexes);
            packet.ReadByte("SpellCategory", indexes);
            packet.ReadUInt32("MaxQty", indexes);
            packet.ReadUInt32("MaxEarnablePerWeek", indexes);
            packet.ReadSByte("Quality", indexes);
            packet.ReadInt32("FactionID", indexes);
            for (int i = 0; i < 2; i++)
                packet.ReadInt32("Flags", indexes, i);
        }

        public static void CurrencyTypesHandler343(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadCString("Description", indexes);
            packet.ReadByte("CategoryID", indexes);
            packet.ReadInt32("InventoryIconFileID", indexes);
            packet.ReadUInt32("SpellWeight", indexes);
            packet.ReadByte("SpellCategory", indexes);
            packet.ReadUInt32("MaxQty", indexes);
            packet.ReadUInt32("MaxEarnablePerWeek", indexes);
            packet.ReadSByte("Quality", indexes);
            packet.ReadInt32("FactionID", indexes);
            packet.ReadInt32("AwardConditionID", indexes);
            for (int i = 0; i < 2; i++)
                packet.ReadInt32("Flags", indexes, i);
        }

        public static void CurveHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadByte("Type", indexes);
            packet.ReadByte("Flags", indexes);
        }

        public static void CurveHandler341(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ID", indexes);
            packet.ReadByte("Type", indexes);
            packet.ReadByte("Flags", indexes);
        }

        public static void CurvePointHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadSingle("PosX", indexes);
            packet.ReadSingle("PosY", indexes);
            packet.ReadUInt16("CurveID", indexes);
            packet.ReadByte("OrderIndex", indexes);
        }

        public static void CurvePointHandler341(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadSingle("PosX", indexes);
            packet.ReadSingle("PosY", indexes);
            packet.ReadSingle("PreSLSquishPosX", indexes);
            packet.ReadSingle("PreSLSquishPosY", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadUInt16("CurveID", indexes);
            packet.ReadByte("OrderIndex", indexes);
        }

        public static void CurvePointHandler342(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadSingle("PosX", indexes);
            packet.ReadSingle("PosY", indexes);
            packet.ReadSingle("PosPreSquishX", indexes);
            packet.ReadSingle("PosPreSquishY", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("CurveID", indexes);
            packet.ReadByte("OrderIndex", indexes);
        }

        public static void DestructibleModelDataHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadSByte("State0ImpactEffectDoodadSet", indexes);
            packet.ReadByte("State0AmbientDoodadSet", indexes);
            packet.ReadUInt32("State1Wmo", indexes);
            packet.ReadSByte("State1DestructionDoodadSet", indexes);
            packet.ReadSByte("State1ImpactEffectDoodadSet", indexes);
            packet.ReadByte("State1AmbientDoodadSet", indexes);
            packet.ReadUInt32("State2Wmo", indexes);
            packet.ReadSByte("State2DestructionDoodadSet", indexes);
            packet.ReadSByte("State2ImpactEffectDoodadSet", indexes);
            packet.ReadByte("State2AmbientDoodadSet", indexes);
            packet.ReadUInt32("State3Wmo", indexes);
            packet.ReadByte("State3InitDoodadSet", indexes);
            packet.ReadByte("State3AmbientDoodadSet", indexes);
            packet.ReadByte("EjectDirection", indexes);
            packet.ReadByte("DoNotHighlight", indexes);
            packet.ReadUInt32("State0Wmo", indexes);
            packet.ReadByte("HealEffect", indexes);
            packet.ReadUInt16("HealEffectSpeed", indexes);
            packet.ReadSByte("State0NameSet", indexes);
            packet.ReadSByte("State1NameSet", indexes);
            packet.ReadSByte("State2NameSet", indexes);
            packet.ReadSByte("State3NameSet", indexes);
        }

        public static void DifficultyHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadByte("InstanceType", indexes);
            packet.ReadByte("OrderIndex", indexes);
            packet.ReadSByte("OldEnumValue", indexes);
            packet.ReadByte("FallbackDifficultyID", indexes);
            packet.ReadByte("MinPlayers", indexes);
            packet.ReadByte("MaxPlayers", indexes);
            packet.ReadByte("Flags", indexes);
            packet.ReadByte("ItemContext", indexes);
            packet.ReadByte("ToggleDifficultyID", indexes);
            packet.ReadUInt16("GroupSizeHealthCurveID", indexes);
            packet.ReadUInt16("GroupSizeDmgCurveID", indexes);
            packet.ReadUInt16("GroupSizeSpellPointsCurveID", indexes);
        }

        public static void DungeonEncounterHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt16("MapID", indexes);
            packet.ReadInt32("DifficultyID", indexes);
            packet.ReadInt32("OrderIndex", indexes);
            packet.ReadSByte("Bit", indexes);
            packet.ReadInt32("CreatureDisplayID", indexes);
            packet.ReadInt32("Flags", indexes);
        }

        public static void DungeonEncounterHandler341(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt16("MapID", indexes);
            packet.ReadInt32("DifficultyID", indexes);
            packet.ReadInt32("OrderIndex", indexes);
            packet.ReadSByte("Bit", indexes);
            packet.ReadInt32("Flags", indexes);
        }

        public static void DungeonEncounterHandler343(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt16("MapID", indexes);
            packet.ReadInt32("DifficultyID", indexes);
            packet.ReadInt32("OrderIndex", indexes);
            packet.ReadSByte("Bit", indexes);
            packet.ReadInt32("Flags", indexes);
            packet.ReadInt32("Faction", indexes);
        }

        public static void DurabilityCostsHandler340(Packet packet, uint entry, params object[] indexes)
        {
            for (int i = 0; i < 21; i++)
                packet.ReadUInt16("WeaponSubClassCost", indexes, i);
            for (int i = 0; i < 8; i++)
                packet.ReadUInt16("ArmorSubClassCost", indexes, i);
        }

        public static void DurabilityQualityHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadSingle("Data", indexes);
        }

        public static void EmotesHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt64("RaceMask", indexes);
            packet.ReadCString("EmoteSlashCommand", indexes);
            packet.ReadInt32("AnimID", indexes);
            packet.ReadUInt32("EmoteFlags", indexes);
            packet.ReadByte("EmoteSpecProc", indexes);
            packet.ReadUInt32("EmoteSpecProcParam", indexes);
            packet.ReadUInt32("EventSoundID", indexes);
            packet.ReadUInt32("SpellVisualKitID", indexes);
            packet.ReadInt32("ClassMask", indexes);
        }

        public static void EmotesTextHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadUInt16("EmoteID", indexes);
        }

        public static void EmotesTextSoundHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadByte("RaceID", indexes);
            packet.ReadByte("ClassID", indexes);
            packet.ReadByte("SexID", indexes);
            packet.ReadUInt32("SoundID", indexes);
            packet.ReadInt32("EmotesTextID", indexes);
        }

        public static void ExpectedStatHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("ExpansionID", indexes);
            packet.ReadSingle("CreatureHealth", indexes);
            packet.ReadSingle("PlayerHealth", indexes);
            packet.ReadSingle("CreatureAutoAttackDps", indexes);
            packet.ReadSingle("CreatureArmor", indexes);
            packet.ReadSingle("PlayerMana", indexes);
            packet.ReadSingle("PlayerPrimaryStat", indexes);
            packet.ReadSingle("PlayerSecondaryStat", indexes);
            packet.ReadSingle("ArmorConstant", indexes);
            packet.ReadSingle("CreatureSpellDamage", indexes);
            packet.ReadInt32("Lvl", indexes);
        }

        public static void ExpectedStatModHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadSingle("CreatureHealthMod", indexes);
            packet.ReadSingle("PlayerHealthMod", indexes);
            packet.ReadSingle("CreatureAutoAttackDPSMod", indexes);
            packet.ReadSingle("CreatureArmorMod", indexes);
            packet.ReadSingle("PlayerManaMod", indexes);
            packet.ReadSingle("PlayerPrimaryStatMod", indexes);
            packet.ReadSingle("PlayerSecondaryStatMod", indexes);
            packet.ReadSingle("ArmorConstantMod", indexes);
            packet.ReadSingle("CreatureSpellDamageMod", indexes);
        }

        public static void FactionHandler340(Packet packet, uint entry, params object[] indexes)
        {
            for (int i = 0; i < 4; i++)
                packet.ReadInt64("ReputationRaceMask", indexes, i);
            packet.ReadCString("Name", indexes);
            packet.ReadCString("Description", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt16("ReputationIndex", indexes);
            packet.ReadUInt16("ParentFactionID", indexes);
            packet.ReadByte("Expansion", indexes);
            packet.ReadByte("FriendshipRepID", indexes);
            packet.ReadByte("Flags", indexes);
            packet.ReadUInt16("ParagonFactionID", indexes);
            for (int i = 0; i < 4; i++)
                packet.ReadInt16("ReputationClassMask", indexes, i);
            for (int i = 0; i < 4; i++)
                packet.ReadUInt16("ReputationFlags", indexes, i);
            for (int i = 0; i < 4; i++)
                packet.ReadInt32("ReputationBase", indexes, i);
            for (int i = 0; i < 4; i++)
                packet.ReadInt32("ReputationMax", indexes, i);
            for (int i = 0; i < 2; i++)
                packet.ReadSingle("ParentFactionMod", indexes, i);
            for (int i = 0; i < 2; i++)
                packet.ReadByte("ParentFactionCap", indexes, i);
        }

        public static void FactionHandler341(Packet packet, uint entry, params object[] indexes)
        {
            for (int i = 0; i < 4; i++)
                packet.ReadInt64("ReputationRaceMask", indexes, i);
            packet.ReadCString("Name", indexes);
            packet.ReadCString("Description", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt16("ReputationIndex", indexes);
            packet.ReadUInt16("ParentFactionID", indexes);
            packet.ReadByte("Expansion", indexes);
            packet.ReadByte("FriendshipRepID", indexes);
            packet.ReadInt32("Flags", indexes);
            packet.ReadUInt16("ParagonFactionID", indexes);
            packet.ReadInt32("RenownFactionID", indexes);
            packet.ReadInt32("RenownCurrencyID", indexes);
            for (int i = 0; i < 4; i++)
                packet.ReadInt16("ReputationClassMask", indexes, i);
            for (int i = 0; i < 4; i++)
                packet.ReadUInt16("ReputationFlags", indexes, i);
            for (int i = 0; i < 4; i++)
                packet.ReadInt32("ReputationBase", indexes, i);
            for (int i = 0; i < 4; i++)
                packet.ReadInt32("ReputationMax", indexes, i);
            for (int i = 0; i < 2; i++)
                packet.ReadSingle("ParentFactionMod", indexes, i);
            for (int i = 0; i < 2; i++)
                packet.ReadByte("ParentFactionCap", indexes, i);
        }

        public static void FactionTemplateHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt16("Faction", indexes);
            packet.ReadUInt16("Flags", indexes);
            packet.ReadByte("FactionGroup", indexes);
            packet.ReadByte("FriendGroup", indexes);
            packet.ReadByte("EnemyGroup", indexes);
            for (int i = 0; i < 4; i++)
                packet.ReadUInt16("Enemies", indexes, i);
            for (int i = 0; i < 4; i++)
                packet.ReadUInt16("Friend", indexes, i);
        }

        public static void FactionTemplateHandler341(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt16("Faction", indexes);
            packet.ReadUInt16("Flags", indexes);
            packet.ReadByte("FactionGroup", indexes);
            packet.ReadByte("FriendGroup", indexes);
            packet.ReadByte("EnemyGroup", indexes);
            for (int i = 0; i < 8; i++)
                packet.ReadUInt16("Enemies", indexes, i);
            for (int i = 0; i < 8; i++)
                packet.ReadUInt16("Friend", indexes, i);
        }

        public static void FriendshipRepReactionHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Reaction", indexes);
            packet.ReadByte("FriendshipRepID", indexes);
            packet.ReadUInt16("ReactionThreshold", indexes);
        }

        public static void FriendshipReputationHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Description", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadUInt16("FactionID", indexes);
            packet.ReadInt32("TextureFileID", indexes);
        }

        public static void FriendshipReputationHandler341(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Description", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("Field34146722002", indexes);
            packet.ReadInt32("Field34146722003", indexes);
        }

        public static void GameobjectArtKitHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("AttachModelFileID", indexes);
            for (int i = 0; i < 3; i++)
                packet.ReadInt32("TextureVariationFileID", indexes, i);
        }

        public static void GameobjectDisplayInfoHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("ModelName", indexes);
            packet.ReadSingle("GeoBoxMinX", indexes);
            packet.ReadSingle("GeoBoxMinY", indexes);
            packet.ReadSingle("GeoBoxMinZ", indexes);
            packet.ReadSingle("GeoBoxMaxX", indexes);
            packet.ReadSingle("GeoBoxMaxY", indexes);
            packet.ReadSingle("GeoBoxMaxZ", indexes);
            packet.ReadInt32("FileDataID", indexes);
            packet.ReadInt16("ObjectEffectPackageID", indexes);
            packet.ReadSingle("OverrideLootEffectScale", indexes);
            packet.ReadSingle("OverrideNameScale", indexes);
        }

        public static void GameobjectsHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadSingle("PosX", indexes);
            packet.ReadSingle("PosY", indexes);
            packet.ReadSingle("PosZ", indexes);
            for (int i = 0; i < 4; i++)
                packet.ReadSingle("Rot", indexes, i);
            packet.ReadUInt32("ID", indexes);
            packet.ReadUInt16("OwnerID", indexes);
            packet.ReadUInt32("DisplayID", indexes);
            packet.ReadSingle("Scale", indexes);
            packet.ReadByte("TypeID", indexes);
            packet.ReadByte("PhaseUseFlags", indexes);
            packet.ReadUInt16("PhaseID", indexes);
            packet.ReadUInt16("PhaseGroupID", indexes);
            for (int i = 0; i < 8; i++)
                packet.ReadInt32("PropValue", indexes, i);
        }

        public static void GarrAbilityHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadCString("Description", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadByte("GarrAbilityCategoryID", indexes);
            packet.ReadByte("GarrFollowerTypeID", indexes);
            packet.ReadInt32("IconFileDataID", indexes);
            packet.ReadUInt16("FactionChangeGarrAbilityID", indexes);
            packet.ReadUInt16("Flags", indexes);
        }

        public static void GarrBuildingHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("HordeName", indexes);
            packet.ReadCString("AllianceName", indexes);
            packet.ReadCString("Description", indexes);
            packet.ReadCString("Tooltip", indexes);
            packet.ReadByte("GarrTypeID", indexes);
            packet.ReadByte("BuildingType", indexes);
            packet.ReadInt32("HordeGameObjectID", indexes);
            packet.ReadInt32("AllianceGameObjectID", indexes);
            packet.ReadByte("GarrSiteID", indexes);
            packet.ReadByte("UpgradeLevel", indexes);
            packet.ReadInt32("BuildSeconds", indexes);
            packet.ReadUInt16("CurrencyTypeID", indexes);
            packet.ReadInt32("CurrencyQty", indexes);
            packet.ReadUInt16("HordeUiTextureKitID", indexes);
            packet.ReadUInt16("AllianceUiTextureKitID", indexes);
            packet.ReadInt32("IconFileDataID", indexes);
            packet.ReadUInt16("AllianceSceneScriptPackageID", indexes);
            packet.ReadUInt16("HordeSceneScriptPackageID", indexes);
            packet.ReadInt32("MaxAssignments", indexes);
            packet.ReadByte("ShipmentCapacity", indexes);
            packet.ReadUInt16("GarrAbilityID", indexes);
            packet.ReadUInt16("BonusGarrAbilityID", indexes);
            packet.ReadUInt16("GoldCost", indexes);
            packet.ReadByte("Flags", indexes);
        }

        public static void GarrBuildingPlotInstHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadSingle("MapOffsetX", indexes);
            packet.ReadSingle("MapOffsetY", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadByte("GarrBuildingID", indexes);
            packet.ReadUInt16("GarrSiteLevelPlotInstID", indexes);
            packet.ReadUInt16("UiTextureAtlasMemberID", indexes);
        }

        public static void GarrClassSpecHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("ClassSpec", indexes);
            packet.ReadCString("ClassSpecMale", indexes);
            packet.ReadCString("ClassSpecFemale", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadUInt16("UiTextureAtlasMemberID", indexes);
            packet.ReadUInt16("GarrFollItemSetID", indexes);
            packet.ReadByte("FollowerClassLimit", indexes);
            packet.ReadByte("Flags", indexes);
        }

        public static void GarrFollowerHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("HordeSourceText", indexes);
            packet.ReadCString("AllianceSourceText", indexes);
            packet.ReadCString("TitleName", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadByte("GarrTypeID", indexes);
            packet.ReadByte("GarrFollowerTypeID", indexes);
            packet.ReadInt32("HordeCreatureID", indexes);
            packet.ReadInt32("AllianceCreatureID", indexes);
            packet.ReadByte("HordeGarrFollRaceID", indexes);
            packet.ReadByte("AllianceGarrFollRaceID", indexes);
            packet.ReadByte("HordeGarrClassSpecID", indexes);
            packet.ReadByte("AllianceGarrClassSpecID", indexes);
            packet.ReadByte("Quality", indexes);
            packet.ReadByte("FollowerLevel", indexes);
            packet.ReadUInt16("ItemLevelWeapon", indexes);
            packet.ReadUInt16("ItemLevelArmor", indexes);
            packet.ReadSByte("HordeSourceTypeEnum", indexes);
            packet.ReadSByte("AllianceSourceTypeEnum", indexes);
            packet.ReadInt32("HordeIconFileDataID", indexes);
            packet.ReadInt32("AllianceIconFileDataID", indexes);
            packet.ReadUInt16("HordeGarrFollItemSetID", indexes);
            packet.ReadUInt16("AllianceGarrFollItemSetID", indexes);
            packet.ReadUInt16("HordeUITextureKitID", indexes);
            packet.ReadUInt16("AllianceUITextureKitID", indexes);
            packet.ReadByte("Vitality", indexes);
            packet.ReadByte("HordeFlavorGarrStringID", indexes);
            packet.ReadByte("AllianceFlavorGarrStringID", indexes);
            packet.ReadUInt32("HordeSlottingBroadcastTextID", indexes);
            packet.ReadUInt32("AllySlottingBroadcastTextID", indexes);
            packet.ReadByte("ChrClassID", indexes);
            packet.ReadByte("Flags", indexes);
            packet.ReadByte("Gender", indexes);
        }

        public static void GarrFollowerXAbilityHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadByte("OrderIndex", indexes);
            packet.ReadByte("FactionIndex", indexes);
            packet.ReadUInt16("GarrAbilityID", indexes);
            packet.ReadInt32("GarrFollowerID", indexes);
        }

        public static void GarrMissionHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadCString("Location", indexes);
            packet.ReadCString("Description", indexes);
            packet.ReadSingle("MapPosX", indexes);
            packet.ReadSingle("MapPosY", indexes);
            packet.ReadSingle("WorldPosX", indexes);
            packet.ReadSingle("WorldPosY", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadByte("GarrTypeID", indexes);
            packet.ReadByte("GarrMissionTypeID", indexes);
            packet.ReadByte("GarrFollowerTypeID", indexes);
            packet.ReadByte("MaxFollowers", indexes);
            packet.ReadUInt32("MissionCost", indexes);
            packet.ReadUInt16("MissionCostCurrencyTypesID", indexes);
            packet.ReadByte("OfferedGarrMissionTextureID", indexes);
            packet.ReadUInt16("UiTextureKitID", indexes);
            packet.ReadUInt32("EnvGarrMechanicID", indexes);
            packet.ReadByte("EnvGarrMechanicTypeID", indexes);
            packet.ReadUInt32("PlayerConditionID", indexes);
            packet.ReadSByte("TargetLevel", indexes);
            packet.ReadUInt16("TargetItemLevel", indexes);
            packet.ReadInt32("MissionDuration", indexes);
            packet.ReadInt32("TravelDuration", indexes);
            packet.ReadUInt32("OfferDuration", indexes);
            packet.ReadByte("BaseCompletionChance", indexes);
            packet.ReadUInt32("BaseFollowerXP", indexes);
            packet.ReadUInt32("OvermaxRewardPackID", indexes);
            packet.ReadByte("FollowerDeathChance", indexes);
            packet.ReadUInt32("AreaID", indexes);
            packet.ReadUInt32("Flags", indexes);
            packet.ReadInt32("GarrMissionSetID", indexes);
        }

        public static void GarrPlotHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadByte("PlotType", indexes);
            packet.ReadInt32("HordeConstructObjID", indexes);
            packet.ReadInt32("AllianceConstructObjID", indexes);
            packet.ReadByte("Flags", indexes);
            packet.ReadByte("UiCategoryID", indexes);
            for (int i = 0; i < 2; i++)
                packet.ReadUInt32("UpgradeRequirement", indexes, i);
        }

        public static void GarrPlotBuildingHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadByte("GarrPlotID", indexes);
            packet.ReadByte("GarrBuildingID", indexes);
        }

        public static void GarrPlotInstanceHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadByte("GarrPlotID", indexes);
        }

        public static void GarrSiteLevelHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadSingle("TownHallUiPosX", indexes);
            packet.ReadSingle("TownHallUiPosY", indexes);
            packet.ReadUInt32("GarrSiteID", indexes);
            packet.ReadByte("GarrLevel", indexes);
            packet.ReadUInt16("MapID", indexes);
            packet.ReadUInt16("UpgradeMovieID", indexes);
            packet.ReadUInt16("UiTextureKitID", indexes);
            packet.ReadByte("MaxBuildingLevel", indexes);
            packet.ReadUInt16("UpgradeCost", indexes);
            packet.ReadUInt16("UpgradeGoldCost", indexes);
        }

        public static void GarrSiteLevelPlotInstHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadSingle("UiMarkerPosX", indexes);
            packet.ReadSingle("UiMarkerPosY", indexes);
            packet.ReadUInt16("GarrSiteLevelID", indexes);
            packet.ReadByte("GarrPlotInstanceID", indexes);
            packet.ReadByte("UiMarkerSize", indexes);
        }

        public static void GarrTalentTreeHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadInt32("GarrTypeID", indexes);
            packet.ReadInt32("ClassID", indexes);
            packet.ReadSByte("MaxTiers", indexes);
            packet.ReadSByte("UiOrder", indexes);
            packet.ReadSByte("Flags", indexes);
            packet.ReadUInt16("UiTextureKitID", indexes);
        }

        public static void GemPropertiesHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt16("EnchantID", indexes);
            packet.ReadInt32("Type", indexes);
            packet.ReadUInt16("MinItemLevel", indexes);
        }

        public static void GlyphBindableSpellHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("SpellID", indexes);
            packet.ReadInt32("GlyphPropertiesID", indexes);
        }

        public static void GlyphSlotHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("Tooltip", indexes);
            packet.ReadUInt32("Type", indexes);
        }

        public static void GlyphPropertiesHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("SpellID", indexes);
            packet.ReadByte("GlyphType", indexes);
            packet.ReadByte("GlyphExclusiveCategoryID", indexes);
            packet.ReadInt32("SpellIconFileDataID", indexes);
            packet.ReadUInt32("GlyphSlotFlags", indexes);
        }

        public static void GlyphRequiredSpecHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt16("ChrSpecializationID", indexes);
            packet.ReadInt32("GlyphPropertiesID", indexes);
        }

        public static void GossipNPCOptionHandler341(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("GossipNpcOption", indexes);
            packet.ReadInt32("LFGDungeonsID", indexes);
            packet.ReadInt32("Unk341_1", indexes);
            packet.ReadInt32("Unk341_2", indexes);
            packet.ReadInt32("Unk341_3", indexes);
            packet.ReadInt32("Unk341_4", indexes);
            packet.ReadInt32("Unk341_5", indexes);
            packet.ReadInt32("Unk341_6", indexes);
            packet.ReadInt32("Unk341_7", indexes);
            packet.ReadInt32("Unk341_8", indexes);
            packet.ReadInt32("Unk341_9", indexes);
            packet.ReadInt32("GossipOptionID", indexes);
        }

        public static void GuildColorBackgroundHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadByte("Red", indexes);
            packet.ReadByte("Blue", indexes);
            packet.ReadByte("Green", indexes);
        }

        public static void GuildColorBorderHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadByte("Red", indexes);
            packet.ReadByte("Blue", indexes);
            packet.ReadByte("Green", indexes);
        }

        public static void GuildColorEmblemHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadByte("Red", indexes);
            packet.ReadByte("Blue", indexes);
            packet.ReadByte("Green", indexes);
        }

        public static void GuildPerkSpellsHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("SpellID", indexes);
        }

        public static void HeirloomHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("SourceText", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("ItemID", indexes);
            packet.ReadInt32("LegacyUpgradedItemID", indexes);
            packet.ReadInt32("StaticUpgradedItemID", indexes);
            packet.ReadSByte("SourceTypeEnum", indexes);
            packet.ReadByte("Flags", indexes);
            packet.ReadInt32("LegacyItemID", indexes);
            for (int i = 0; i < 6; i++)
                packet.ReadInt32("UpgradeItemID", indexes, i);
            for (int i = 0; i < 6; i++)
                packet.ReadUInt16("UpgradeItemBonusListID", indexes, i);
        }

        public static void HolidaysHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ID", indexes);
            packet.ReadUInt16("Region", indexes);
            packet.ReadByte("Looping", indexes);
            packet.ReadUInt32("HolidayNameID", indexes);
            packet.ReadUInt32("HolidayDescriptionID", indexes);
            packet.ReadByte("Priority", indexes);
            packet.ReadSByte("CalendarFilterType", indexes);
            packet.ReadByte("Flags", indexes);
            packet.ReadUInt32("WorldStateExpressionID", indexes);
            for (int i = 0; i < 10; i++)
                packet.ReadUInt16("Duration", indexes, i);
            for (int i = 0; i < 16; i++)
                packet.ReadUInt32("Date", indexes, i);
            for (int i = 0; i < 10; i++)
                packet.ReadByte("CalendarFlags", indexes, i);
            for (int i = 0; i < 3; i++)
                packet.ReadInt32("TextureFileDataID", indexes, i);
        }

        public static void ImportPriceArmorHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadSingle("ClothModifier", indexes);
            packet.ReadSingle("LeatherModifier", indexes);
            packet.ReadSingle("ChainModifier", indexes);
            packet.ReadSingle("PlateModifier", indexes);
        }

        public static void ImportPriceQualityHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadSingle("Data", indexes);
        }

        public static void ImportPriceShieldHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadSingle("Data", indexes);
        }

        public static void ImportPriceWeaponHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadSingle("Data", indexes);
        }

        public static void ItemHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadByte("ClassID", indexes);
            packet.ReadByte("SubclassID", indexes);
            packet.ReadByte("Material", indexes);
            packet.ReadSByte("InventoryType", indexes);
            packet.ReadInt32("RequiredLevel", indexes);
            packet.ReadByte("SheatheType", indexes);
            packet.ReadUInt16("RandomSelect", indexes);
            packet.ReadUInt16("ItemRandomSuffixGroupID", indexes);
            packet.ReadSByte("SoundOverrideSubclassID", indexes);
            packet.ReadUInt16("ScalingStatDistributionID", indexes);
            packet.ReadInt32("IconFileDataID", indexes);
            packet.ReadByte("ItemGroupSoundsID", indexes);
            packet.ReadInt32("ContentTuningID", indexes);
            packet.ReadUInt32("MaxDurability", indexes);
            packet.ReadByte("AmmunitionType", indexes);
            for (int i = 0; i < 5; i++)
                packet.ReadByte("DamageType", indexes, i);
            for (int i = 0; i < 7; i++)
                packet.ReadInt16("Resistances", indexes, i);
            for (int i = 0; i < 5; i++)
                packet.ReadUInt16("MinDamage", indexes, i);
            for (int i = 0; i < 5; i++)
                packet.ReadUInt16("MaxDamage", indexes, i);
        }

        public static void ItemHandler341(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadByte("ClassID", indexes);
            packet.ReadByte("SubclassID", indexes);
            packet.ReadByte("Material", indexes);
            packet.ReadSByte("InventoryType", indexes);
            packet.ReadInt32("RequiredLevel", indexes);
            packet.ReadByte("SheatheType", indexes);
            packet.ReadUInt16("RandomSelect", indexes);
            packet.ReadUInt16("ItemRandomSuffixGroupID", indexes);
            packet.ReadSByte("SoundOverrideSubclassID", indexes);
            packet.ReadUInt16("ScalingStatDistributionID", indexes);
            packet.ReadInt32("IconFileDataID", indexes);
            packet.ReadByte("ItemGroupSoundsID", indexes);
            packet.ReadInt32("ContentTuningID", indexes);
            packet.ReadUInt32("MaxDurability", indexes);
            packet.ReadByte("AmmunitionType", indexes);
            packet.ReadInt32("ScalingStatValue", indexes);
            for (int i = 0; i < 5; i++)
                packet.ReadByte("DamageType", indexes, i);
            for (int i = 0; i < 7; i++)
                packet.ReadInt16("Resistances", indexes, i);
            for (int i = 0; i < 5; i++)
                packet.ReadUInt16("MinDamage", indexes, i);
            for (int i = 0; i < 5; i++)
                packet.ReadUInt16("MaxDamage", indexes, i);
        }

        public static void ItemAppearanceHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadByte("DisplayType", indexes);
            packet.ReadInt32("ItemDisplayInfoID", indexes);
            packet.ReadInt32("DefaultIconFileDataID", indexes);
            packet.ReadInt32("UiOrder", indexes);
        }

        public static void ItemArmorQualityHandler340(Packet packet, uint entry, params object[] indexes)
        {
            for (int i = 0; i < 7; i++)
                packet.ReadSingle("Qualitymod", indexes, i);
        }

        public static void ItemArmorShieldHandler340(Packet packet, uint entry, params object[] indexes)
        {
            for (int i = 0; i < 7; i++)
                packet.ReadSingle("Quality", indexes, i);
            packet.ReadUInt16("ItemLevel", indexes);
        }

        public static void ItemArmorTotalHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt16("ItemLevel", indexes);
            packet.ReadSingle("Cloth", indexes);
            packet.ReadSingle("Leather", indexes);
            packet.ReadSingle("Mail", indexes);
            packet.ReadSingle("Plate", indexes);
        }

        public static void ItemBagFamilyHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
        }

        public static void ItemBonusHandler340(Packet packet, uint entry, params object[] indexes)
        {
            for (int i = 0; i < 4; i++)
                packet.ReadInt32("Value", indexes, i);
            packet.ReadUInt16("ParentItemBonusListID", indexes);
            packet.ReadByte("Type", indexes);
            packet.ReadByte("OrderIndex", indexes);
        }

        public static void ItemBonusListLevelDeltaHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt16("ItemLevelDelta", indexes);
            packet.ReadUInt32("ID", indexes);
        }

        public static void ItemBonusTreeNodeHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadByte("ItemContext", indexes);
            packet.ReadUInt16("ChildItemBonusTreeID", indexes);
            packet.ReadUInt16("ChildItemBonusListID", indexes);
            packet.ReadUInt16("ChildItemLevelSelectorID", indexes);
            packet.ReadInt32("ParentItemBonusTreeID", indexes);
        }

        public static void ItemChildEquipmentHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("ChildItemID", indexes);
            packet.ReadByte("ChildItemEquipSlot", indexes);
            packet.ReadInt32("ParentItemID", indexes);
        }

        public static void ItemClassHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("ClassName", indexes);
            packet.ReadSByte("ClassID", indexes);
            packet.ReadSingle("PriceModifier", indexes);
            packet.ReadByte("Flags", indexes);
        }

        public static void ItemContextPickerEntryHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadByte("ItemCreationContext", indexes);
            packet.ReadByte("OrderIndex", indexes);
            packet.ReadInt32("PVal", indexes);
            packet.ReadUInt32("Flags", indexes);
            packet.ReadUInt32("PlayerConditionID", indexes);
            packet.ReadInt32("ItemContextPickerID", indexes);
        }

        public static void ItemCurrencyCostHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("ItemID", indexes);
        }

        public static void ItemDamageAmmoHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt16("ItemLevel", indexes);
            for (int i = 0; i < 7; i++)
                packet.ReadSingle("Quality", indexes, i);
        }

        public static void ItemDamageOneHandHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt16("ItemLevel", indexes);
            for (int i = 0; i < 7; i++)
                packet.ReadSingle("Quality", indexes, i);
        }

        public static void ItemDamageOneHandCasterHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt16("ItemLevel", indexes);
            for (int i = 0; i < 7; i++)
                packet.ReadSingle("Quality", indexes, i);
        }

        public static void ItemDamageTwoHandHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt16("ItemLevel", indexes);
            for (int i = 0; i < 7; i++)
                packet.ReadSingle("Quality", indexes, i);
        }

        public static void ItemDamageTwoHandCasterHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt16("ItemLevel", indexes);
            for (int i = 0; i < 7; i++)
                packet.ReadSingle("Quality", indexes, i);
        }

        public static void ItemDisenchantLootHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadSByte("Subclass", indexes);
            packet.ReadByte("Quality", indexes);
            packet.ReadUInt16("MinLevel", indexes);
            packet.ReadUInt16("MaxLevel", indexes);
            packet.ReadUInt16("SkillRequired", indexes);
            packet.ReadSByte("ExpansionID", indexes);
            packet.ReadInt32("Class", indexes);
        }

        public static void ItemEffectHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadByte("LegacySlotIndex", indexes);
            packet.ReadSByte("TriggerType", indexes);
            packet.ReadInt16("Charges", indexes);
            packet.ReadInt32("CoolDownMSec", indexes);
            packet.ReadInt32("CategoryCoolDownMSec", indexes);
            packet.ReadUInt16("SpellCategoryID", indexes);
            packet.ReadInt32("SpellID", indexes);
            packet.ReadUInt16("ChrSpecializationID", indexes);
            packet.ReadInt32("ParentItemID", indexes);
        }

        public static void ItemExtendedCostHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt16("RequiredArenaRating", indexes);
            packet.ReadSByte("ArenaBracket", indexes);
            packet.ReadByte("Flags", indexes);
            packet.ReadByte("MinFactionID", indexes);
            packet.ReadByte("MinReputation", indexes);
            packet.ReadByte("RequiredAchievement", indexes);
            for (int i = 0; i < 5; i++)
                packet.ReadInt32("ItemID", indexes, i);
            for (int i = 0; i < 5; i++)
                packet.ReadUInt16("ItemCount", indexes, i);
            for (int i = 0; i < 5; i++)
                packet.ReadUInt16("CurrencyID", indexes, i);
            for (int i = 0; i < 5; i++)
                packet.ReadUInt32("CurrencyCount", indexes, i);
        }

        public static void ItemExtendedCostHandler341(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt16("RequiredArenaRating", indexes);
            packet.ReadSByte("ArenaBracket", indexes);
            packet.ReadByte("Flags", indexes);
            packet.ReadByte("MinFactionID", indexes);
            packet.ReadInt32("MinReputation", indexes);
            packet.ReadByte("RequiredAchievement", indexes);
            for (int i = 0; i < 5; i++)
                packet.ReadInt32("ItemID", indexes, i);
            for (int i = 0; i < 5; i++)
                packet.ReadUInt16("ItemCount", indexes, i);
            for (int i = 0; i < 5; i++)
                packet.ReadUInt16("CurrencyID", indexes, i);
            for (int i = 0; i < 5; i++)
                packet.ReadUInt32("CurrencyCount", indexes, i);
        }

        public static void ItemLevelSelectorHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt16("MinItemLevel", indexes);
            packet.ReadUInt16("ItemLevelSelectorQualitySetID", indexes);
        }

        public static void ItemLevelSelectorQualityHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("QualityItemBonusListID", indexes);
            packet.ReadSByte("Quality", indexes);
            packet.ReadInt32("ParentILSQualitySetID", indexes);
        }

        public static void ItemLevelSelectorQualitySetHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt16("IlvlRare", indexes);
            packet.ReadInt16("IlvlEpic", indexes);
        }

        public static void ItemLimitCategoryHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadByte("Quantity", indexes);
            packet.ReadByte("Flags", indexes);
        }

        public static void ItemLimitCategoryConditionHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadSByte("AddQuantity", indexes);
            packet.ReadUInt32("PlayerConditionID", indexes);
            packet.ReadInt32("ParentItemLimitCategoryID", indexes);
        }

        public static void ItemModifiedAppearanceHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("ItemID", indexes);
            packet.ReadInt32("ItemAppearanceModifierID", indexes);
            packet.ReadInt32("ItemAppearanceID", indexes);
            packet.ReadInt32("OrderIndex", indexes);
            packet.ReadSByte("TransmogSourceTypeEnum", indexes);
        }

        public static void ItemModifiedAppearanceExtraHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("IconFileDataID", indexes);
            packet.ReadInt32("UnequippedIconFileDataID", indexes);
            packet.ReadByte("SheatheType", indexes);
            packet.ReadSByte("DisplayWeaponSubclassID", indexes);
            packet.ReadSByte("DisplayInventoryType", indexes);
        }

        public static void ItemNameDescriptionHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Description", indexes);
            packet.ReadInt32("Color", indexes);
        }

        public static void ItemPriceBaseHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt16("ItemLevel", indexes);
            packet.ReadSingle("Armor", indexes);
            packet.ReadSingle("Weapon", indexes);
        }

        public static void ItemRandomPropertiesHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            for (int i = 0; i < 5; i++)
                packet.ReadUInt16("Enchantment", indexes, i);
        }

        public static void ItemRandomSuffixHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            for (int i = 0; i < 5; i++)
                packet.ReadUInt16("Enchantment", indexes, i);
            for (int i = 0; i < 5; i++)
                packet.ReadUInt16("AllocationPct", indexes, i);
        }

        public static void ItemSearchNameHandler342(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt64("AllowableRace", indexes);
            packet.ReadCString("Display", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadByte("OverallQualityID", indexes);
            packet.ReadSByte("ExpansionID", indexes);
            packet.ReadUInt16("MinFactionID", indexes);
            packet.ReadInt32("MinReputation", indexes);
            packet.ReadInt32("AllowableClass", indexes);
            packet.ReadSByte("RequiredLevel", indexes);
            packet.ReadUInt16("RequiredSkill", indexes);
            packet.ReadUInt16("RequiredSkillRank", indexes);
            packet.ReadUInt32("RequiredAbility", indexes);
            packet.ReadUInt16("ItemLevel", indexes);
            for (int i = 0; i < 4; i++)
                packet.ReadInt32("Flags", indexes, i);
        }

        public static void ItemSetHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadUInt32("SetFlags", indexes);
            packet.ReadUInt32("RequiredSkill", indexes);
            packet.ReadUInt16("RequiredSkillRank", indexes);
            for (int i = 0; i < 17; i++)
                packet.ReadUInt32("ItemID", indexes, i);
        }

        public static void ItemSetSpellHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt16("ChrSpecID", indexes);
            packet.ReadUInt32("SpellID", indexes);
            packet.ReadByte("Threshold", indexes);
            packet.ReadInt32("ItemSetID", indexes);
        }

        public static void ItemSparseHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt64("AllowableRace", indexes);
            packet.ReadCString("Description", indexes);
            packet.ReadCString("Display3", indexes);
            packet.ReadCString("Display2", indexes);
            packet.ReadCString("Display1", indexes);
            packet.ReadCString("Display", indexes);
            packet.ReadSingle("DmgVariance", indexes);
            packet.ReadUInt32("DurationInInventory", indexes);
            packet.ReadSingle("QualityModifier", indexes);
            packet.ReadUInt32("BagFamily", indexes);
            packet.ReadInt32("StartQuestID", indexes);
            packet.ReadSingle("ItemRange", indexes);
            for (int i = 0; i < 10; i++)
                packet.ReadSingle("StatPercentageOfSocket", indexes, i);
            for (int i = 0; i < 10; i++)
                packet.ReadInt32("StatPercentEditor", indexes, i);
            packet.ReadInt32("Stackable", indexes);
            packet.ReadInt32("MaxCount", indexes);
            packet.ReadUInt32("RequiredAbility", indexes);
            packet.ReadUInt32("SellPrice", indexes);
            packet.ReadUInt32("BuyPrice", indexes);
            packet.ReadUInt32("VendorStackCount", indexes);
            packet.ReadSingle("PriceVariance", indexes);
            packet.ReadSingle("PriceRandomValue", indexes);
            for (int i = 0; i < 4; i++)
                packet.ReadInt32("Flags", indexes, i);
            packet.ReadInt32("FactionRelated", indexes);
            packet.ReadInt32("ModifiedCraftingReagentItemID", indexes);
            packet.ReadInt32("ContentTuningID", indexes);
            packet.ReadInt32("PlayerLevelToItemLevelCurveID", indexes);
            packet.ReadUInt32("MaxDurability", indexes);
            packet.ReadUInt16("ItemNameDescriptionID", indexes);
            packet.ReadUInt16("RequiredTransmogHoliday", indexes);
            packet.ReadUInt16("RequiredHoliday", indexes);
            packet.ReadUInt16("LimitCategory", indexes);
            packet.ReadUInt16("GemProperties", indexes);
            packet.ReadUInt16("SocketMatchEnchantmentID", indexes);
            packet.ReadUInt16("TotemCategoryID", indexes);
            packet.ReadUInt16("InstanceBound", indexes);
            for (int i = 0; i < 2; i++)
                packet.ReadUInt16("ZoneBound", indexes, i);
            packet.ReadUInt16("ItemSet", indexes);
            packet.ReadUInt16("LockID", indexes);
            packet.ReadUInt16("PageID", indexes);
            packet.ReadUInt16("ItemDelay", indexes);
            packet.ReadUInt16("MinFactionID", indexes);
            packet.ReadUInt16("RequiredSkillRank", indexes);
            packet.ReadUInt16("RequiredSkill", indexes);
            packet.ReadUInt16("ItemLevel", indexes);
            packet.ReadInt16("AllowableClass", indexes);
            packet.ReadUInt16("ItemRandomSuffixGroupID", indexes);
            packet.ReadUInt16("RandomSelect", indexes);
            for (int i = 0; i < 5; i++)
                packet.ReadUInt16("MinDamage", indexes, i);
            for (int i = 0; i < 5; i++)
                packet.ReadUInt16("MaxDamage", indexes, i);
            for (int i = 0; i < 7; i++)
                packet.ReadInt16("Resistances", indexes, i);
            packet.ReadUInt16("ScalingStatDistributionID", indexes);
            for (int i = 0; i < 10; i++)
                packet.ReadInt16("StatModifierBonusAmount", indexes, i);
            packet.ReadByte("ExpansionID", indexes);
            packet.ReadByte("ArtifactID", indexes);
            packet.ReadByte("SpellWeight", indexes);
            packet.ReadByte("SpellWeightCategory", indexes);
            for (int i = 0; i < 3; i++)
                packet.ReadByte("SocketType", indexes, i);
            packet.ReadByte("SheatheType", indexes);
            packet.ReadByte("Material", indexes);
            packet.ReadByte("PageMaterialID", indexes);
            packet.ReadByte("LanguageID", indexes);
            packet.ReadByte("Bonding", indexes);
            packet.ReadByte("DamageDamageType", indexes);
            for (int i = 0; i < 10; i++)
                packet.ReadSByte("StatModifierBonusStat", indexes, i);
            packet.ReadByte("ContainerSlots", indexes);
            packet.ReadByte("MinReputation", indexes);
            packet.ReadByte("RequiredPVPMedal", indexes);
            packet.ReadByte("RequiredPVPRank", indexes);
            packet.ReadSByte("InventoryType", indexes);
            packet.ReadSByte("OverallQualityID", indexes);
            packet.ReadByte("AmmunitionType", indexes);
            packet.ReadSByte("RequiredLevel", indexes);
        }

        public static void ItemSparseHandler341(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt64("AllowableRace", indexes);
            packet.ReadCString("Description", indexes);
            packet.ReadCString("Display3", indexes);
            packet.ReadCString("Display2", indexes);
            packet.ReadCString("Display1", indexes);
            packet.ReadCString("Display", indexes);
            packet.ReadSingle("DmgVariance", indexes);
            packet.ReadUInt32("DurationInInventory", indexes);
            packet.ReadSingle("QualityModifier", indexes);
            packet.ReadUInt32("BagFamily", indexes);
            packet.ReadInt32("StartQuestID", indexes);
            packet.ReadSingle("ItemRange", indexes);
            for (int i = 0; i < 10; i++)
                packet.ReadSingle("StatPercentageOfSocket", indexes, i);
            for (int i = 0; i < 10; i++)
                packet.ReadInt32("StatPercentEditor", indexes, i);
            packet.ReadInt32("Stackable", indexes);
            packet.ReadInt32("MaxCount", indexes);
            packet.ReadInt32("MinReputation", indexes);
            packet.ReadUInt32("RequiredAbility", indexes);
            packet.ReadUInt32("SellPrice", indexes);
            packet.ReadUInt32("BuyPrice", indexes);
            packet.ReadUInt32("VendorStackCount", indexes);
            packet.ReadSingle("PriceVariance", indexes);
            packet.ReadSingle("PriceRandomValue", indexes);
            for (int i = 0; i < 4; i++)
                packet.ReadInt32("Flags", indexes, i);
            packet.ReadInt32("FactionRelated", indexes);
            packet.ReadInt32("ModifiedCraftingReagentItemID", indexes);
            packet.ReadInt32("ContentTuningID", indexes);
            packet.ReadInt32("PlayerLevelToItemLevelCurveID", indexes);
            packet.ReadUInt32("MaxDurability", indexes);
            packet.ReadUInt16("ItemNameDescriptionID", indexes);
            packet.ReadUInt16("RequiredTransmogHoliday", indexes);
            packet.ReadUInt16("RequiredHoliday", indexes);
            packet.ReadUInt16("LimitCategory", indexes);
            packet.ReadUInt16("GemProperties", indexes);
            packet.ReadUInt16("SocketMatchEnchantmentID", indexes);
            packet.ReadUInt16("TotemCategoryID", indexes);
            packet.ReadUInt16("InstanceBound", indexes);
            for (int i = 0; i < 2; i++)
                packet.ReadUInt16("ZoneBound", indexes, i);
            packet.ReadUInt16("ItemSet", indexes);
            packet.ReadUInt16("LockID", indexes);
            packet.ReadUInt16("PageID", indexes);
            packet.ReadUInt16("ItemDelay", indexes);
            packet.ReadUInt16("MinFactionID", indexes);
            packet.ReadUInt16("RequiredSkillRank", indexes);
            packet.ReadUInt16("RequiredSkill", indexes);
            packet.ReadUInt16("ItemLevel", indexes);
            packet.ReadInt16("AllowableClass", indexes);
            packet.ReadUInt16("ItemRandomSuffixGroupID", indexes);
            packet.ReadUInt16("RandomSelect", indexes);
            for (int i = 0; i < 5; i++)
                packet.ReadUInt16("MinDamage", indexes, i);
            for (int i = 0; i < 5; i++)
                packet.ReadUInt16("MaxDamage", indexes, i);
            for (int i = 0; i < 7; i++)
                packet.ReadInt16("Resistances", indexes, i);
            packet.ReadUInt16("ScalingStatDistributionID", indexes);
            for (int i = 0; i < 10; i++)
                packet.ReadInt16("StatModifierBonusAmount", indexes, i);
            packet.ReadByte("ExpansionID", indexes);
            packet.ReadByte("ArtifactID", indexes);
            packet.ReadByte("SpellWeight", indexes);
            packet.ReadByte("SpellWeightCategory", indexes);
            for (int i = 0; i < 3; i++)
                packet.ReadByte("SocketType", indexes, i);
            packet.ReadByte("SheatheType", indexes);
            packet.ReadByte("Material", indexes);
            packet.ReadByte("PageMaterialID", indexes);
            packet.ReadByte("LanguageID", indexes);
            packet.ReadByte("Bonding", indexes);
            packet.ReadByte("DamageDamageType", indexes);
            for (int i = 0; i < 10; i++)
                packet.ReadSByte("StatModifierBonusStat", indexes, i);
            packet.ReadByte("ContainerSlots", indexes);
            packet.ReadByte("RequiredPVPMedal", indexes);
            packet.ReadByte("RequiredPVPRank", indexes);
            packet.ReadSByte("InventoryType", indexes);
            packet.ReadSByte("OverallQualityID", indexes);
            packet.ReadByte("AmmunitionType", indexes);
            packet.ReadSByte("RequiredLevel", indexes);
        }

        public static void ItemSpecHandler340(Packet packet, uint entry, params object[] indexes)
        {;
            packet.ReadByte("MinLevel", indexes);
            packet.ReadByte("MaxLevel", indexes);
            packet.ReadByte("ItemType", indexes);
            packet.ReadByte("PrimaryStat", indexes);
            packet.ReadByte("SecondaryStat", indexes);
            packet.ReadUInt16("SpecializationID", indexes);
        }

        public static void ItemSpecOverrideHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt16("SpecID", indexes);
            packet.ReadInt32("ItemID", indexes);
        }

        public static void ItemXBonusTreeHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt16("ItemBonusTreeID", indexes);
            packet.ReadInt32("ItemID", indexes);
        }

        public static void JournalEncounterHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadCString("Description", indexes);
            packet.ReadSingle("MapX", indexes);
            packet.ReadSingle("MapY", indexes);
            packet.ReadUInt16("JournalInstanceID", indexes);
            packet.ReadUInt32("OrderIndex", indexes);
            packet.ReadUInt16("FirstSectionID", indexes);
            packet.ReadUInt16("UiMapID", indexes);
            packet.ReadUInt32("MapDisplayConditionID", indexes);
            packet.ReadInt32("Flags", indexes);
            packet.ReadSByte("DifficultyMask", indexes);
        }

        public static void JournalEncounterSectionHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Title", indexes);
            packet.ReadCString("BodyText", indexes);
            packet.ReadUInt16("JournalEncounterID", indexes);
            packet.ReadByte("OrderIndex", indexes);
            packet.ReadUInt16("ParentSectionID", indexes);
            packet.ReadUInt16("FirstChildSectionID", indexes);
            packet.ReadUInt16("NextSiblingSectionID", indexes);
            packet.ReadByte("Type", indexes);
            packet.ReadUInt32("IconCreatureDisplayInfoID", indexes);
            packet.ReadInt32("UiModelSceneID", indexes);
            packet.ReadInt32("SpellID", indexes);
            packet.ReadInt32("IconFileDataID", indexes);
            packet.ReadInt32("Flags", indexes);
            packet.ReadInt32("IconFlags", indexes);
            packet.ReadSByte("DifficultyMask", indexes);
        }

        public static void JournalInstanceHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadCString("Description", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadUInt16("MapID", indexes);
            packet.ReadInt32("BackgroundFileDataID", indexes);
            packet.ReadInt32("ButtonFileDataID", indexes);
            packet.ReadInt32("ButtonSmallFileDataID", indexes);
            packet.ReadInt32("LoreFileDataID", indexes);
            packet.ReadByte("OrderIndex", indexes);
            packet.ReadInt32("Flags", indexes);
            packet.ReadUInt16("AreaID", indexes);
        }

        public static void JournalInstanceHandler341(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadCString("Description", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadUInt16("MapID", indexes);
            packet.ReadInt32("BackgroundFileDataID", indexes);
            packet.ReadInt32("ButtonFileDataID", indexes);
            packet.ReadInt32("ButtonSmallFileDataID", indexes);
            packet.ReadInt32("LoreFileDataID", indexes);
            packet.ReadInt32("Flags", indexes);
            packet.ReadUInt16("AreaID", indexes);
        }

        public static void JournalTierHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
        }

        public static void KeychainHandler340(Packet packet, uint entry, params object[] indexes)
        {
            for (int i = 0; i < 32; i++)
                packet.ReadByte("Key", indexes, i);
        }

        public static void KeystoneAffixHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadCString("Description", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("FiledataID", indexes);
        }

        public static void LanguageWordsHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Word", indexes);
            packet.ReadByte("LanguageID", indexes);
        }

        public static void LanguagesHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("Flags", indexes);
            packet.ReadInt32("UiTextureKitID", indexes);
            packet.ReadInt32("UiTextureKitElementCount", indexes);
        }

        public static void LanguagesHandler342(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("Flags", indexes);
            packet.ReadInt32("UiTextureKitID", indexes);
            packet.ReadInt32("UiTextureKitElementCount", indexes);
            packet.ReadInt32("LearningCurveID", indexes);
        }

        public static void LfgDungeonsHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadCString("Description", indexes);
            packet.ReadByte("MinLevel", indexes);
            packet.ReadUInt16("MaxLevel", indexes);
            packet.ReadByte("TypeID", indexes);
            packet.ReadByte("Subtype", indexes);
            packet.ReadSByte("Faction", indexes);
            packet.ReadInt32("IconTextureFileID", indexes);
            packet.ReadInt32("RewardsBgTextureFileID", indexes);
            packet.ReadInt32("PopupBgTextureFileID", indexes);
            packet.ReadByte("ExpansionLevel", indexes);
            packet.ReadInt16("MapID", indexes);
            packet.ReadByte("DifficultyID", indexes);
            packet.ReadSingle("MinGear", indexes);
            packet.ReadByte("GroupID", indexes);
            packet.ReadByte("OrderIndex", indexes);
            packet.ReadUInt32("RequiredPlayerConditionID", indexes);
            packet.ReadByte("TargetLevel", indexes);
            packet.ReadByte("TargetLevelMin", indexes);
            packet.ReadUInt16("TargetLevelMax", indexes);
            packet.ReadUInt16("RandomID", indexes);
            packet.ReadUInt16("ScenarioID", indexes);
            packet.ReadUInt16("FinalEncounterID", indexes);
            packet.ReadByte("CountTank", indexes);
            packet.ReadByte("CountHealer", indexes);
            packet.ReadByte("CountDamage", indexes);
            packet.ReadByte("MinCountTank", indexes);
            packet.ReadByte("MinCountHealer", indexes);
            packet.ReadByte("MinCountDamage", indexes);
            packet.ReadUInt16("BonusReputationAmount", indexes);
            packet.ReadUInt16("MentorItemLevel", indexes);
            packet.ReadByte("MentorCharLevel", indexes);
            for (int i = 0; i < 2; i++)
                packet.ReadInt32("Flags", indexes, i);
        }

        public static void LfgDungeonsHandler341(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadCString("Description", indexes);
            packet.ReadByte("MinLevel", indexes);
            packet.ReadUInt16("MaxLevel", indexes);
            packet.ReadByte("TypeID", indexes);
            packet.ReadByte("Subtype", indexes);
            packet.ReadSByte("Faction", indexes);
            packet.ReadInt32("IconTextureFileID", indexes);
            packet.ReadInt32("RewardsBgTextureFileID", indexes);
            packet.ReadInt32("PopupBgTextureFileID", indexes);
            packet.ReadByte("ExpansionLevel", indexes);
            packet.ReadInt16("MapID", indexes);
            packet.ReadByte("DifficultyID", indexes);
            packet.ReadSingle("MinGear", indexes);
            packet.ReadByte("GroupID", indexes);
            packet.ReadByte("OrderIndex", indexes);
            packet.ReadUInt32("RequiredPlayerConditionID", indexes);
            packet.ReadByte("TargetLevel", indexes);
            packet.ReadByte("TargetLevelMin", indexes);
            packet.ReadUInt16("TargetLevelMax", indexes);
            packet.ReadUInt16("RandomID", indexes);
            packet.ReadUInt16("ScenarioID", indexes);
            packet.ReadUInt16("FinalEncounterID", indexes);
            packet.ReadByte("CountTank", indexes);
            packet.ReadByte("CountHealer", indexes);
            packet.ReadByte("CountDamage", indexes);
            packet.ReadByte("MinCountTank", indexes);
            packet.ReadByte("MinCountHealer", indexes);
            packet.ReadByte("MinCountDamage", indexes);
            packet.ReadUInt16("BonusReputationAmount", indexes);
            packet.ReadUInt16("MentorItemLevel", indexes);
            packet.ReadByte("MentorCharLevel", indexes);
            for (int i = 0; i < 2; i++)
                packet.ReadInt32("Flags", indexes, i);
        }

        public static void LightHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadSingle("GameCoordsX", indexes);
            packet.ReadSingle("GameCoordsY", indexes);
            packet.ReadSingle("GameCoordsZ", indexes);
            packet.ReadSingle("GameFalloffStart", indexes);
            packet.ReadSingle("GameFalloffEnd", indexes);
            packet.ReadInt16("ContinentID", indexes);
            for (int i = 0; i < 8; i++)
                packet.ReadUInt16("LightParamsID", indexes, i);
        }

        public static void LiquidTypeHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            for (int i = 0; i < 6; i++)
                packet.ReadCString("Texture", indexes, i);
            packet.ReadUInt16("Flags", indexes);
            packet.ReadByte("SoundBank", indexes);
            packet.ReadUInt32("SoundID", indexes);
            packet.ReadUInt32("SpellID", indexes);
            packet.ReadSingle("MaxDarkenDepth", indexes);
            packet.ReadSingle("FogDarkenIntensity", indexes);
            packet.ReadSingle("AmbDarkenIntensity", indexes);
            packet.ReadSingle("DirDarkenIntensity", indexes);
            packet.ReadUInt16("LightID", indexes);
            packet.ReadSingle("ParticleScale", indexes);
            packet.ReadByte("ParticleMovement", indexes);
            packet.ReadByte("ParticleTexSlots", indexes);
            packet.ReadByte("MaterialID", indexes);
            packet.ReadInt32("MinimapStaticCol", indexes);
            for (int i = 0; i < 6; i++)
                packet.ReadByte("FrameCountTexture", indexes, i);
            for (int i = 0; i < 2; i++)
                packet.ReadInt32("Color", indexes, i);
            for (int i = 0; i < 18; i++)
                packet.ReadSingle("Float", indexes, i);
            for (int i = 0; i < 4; i++)
                packet.ReadUInt32("Int", indexes, i);
            for (int i = 0; i < 4; i++)
                packet.ReadSingle("Coefficient", indexes, i);
        }

        public static void LockHandler340(Packet packet, uint entry, params object[] indexes)
        {
            for (int i = 0; i < 8; i++)
                packet.ReadInt32("Index", indexes, i);
            for (int i = 0; i < 8; i++)
                packet.ReadUInt16("Skill", indexes, i);
            for (int i = 0; i < 8; i++)
                packet.ReadByte("Type", indexes, i);
            for (int i = 0; i < 8; i++)
                packet.ReadByte("Action", indexes, i);
        }

        public static void MailTemplateHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Body", indexes);
        }

        public static void MapHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Directory", indexes);
            packet.ReadCString("MapName", indexes);
            packet.ReadCString("MapDescription0", indexes);
            packet.ReadCString("MapDescription1", indexes);
            packet.ReadCString("PvpShortDescription", indexes);
            packet.ReadCString("PvpLongDescription", indexes);
            packet.ReadByte("MapType", indexes);
            packet.ReadSByte("InstanceType", indexes);
            packet.ReadByte("ExpansionID", indexes);
            packet.ReadUInt16("AreaTableID", indexes);
            packet.ReadInt16("LoadingScreenID", indexes);
            packet.ReadInt16("TimeOfDayOverride", indexes);
            packet.ReadInt16("ParentMapID", indexes);
            packet.ReadInt16("CosmeticParentMapID", indexes);
            packet.ReadByte("TimeOffset", indexes);
            packet.ReadSingle("MinimapIconScale", indexes);
            packet.ReadInt32("RaidOffset", indexes);
            packet.ReadInt16("CorpseMapID", indexes);
            packet.ReadByte("MaxPlayers", indexes);
            packet.ReadInt16("WindSettingsID", indexes);
            packet.ReadInt32("ZmpFileDataID", indexes);
            for (int i = 0; i < 3; i++)
                packet.ReadInt32("Flags", indexes, i);
        }

        public static void MapChallengeModeHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadUInt16("MapID", indexes);
            packet.ReadByte("Flags", indexes);
            packet.ReadUInt32("ExpansionLevel", indexes);
            packet.ReadInt32("RequiredWorldStateID", indexes);
            for (int i = 0; i < 3; i++)
                packet.ReadInt16("CriteriaCount", indexes, i);
        }

        public static void MapDifficultyHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Message", indexes);
            packet.ReadUInt32("ItemContextPickerID", indexes);
            packet.ReadInt32("ContentTuningID", indexes);
            packet.ReadByte("DifficultyID", indexes);
            packet.ReadByte("LockID", indexes);
            packet.ReadByte("ResetInterval", indexes);
            packet.ReadByte("MaxPlayers", indexes);
            packet.ReadByte("ItemContext", indexes);
            packet.ReadByte("Flags", indexes);
            packet.ReadInt32("MapID", indexes);
        }

        public static void MapDifficultyXConditionHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("FailureDescription", indexes);
            packet.ReadUInt32("PlayerConditionID", indexes);
            packet.ReadInt32("OrderIndex", indexes);
            packet.ReadInt32("MapDifficultyID", indexes);
        }

        public static void ModifierTreeHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("Parent", indexes);
            packet.ReadSByte("Operator", indexes);
            packet.ReadSByte("Amount", indexes);
            packet.ReadInt32("Type", indexes);
            packet.ReadInt32("Asset", indexes);
            packet.ReadInt32("SecondaryAsset", indexes);
            packet.ReadSByte("TertiaryAsset", indexes);
        }

        public static void ModifierTreeHandler343(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("Parent", indexes);
            packet.ReadSByte("Operator", indexes);
            packet.ReadSByte("Amount", indexes);
            packet.ReadInt32("Type", indexes);
            packet.ReadInt32("Asset", indexes);
            packet.ReadInt32("SecondaryAsset", indexes);
            packet.ReadSByte("TertiaryAsset", indexes);
        }

        public static void MountHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadCString("SourceText", indexes);
            packet.ReadCString("Description", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadUInt16("MountTypeID", indexes);
            packet.ReadUInt16("Flags", indexes);
            packet.ReadSByte("SourceTypeEnum", indexes);
            packet.ReadInt32("SourceSpellID", indexes);
            packet.ReadUInt32("PlayerConditionID", indexes);
            packet.ReadSingle("MountFlyRideHeight", indexes);
            packet.ReadInt32("UiModelSceneID", indexes);
        }

        public static void MountCapabilityHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ID", indexes);
            packet.ReadByte("Flags", indexes);
            packet.ReadUInt16("ReqRidingSkill", indexes);
            packet.ReadUInt16("ReqAreaID", indexes);
            packet.ReadUInt32("ReqSpellAuraID", indexes);
            packet.ReadInt32("ReqSpellKnownID", indexes);
            packet.ReadInt32("ModSpellAuraID", indexes);
            packet.ReadInt16("ReqMapID", indexes);
        }

        public static void MountTypeXCapabilityHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt16("MountTypeID", indexes);
            packet.ReadUInt16("MountCapabilityID", indexes);
            packet.ReadByte("OrderIndex", indexes);
        }

        public static void MountXDisplayHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("CreatureDisplayInfoID", indexes);
            packet.ReadUInt32("PlayerConditionID", indexes);
            packet.ReadInt32("MountID", indexes);
        }

        public static void MovieHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadByte("Volume", indexes);
            packet.ReadByte("KeyID", indexes);
            packet.ReadUInt32("AudioFileDataID", indexes);
            packet.ReadUInt32("SubtitleFileDataID", indexes);
        }

        public static void MythicPlusSeasonHandler342(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("MilestoneSeason", indexes);
            packet.ReadInt32("ExpansionLevel", indexes);
            packet.ReadInt32("HeroicLFGDungeonMinGear", indexes);
        }

        public static void NameGenHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadByte("RaceID", indexes);
            packet.ReadByte("Sex", indexes);
        }

        public static void NamesProfanityHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadSByte("Language", indexes);
        }

        public static void NamesReservedHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
        }

        public static void NamesReservedLocaleHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadByte("LocaleMask", indexes);
        }

        public static void NumTalentsAtLevelHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("NumTalents", indexes);
            packet.ReadInt32("NumTalentsDeathKnight", indexes);
            packet.ReadInt32("NumTalentsDemonHunter", indexes);
        }

        public static void OverrideSpellDataHandler340(Packet packet, uint entry, params object[] indexes)
        {
            for (int i = 0; i < 10; i++)
                packet.ReadInt32("Spells", indexes, i);
            packet.ReadInt32("PlayerActionbarFileDataID", indexes);
            packet.ReadByte("Flags", indexes);
        }

        public static void ParagonReputationHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("FactionID", indexes);
            packet.ReadInt32("LevelThreshold", indexes);
            packet.ReadInt32("QuestID", indexes);
        }

        public static void PhaseHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt16("Flags", indexes);
        }

        public static void PhaseXPhaseGroupHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt16("PhaseID", indexes);
            packet.ReadInt32("PhaseGroupID", indexes);
        }

        public static void PlayerConditionHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt64("RaceMask", indexes);
            packet.ReadCString("FailureDescription", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadUInt16("MinLevel", indexes);
            packet.ReadUInt16("MaxLevel", indexes);
            packet.ReadInt32("ClassMask", indexes);
            packet.ReadUInt32("SkillLogic", indexes);
            packet.ReadByte("LanguageID", indexes);
            packet.ReadByte("MinLanguage", indexes);
            packet.ReadInt32("MaxLanguage", indexes);
            packet.ReadUInt16("MaxFactionID", indexes);
            packet.ReadByte("MaxReputation", indexes);
            packet.ReadUInt32("ReputationLogic", indexes);
            packet.ReadSByte("CurrentPvpFaction", indexes);
            packet.ReadByte("PvpMedal", indexes);
            packet.ReadUInt32("PrevQuestLogic", indexes);
            packet.ReadUInt32("CurrQuestLogic", indexes);
            packet.ReadUInt32("CurrentCompletedQuestLogic", indexes);
            packet.ReadUInt32("SpellLogic", indexes);
            packet.ReadUInt32("ItemLogic", indexes);
            packet.ReadByte("ItemFlags", indexes);
            packet.ReadUInt32("AuraSpellLogic", indexes);
            packet.ReadUInt16("WorldStateExpressionID", indexes);
            packet.ReadByte("WeatherID", indexes);
            packet.ReadByte("PartyStatus", indexes);
            packet.ReadByte("LifetimeMaxPVPRank", indexes);
            packet.ReadUInt32("AchievementLogic", indexes);
            packet.ReadSByte("Gender", indexes);
            packet.ReadSByte("NativeGender", indexes);
            packet.ReadUInt32("AreaLogic", indexes);
            packet.ReadUInt32("LfgLogic", indexes);
            packet.ReadUInt32("CurrencyLogic", indexes);
            packet.ReadUInt32("QuestKillID", indexes);
            packet.ReadUInt32("QuestKillLogic", indexes);
            packet.ReadSByte("MinExpansionLevel", indexes);
            packet.ReadSByte("MaxExpansionLevel", indexes);
            packet.ReadInt32("MinAvgItemLevel", indexes);
            packet.ReadInt32("MaxAvgItemLevel", indexes);
            packet.ReadUInt16("MinAvgEquippedItemLevel", indexes);
            packet.ReadUInt16("MaxAvgEquippedItemLevel", indexes);
            packet.ReadByte("PhaseUseFlags", indexes);
            packet.ReadUInt16("PhaseID", indexes);
            packet.ReadUInt32("PhaseGroupID", indexes);
            packet.ReadByte("Flags", indexes);
            packet.ReadSByte("ChrSpecializationIndex", indexes);
            packet.ReadSByte("ChrSpecializationRole", indexes);
            packet.ReadUInt32("ModifierTreeID", indexes);
            packet.ReadSByte("PowerType", indexes);
            packet.ReadByte("PowerTypeComp", indexes);
            packet.ReadByte("PowerTypeValue", indexes);
            packet.ReadInt32("WeaponSubclassMask", indexes);
            packet.ReadByte("MaxGuildLevel", indexes);
            packet.ReadByte("MinGuildLevel", indexes);
            packet.ReadSByte("MaxExpansionTier", indexes);
            packet.ReadSByte("MinExpansionTier", indexes);
            packet.ReadByte("MinPVPRank", indexes);
            packet.ReadByte("MaxPVPRank", indexes);
            for (int i = 0; i < 4; i++)
                packet.ReadUInt16("SkillID", indexes, i);
            for (int i = 0; i < 4; i++)
                packet.ReadUInt16("MinSkill", indexes, i);
            for (int i = 0; i < 4; i++)
                packet.ReadUInt16("MaxSkill", indexes, i);
            for (int i = 0; i < 3; i++)
                packet.ReadUInt32("MinFactionID", indexes, i);
            for (int i = 0; i < 3; i++)
                packet.ReadByte("MinReputation", indexes, i);
            for (int i = 0; i < 4; i++)
                packet.ReadUInt32("PrevQuestID", indexes, i);
            for (int i = 0; i < 4; i++)
                packet.ReadUInt32("CurrQuestID", indexes, i);
            for (int i = 0; i < 4; i++)
                packet.ReadUInt32("CurrentCompletedQuestID", indexes, i);
            for (int i = 0; i < 4; i++)
                packet.ReadInt32("SpellID", indexes, i);
            for (int i = 0; i < 4; i++)
                packet.ReadInt32("ItemID", indexes, i);
            for (int i = 0; i < 4; i++)
                packet.ReadUInt32("ItemCount", indexes, i);
            for (int i = 0; i < 2; i++)
                packet.ReadUInt16("Explored", indexes, i);
            for (int i = 0; i < 2; i++)
                packet.ReadUInt32("Time", indexes, i);
            for (int i = 0; i < 4; i++)
                packet.ReadInt32("AuraSpellID", indexes, i);
            for (int i = 0; i < 4; i++)
                packet.ReadByte("AuraStacks", indexes, i);
            for (int i = 0; i < 4; i++)
                packet.ReadUInt16("Achievement", indexes, i);
            for (int i = 0; i < 4; i++)
                packet.ReadUInt16("AreaID", indexes, i);
            for (int i = 0; i < 4; i++)
                packet.ReadByte("LfgStatus", indexes, i);
            for (int i = 0; i < 4; i++)
                packet.ReadByte("LfgCompare", indexes, i);
            for (int i = 0; i < 4; i++)
                packet.ReadUInt32("LfgValue", indexes, i);
            for (int i = 0; i < 4; i++)
                packet.ReadUInt32("CurrencyID", indexes, i);
            for (int i = 0; i < 4; i++)
                packet.ReadUInt32("CurrencyCount", indexes, i);
            for (int i = 0; i < 6; i++)
                packet.ReadUInt32("QuestKillMonster", indexes, i);
            for (int i = 0; i < 2; i++)
                packet.ReadInt32("MovementFlags", indexes, i);
        }

        public static void PowerDisplayHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("GlobalStringBaseTag", indexes);
            packet.ReadByte("ActualType", indexes);
            packet.ReadByte("Red", indexes);
            packet.ReadByte("Green", indexes);
            packet.ReadByte("Blue", indexes);
        }

        public static void PowerTypeHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("NameGlobalStringTag", indexes);
            packet.ReadCString("CostGlobalStringTag", indexes);
            packet.ReadSByte("PowerTypeEnum", indexes);
            packet.ReadSByte("MinPower", indexes);
            packet.ReadUInt32("MaxBasePower", indexes);
            packet.ReadSByte("CenterPower", indexes);
            packet.ReadSByte("DefaultPower", indexes);
            packet.ReadUInt16("DisplayModifier", indexes);
            packet.ReadInt16("RegenInterruptTimeMS", indexes);
            packet.ReadSingle("RegenPeace", indexes);
            packet.ReadSingle("RegenCombat", indexes);
            packet.ReadInt16("Flags", indexes);
        }

        public static void PowerTypeHandler341(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("NameGlobalStringTag", indexes);
            packet.ReadCString("CostGlobalStringTag", indexes);
            packet.ReadSByte("PowerTypeEnum", indexes);
            packet.ReadInt32("MinPower", indexes);
            packet.ReadInt32("MaxBasePower", indexes);
            packet.ReadInt32("CenterPower", indexes);
            packet.ReadInt32("DefaultPower", indexes);
            packet.ReadInt32("DisplayModifier", indexes);
            packet.ReadInt32("RegenInterruptTimeMS", indexes);
            packet.ReadSingle("RegenPeace", indexes);
            packet.ReadSingle("RegenCombat", indexes);
            packet.ReadInt16("Flags", indexes);
        }

        public static void PrestigeLevelInfoHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadInt32("PrestigeLevel", indexes);
            packet.ReadInt32("BadgeTextureFileDataID", indexes);
            packet.ReadByte("Flags", indexes);
            packet.ReadInt32("AwardedAchievementID", indexes);
        }

        public static void PvpDifficultyHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadByte("RangeIndex", indexes);
            packet.ReadByte("MinLevel", indexes);
            packet.ReadByte("MaxLevel", indexes);
            packet.ReadInt32("MapID", indexes);
        }

        public static void PvpItemHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("ItemID", indexes);
            packet.ReadByte("ItemLevelDelta", indexes);
        }

        public static void PvpSeasonHandler342(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("MilestoneSeason", indexes);
            packet.ReadInt32("AllianceAchievementID", indexes);
            packet.ReadInt32("HordeAchievementID", indexes);
        }

        public static void PvpTalentHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Description", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("SpecID", indexes);
            packet.ReadInt32("SpellID", indexes);
            packet.ReadInt32("OverridesSpellID", indexes);
            packet.ReadInt32("Flags", indexes);
            packet.ReadInt32("ActionBarSpellID", indexes);
            packet.ReadInt32("PvpTalentCategoryID", indexes);
            packet.ReadInt32("LevelRequired", indexes);
        }

        public static void PvpTalentCategoryHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadByte("TalentSlotMask", indexes);
        }

        public static void PvpTalentSlotUnlockHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadSByte("Slot", indexes);
            packet.ReadInt32("LevelRequired", indexes);
            packet.ReadInt32("DeathKnightLevelRequired", indexes);
            packet.ReadInt32("DemonHunterLevelRequired", indexes);
        }

        public static void PvpTierHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadInt16("MinRating", indexes);
            packet.ReadInt16("MaxRating", indexes);
            packet.ReadInt32("PrevTier", indexes);
            packet.ReadInt32("NextTier", indexes);
            packet.ReadSByte("BracketID", indexes);
            packet.ReadSByte("Rank", indexes);
            packet.ReadInt32("RankIconFileDataID", indexes);
        }

        public static void QuestFactionRewardHandler340(Packet packet, uint entry, params object[] indexes)
        {
            for (int i = 0; i < 10; i++)
                packet.ReadInt16("Difficulty", indexes, i);
        }

        public static void QuestInfoHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("InfoName", indexes);
            packet.ReadSByte("Type", indexes);
            packet.ReadInt32("Modifiers", indexes);
            packet.ReadUInt16("Profession", indexes);
        }

        public static void QuestLineXQuestHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("QuestLineID", indexes);
            packet.ReadUInt32("QuestID", indexes);
            packet.ReadUInt32("OrderIndex", indexes);
        }

        public static void QuestMoneyRewardHandler340(Packet packet, uint entry, params object[] indexes)
        {
            for (int i = 0; i < 10; i++)
                packet.ReadUInt32("Difficulty", indexes, i);
        }

        public static void QuestPackageItemHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt16("PackageID", indexes);
            packet.ReadInt32("ItemID", indexes);
            packet.ReadUInt32("ItemQuantity", indexes);
            packet.ReadByte("DisplayType", indexes);
        }

        public static void QuestSortHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("SortName", indexes);
            packet.ReadSByte("UiOrderIndex", indexes);
        }

        public static void QuestV2Handler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt16("UniqueBitFlag", indexes);
        }

        public static void QuestXpHandler340(Packet packet, uint entry, params object[] indexes)
        {
            for (int i = 0; i < 10; i++)
                packet.ReadUInt16("Difficulty", indexes, i);
        }

        public static void RandPropPointsHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("DamageReplaceStat", indexes);
            for (int i = 0; i < 5; i++)
                packet.ReadUInt32("Epic", indexes, i);
            for (int i = 0; i < 5; i++)
                packet.ReadUInt32("Superior", indexes, i);
            for (int i = 0; i < 5; i++)
                packet.ReadUInt32("Good", indexes, i);
        }

        public static void RewardPackHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("CharTitleID", indexes);
            packet.ReadUInt32("Money", indexes);
            packet.ReadSByte("ArtifactXPDifficulty", indexes);
            packet.ReadSingle("ArtifactXPMultiplier", indexes);
            packet.ReadByte("ArtifactXPCategoryID", indexes);
            packet.ReadUInt32("TreasurePickerID", indexes);
        }

        public static void RewardPackXCurrencyTypeHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("CurrencyTypeID", indexes);
            packet.ReadInt32("Quantity", indexes);
            packet.ReadInt32("RewardPackID", indexes);
        }

        public static void RewardPackXItemHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("ItemID", indexes);
            packet.ReadInt32("ItemQuantity", indexes);
            packet.ReadInt32("RewardPackID", indexes);
        }

        public static void ScenarioHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadUInt16("AreaTableID", indexes);
            packet.ReadByte("Type", indexes);
            packet.ReadByte("Flags", indexes);
            packet.ReadUInt32("UiTextureKitID", indexes);
        }

        public static void ScenarioStepHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Description", indexes);
            packet.ReadCString("Title", indexes);
            packet.ReadUInt16("ScenarioID", indexes);
            packet.ReadUInt32("CriteriatreeID", indexes);
            packet.ReadUInt32("RewardQuestID", indexes);
            packet.ReadInt32("RelatedStep", indexes);
            packet.ReadUInt16("Supersedes", indexes);
            packet.ReadByte("OrderIndex", indexes);
            packet.ReadByte("Flags", indexes);
            packet.ReadUInt32("VisibilityPlayerConditionID", indexes);
            packet.ReadUInt16("WidgetSetID", indexes);
        }

        public static void ScalingStatDistributionHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt16("PlayerLevelToItemLevelCurveID", indexes);
            packet.ReadInt32("MinLevel", indexes);
            packet.ReadInt32("MaxLevel", indexes);
        }

        public static void ScalingStatDistributionHandler341(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt16("PlayerLevelToItemLevelCurveID", indexes);
            packet.ReadInt32("MinLevel", indexes);
            packet.ReadInt32("MaxLevel", indexes);
            for (int i = 0; i < 10; i++)
                packet.ReadInt32("Bonus", indexes, i);
            for (int i = 0; i < 10; i++)
                packet.ReadInt32("StatID", indexes, i);
        }

        public static void ScalingStatValuesHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("Charlevel", indexes);
            packet.ReadInt32("WeaponDPS1H", indexes);
            packet.ReadInt32("WeaponDPS2H", indexes);
            packet.ReadInt32("SpellcasterDPS1H", indexes);
            packet.ReadInt32("SpellcasterDPS2H", indexes);
            packet.ReadInt32("RangedDPS", indexes);
            packet.ReadInt32("WandDPS", indexes);
            packet.ReadInt32("SpellPower", indexes);
            packet.ReadInt32("ShoulderBudget", indexes);
            packet.ReadInt32("TrinketBudget", indexes);
            packet.ReadInt32("WeaponBudget1H", indexes);
            packet.ReadInt32("PrimaryBudget", indexes);
            packet.ReadInt32("RangedBudget", indexes);
            packet.ReadInt32("TertiaryBudget", indexes);
            packet.ReadInt32("ClothShoulderArmor", indexes);
            packet.ReadInt32("LeatherShoulderArmor", indexes);
            packet.ReadInt32("MailShoulderArmor", indexes);
            packet.ReadInt32("PlateShoulderArmor", indexes);
            packet.ReadInt32("ClothCloakArmor", indexes);
            packet.ReadInt32("ClothChestArmor", indexes);
            packet.ReadInt32("LeatherChestArmor", indexes);
            packet.ReadInt32("MailChestArmor", indexes);
            packet.ReadInt32("PlateChestArmor", indexes);
        }

        public static void SceneScriptHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt16("FirstSceneScriptID", indexes);
            packet.ReadUInt16("NextSceneScriptID", indexes);
            packet.ReadInt32("Unknown915", indexes);
        }

        public static void SceneScriptGlobalTextHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadCString("Script", indexes);
        }

        public static void SceneScriptPackageHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
        }

        public static void SceneScriptTextHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadCString("Script", indexes);
        }

        public static void ServerMessagesHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Text", indexes);
        }

        public static void SkillLineHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("DisplayName", indexes);
            packet.ReadCString("AlternateVerb", indexes);
            packet.ReadCString("Description", indexes);
            packet.ReadCString("HordeDisplayName", indexes);
            packet.ReadCString("OverrideSourceInfoDisplayName", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadSByte("CategoryID", indexes);
            packet.ReadInt32("SpellIconFileID", indexes);
            packet.ReadSByte("CanLink", indexes);
            packet.ReadUInt32("ParentSkillLineID", indexes);
            packet.ReadInt32("ParentTierIndex", indexes);
            packet.ReadUInt16("Flags", indexes);
            packet.ReadInt32("SpellBookSpellID", indexes);
        }

        public static void SkillLineAbilityHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt64("RaceMask", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt16("SkillLine", indexes);
            packet.ReadInt32("Spell", indexes);
            packet.ReadInt16("MinSkillLineRank", indexes);
            packet.ReadInt32("ClassMask", indexes);
            packet.ReadInt32("SupercedesSpell", indexes);
            packet.ReadSByte("AcquireMethod", indexes);
            packet.ReadInt16("TrivialSkillLineRankHigh", indexes);
            packet.ReadInt16("TrivialSkillLineRankLow", indexes);
            packet.ReadSByte("Flags", indexes);
            packet.ReadSByte("NumSkillUps", indexes);
            packet.ReadInt16("UniqueBit", indexes);
            packet.ReadInt16("TradeSkillCategoryID", indexes);
            packet.ReadInt16("SkillupSkillLineID", indexes);
            for (int i = 0; i < 2; i++)
                packet.ReadInt32("CharacterPoints", indexes, i);
        }

        public static void SkillLineXTraitTreeHandler341(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("SkillLineID", indexes);
            packet.ReadInt32("TraitTreeID", indexes);
            packet.ReadInt32("OrderIndex", indexes);
        }

        public static void SkillRaceClassInfoHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt64("RaceMask", indexes);
            packet.ReadInt16("SkillID", indexes);
            packet.ReadInt32("ClassMask", indexes);
            packet.ReadUInt16("Flags", indexes);
            packet.ReadSByte("Availability", indexes);
            packet.ReadSByte("MinLevel", indexes);
            packet.ReadInt16("SkillTierID", indexes);
        }

        public static void SoundKitHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ID", indexes);
            packet.ReadByte("SoundType", indexes);
            packet.ReadSingle("VolumeFloat", indexes);
            packet.ReadUInt16("Flags", indexes);
            packet.ReadSingle("MinDistance", indexes);
            packet.ReadSingle("DistanceCutoff", indexes);
            packet.ReadByte("EAXDef", indexes);
            packet.ReadUInt32("SoundKitAdvancedID", indexes);
            packet.ReadSingle("VolumeVariationPlus", indexes);
            packet.ReadSingle("VolumeVariationMinus", indexes);
            packet.ReadSingle("PitchVariationPlus", indexes);
            packet.ReadSingle("PitchVariationMinus", indexes);
            packet.ReadSByte("DialogType", indexes);
            packet.ReadSingle("PitchAdjust", indexes);
            packet.ReadUInt16("BusOverwriteID", indexes);
            packet.ReadByte("MaxInstances", indexes);
        }

        public static void SoundKitHandler341(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ID", indexes);
            packet.ReadByte("SoundType", indexes);
            packet.ReadSingle("VolumeFloat", indexes);
            packet.ReadUInt16("Flags", indexes);
            packet.ReadSingle("MinDistance", indexes);
            packet.ReadSingle("DistanceCutoff", indexes);
            packet.ReadByte("EAXDef", indexes);
            packet.ReadUInt32("SoundKitAdvancedID", indexes);
            packet.ReadSingle("VolumeVariationPlus", indexes);
            packet.ReadSingle("VolumeVariationMinus", indexes);
            packet.ReadSingle("PitchVariationPlus", indexes);
            packet.ReadSingle("PitchVariationMinus", indexes);
            packet.ReadSByte("DialogType", indexes);
            packet.ReadSingle("PitchAdjust", indexes);
            packet.ReadUInt16("BusOverwriteID", indexes);
            packet.ReadByte("MaxInstances", indexes);
            packet.ReadUInt32("SoundMixGroupID", indexes);
        }

        public static void SpecializationSpellsHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Description", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadUInt16("SpecID", indexes);
            packet.ReadInt32("SpellID", indexes);
            packet.ReadInt32("OverridesSpellID", indexes);
            packet.ReadByte("DisplayOrder", indexes);
        }

        public static void SpecSetMemberHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("ChrSpecializationID", indexes);
            packet.ReadInt32("SpecSetID", indexes);
        }

        public static void SpellAuraOptionsHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadByte("DifficultyID", indexes);
            packet.ReadUInt32("CumulativeAura", indexes);
            packet.ReadInt32("ProcCategoryRecovery", indexes);
            packet.ReadByte("ProcChance", indexes);
            packet.ReadInt32("ProcCharges", indexes);
            packet.ReadUInt16("SpellProcsPerMinuteID", indexes);
            for (int i = 0; i < 2; i++)
                packet.ReadInt32("ProcTypeMask", indexes, i);
            packet.ReadInt32("SpellID", indexes);
        }

        public static void SpellAuraRestrictionsHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadByte("DifficultyID", indexes);
            packet.ReadByte("CasterAuraState", indexes);
            packet.ReadByte("TargetAuraState", indexes);
            packet.ReadByte("ExcludeCasterAuraState", indexes);
            packet.ReadByte("ExcludeTargetAuraState", indexes);
            packet.ReadInt32("CasterAuraSpell", indexes);
            packet.ReadInt32("TargetAuraSpell", indexes);
            packet.ReadInt32("ExcludeCasterAuraSpell", indexes);
            packet.ReadInt32("ExcludeTargetAuraSpell", indexes);
            packet.ReadInt32("SpellID", indexes);
        }

        public static void SpellCastTimesHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("Base", indexes);
            packet.ReadInt16("PerLevel", indexes);
            packet.ReadInt32("Minimum", indexes);
        }

        public static void SpellCastingRequirementsHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("SpellID", indexes);
            packet.ReadByte("FacingCasterFlags", indexes);
            packet.ReadUInt16("MinFactionID", indexes);
            packet.ReadSByte("MinReputation", indexes);
            packet.ReadUInt16("RequiredAreasID", indexes);
            packet.ReadByte("RequiredAuraVision", indexes);
            packet.ReadUInt16("RequiresSpellFocus", indexes);
        }

        public static void SpellCastingRequirementsHandler341(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("SpellID", indexes);
            packet.ReadByte("FacingCasterFlags", indexes);
            packet.ReadUInt16("MinFactionID", indexes);
            packet.ReadInt32("MinReputation", indexes);
            packet.ReadUInt16("RequiredAreasID", indexes);
            packet.ReadByte("RequiredAuraVision", indexes);
            packet.ReadUInt16("RequiresSpellFocus", indexes);
        }

        public static void SpellCategoriesHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadByte("DifficultyID", indexes);
            packet.ReadInt16("Category", indexes);
            packet.ReadSByte("DefenseType", indexes);
            packet.ReadSByte("DispelType", indexes);
            packet.ReadSByte("Mechanic", indexes);
            packet.ReadSByte("PreventionType", indexes);
            packet.ReadInt16("StartRecoveryCategory", indexes);
            packet.ReadInt16("ChargeCategory", indexes);
            packet.ReadInt32("SpellID", indexes);
        }

        public static void SpellCategoryHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadSByte("Flags", indexes);
            packet.ReadByte("UsesPerWeek", indexes);
            packet.ReadSByte("MaxCharges", indexes);
            packet.ReadInt32("ChargeRecoveryTime", indexes);
            packet.ReadInt32("TypeMask", indexes);
        }

        public static void SpellCategoryHandler343(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadInt32("Flags", indexes);
            packet.ReadByte("UsesPerWeek", indexes);
            packet.ReadSByte("MaxCharges", indexes);
            packet.ReadInt32("ChargeRecoveryTime", indexes);
            packet.ReadInt32("TypeMask", indexes);
        }

        public static void SpellClassOptionsHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("SpellID", indexes);
            packet.ReadUInt32("ModalNextSpell", indexes);
            packet.ReadByte("SpellClassSet", indexes);
            for (int i = 0; i < 4; i++)
                packet.ReadInt32("SpellClassMask", indexes, i);
        }

        public static void SpellCooldownsHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadByte("DifficultyID", indexes);
            packet.ReadInt32("CategoryRecoveryTime", indexes);
            packet.ReadInt32("RecoveryTime", indexes);
            packet.ReadInt32("StartRecoveryTime", indexes);
            packet.ReadInt32("SpellID", indexes);
        }

        public static void SpellDurationHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("Duration", indexes);
            packet.ReadUInt32("DurationPerLevel", indexes);
            packet.ReadInt32("MaxDuration", indexes);
        }

        public static void SpellEffectHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("DifficultyID", indexes);
            packet.ReadInt32("EffectIndex", indexes);
            packet.ReadUInt32("Effect", indexes);
            packet.ReadSingle("EffectAmplitude", indexes);
            packet.ReadInt32("EffectAttributes", indexes);
            packet.ReadInt16("EffectAura", indexes);
            packet.ReadInt32("EffectAuraPeriod", indexes);
            packet.ReadInt32("EffectBasePoints", indexes);
            packet.ReadSingle("EffectBonusCoefficient", indexes);
            packet.ReadSingle("EffectChainAmplitude", indexes);
            packet.ReadInt32("EffectChainTargets", indexes);
            packet.ReadInt32("EffectDieSides", indexes);
            packet.ReadInt32("EffectItemType", indexes);
            packet.ReadInt32("EffectMechanic", indexes);
            packet.ReadSingle("EffectPointsPerResource", indexes);
            packet.ReadSingle("EffectPosFacing", indexes);
            packet.ReadSingle("EffectRealPointsPerLevel", indexes);
            packet.ReadInt32("EffectTriggerSpell", indexes);
            packet.ReadSingle("BonusCoefficientFromAP", indexes);
            packet.ReadSingle("PvpMultiplier", indexes);
            packet.ReadSingle("Coefficient", indexes);
            packet.ReadSingle("Variance", indexes);
            packet.ReadSingle("ResourceCoefficient", indexes);
            packet.ReadSingle("GroupSizeBasePointsCoefficient", indexes);
            for (int i = 0; i < 2; i++)
                packet.ReadInt32("EffectMiscValue", indexes, i);
            for (int i = 0; i < 2; i++)
                packet.ReadUInt32("EffectRadiusIndex", indexes, i);
            for (int i = 0; i < 4; i++)
                packet.ReadInt32("EffectSpellClassMask", indexes, i);
            for (int i = 0; i < 2; i++)
                packet.ReadInt16("ImplicitTarget", indexes, i);
            packet.ReadInt32("SpellID", indexes);
        }

        public static void SpellEquippedItemsHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("SpellID", indexes);
            packet.ReadSByte("EquippedItemClass", indexes);
            packet.ReadInt32("EquippedItemInvTypes", indexes);
            packet.ReadInt32("EquippedItemSubclass", indexes);
        }

        public static void SpellFocusObjectHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
        }

        public static void SpellInterruptsHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadByte("DifficultyID", indexes);
            packet.ReadInt16("InterruptFlags", indexes);
            for (int i = 0; i < 2; i++)
                packet.ReadInt32("AuraInterruptFlags", indexes, i);
            for (int i = 0; i < 2; i++)
                packet.ReadInt32("ChannelInterruptFlags", indexes, i);
            packet.ReadInt32("SpellID", indexes);
        }

        public static void SpellItemEnchantmentHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadCString("HordeName", indexes);
            for (int i = 0; i < 3; i++)
                packet.ReadUInt32("EffectArg", indexes, i);
            for (int i = 0; i < 3; i++)
                packet.ReadSingle("EffectScalingPoints", indexes, i);
            packet.ReadUInt32("GemItemID", indexes);
            packet.ReadUInt32("TransmogUnlockConditionID", indexes);
            packet.ReadUInt32("TransmogCost", indexes);
            packet.ReadUInt32("IconFileDataID", indexes);
            for (int i = 0; i < 3; i++)
                packet.ReadInt16("EffectPointsMin", indexes, i);
            packet.ReadUInt16("ItemVisual", indexes);
            packet.ReadUInt16("Flags", indexes);
            packet.ReadUInt16("RequiredSkillID", indexes);
            packet.ReadUInt16("RequiredSkillRank", indexes);
            packet.ReadUInt16("ItemLevel", indexes);
            packet.ReadByte("Charges", indexes);
            for (int i = 0; i < 3; i++)
                packet.ReadByte("Effect", indexes, i);
            packet.ReadSByte("ScalingClass", indexes);
            packet.ReadSByte("ScalingClassRestricted", indexes);
            packet.ReadByte("ConditionID", indexes);
            packet.ReadByte("MinLevel", indexes);
            packet.ReadByte("MaxLevel", indexes);
        }

        public static void SpellItemEnchantmentConditionHandler340(Packet packet, uint entry, params object[] indexes)
        {
            for (int i = 0; i < 5; i++)
                packet.ReadByte("LtOperandType", indexes, i);
            for (int i = 0; i < 5; i++)
                packet.ReadUInt32("LtOperand", indexes, i);
            for (int i = 0; i < 5; i++)
                packet.ReadByte("Operator", indexes, i);
            for (int i = 0; i < 5; i++)
                packet.ReadByte("RtOperandType", indexes, i);
            for (int i = 0; i < 5; i++)
                packet.ReadByte("RtOperand", indexes, i);
            for (int i = 0; i < 5; i++)
                packet.ReadByte("Logic", indexes, i);
        }

        public static void SpellKeyboundOverrideHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Function", indexes);
            packet.ReadSByte("Type", indexes);
            packet.ReadInt32("Data", indexes);
            packet.ReadInt32("Flags", indexes);
        }

        public static void SpellLabelHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("LabelID", indexes);
            packet.ReadInt32("SpellID", indexes);
        }

        public static void SpellLearnSpellHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("SpellID", indexes);
            packet.ReadInt32("LearnSpellID", indexes);
            packet.ReadInt32("OverridesSpellID", indexes);
        }

        public static void SpellLevelsHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadByte("DifficultyID", indexes);
            packet.ReadInt16("BaseLevel", indexes);
            packet.ReadInt16("MaxLevel", indexes);
            packet.ReadInt16("SpellLevel", indexes);
            packet.ReadByte("MaxPassiveAuraLevel", indexes);
            packet.ReadInt32("SpellID", indexes);
        }

        public static void SpellMiscHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadByte("DifficultyID", indexes);
            packet.ReadUInt16("CastingTimeIndex", indexes);
            packet.ReadUInt16("DurationIndex", indexes);
            packet.ReadUInt16("RangeIndex", indexes);
            packet.ReadByte("SchoolMask", indexes);
            packet.ReadSingle("Speed", indexes);
            packet.ReadSingle("LaunchDelay", indexes);
            packet.ReadSingle("MinDuration", indexes);
            packet.ReadInt32("SpellIconFileDataID", indexes);
            packet.ReadInt32("ActiveIconFileDataID", indexes);
            packet.ReadInt32("ContentTuningID", indexes);
            packet.ReadInt32("ShowFutureSpellPlayerConditionID", indexes);
            for (int i = 0; i < 14; i++)
                packet.ReadInt32("Attributes", indexes, i);
            packet.ReadInt32("SpellID", indexes);
        }

        public static void SpellMiscHandler341(Packet packet, uint entry, params object[] indexes)
        {
            for (int i = 0; i < 15; i++)
                packet.ReadInt32("Attributes", indexes, i);
            packet.ReadByte("DifficultyID", indexes);
            packet.ReadUInt16("CastingTimeIndex", indexes);
            packet.ReadUInt16("DurationIndex", indexes);
            packet.ReadUInt16("RangeIndex", indexes);
            packet.ReadByte("SchoolMask", indexes);
            packet.ReadSingle("Speed", indexes);
            packet.ReadSingle("LaunchDelay", indexes);
            packet.ReadSingle("MinDuration", indexes);
            packet.ReadInt32("SpellIconFileDataID", indexes);
            packet.ReadInt32("ActiveIconFileDataID", indexes);
            packet.ReadInt32("ContentTuningID", indexes);
            packet.ReadInt32("ShowFutureSpellPlayerConditionID", indexes);
            packet.ReadInt32("SpellID", indexes);
        }

        public static void SpellNameHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
        }

        public static void SpellPowerHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ID", indexes);
            packet.ReadByte("OrderIndex", indexes);
            packet.ReadInt32("ManaCost", indexes);
            packet.ReadInt32("ManaCostPerLevel", indexes);
            packet.ReadInt32("ManaPerSecond", indexes);
            packet.ReadUInt32("PowerDisplayID", indexes);
            packet.ReadInt32("AltPowerBarID", indexes);
            packet.ReadSingle("PowerCostPct", indexes);
            packet.ReadSingle("PowerCostMaxPct", indexes);
            packet.ReadSingle("PowerPctPerSecond", indexes);
            packet.ReadSByte("PowerType", indexes);
            packet.ReadInt32("RequiredAuraSpellID", indexes);
            packet.ReadUInt32("OptionalCost", indexes);
            packet.ReadInt32("SpellID", indexes);
        }

        public static void SpellPowerDifficultyHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ID", indexes);
            packet.ReadByte("DifficultyID", indexes);
            packet.ReadByte("OrderIndex", indexes);
        }

        public static void SpellProcsPerMinuteHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadSingle("BaseProcRate", indexes);
            packet.ReadByte("Flags", indexes);
        }

        public static void SpellProcsPerMinuteModHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadByte("Type", indexes);
            packet.ReadInt16("Param", indexes);
            packet.ReadSingle("Coeff", indexes);
            packet.ReadInt32("SpellProcsPerMinuteID", indexes);
        }

        public static void SpellRadiusHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadSingle("Radius", indexes);
            packet.ReadSingle("RadiusPerLevel", indexes);
            packet.ReadSingle("RadiusMin", indexes);
            packet.ReadSingle("RadiusMax", indexes);
        }

        public static void SpellRangeHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("DisplayName", indexes);
            packet.ReadCString("DisplayNameShort", indexes);
            packet.ReadByte("Flags", indexes);
            for (int i = 0; i < 2; i++)
                packet.ReadSingle("RangeMin", indexes, i);
            for (int i = 0; i < 2; i++)
                packet.ReadSingle("RangeMax", indexes, i);
        }

        public static void SpellReagentsHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("SpellID", indexes);
            for (int i = 0; i < 8; i++)
                packet.ReadInt32("Reagent", indexes, i);
            for (int i = 0; i < 8; i++)
                packet.ReadInt16("ReagentCount", indexes, i);
        }

        public static void SpellReagentsCurrencyHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("SpellID", indexes);
            packet.ReadUInt16("CurrencyTypesID", indexes);
            packet.ReadUInt16("CurrencyCount", indexes);
        }

        public static void SpellScalingHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("SpellID", indexes);
            packet.ReadInt32("Class", indexes);
            packet.ReadUInt32("MinScalingLevel", indexes);
            packet.ReadUInt32("MaxScalingLevel", indexes);
            packet.ReadInt16("ScalesFromItemLevel", indexes);
        }

        public static void SpellShapeshiftHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("SpellID", indexes);
            packet.ReadSByte("StanceBarOrder", indexes);
            for (int i = 0; i < 2; i++)
                packet.ReadInt32("ShapeshiftExclude", indexes, i);
            for (int i = 0; i < 2; i++)
                packet.ReadInt32("ShapeshiftMask", indexes, i);
        }

        public static void SpellShapeshiftFormHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadSByte("CreatureType", indexes);
            packet.ReadInt32("Flags", indexes);
            packet.ReadInt32("AttackIconFileID", indexes);
            packet.ReadSByte("BonusActionBar", indexes);
            packet.ReadInt16("CombatRoundTime", indexes);
            packet.ReadSingle("DamageVariance", indexes);
            packet.ReadUInt16("MountTypeID", indexes);
            for (int i = 0; i < 4; i++)
                packet.ReadUInt32("CreatureDisplayID", indexes, i);
            for (int i = 0; i < 8; i++)
                packet.ReadUInt32("PresetSpellID", indexes, i);
        }

        public static void SpellTargetRestrictionsHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadByte("DifficultyID", indexes);
            packet.ReadSingle("ConeDegrees", indexes);
            packet.ReadByte("MaxTargets", indexes);
            packet.ReadUInt32("MaxTargetLevel", indexes);
            packet.ReadInt16("TargetCreatureType", indexes);
            packet.ReadInt32("Targets", indexes);
            packet.ReadSingle("Width", indexes);
            packet.ReadInt32("SpellID", indexes);
        }

        public static void SpellTotemsHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("SpellID", indexes);
            for (int i = 0; i < 2; i++)
                packet.ReadUInt16("RequiredTotemCategoryID", indexes, i);
            for (int i = 0; i < 2; i++)
                packet.ReadInt32("Totem", indexes, i);
        }

        public static void SpellVisualHandler340(Packet packet, uint entry, params object[] indexes)
        {
            for (int i = 0; i < 3; i++)
                packet.ReadSingle("MissileCastOffset", indexes, i);
            for (int i = 0; i < 3; i++)
                packet.ReadSingle("MissileImpactOffset", indexes, i);
            packet.ReadUInt32("AnimEventSoundID", indexes);
            packet.ReadInt32("Flags", indexes);
            packet.ReadSByte("MissileAttachment", indexes);
            packet.ReadSByte("MissileDestinationAttachment", indexes);
            packet.ReadUInt32("MissileCastPositionerID", indexes);
            packet.ReadUInt32("MissileImpactPositionerID", indexes);
            packet.ReadInt32("MissileTargetingKit", indexes);
            packet.ReadUInt32("HostileSpellVisualID", indexes);
            packet.ReadUInt32("CasterSpellVisualID", indexes);
            packet.ReadUInt16("SpellVisualMissileSetID", indexes);
            packet.ReadUInt16("DamageNumberDelay", indexes);
            packet.ReadUInt32("LowViolenceSpellVisualID", indexes);
            packet.ReadUInt32("RaidSpellVisualMissileSetID", indexes);
            packet.ReadInt32("ReducedUnexpectedCameraMovementSpellVisualID", indexes);
            packet.ReadUInt16("AreaModel", indexes);
            packet.ReadSByte("HasMissile", indexes);
        }

        public static void SpellVisualEffectNameHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("ModelFileDataID", indexes);
            packet.ReadSingle("BaseMissileSpeed", indexes);
            packet.ReadSingle("Scale", indexes);
            packet.ReadSingle("MinAllowedScale", indexes);
            packet.ReadSingle("MaxAllowedScale", indexes);
            packet.ReadSingle("Alpha", indexes);
            packet.ReadUInt32("Flags", indexes);
            packet.ReadInt32("TextureFileDataID", indexes);
            packet.ReadSingle("EffectRadius", indexes);
            packet.ReadUInt32("Type", indexes);
            packet.ReadInt32("GenericID", indexes);
            packet.ReadUInt32("RibbonQualityID", indexes);
            packet.ReadInt32("DissolveEffectID", indexes);
            packet.ReadInt32("ModelPosition", indexes);
        }

        public static void SpellVisualMissileHandler340(Packet packet, uint entry, params object[] indexes)
        {
            for (int i = 0; i < 3; i++)
                packet.ReadSingle("CastOffset", indexes, i);
            for (int i = 0; i < 3; i++)
                packet.ReadSingle("ImpactOffset", indexes, i);
            packet.ReadUInt32("ID", indexes);
            packet.ReadUInt16("SpellVisualEffectNameID", indexes);
            packet.ReadUInt32("SoundEntriesID", indexes);
            packet.ReadSByte("Attachment", indexes);
            packet.ReadSByte("DestinationAttachment", indexes);
            packet.ReadUInt16("CastPositionerID", indexes);
            packet.ReadUInt16("ImpactPositionerID", indexes);
            packet.ReadInt32("FollowGroundHeight", indexes);
            packet.ReadUInt32("FollowGroundDropSpeed", indexes);
            packet.ReadUInt16("FollowGroundApproach", indexes);
            packet.ReadUInt32("Flags", indexes);
            packet.ReadUInt16("SpellMissileMotionID", indexes);
            packet.ReadUInt32("AnimKitID", indexes);
            packet.ReadInt16("SpellVisualMissileSetID", indexes);
        }

        public static void SpellVisualKitHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("FallbackSpellVisualKitID", indexes);
            packet.ReadUInt16("DelayMin", indexes);
            packet.ReadUInt16("DelayMax", indexes);
            packet.ReadSingle("FallbackPriority", indexes);
            for (int i = 0; i < 2; i++)
                packet.ReadInt32("Flags", indexes, i);
        }

        public static void SpellXSpellVisualHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ID", indexes);
            packet.ReadByte("DifficultyID", indexes);
            packet.ReadUInt32("SpellVisualID", indexes);
            packet.ReadSingle("Probability", indexes);
            packet.ReadByte("Flags", indexes);
            packet.ReadInt32("Priority", indexes);
            packet.ReadInt32("SpellIconFileID", indexes);
            packet.ReadInt32("ActiveIconFileID", indexes);
            packet.ReadUInt16("ViewerUnitConditionID", indexes);
            packet.ReadUInt32("ViewerPlayerConditionID", indexes);
            packet.ReadUInt16("CasterUnitConditionID", indexes);
            packet.ReadUInt32("CasterPlayerConditionID", indexes);
            packet.ReadInt32("SpellID", indexes);
        }

        public static void SummonPropertiesHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("Control", indexes);
            packet.ReadInt32("Faction", indexes);
            packet.ReadInt32("Title", indexes);
            packet.ReadInt32("Slot", indexes);
            for (int i = 0; i < 2; i++)
                packet.ReadInt32("Flags", indexes, i);
        }

        public static void TactKeyHandler340(Packet packet, uint entry, params object[] indexes)
        {
            for (int i = 0; i < 16; i++)
                packet.ReadByte("Key", indexes, i);
        }

        public static void TalentHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Description", indexes);
            packet.ReadByte("TierID", indexes);
            packet.ReadByte("Flags", indexes);
            packet.ReadByte("ColumnIndex", indexes);
            packet.ReadUInt16("TabID", indexes);
            packet.ReadByte("ClassID", indexes);
            packet.ReadUInt16("SpecID", indexes);
            packet.ReadInt32("SpellID", indexes);
            packet.ReadInt32("OverridesSpellID", indexes);
            packet.ReadInt32("RequiredSpellID", indexes);
            for (int i = 0; i < 2; i++)
                packet.ReadInt32("CategoryMask", indexes, i);
            for (int i = 0; i < 9; i++)
                packet.ReadInt32("SpellRank", indexes, i);
            for (int i = 0; i < 3; i++)
                packet.ReadInt32("PrereqTalent", indexes, i);
            for (int i = 0; i < 3; i++)
                packet.ReadInt32("PrereqRank", indexes, i);
        }

        public static void TalentTabHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadCString("BackgroundFile", indexes);
            packet.ReadInt32("OrderIndex", indexes);
            packet.ReadInt32("RaceMask", indexes);
            packet.ReadInt32("ClassMask", indexes);
            packet.ReadInt32("PetTalentMask", indexes);
            packet.ReadInt32("SpellIconID", indexes);
        }

        public static void TaxiNodesHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadSingle("PosX", indexes);
            packet.ReadSingle("PosY", indexes);
            packet.ReadSingle("PosZ", indexes);
            packet.ReadSingle("MapOffsetX", indexes);
            packet.ReadSingle("MapOffsetY", indexes);
            packet.ReadSingle("FlightMapOffsetX", indexes);
            packet.ReadSingle("FlightMapOffsetY", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadUInt32("ContinentID", indexes);
            packet.ReadUInt32("ConditionID", indexes);
            packet.ReadUInt16("CharacterBitNumber", indexes);
            packet.ReadUInt16("Flags", indexes);
            packet.ReadInt32("UiTextureKitID", indexes);
            packet.ReadSingle("Facing", indexes);
            packet.ReadUInt32("SpecialIconConditionID", indexes);
            packet.ReadUInt32("VisibilityConditionID", indexes);
            for (int i = 0; i < 2; i++)
                packet.ReadInt32("MountCreatureID", indexes, i);
        }

        public static void TaxiNodesHandler343(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadSingle("PosX", indexes);
            packet.ReadSingle("PosY", indexes);
            packet.ReadSingle("PosZ", indexes);
            packet.ReadSingle("MapOffsetX", indexes);
            packet.ReadSingle("MapOffsetY", indexes);
            packet.ReadSingle("FlightMapOffsetX", indexes);
            packet.ReadSingle("FlightMapOffsetY", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadUInt32("ContinentID", indexes);
            packet.ReadUInt32("ConditionID", indexes);
            packet.ReadUInt16("CharacterBitNumber", indexes);
            packet.ReadInt32("Flags", indexes);
            packet.ReadInt32("UiTextureKitID", indexes);
            packet.ReadSingle("Facing", indexes);
            packet.ReadUInt32("SpecialIconConditionID", indexes);
            packet.ReadUInt32("VisibilityConditionID", indexes);
            for (int i = 0; i < 2; i++)
                packet.ReadInt32("MountCreatureID", indexes, i);
        }

        public static void TaxiPathHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ID", indexes);
            packet.ReadUInt16("FromTaxiNode", indexes);
            packet.ReadUInt16("ToTaxiNode", indexes);
            packet.ReadUInt32("Cost", indexes);
        }

        public static void TaxiPathNodeHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadSingle("LocX", indexes);
            packet.ReadSingle("LocY", indexes);
            packet.ReadSingle("LocZ", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadUInt16("PathID", indexes);
            packet.ReadInt32("NodeIndex", indexes);
            packet.ReadUInt16("ContinentID", indexes);
            packet.ReadByte("Flags", indexes);
            packet.ReadUInt32("Delay", indexes);
            packet.ReadUInt32("ArrivalEventID", indexes);
            packet.ReadUInt32("DepartureEventID", indexes);
        }

        public static void TaxiPathNodeHandler343(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadSingle("LocX", indexes);
            packet.ReadSingle("LocY", indexes);
            packet.ReadSingle("LocZ", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadUInt16("PathID", indexes);
            packet.ReadInt32("NodeIndex", indexes);
            packet.ReadUInt16("ContinentID", indexes);
            packet.ReadInt32("Flags", indexes);
            packet.ReadUInt32("Delay", indexes);
            packet.ReadUInt32("ArrivalEventID", indexes);
            packet.ReadUInt32("DepartureEventID", indexes);
        }

        public static void TotemCategoryHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadByte("TotemCategoryType", indexes);
            packet.ReadInt32("TotemCategoryMask", indexes);
        }

        public static void ToyHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("SourceText", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("ItemID", indexes);
            packet.ReadByte("Flags", indexes);
            packet.ReadSByte("SourceTypeEnum", indexes);
        }

        public static void TransmogHolidayHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("RequiredTransmogHoliday", indexes);
        }

        public static void TraitCondHandler341(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("CondType", indexes);
            packet.ReadInt32("TraitTreeID", indexes);
            packet.ReadInt32("GrantedRanks", indexes);
            packet.ReadInt32("QuestID", indexes);
            packet.ReadInt32("AchievementID", indexes);
            packet.ReadInt32("SpecSetID", indexes);
            packet.ReadInt32("TraitNodeGroupID", indexes);
            packet.ReadInt32("TraitNodeID", indexes);
            packet.ReadInt32("TraitCurrencyID", indexes);
            packet.ReadInt32("SpentAmountRequired", indexes);
            packet.ReadInt32("Flags", indexes);
            packet.ReadInt32("RequiredLevel", indexes);
            packet.ReadInt32("FreeSharedStringID", indexes);
            packet.ReadInt32("SpendMoreSharedStringID", indexes);
        }

        public static void TraitCostHandler341(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("InternalName", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("Amount", indexes);
            packet.ReadInt32("TraitCurrencyID", indexes);
        }

        public static void TraitCurrencyHandler341(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("Type", indexes);
            packet.ReadInt32("CurrencyTypesID", indexes);
            packet.ReadInt32("Flags", indexes);
            packet.ReadInt32("Icon", indexes);
        }

        public static void TraitCurrencySourceHandler341(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Requirement", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("TraitCurrencyID", indexes);
            packet.ReadInt32("Amount", indexes);
            packet.ReadInt32("QuestID", indexes);
            packet.ReadInt32("AchievementID", indexes);
            packet.ReadInt32("PlayerLevel", indexes);
            packet.ReadInt32("TraitNodeEntryID", indexes);
            packet.ReadInt32("OrderIndex", indexes);
        }

        public static void TraitDefinitionHandler341(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("OverrideName", indexes);
            packet.ReadCString("OverrideSubtext", indexes);
            packet.ReadCString("OverrideDescription", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("SpellID", indexes);
            packet.ReadInt32("OverrideIcon", indexes);
            packet.ReadInt32("OverridesSpellID", indexes);
            packet.ReadInt32("VisibleSpellID", indexes);
        }

        public static void TraitDefinitionEffectPointsHandler341(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("TraitDefinitionID", indexes);
            packet.ReadInt32("EffectIndex", indexes);
            packet.ReadInt32("OperationType", indexes);
            packet.ReadInt32("CurveID", indexes);
        }

        public static void TraitEdgeHandler341(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("VisualStyle", indexes);
            packet.ReadInt32("LeftTraitNodeID", indexes);
            packet.ReadInt32("RightTraitNodeID", indexes);
            packet.ReadInt32("Type", indexes);
        }

        public static void TraitNodeHandler341(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("TraitTreeID", indexes);
            packet.ReadInt32("PosX", indexes);
            packet.ReadInt32("PosY", indexes);
            packet.ReadByte("Type", indexes);
            packet.ReadInt32("Flags", indexes);
        }

        public static void TraitNodeEntryHandler341(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("TraitDefinitionID", indexes);
            packet.ReadInt32("MaxRanks", indexes);
            packet.ReadByte("NodeEntryType", indexes);
        }

        public static void TraitNodeEntryXTraitCondHandler341(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("TraitCondID", indexes);
            packet.ReadInt32("TraitNodeEntryID", indexes);
        }

        public static void TraitNodeEntryXTraitCostHandler341(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("TraitNodeEntryID", indexes);
            packet.ReadInt32("TraitCostID", indexes);
        }

        public static void TraitNodeGroupHandler341(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("TraitTreeID", indexes);
            packet.ReadInt32("Flags", indexes);
        }

        public static void TraitNodeGroupXTraitCondHandler341(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("TraitCondID", indexes);
            packet.ReadInt32("TraitNodeGroupID", indexes);
        }

        public static void TraitNodeGroupXTraitCostHandler341(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("TraitNodeGroupID", indexes);
            packet.ReadInt32("TraitCostID", indexes);
        }

        public static void TraitNodeGroupXTraitNodeHandler341(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("TraitNodeGroupID", indexes);
            packet.ReadInt32("TraitNodeID", indexes);
            packet.ReadInt32("Index", indexes);
        }

        public static void TraitNodeXTraitCondHandler341(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("TraitCondID", indexes);
            packet.ReadInt32("TraitNodeID", indexes);
        }

        public static void TraitNodeXTraitCostHandler341(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("TraitNodeID", indexes);
            packet.ReadInt32("TraitCostID", indexes);
        }

        public static void TraitNodeXTraitNodeEntryHandler341(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("TraitNodeID", indexes);
            packet.ReadInt32("TraitNodeEntryID", indexes);
            packet.ReadInt32("Index", indexes);
        }

        public static void TraitTreeHandler341(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("TraitSystemID", indexes);
            packet.ReadInt32("Unused1000_1", indexes);
            packet.ReadInt32("FirstTraitNodeID", indexes);
            packet.ReadInt32("PlayerConditionID", indexes);
            packet.ReadInt32("Flags", indexes);
            packet.ReadSingle("Unused1000_2", indexes);
            packet.ReadSingle("Unused1000_3", indexes);
        }

        public static void TraitTreeLoadoutHandler341(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("TraitTreeID", indexes);
            packet.ReadInt32("ChrSpecializationID", indexes);
        }

        public static void TraitTreeLoadoutEntryHandler341(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("TraitTreeLoadoutID", indexes);
            packet.ReadInt32("SelectedTraitNodeID", indexes);
            packet.ReadInt32("SelectedTraitNodeEntryID", indexes);
            packet.ReadInt32("NumPoints", indexes);
            packet.ReadInt32("OrderIndex", indexes);
        }

        public static void TraitTreeXTraitCostHandler341(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("TraitTreeID", indexes);
            packet.ReadInt32("TraitCostID", indexes);
        }

        public static void TraitTreeXTraitCurrencyHandler341(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("Index", indexes);
            packet.ReadInt32("TraitTreeID", indexes);
            packet.ReadInt32("TraitCurrencyID", indexes);
        }

        public static void TransmogSetHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("ClassMask", indexes);
            packet.ReadUInt32("TrackingQuestID", indexes);
            packet.ReadInt32("Flags", indexes);
            packet.ReadUInt32("TransmogSetGroupID", indexes);
            packet.ReadInt32("ItemNameDescriptionID", indexes);
            packet.ReadUInt16("ParentTransmogSetID", indexes);
            packet.ReadByte("ExpansionID", indexes);
            packet.ReadInt16("UiOrder", indexes);
        }

        public static void TransmogSetGroupHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadUInt32("ID", indexes);
        }

        public static void TransmogSetItemHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ID", indexes);
            packet.ReadUInt32("TransmogSetID", indexes);
            packet.ReadUInt32("ItemModifiedAppearanceID", indexes);
            packet.ReadInt32("Flags", indexes);
        }

        public static void TransportAnimationHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadSingle("PosX", indexes);
            packet.ReadSingle("PosY", indexes);
            packet.ReadSingle("PosZ", indexes);
            packet.ReadByte("SequenceID", indexes);
            packet.ReadUInt32("TimeIndex", indexes);
            packet.ReadInt32("TransportID", indexes);
        }

        public static void TransportRotationHandler340(Packet packet, uint entry, params object[] indexes)
        {
            for (int i = 0; i < 4; i++)
                packet.ReadSingle("Rot", indexes, i);
            packet.ReadUInt32("TimeIndex", indexes);
            packet.ReadInt32("GameObjectsID", indexes);
        }

        public static void UiMapHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("ParentUiMapID", indexes);
            packet.ReadInt32("Flags", indexes);
            packet.ReadUInt32("System", indexes);
            packet.ReadUInt32("Type", indexes);
            packet.ReadInt32("BountySetID", indexes);
            packet.ReadUInt32("BountyDisplayLocation", indexes);
            packet.ReadInt32("VisibilityPlayerConditionID", indexes);
            packet.ReadSByte("HelpTextPosition", indexes);
            packet.ReadInt32("BkgAtlasID", indexes);
            packet.ReadUInt32("LevelRangeMin", indexes);
            packet.ReadUInt32("LevelRangeMax", indexes);
        }

        public static void UiMapHandler343(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("ParentUiMapID", indexes);
            packet.ReadInt32("Flags", indexes);
            packet.ReadByte("System", indexes);
            packet.ReadByte("Type", indexes);
            packet.ReadInt32("BountySetID", indexes);
            packet.ReadUInt32("BountyDisplayLocation", indexes);
            packet.ReadInt32("VisibilityPlayerConditionID2", indexes);
            packet.ReadInt32("VisibilityPlayerConditionID", indexes);
            packet.ReadSByte("HelpTextPosition", indexes);
            packet.ReadInt32("BkgAtlasID", indexes);
            packet.ReadUInt32("AlternateUiMapGroup", indexes);
            packet.ReadUInt32("ContentTuningID", indexes);
        }

        public static void UiMapAssignmentHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadSingle("UiMinX", indexes);
            packet.ReadSingle("UiMinY", indexes);
            packet.ReadSingle("UiMaxX", indexes);
            packet.ReadSingle("UiMaxY", indexes);
            packet.ReadSingle("Region1X", indexes);
            packet.ReadSingle("Region1Y", indexes);
            packet.ReadSingle("Region1Z", indexes);
            packet.ReadSingle("Region2X", indexes);
            packet.ReadSingle("Region2Y", indexes);
            packet.ReadSingle("Region2Z", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("UiMapID", indexes);
            packet.ReadInt32("OrderIndex", indexes);
            packet.ReadInt32("MapID", indexes);
            packet.ReadInt32("AreaID", indexes);
            packet.ReadInt32("WmoDoodadPlacementID", indexes);
            packet.ReadInt32("WmoGroupID", indexes);
        }

        public static void UiMapLinkHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadSingle("UiMinX", indexes);
            packet.ReadSingle("UiMinY", indexes);
            packet.ReadSingle("UiMaxX", indexes);
            packet.ReadSingle("UiMaxY", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadInt32("ParentUiMapID", indexes);
            packet.ReadInt32("OrderIndex", indexes);
            packet.ReadInt32("ChildUiMapID", indexes);
            packet.ReadInt32("OverrideHighlightFileDataID", indexes);
            packet.ReadInt32("OverrideHighlightAtlasID", indexes);
            packet.ReadInt32("Flags", indexes);
        }

        public static void UiMapXMapArtHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("PhaseID", indexes);
            packet.ReadInt32("UiMapArtID", indexes);
            packet.ReadInt32("UiMapID", indexes);
        }

        public static void UnitConditionHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadByte("Flags", indexes);
            for (int i = 0; i < 8; i++)
                packet.ReadByte("Variable", indexes, i);
            for (int i = 0; i < 8; i++)
                packet.ReadSByte("Op", indexes, i);
            for (int i = 0; i < 8; i++)
                 packet.ReadInt32("Value", indexes, i);
        }

        public static void UnitPowerBarHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Name", indexes);
            packet.ReadCString("Cost", indexes);
            packet.ReadCString("OutOfError", indexes);
            packet.ReadCString("ToolTip", indexes);
            packet.ReadUInt32("MinPower", indexes);
            packet.ReadUInt32("MaxPower", indexes);
            packet.ReadUInt16("StartPower", indexes);
            packet.ReadByte("CenterPower", indexes);
            packet.ReadSingle("RegenerationPeace", indexes);
            packet.ReadSingle("RegenerationCombat", indexes);
            packet.ReadByte("BarType", indexes);
            packet.ReadUInt16("Flags", indexes);
            packet.ReadSingle("StartInset", indexes);
            packet.ReadSingle("EndInset", indexes);
            for (int i = 0; i < 6; i++)
                packet.ReadInt32("FileDataID", indexes, i);
            for (int i = 0; i < 6; i++)
                packet.ReadInt32("Color", indexes, i);
        }

        public static void VehicleHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("Flags", indexes);
            packet.ReadByte("FlagsB", indexes);
            packet.ReadSingle("TurnSpeed", indexes);
            packet.ReadSingle("PitchSpeed", indexes);
            packet.ReadSingle("PitchMin", indexes);
            packet.ReadSingle("PitchMax", indexes);
            packet.ReadSingle("MouseLookOffsetPitch", indexes);
            packet.ReadSingle("CameraFadeDistScalarMin", indexes);
            packet.ReadSingle("CameraFadeDistScalarMax", indexes);
            packet.ReadSingle("CameraPitchOffset", indexes);
            packet.ReadSingle("FacingLimitRight", indexes);
            packet.ReadSingle("FacingLimitLeft", indexes);
            packet.ReadSingle("CameraYawOffset", indexes);
            packet.ReadUInt16("VehicleUIIndicatorID", indexes);
            packet.ReadInt32("MissileTargetingID", indexes);
            packet.ReadByte("UiLocomotionType", indexes);
            for (int i = 0; i < 8; i++)
                packet.ReadUInt16("SeatID", indexes, i);
            for (int i = 0; i < 3; i++)
                packet.ReadUInt16("PowerDisplayID", indexes, i);
        }

        public static void VehicleHandler342(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadInt32("Flags", indexes);
            packet.ReadInt32("FlagsB", indexes);
            packet.ReadSingle("TurnSpeed", indexes);
            packet.ReadSingle("PitchSpeed", indexes);
            packet.ReadSingle("PitchMin", indexes);
            packet.ReadSingle("PitchMax", indexes);
            packet.ReadSingle("MouseLookOffsetPitch", indexes);
            packet.ReadSingle("CameraFadeDistScalarMin", indexes);
            packet.ReadSingle("CameraFadeDistScalarMax", indexes);
            packet.ReadSingle("CameraPitchOffset", indexes);
            packet.ReadSingle("FacingLimitRight", indexes);
            packet.ReadSingle("FacingLimitLeft", indexes);
            packet.ReadSingle("CameraYawOffset", indexes);
            packet.ReadUInt16("VehicleUIIndicatorID", indexes);
            packet.ReadInt32("MissileTargetingID", indexes);
            packet.ReadUInt16("VehiclePOITypeID", indexes);
            packet.ReadInt32("UiLocomotionType", indexes);
            for (int i = 0; i < 8; i++)
                packet.ReadUInt16("SeatID", indexes, i);
            for (int i = 0; i < 3; i++)
                packet.ReadUInt16("PowerDisplayID", indexes, i);
        }

        public static void VehicleSeatHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadSingle("AttachmentOffsetX", indexes);
            packet.ReadSingle("AttachmentOffsetY", indexes);
            packet.ReadSingle("AttachmentOffsetZ", indexes);
            packet.ReadSingle("CameraOffsetX", indexes);
            packet.ReadSingle("CameraOffsetY", indexes);
            packet.ReadSingle("CameraOffsetZ", indexes);
            packet.ReadInt32("Flags", indexes);
            packet.ReadInt32("FlagsB", indexes);
            packet.ReadInt32("FlagsC", indexes);
            packet.ReadSByte("AttachmentID", indexes);
            packet.ReadSingle("EnterPreDelay", indexes);
            packet.ReadSingle("EnterSpeed", indexes);
            packet.ReadSingle("EnterGravity", indexes);
            packet.ReadSingle("EnterMinDuration", indexes);
            packet.ReadSingle("EnterMaxDuration", indexes);
            packet.ReadSingle("EnterMinArcHeight", indexes);
            packet.ReadSingle("EnterMaxArcHeight", indexes);
            packet.ReadInt32("EnterAnimStart", indexes);
            packet.ReadInt32("EnterAnimLoop", indexes);
            packet.ReadInt32("RideAnimStart", indexes);
            packet.ReadInt32("RideAnimLoop", indexes);
            packet.ReadInt32("RideUpperAnimStart", indexes);
            packet.ReadInt32("RideUpperAnimLoop", indexes);
            packet.ReadSingle("ExitPreDelay", indexes);
            packet.ReadSingle("ExitSpeed", indexes);
            packet.ReadSingle("ExitGravity", indexes);
            packet.ReadSingle("ExitMinDuration", indexes);
            packet.ReadSingle("ExitMaxDuration", indexes);
            packet.ReadSingle("ExitMinArcHeight", indexes);
            packet.ReadSingle("ExitMaxArcHeight", indexes);
            packet.ReadInt32("ExitAnimStart", indexes);
            packet.ReadInt32("ExitAnimLoop", indexes);
            packet.ReadInt32("ExitAnimEnd", indexes);
            packet.ReadInt16("VehicleEnterAnim", indexes);
            packet.ReadSByte("VehicleEnterAnimBone", indexes);
            packet.ReadInt16("VehicleExitAnim", indexes);
            packet.ReadSByte("VehicleExitAnimBone", indexes);
            packet.ReadInt16("VehicleRideAnimLoop", indexes);
            packet.ReadSByte("VehicleRideAnimLoopBone", indexes);
            packet.ReadSByte("PassengerAttachmentID", indexes);
            packet.ReadSingle("PassengerYaw", indexes);
            packet.ReadSingle("PassengerPitch", indexes);
            packet.ReadSingle("PassengerRoll", indexes);
            packet.ReadSingle("VehicleEnterAnimDelay", indexes);
            packet.ReadSingle("VehicleExitAnimDelay", indexes);
            packet.ReadSByte("VehicleAbilityDisplay", indexes);
            packet.ReadUInt32("EnterUISoundID", indexes);
            packet.ReadUInt32("ExitUISoundID", indexes);
            packet.ReadInt32("UiSkinFileDataID", indexes);
            packet.ReadInt32("UiSkin", indexes);
            packet.ReadSingle("CameraEnteringDelay", indexes);
            packet.ReadSingle("CameraEnteringDuration", indexes);
            packet.ReadSingle("CameraExitingDelay", indexes);
            packet.ReadSingle("CameraExitingDuration", indexes);
            packet.ReadSingle("CameraPosChaseRate", indexes);
            packet.ReadSingle("CameraFacingChaseRate", indexes);
            packet.ReadSingle("CameraEnteringZoom", indexes);
            packet.ReadSingle("CameraSeatZoomMin", indexes);
            packet.ReadSingle("CameraSeatZoomMax", indexes);
            packet.ReadInt16("EnterAnimKitID", indexes);
            packet.ReadInt16("RideAnimKitID", indexes);
            packet.ReadInt16("ExitAnimKitID", indexes);
            packet.ReadInt16("VehicleEnterAnimKitID", indexes);
            packet.ReadInt16("VehicleRideAnimKitID", indexes);
            packet.ReadInt16("VehicleExitAnimKitID", indexes);
            packet.ReadInt16("CameraModeID", indexes);
        }

        public static void VehicleSeatHandler342(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadSingle("AttachmentOffsetX", indexes);
            packet.ReadSingle("AttachmentOffsetY", indexes);
            packet.ReadSingle("AttachmentOffsetZ", indexes);
            packet.ReadSingle("CameraOffsetX", indexes);
            packet.ReadSingle("CameraOffsetY", indexes);
            packet.ReadSingle("CameraOffsetZ", indexes);
            packet.ReadInt32("Flags", indexes);
            packet.ReadInt32("FlagsB", indexes);
            packet.ReadInt32("FlagsC", indexes);
            packet.ReadSByte("AttachmentID", indexes);
            packet.ReadSingle("EnterPreDelay", indexes);
            packet.ReadSingle("EnterSpeed", indexes);
            packet.ReadSingle("EnterGravity", indexes);
            packet.ReadSingle("EnterMinDuration", indexes);
            packet.ReadSingle("EnterMaxDuration", indexes);
            packet.ReadSingle("EnterMinArcHeight", indexes);
            packet.ReadSingle("EnterMaxArcHeight", indexes);
            packet.ReadInt32("EnterAnimStart", indexes);
            packet.ReadInt32("EnterAnimLoop", indexes);
            packet.ReadInt32("RideAnimStart", indexes);
            packet.ReadInt32("RideAnimLoop", indexes);
            packet.ReadInt32("RideUpperAnimStart", indexes);
            packet.ReadInt32("RideUpperAnimLoop", indexes);
            packet.ReadSingle("ExitPreDelay", indexes);
            packet.ReadSingle("ExitSpeed", indexes);
            packet.ReadSingle("ExitGravity", indexes);
            packet.ReadSingle("ExitMinDuration", indexes);
            packet.ReadSingle("ExitMaxDuration", indexes);
            packet.ReadSingle("ExitMinArcHeight", indexes);
            packet.ReadSingle("ExitMaxArcHeight", indexes);
            packet.ReadInt32("ExitAnimStart", indexes);
            packet.ReadInt32("ExitAnimLoop", indexes);
            packet.ReadInt32("ExitAnimEnd", indexes);
            packet.ReadInt16("VehicleEnterAnim", indexes);
            packet.ReadSByte("VehicleEnterAnimBone", indexes);
            packet.ReadInt16("VehicleExitAnim", indexes);
            packet.ReadSByte("VehicleExitAnimBone", indexes);
            packet.ReadInt16("VehicleRideAnimLoop", indexes);
            packet.ReadSByte("VehicleRideAnimLoopBone", indexes);
            packet.ReadSByte("PassengerAttachmentID", indexes);
            packet.ReadSingle("PassengerYaw", indexes);
            packet.ReadSingle("PassengerPitch", indexes);
            packet.ReadSingle("PassengerRoll", indexes);
            packet.ReadSingle("VehicleEnterAnimDelay", indexes);
            packet.ReadSingle("VehicleExitAnimDelay", indexes);
            packet.ReadSByte("VehicleAbilityDisplay", indexes);
            packet.ReadUInt32("EnterUISoundID", indexes);
            packet.ReadUInt32("ExitUISoundID", indexes);
            packet.ReadInt32("UiSkinFileDataID", indexes);
            packet.ReadInt32("UiSkin", indexes);
            packet.ReadSingle("CameraEnteringDelay", indexes);
            packet.ReadSingle("CameraEnteringDuration", indexes);
            packet.ReadSingle("CameraExitingDelay", indexes);
            packet.ReadSingle("CameraExitingDuration", indexes);
            packet.ReadSingle("CameraPosChaseRate", indexes);
            packet.ReadSingle("CameraFacingChaseRate", indexes);
            packet.ReadSingle("CameraEnteringZoom", indexes);
            packet.ReadSingle("CameraSeatZoomMin", indexes);
            packet.ReadSingle("CameraSeatZoomMax", indexes);
            packet.ReadInt16("EnterAnimKitID", indexes);
            packet.ReadInt16("RideAnimKitID", indexes);
            packet.ReadInt16("ExitAnimKitID", indexes);
            packet.ReadInt16("VehicleEnterAnimKitID", indexes);
            packet.ReadInt16("VehicleRideAnimKitID", indexes);
            packet.ReadInt16("VehicleExitAnimKitID", indexes);
            packet.ReadInt16("CameraModeID", indexes);
        }

        public static void WmoAreaTableHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("AreaName", indexes);
            packet.ReadUInt32("ID", indexes);
            packet.ReadUInt16("WmoID", indexes);
            packet.ReadByte("NameSetID", indexes);
            packet.ReadInt32("WmoGroupID", indexes);
            packet.ReadByte("SoundProviderPref", indexes);
            packet.ReadByte("SoundProviderPrefUnderwater", indexes);
            packet.ReadUInt16("AmbienceID", indexes);
            packet.ReadUInt16("UwAmbience", indexes);
            packet.ReadUInt16("ZoneMusic", indexes);
            packet.ReadUInt32("UwZoneMusic", indexes);
            packet.ReadUInt16("IntroSound", indexes);
            packet.ReadUInt16("UwIntroSound", indexes);
            packet.ReadUInt16("AreaTableID", indexes);
            packet.ReadByte("Flags", indexes);
        }

        public static void WorldEffectHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("QuestFeedbackEffectID", indexes);
            packet.ReadByte("WhenToDisplay", indexes);
            packet.ReadByte("TargetType", indexes);
            packet.ReadInt32("TargetAsset", indexes);
            packet.ReadUInt32("PlayerConditionID", indexes);
            packet.ReadUInt16("CombatConditionID", indexes);
        }

        public static void WorldMapOverlayHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadUInt32("ID", indexes);
            packet.ReadUInt32("UiMapArtID", indexes);
            packet.ReadUInt16("TextureWidth", indexes);
            packet.ReadUInt16("TextureHeight", indexes);
            packet.ReadInt32("OffsetX", indexes);
            packet.ReadInt32("OffsetY", indexes);
            packet.ReadInt32("HitRectTop", indexes);
            packet.ReadInt32("HitRectBottom", indexes);
            packet.ReadInt32("HitRectLeft", indexes);
            packet.ReadInt32("HitRectRight", indexes);
            packet.ReadUInt32("PlayerConditionID", indexes);
            packet.ReadUInt32("Flags", indexes);
            for (int i = 0; i < 4; i++)
                packet.ReadUInt32("AreaID", indexes, i);
        }

        public static void WorldStateExpressionHandler340(Packet packet, uint entry, params object[] indexes)
        {
            packet.ReadCString("Expression", indexes);
        }

        static void ReadHotfixContent(Packet packet, DB2Hash tableHash, uint entry, byte[] data, Packet db2File, params object[] indexes)
        {
            switch (tableHash)
            {
                case DB2Hash.Achievement:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_3_51666))
                        AchievementHandler343(db2File, entry, indexes);
                    else
                        AchievementHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.AchievementCategory:
                {
                    AchievementCategoryHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.AdventureJournal:
                {
                    AdventureJournalHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.AdventureMapPoi:
                {
                    AdventureMapPOIHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.AnimationData:
                {
                    AnimationDataHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.AnimKit:
                {
                    AnimKitHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.AreaGroupMember:
                {
                    AreaGroupMemberHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.AreaTable:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_3_51666))
                        AreaTableHandler343(db2File, entry, indexes);
                    else
                        AreaTableHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.AreaTrigger:
                {
                    AreaTriggerHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ArmorLocation:
                {
                    ArmorLocationHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.Artifact:
                {
                    ArtifactHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ArtifactAppearance:
                {
                    ArtifactAppearanceHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ArtifactAppearanceSet:
                {
                    ArtifactAppearanceSetHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ArtifactCategory:
                {
                    ArtifactCategoryHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ArtifactPower:
                {
                    ArtifactPowerHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ArtifactPowerLink:
                {
                    ArtifactPowerLinkHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ArtifactPowerPicker:
                {
                    ArtifactPowerPickerHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ArtifactPowerRank:
                {
                    ArtifactPowerRankHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ArtifactQuestXp:
                {
                    ArtifactQuestXpHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ArtifactTier:
                {
                    ArtifactTierHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ArtifactUnlock:
                {
                    ArtifactUnlockHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.AuctionHouse:
                {
                    AuctionHouseHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.AzeriteEmpoweredItem:
                {
                    AzeriteEmpoweredItemHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.AzeriteEssence:
                {
                    AzeriteEssenceHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.AzeriteEssencePower:
                {
                    AzeriteEssencePowerHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.AzeriteItem:
                {
                    AzeriteItemHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.AzeriteItemMilestonePower:
                {
                    AzeriteItemMilestonePowerHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.AzeriteKnowledgeMultiplier:
                {
                    AzeriteKnowledgeMultiplierHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.AzeriteLevelInfo:
                {
                    AzeriteLevelInfoHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.AzeritePower:
                {
                    AzeritePowerHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.AzeritePowerSetMember:
                {
                    AzeritePowerSetMemberHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.AzeriteTierUnlock:
                {
                    AzeriteTierUnlockHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.AzeriteTierUnlockSet:
                {
                    AzeriteTierUnlockSetHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.BankBagSlotPrices:
                {
                    BankBagSlotPricesHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.BannedAddons:
                {
                    BannedAddonsHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.BarberShopStyle:
                {
                    BarberShopStyleHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.BattlePetAbility:
                {
                    BattlePetAbilityHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.BattlePetBreedQuality:
                {
                    BattlePetBreedQualityHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.BattlePetBreedState:
                {
                    BattlePetBreedStateHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.BattlePetSpecies:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        BattlePetSpeciesHandler341(db2File, entry, indexes);
                    else
                        BattlePetSpeciesHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.BattlePetSpeciesState:
                {
                    BattlePetSpeciesStateHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.BattlemasterList:
                {
                    BattlemasterListHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.BroadcastText:
                {
                    BroadcastTextHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.CfgCategories:
                {
                    CfgCategoriesHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.CfgRegions:
                {
                    CfgRegionsHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.CharTitles:
                {
                    CharTitlesHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.CharacterLoadout:
                {
                    CharacterLoadoutHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.CharacterLoadoutItem:
                {
                    CharacterLoadoutItemHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ChatChannels:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_3_51666))
                        ChatChannelsHandler343(db2File, entry, indexes);
                    else
                        ChatChannelsHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ChrClassUiDisplay:
                {
                    ChrClassUiDisplayHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ChrClasses:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_3_51666))
                        ChrClassesHandler343(db2File, entry, indexes);
                    else
                        ChrClassesHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ChrClassesXPowerTypes:
                {
                    ChrClassesXPowerTypesHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ChrCustomizationChoice:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_2_50129))
                        ChrCustomizationChoiceHandler342(db2File, entry, indexes);
                    else if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        ChrCustomizationChoiceHandler341(db2File, entry, indexes);
                    else
                        ChrCustomizationChoiceHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ChrCustomizationDisplayInfo:
                {
                    ChrCustomizationDisplayInfoHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ChrCustomizationElement:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_3_51666))
                        ChrCustomizationElementHandler343(db2File, entry, indexes);
                    else if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_2_50129))
                        ChrCustomizationElementHandler342(db2File, entry, indexes);
                    else if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        ChrCustomizationElementHandler341(db2File, entry, indexes);
                    else
                        ChrCustomizationElementHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ChrCustomizationOption:
                {
                    ChrCustomizationOptionHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ChrCustomizationReq:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_3_51666))
                        ChrCustomizationReqHandler343(db2File, entry, indexes);
                    else if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        ChrCustomizationReqHandler341(db2File, entry, indexes);
                    else
                        ChrCustomizationReqHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ChrCustomizationReqChoice:
                {
                    ChrCustomizationReqChoiceHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ChrModel:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        ChrModelHandler341(db2File, entry, indexes);
                    else
                        ChrModelHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ChrRaceXChrModel:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        ChrRaceXChrModelHandler341(db2File, entry, indexes);
                    else
                        ChrRaceXChrModelHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ChrRaces:
                {
                    ChrRacesHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ChrSpecialization:
                {
                    ChrSpecializationHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.CinematicCamera:
                {
                    CinematicCameraHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.CinematicSequences:
                {
                    CinematicSequencesHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ConditionalChrModel:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_3_51666))
                        ConditionalChrModelHandler343(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ConditionalContentTuning:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_3_51666))
                        ConditionalContentTuningHandler343(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ContentTuning:
                {
                    ContentTuningHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ConversationLine:
                {
                    ConversationLineHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.CreatureDisplayInfo:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        CreatureDisplayInfoHandler341(db2File, entry, indexes);
                    else
                        CreatureDisplayInfoHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.CreatureDisplayInfoExtra:
                {
                    CreatureDisplayInfoExtraHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.CreatureFamily:
                {
                    CreatureFamilyHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.CreatureModelData:
                {
                    CreatureModelDataHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.CreatureType:
                {
                    CreatureTypeHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.Criteria:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_3_51666))
                        CriteriaHandler343(db2File, entry, indexes);
                    else
                        CriteriaHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.CriteriaTree:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_3_51666))
                        CriteriaTreeHandler343(db2File, entry, indexes);
                    else
                        CriteriaTreeHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.CurrencyContainer:
                {
                    CurrencyContainerHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.CurrencyTypes:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_3_51666))
                        CurrencyTypesHandler343(db2File, entry, indexes);
                    else
                        CurrencyTypesHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.Curve:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        CurveHandler341(db2File, entry, indexes);
                    else
                        CurveHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.CurvePoint:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_2_50129))
                        CurvePointHandler342(db2File, entry, indexes);
                    else if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        CurvePointHandler341(db2File, entry, indexes);
                    else
                        CurvePointHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.DestructibleModelData:
                {
                    DestructibleModelDataHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.Difficulty:
                {
                    DifficultyHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.DungeonEncounter:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_3_51666))
                        DungeonEncounterHandler343(db2File, entry, indexes);
                    else if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        DungeonEncounterHandler341(db2File, entry, indexes);
                    else
                        DungeonEncounterHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.DurabilityCosts:
                {
                    DurabilityCostsHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.DurabilityQuality:
                {
                    DurabilityQualityHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.Emotes:
                {
                    EmotesHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.EmotesText:
                {
                    EmotesTextHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.EmotesTextSound:
                {
                    EmotesTextSoundHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ExpectedStat:
                {
                    ExpectedStatHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ExpectedStatMod:
                {
                    ExpectedStatModHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.Faction:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        FactionHandler341(db2File, entry, indexes);
                    else
                        FactionHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.FactionTemplate:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        FactionTemplateHandler341(db2File, entry, indexes);
                    else
                        FactionTemplateHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.FriendshipRepReaction:
                {
                    FriendshipRepReactionHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.FriendshipReputation:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        FriendshipReputationHandler341(db2File, entry, indexes);
                    else
                        FriendshipReputationHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.GameobjectArtKit:
                {
                    GameobjectArtKitHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.GameobjectDisplayInfo:
                {
                    GameobjectDisplayInfoHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.Gameobjects:
                {
                    GameobjectsHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.GarrAbility:
                {
                    GarrAbilityHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.GarrBuilding:
                {
                    GarrBuildingHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.GarrBuildingPlotInst:
                {
                    GarrBuildingPlotInstHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.GarrClassSpec:
                {
                    GarrClassSpecHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.GarrFollower:
                {
                    GarrFollowerHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.GarrFollowerXAbility:
                {
                    GarrFollowerXAbilityHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.GarrMission:
                {
                    GarrMissionHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.GarrPlot:
                {
                    GarrPlotHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.GarrPlotBuilding:
                {
                    GarrPlotBuildingHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.GarrPlotInstance:
                {
                    GarrPlotInstanceHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.GarrSiteLevel:
                {
                    GarrSiteLevelHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.GarrSiteLevelPlotInst:
                {
                    GarrSiteLevelPlotInstHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.GarrTalentTree:
                {
                    GarrTalentTreeHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.GemProperties:
                {
                    GemPropertiesHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.GlyphBindableSpell:
                {
                    GlyphBindableSpellHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.GlyphSlot:
                {
                    GlyphSlotHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.GlyphProperties:
                {
                    GlyphPropertiesHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.GlyphRequiredSpec:
                {
                    GlyphRequiredSpecHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.GossipNpcOption:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        GossipNPCOptionHandler341(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.GuildColorBackground:
                {
                    GuildColorBackgroundHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.GuildColorBorder:
                {
                    GuildColorBorderHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.GuildColorEmblem:
                {
                    GuildColorEmblemHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.GuildPerkSpells:
                {
                    GuildPerkSpellsHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.Heirloom:
                {
                    HeirloomHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.Holidays:
                {
                    HolidaysHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ImportPriceArmor:
                {
                    ImportPriceArmorHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ImportPriceQuality:
                {
                    ImportPriceQualityHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ImportPriceShield:
                {
                    ImportPriceShieldHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ImportPriceWeapon:
                {
                    ImportPriceWeaponHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.Item:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        ItemHandler341(db2File, entry, indexes);
                    else
                        ItemHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ItemAppearance:
                {
                    ItemAppearanceHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ItemArmorQuality:
                {
                    ItemArmorQualityHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ItemArmorShield:
                {
                    ItemArmorShieldHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ItemArmorTotal:
                {
                    ItemArmorTotalHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ItemBagFamily:
                {
                    ItemBagFamilyHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ItemBonus:
                {
                    ItemBonusHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ItemBonusListLevelDelta:
                {
                    ItemBonusListLevelDeltaHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ItemBonusTreeNode:
                {
                    ItemBonusTreeNodeHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ItemChildEquipment:
                {
                    ItemChildEquipmentHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ItemClass:
                {
                    ItemClassHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ItemContextPickerEntry:
                {
                    ItemContextPickerEntryHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ItemCurrencyCost:
                {
                    ItemCurrencyCostHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ItemDamageAmmo:
                {
                    ItemDamageAmmoHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ItemDamageOneHand:
                {
                    ItemDamageOneHandHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ItemDamageOneHandCaster:
                {
                    ItemDamageOneHandCasterHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ItemDamageTwoHand:
                {
                    ItemDamageTwoHandHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ItemDamageTwoHandCaster:
                {
                    ItemDamageTwoHandCasterHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ItemDisenchantLoot:
                {
                    ItemDisenchantLootHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ItemEffect:
                {
                    ItemEffectHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ItemExtendedCost:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        ItemExtendedCostHandler341(db2File, entry, indexes);
                    else
                        ItemExtendedCostHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ItemLevelSelector:
                {
                    ItemLevelSelectorHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ItemLevelSelectorQuality:
                {
                    ItemLevelSelectorQualityHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ItemLevelSelectorQualitySet:
                {
                    ItemLevelSelectorQualitySetHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ItemLimitCategory:
                {
                    ItemLimitCategoryHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ItemLimitCategoryCondition:
                {
                    ItemLimitCategoryConditionHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ItemModifiedAppearance:
                {
                    ItemModifiedAppearanceHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ItemModifiedAppearanceExtra:
                {
                    ItemModifiedAppearanceExtraHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ItemNameDescription:
                {
                    ItemNameDescriptionHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ItemPriceBase:
                {
                    ItemPriceBaseHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ItemSearchName:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_2_50129))
                        ItemSearchNameHandler342(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ItemSet:
                {
                    ItemSetHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ItemSetSpell:
                {
                    ItemSetSpellHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ItemSparse:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        ItemSparseHandler341(db2File, entry, indexes);
                    else
                        ItemSparseHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ItemSpec:
                {
                    ItemSpecHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ItemSpecOverride:
                {
                    ItemSpecOverrideHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ItemXBonusTree:
                {
                    ItemXBonusTreeHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.JournalEncounter:
                {
                    JournalEncounterHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.JournalEncounterSection:
                {
                    JournalEncounterSectionHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.JournalInstance:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        JournalInstanceHandler341(db2File, entry, indexes);
                    else
                        JournalInstanceHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.JournalTier:
                {
                    JournalTierHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.Keychain:
                {
                    KeychainHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.KeystoneAffix:
                {
                    KeystoneAffixHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.LanguageWords:
                {
                    LanguageWordsHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.Languages:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_2_50129))
                        LanguagesHandler342(db2File, entry, indexes);
                    else
                        LanguagesHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.LfgDungeons:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        LfgDungeonsHandler341(db2File, entry, indexes);
                    else
                        LfgDungeonsHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.Light:
                {
                    LightHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.LiquidType:
                {
                    LiquidTypeHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.Lock:
                {
                    LockHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.MailTemplate:
                {
                    MailTemplateHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.Map:
                {
                    MapHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.MapChallengeMode:
                {
                    MapChallengeModeHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.MapDifficulty:
                {
                    MapDifficultyHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.MapDifficultyXCondition:
                {
                    MapDifficultyXConditionHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ModifierTree:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_3_51666))
                        ModifierTreeHandler343(db2File, entry, indexes);
                    else
                        ModifierTreeHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.Mount:
                {
                    MountHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.MountCapability:
                {
                    MountCapabilityHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.MountTypeXCapability:
                {
                    MountTypeXCapabilityHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.MountXDisplay:
                {
                    MountXDisplayHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.Movie:
                {
                    MovieHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.MythicPlusSeason:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_2_50129))
                        MythicPlusSeasonHandler342(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.NameGen:
                {
                    NameGenHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.NamesProfanity:
                {
                    NamesProfanityHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.NamesReserved:
                {
                    NamesReservedHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.NamesReservedLocale:
                {
                    NamesReservedLocaleHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.NumTalentsAtLevel:
                {
                    NumTalentsAtLevelHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.OverrideSpellData:
                {
                    OverrideSpellDataHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ParagonReputation:
                {
                    ParagonReputationHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.Phase:
                {
                    PhaseHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.PhaseXPhaseGroup:
                {
                    PhaseXPhaseGroupHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.PlayerCondition:
                {
                    PlayerConditionHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.PowerDisplay:
                {
                    PowerDisplayHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.PowerType:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        PowerTypeHandler341(db2File, entry, indexes);
                    else
                        PowerTypeHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.PrestigeLevelInfo:
                {
                    PrestigeLevelInfoHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.PvpDifficulty:
                {
                    PvpDifficultyHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.PvpItem:
                {
                    PvpItemHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.PvpSeason:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_2_50129))
                        PvpSeasonHandler342(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.PvpTalent:
                {
                    PvpTalentHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.PvpTalentCategory:
                {
                    PvpTalentCategoryHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.PvpTalentSlotUnlock:
                {
                    PvpTalentSlotUnlockHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.PvpTier:
                {
                    PvpTierHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.QuestFactionReward:
                {
                    QuestFactionRewardHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.QuestInfo:
                {
                    QuestInfoHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.QuestLineXQuest:
                {
                    QuestLineXQuestHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.QuestMoneyReward:
                {
                    QuestMoneyRewardHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.QuestPackageItem:
                {
                    QuestPackageItemHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.QuestSort:
                {
                    QuestSortHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.QuestV2:
                {
                    QuestV2Handler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.QuestXp:
                {
                    QuestXpHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.RandPropPoints:
                {
                    RandPropPointsHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.RewardPack:
                {
                    RewardPackHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.RewardPackXCurrencyType:
                {
                    RewardPackXCurrencyTypeHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.RewardPackXItem:
                {
                    RewardPackXItemHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.Scenario:
                {
                    ScenarioHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ScenarioStep:
                {
                    ScenarioStepHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ScalingStatDistribution:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        ScalingStatDistributionHandler341(db2File, entry, indexes);
                    else
                        ScalingStatDistributionHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ScalingStatValues:
                {
                    ScalingStatValuesHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SceneScript:
                {
                    SceneScriptHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SceneScriptGlobalText:
                {
                    SceneScriptGlobalTextHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SceneScriptPackage:
                {
                    SceneScriptPackageHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SceneScriptText:
                {
                    SceneScriptTextHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.ServerMessages:
                {
                    ServerMessagesHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SkillLine:
                {
                    SkillLineHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SkillLineAbility:
                {
                    SkillLineAbilityHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SkillLineXTraitTree:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        SkillLineXTraitTreeHandler341(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SkillRaceClassInfo:
                {
                    SkillRaceClassInfoHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SoundKit:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        SoundKitHandler341(db2File, entry, indexes);
                    else
                        SoundKitHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SpecializationSpells:
                {
                    SpecializationSpellsHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SpecSetMember:
                {
                    SpecSetMemberHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SpellAuraOptions:
                {
                    SpellAuraOptionsHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SpellAuraRestrictions:
                {
                    SpellAuraRestrictionsHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SpellCastTimes:
                {
                    SpellCastTimesHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SpellCastingRequirements:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        SpellCastingRequirementsHandler341(db2File, entry, indexes);
                    else
                        SpellCastingRequirementsHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SpellCategories:
                {
                    SpellCategoriesHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SpellCategory:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_3_51666))
                        SpellCategoryHandler343(db2File, entry, indexes);
                    else
                        SpellCategoryHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SpellClassOptions:
                {
                    SpellClassOptionsHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SpellCooldowns:
                {
                    SpellCooldownsHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SpellDuration:
                {
                    SpellDurationHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SpellEffect:
                {
                    SpellEffectHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SpellEquippedItems:
                {
                    SpellEquippedItemsHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SpellFocusObject:
                {
                    SpellFocusObjectHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SpellInterrupts:
                {
                    SpellInterruptsHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SpellItemEnchantment:
                {
                    SpellItemEnchantmentHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SpellItemEnchantmentCondition:
                {
                    SpellItemEnchantmentConditionHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SpellKeyboundOverride:
                {
                    SpellKeyboundOverrideHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SpellLabel:
                {
                    SpellLabelHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SpellLearnSpell:
                {
                    SpellLearnSpellHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SpellLevels:
                {
                    SpellLevelsHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SpellMisc:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        SpellMiscHandler341(db2File, entry, indexes);
                    else
                        SpellMiscHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SpellName:
                {
                    SpellNameHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SpellPower:
                {
                    SpellPowerHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SpellPowerDifficulty:
                {
                    SpellPowerDifficultyHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SpellProcsPerMinute:
                {
                    SpellProcsPerMinuteHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SpellProcsPerMinuteMod:
                {
                    SpellProcsPerMinuteModHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SpellRadius:
                {
                    SpellRadiusHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SpellRange:
                {
                    SpellRangeHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SpellReagents:
                {
                    SpellReagentsHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SpellReagentsCurrency:
                {
                    SpellReagentsCurrencyHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SpellScaling:
                {
                    SpellScalingHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SpellShapeshift:
                {
                    SpellShapeshiftHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SpellShapeshiftForm:
                {
                    SpellShapeshiftFormHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SpellTargetRestrictions:
                {
                    SpellTargetRestrictionsHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SpellTotems:
                {
                    SpellTotemsHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SpellVisual:
                {
                    SpellVisualHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SpellVisualEffectName:
                {
                    SpellVisualEffectNameHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SpellVisualMissile:
                {
                    SpellVisualMissileHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SpellVisualKit:
                {
                    SpellVisualKitHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SpellXSpellVisual:
                {
                    SpellXSpellVisualHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.SummonProperties:
                {
                    SummonPropertiesHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.TactKey:
                {
                    TactKeyHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.Talent:
                {
                    TalentHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.TalentTab:
                {
                    TalentTabHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.TaxiNodes:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_3_51666))
                        TaxiNodesHandler343(db2File, entry, indexes);
                    else
                        TaxiNodesHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.TaxiPath:
                {
                    TaxiPathHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.TaxiPathNode:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_3_51666))
                        TaxiPathNodeHandler343(db2File, entry, indexes);
                    else
                        TaxiPathNodeHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.TotemCategory:
                {
                    TotemCategoryHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.Toy:
                {
                    ToyHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.TransmogHoliday:
                {
                    TransmogHolidayHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.TraitCond:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        TraitCondHandler341(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.TraitCost:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        TraitCostHandler341(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.TraitCurrency:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        TraitCurrencyHandler341(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.TraitCurrencySource:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        TraitCurrencySourceHandler341(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.TraitDefinition:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        TraitDefinitionHandler341(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.TraitDefinitionEffectPoints:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        TraitDefinitionEffectPointsHandler341(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.TraitEdge:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        TraitEdgeHandler341(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.TraitNode:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        TraitNodeHandler341(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.TraitNodeEntry:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        TraitNodeEntryHandler341(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.TraitNodeEntryXTraitCond:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        TraitNodeEntryXTraitCondHandler341(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.TraitNodeEntryXTraitCost:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        TraitNodeEntryXTraitCostHandler341(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.TraitNodeGroup:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        TraitNodeGroupHandler341(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.TraitNodeGroupXTraitCond:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        TraitNodeGroupXTraitCondHandler341(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.TraitNodeGroupXTraitCost:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        TraitNodeGroupXTraitCostHandler341(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.TraitNodeGroupXTraitNode:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        TraitNodeGroupXTraitNodeHandler341(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.TraitNodeXTraitCond:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        TraitNodeXTraitCondHandler341(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.TraitNodeXTraitCost:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        TraitNodeXTraitCostHandler341(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.TraitNodeXTraitNodeEntry:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        TraitNodeXTraitNodeEntryHandler341(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.TraitTree:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        TraitTreeHandler341(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.TraitTreeLoadout:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        TraitTreeLoadoutHandler341(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.TraitTreeLoadoutEntry:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        TraitTreeLoadoutEntryHandler341(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.TraitTreeXTraitCost:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        TraitTreeXTraitCostHandler341(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.TraitTreeXTraitCurrency:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                        TraitTreeXTraitCurrencyHandler341(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.TransmogSet:
                {
                    TransmogSetHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.TransmogSetGroup:
                {
                    TransmogSetGroupHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.TransmogSetItem:
                {
                    TransmogSetItemHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.TransportAnimation:
                {
                    TransportAnimationHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.TransportRotation:
                {
                    TransportRotationHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.UiMap:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_3_51666))
                        UiMapHandler343(db2File, entry, indexes);
                    else
                        UiMapHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.UiMapAssignment:
                {
                    UiMapAssignmentHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.UiMapLink:
                {
                    UiMapLinkHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.UiMapXMapArt:
                {
                    UiMapXMapArtHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.UnitCondition:
                {
                    UnitConditionHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.UnitPowerBar:
                {
                    UnitPowerBarHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.Vehicle:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_2_50129))
                        VehicleHandler342(db2File, entry, indexes);
                    else
                        VehicleHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.VehicleSeat:
                {
                    if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_2_50129))
                        VehicleSeatHandler342(db2File, entry, indexes);
                    else
                        VehicleSeatHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.WmoAreaTable:
                {
                    WmoAreaTableHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.WorldEffect:
                {
                    WorldEffectHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.WorldMapOverlay:
                {
                    WorldMapOverlayHandler340(db2File, entry, indexes);
                    break;
                }
                case DB2Hash.WorldStateExpression:
                {
                    WorldStateExpressionHandler340(db2File, entry, indexes);
                    break;
                }
                default:
                {
                    db2File.WriteLine($"(Entry: {entry} TableHash: {tableHash}) has missing structure. HotfixBlob entry generated!");
                    db2File.AsHex();
                    db2File.ReadToEnd();

                    HotfixBlob hotfixBlob = new HotfixBlob
                    {
                        TableHash = tableHash,
                        RecordID = (int)entry,
                        Blob = new Blob(data)
                    };

                    Storage.HotfixBlobs.Add(hotfixBlob);
                    break;
                }
            }

            if (db2File.Position != db2File.Length)
                HandleHotfixOptionalData(packet, tableHash, (int)entry, db2File);

            db2File.ClosePacket(false);
        }

        public class HotfixRecord
        {
            public uint HotfixId;
            public uint UniqueId;
            public DB2Hash Type;
            public int RecordId;
            public int HotfixDataSize;
            public HotfixStatus Status;
        }

        static void ReadHotfixData(Packet packet, List<HotfixRecord> records, params object[] indexes)
        {
            int count = 0;
            foreach (var record in records)
            {
                var hotfixId = packet.AddValue("HotfixID", record.HotfixId, count, indexes, "HotfixRecord");
                var uniqueId = packet.AddValue("UniqueID", record.UniqueId, count, indexes, "HotfixRecord");
                var type = packet.AddValue("TableHash", record.Type, count, indexes, "HotfixRecord");
                var entry = packet.AddValue("RecordID", record.RecordId, count, indexes, "HotfixRecord");
                var dataSize = packet.AddValue("Size", record.HotfixDataSize, count, indexes, "HotfixRecord");
                var status = packet.AddValue("Status", record.Status, count, indexes, "HotfixRecord");
                var data = packet.ReadBytes(dataSize);
                var db2File = new Packet(data, packet.Opcode, packet.Time, packet.Direction, packet.Number, packet.Writer, packet.FileName);

                switch (status)
                {
                    case HotfixStatus.Valid:
                    {
                        packet.AddSniffData(StoreNameType.None, entry, type.ToString());

                        ReadHotfixContent(packet, type, (uint)entry, data, db2File, count);
                        break;
                    }
                    case HotfixStatus.RecordRemoved:
                    {
                        packet.WriteLine($"RecID {entry} has been removed.");
                        break;
                    }
                    case HotfixStatus.Invalid:
                    {
                        packet.WriteLine($"Hotfix with RecID {entry} is invalid.");
                        break;
                    }
                    case HotfixStatus.NotPublic:
                    {
                        packet.WriteLine($"RecID {entry} is not public.");
                        break;
                    }
                    default:
                    {
                        packet.WriteLine($"Unhandled status: {status}");
                        break;
                    }
                }

                HotfixData hotfixData = new HotfixData
                {
                    ID = hotfixId,
                    UniqueID = uniqueId,
                    TableHash = type,
                    RecordID = entry,
                    Status = status
                };

                Storage.HotfixDatas.Add(hotfixData);
                count++;
            }
        }

        private static void HandleHotfixOptionalData(Packet packet, DB2Hash type, int entry, Packet db2File)
        {
            var leftSize = db2File.Length - db2File.Position;
            var backupPosition = db2File.Position;

            // 28 bytes = size of TactKey optional data
            if (leftSize % 28 == 0)
            {
                var tactKeyCount = leftSize / 28;

                for (int i = 0; i < tactKeyCount; ++i)
                {
                    // get hash, we need to verify
                    var hash = db2File.ReadUInt32E<DB2Hash>();

                    // check if hash is valid hash, we only support TactKey optional data yet
                    if (hash == DB2Hash.TactKey)
                    {
                        // read optional data
                        var optionalData = db2File.ReadBytes(24);

                        packet.AddValue($"(OptionalData) [{i}] Key:", hash);
                        packet.AddValue($"(OptionalData) [{i}] OptionalData:", Convert.ToBase64String(optionalData));

                        HotfixOptionalData hotfixOptionalData = new HotfixOptionalData
                        {
                            // data to link the optional data to correct hotfix
                            TableHash = type,
                            RecordID = entry,
                            Key = hash,

                            Data = new Blob(optionalData)
                        };

                        Storage.HotfixOptionalDatas.Add(hotfixOptionalData);
                    }
                    else
                    {
                        db2File.SetPosition(backupPosition);
                        db2File.WriteLine($"(Entry: {entry} TableHash: {type}) has incorrect structure OR optional data. PacketLength: {db2File.Length} CurrentPosition: {db2File.Position}");
                        db2File.AsHex();
                    }
                }
            }
            else
            {
                db2File.WriteLine($"(Entry: {entry} TableHash: {type}) has incorrect structure OR optional data. PacketLength: {db2File.Length} CurrentPosition: {db2File.Position}");
                db2File.AsHex();
            }
        }

        [HasSniffData]
        [Parser(Opcode.SMSG_HOTFIX_MESSAGE)]
        [Parser(Opcode.SMSG_HOTFIX_CONNECT)]
        public static void HandleHotixData815(Packet packet)
        {
            var hotfixRecords = new List<HotfixRecord>();
            var hotfixCount = packet.ReadUInt32("HotfixCount");

            for (var i = 0u; i < hotfixCount; ++i)
            {
                var hotfixRecord = new HotfixRecord();
                packet.ResetBitReader();

                hotfixRecord.HotfixId = packet.ReadUInt32();
                hotfixRecord.UniqueId = packet.ReadUInt32();
                hotfixRecord.Type = packet.ReadUInt32E<DB2Hash>();
                hotfixRecord.RecordId = packet.ReadInt32();
                hotfixRecord.HotfixDataSize = packet.ReadInt32();
                packet.ResetBitReader();
                hotfixRecord.Status = (HotfixStatus)packet.ReadBits(3);

                hotfixRecords.Add(hotfixRecord);
            }

            var dataSize = packet.ReadInt32("HotfixDataSize");
            var data = packet.ReadBytes(dataSize);
            var hotfixData = new Packet(data, packet.Opcode, packet.Time, packet.Direction, packet.Number, packet.Writer, packet.FileName);

            ReadHotfixData(hotfixData, hotfixRecords, "HotfixData");
        }

        [HasSniffData]
        [Parser(Opcode.SMSG_DB_REPLY)]
        public static void HandleDBReply(Packet packet)
        {
            var type = packet.ReadUInt32E<DB2Hash>("TableHash");
            var entry = packet.ReadInt32("RecordID");
            var timeStamp = packet.ReadUInt32();
            var time = packet.AddValue("Timestamp", Utilities.GetDateTimeFromUnixTime(timeStamp));
            var status = packet.ReadBitsE<HotfixStatus>("Status", 3);

            var size = packet.ReadInt32("Size");
            var data = packet.ReadBytes(size);
            var db2File = new Packet(data, packet.Opcode, packet.Time, packet.Direction, packet.Number, packet.Writer, packet.FileName);

            switch (status)
            {
                case HotfixStatus.Valid:
                {
                    ReadHotfixContent(packet, type, (uint)entry, data, db2File);
                    break;
                }
                case HotfixStatus.RecordRemoved:
                {
                    packet.WriteLine($"RecID {entry} has been removed.");
                    break;
                }
                case HotfixStatus.Invalid:
                {
                    packet.WriteLine($"DbReply with RecID {entry} is invalid.");
                    break;
                }
                case HotfixStatus.NotPublic:
                {
                    packet.WriteLine($"RecID {entry} is not public.");
                    break;
                }
                default:
                {
                    packet.WriteLine($"Unhandled status: {status}");
                    break;
                }
            }
        }
    }
}
