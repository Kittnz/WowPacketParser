using WowPacketParser.Misc;

namespace WowPacketParser.Enums.Version.V3_4_0_45166
{
    public static class Opcodes_3_4_0
    {
        public static BiDictionary<Opcode, int> Opcodes(Direction direction)
        {
            switch (direction)
            {
                case Direction.ClientToServer:
                    return ClientOpcodes;
                case Direction.ServerToClient:
                    return ServerOpcodes;
                default:
                    return MiscOpcodes;
            }
        }

        private static readonly BiDictionary<Opcode, int> ClientOpcodes = new BiDictionary<Opcode, int>
        {
            { Opcode.CMSG_ACCEPT_GUILD_INVITE, 0x35FD },
            { Opcode.CMSG_ACCEPT_TRADE, 0x315A },
            { Opcode.CMSG_ACCEPT_WARGAME_INVITE, 0x35E1 },
            { Opcode.CMSG_ACCOUNT_NOTIFICATION_ACKNOWLEDGED, 0x373B },
            { Opcode.CMSG_ACTIVATE_TAXI, 0x34AB },
            { Opcode.CMSG_ADDON_LIST, 0x35D8 },
            { Opcode.CMSG_ADD_BATTLENET_FRIEND, 0x365B },
            { Opcode.CMSG_ADD_FRIEND, 0x36D5 },
            { Opcode.CMSG_ADD_IGNORE, 0x36D9 },
            { Opcode.CMSG_ADVENTURE_JOURNAL_OPEN_QUEST, 0x3201 },
            { Opcode.CMSG_ALTER_APPEARANCE, 0x34F5 },
            { Opcode.CMSG_AREA_SPIRIT_HEALER_QUERY, 0x34B0 },
            { Opcode.CMSG_AREA_SPIRIT_HEALER_QUEUE, 0x34B1 },
            { Opcode.CMSG_AREA_TRIGGER, 0x31D7 },
            { Opcode.CMSG_ARENA_TEAM_ACCEPT, 0x36B6 },
            { Opcode.CMSG_ARENA_TEAM_DECLINE, 0x36B7 },
            { Opcode.CMSG_ARENA_TEAM_DISBAND, 0x36BA },
            { Opcode.CMSG_ARENA_TEAM_LEADER, 0x36BB },
            { Opcode.CMSG_ARENA_TEAM_LEAVE, 0x36B8 },
            { Opcode.CMSG_ARENA_TEAM_QUERY, 0x36A2 },
            { Opcode.CMSG_ARENA_TEAM_REMOVE, 0x36B9 },
            { Opcode.CMSG_ARENA_TEAM_ROSTER, 0x36B5 },
            { Opcode.CMSG_ARTIFACT_ADD_POWER, 0x31AC },
            { Opcode.CMSG_ARTIFACT_SET_APPEARANCE, 0x31AE },
            { Opcode.CMSG_ASSIGN_EQUIPMENT_SET_SPEC, 0x3209 },
            { Opcode.CMSG_ATTACK_STOP, 0x3252 },
            { Opcode.CMSG_ATTACK_SWING, 0x3251 },
            { Opcode.CMSG_AUCTIONABLE_TOKEN_SELL, 0x36EB },
            { Opcode.CMSG_AUCTIONABLE_TOKEN_SELL_AT_MARKET_PRICE, 0x36EC },
            { Opcode.CMSG_AUCTION_HELLO_REQUEST, 0x34CA },
            { Opcode.CMSG_AUCTION_LIST_BIDDED_ITEMS, 0x34D0 },
            { Opcode.CMSG_AUCTION_LIST_ITEMS, 0x34CD },
            { Opcode.CMSG_AUCTION_LIST_OWNED_ITEMS, 0x34CF },
            { Opcode.CMSG_AUCTION_LIST_PENDING_SALES, 0x34D2 },
            { Opcode.CMSG_AUCTION_PLACE_BID, 0x34D1 },
            { Opcode.CMSG_AUCTION_REMOVE_ITEM, 0x34CC },
            { Opcode.CMSG_AUCTION_REPLICATE_ITEMS, 0x34CE },
            { Opcode.CMSG_AUCTION_SELL_ITEM, 0x34CB },
            { Opcode.CMSG_AUCTION_SET_FAVORITE_ITEM, 0x373C },
            { Opcode.CMSG_AUTH_CONTINUED_SESSION, 0x3766 },
            { Opcode.CMSG_AUTH_SESSION, 0x3765 },
            { Opcode.CMSG_AUTOBANK_ITEM, 0x3997 },
            { Opcode.CMSG_AUTOSTORE_BANK_ITEM, 0x3996 },
            { Opcode.CMSG_AUTO_EQUIP_ITEM, 0x3998 },
            { Opcode.CMSG_AUTO_EQUIP_ITEM_SLOT, 0x399D },
            { Opcode.CMSG_AUTO_GUILD_BANK_ITEM, 0x34B6 },
            { Opcode.CMSG_AUTO_STORE_BAG_ITEM, 0x3999 },
            { Opcode.CMSG_AUTO_STORE_GUILD_BANK_ITEM, 0x34BF },
            { Opcode.CMSG_BANKER_ACTIVATE, 0x34B3 },
            { Opcode.CMSG_BATTLEFIELD_LEAVE, 0x3176 },
            { Opcode.CMSG_BATTLEFIELD_LIST, 0x3182 },
            { Opcode.CMSG_BATTLEFIELD_PORT, 0x3525 },
            { Opcode.CMSG_BATTLEMASTER_HELLO, 0x32AA },
            { Opcode.CMSG_BATTLEMASTER_JOIN, 0x3520 },
            { Opcode.CMSG_BATTLEMASTER_JOIN_ARENA, 0x3521 },
            { Opcode.CMSG_BATTLEMASTER_JOIN_BRAWL, 0x3523 },
            { Opcode.CMSG_BATTLEMASTER_JOIN_SKIRMISH, 0x3522 },
            { Opcode.CMSG_BATTLENET_CHALLENGE_RESPONSE, 0x36D8 },
            { Opcode.CMSG_BATTLENET_REQUEST, 0x36FA },
            { Opcode.CMSG_BATTLE_PAY_ACK_FAILED_RESPONSE, 0x36D2 },
            { Opcode.CMSG_BATTLE_PAY_CANCEL_OPEN_CHECKOUT, 0x3719 },
            { Opcode.CMSG_BATTLE_PAY_CONFIRM_PURCHASE_RESPONSE, 0x36D1 },
            { Opcode.CMSG_BATTLE_PAY_DISTRIBUTION_ASSIGN_TO_TARGET, 0x36C8 },
            { Opcode.CMSG_BATTLE_PAY_DISTRIBUTION_ASSIGN_VAS, 0x3740 },
            { Opcode.CMSG_BATTLE_PAY_GET_PRODUCT_LIST, 0x36C1 },
            { Opcode.CMSG_BATTLE_PAY_GET_PURCHASE_LIST, 0x36C2 },
            { Opcode.CMSG_BATTLE_PAY_OPEN_CHECKOUT, 0x3712 },
            { Opcode.CMSG_BATTLE_PAY_REQUEST_PRICE_INFO, 0x370E },
            { Opcode.CMSG_BATTLE_PAY_START_PURCHASE, 0x36D0 },
            { Opcode.CMSG_BATTLE_PAY_START_VAS_PURCHASE, 0x36F7 },
            { Opcode.CMSG_BATTLE_PET_CLEAR_FANFARE, 0x312C },
            { Opcode.CMSG_BATTLE_PET_DELETE_PET, 0x3626 },
            { Opcode.CMSG_BATTLE_PET_DELETE_PET_CHEAT, 0x3627 },
            { Opcode.CMSG_BATTLE_PET_MODIFY_NAME, 0x3629 },
            { Opcode.CMSG_BATTLE_PET_REQUEST_JOURNAL, 0x3625 },
            { Opcode.CMSG_BATTLE_PET_REQUEST_JOURNAL_LOCK, 0x3624 },
            { Opcode.CMSG_BATTLE_PET_SET_BATTLE_SLOT, 0x362E },
            { Opcode.CMSG_BATTLE_PET_SET_FLAGS, 0x3631 },
            { Opcode.CMSG_BATTLE_PET_SUMMON, 0x362A },
            { Opcode.CMSG_BATTLE_PET_UPDATE_DISPLAY_NOTIFY, 0x31E1 },
            { Opcode.CMSG_BATTLE_PET_UPDATE_NOTIFY, 0x31E0 },
            { Opcode.CMSG_BEGIN_TRADE, 0x3157 },
            { Opcode.CMSG_BINDER_ACTIVATE, 0x34B2 },
            { Opcode.CMSG_BLACK_MARKET_BID_ON_ITEM, 0x352D },
            { Opcode.CMSG_BLACK_MARKET_OPEN, 0x352B },
            { Opcode.CMSG_BLACK_MARKET_REQUEST_ITEMS, 0x352C },
            { Opcode.CMSG_BUG_REPORT, 0x3686 },
            { Opcode.CMSG_BUSY_TRADE, 0x3158 },
            { Opcode.CMSG_BUY_BACK_ITEM, 0x34A4 },
            { Opcode.CMSG_BUY_BANK_SLOT, 0x34B4 },
            { Opcode.CMSG_BUY_ITEM, 0x34A3 },
            { Opcode.CMSG_BUY_STABLE_SLOT, 0x316B },
            { Opcode.CMSG_CALENDAR_ADD_EVENT, 0x367E },
            { Opcode.CMSG_CALENDAR_COMMUNITY_INVITE, 0x3672 },
            { Opcode.CMSG_CALENDAR_COMPLAIN, 0x367A },
            { Opcode.CMSG_CALENDAR_COPY_EVENT, 0x3679 },
            { Opcode.CMSG_CALENDAR_EVENT_SIGN_UP, 0x367C },
            { Opcode.CMSG_CALENDAR_GET, 0x3670 },
            { Opcode.CMSG_CALENDAR_GET_EVENT, 0x3671 },
            { Opcode.CMSG_CALENDAR_GET_NUM_PENDING, 0x367B },
            { Opcode.CMSG_CALENDAR_INVITE, 0x3673 },
            { Opcode.CMSG_CALENDAR_MODERATOR_STATUS, 0x3677 },
            { Opcode.CMSG_CALENDAR_REMOVE_EVENT, 0x3678 },
            { Opcode.CMSG_CALENDAR_REMOVE_INVITE, 0x3674 },
            { Opcode.CMSG_CALENDAR_RSVP, 0x3675 },
            { Opcode.CMSG_CALENDAR_STATUS, 0x3676 },
            { Opcode.CMSG_CALENDAR_UPDATE_EVENT, 0x367F },
            { Opcode.CMSG_CANCEL_AURA, 0x31B0 },
            { Opcode.CMSG_CANCEL_AUTO_REPEAT_SPELL, 0x34E7 },
            { Opcode.CMSG_CANCEL_CAST, 0x3298 },
            { Opcode.CMSG_CANCEL_CHANNELLING, 0x3266 },
            { Opcode.CMSG_CANCEL_GROWTH_AURA, 0x326B },
            { Opcode.CMSG_CANCEL_MOD_SPEED_NO_CONTROL_AURAS, 0x31AF },
            { Opcode.CMSG_CANCEL_MOUNT_AURA, 0x327B },
            { Opcode.CMSG_CANCEL_QUEUED_SPELL, 0x3183 },
            { Opcode.CMSG_CANCEL_TEMP_ENCHANTMENT, 0x34F2 },
            { Opcode.CMSG_CANCEL_TRADE, 0x315C },
            { Opcode.CMSG_CAN_DUEL, 0x3663 },
            { Opcode.CMSG_CAN_REDEEM_TOKEN_FOR_BALANCE, 0x370D },
            { Opcode.CMSG_CAST_SPELL, 0x3295 },
            { Opcode.CMSG_CHANGE_BAG_SLOT_FLAG, 0x32C1 },
            { Opcode.CMSG_CHANGE_BANK_BAG_SLOT_FLAG, 0x32C2 },
            { Opcode.CMSG_CHANGE_REALM_TICKET, 0x36FE },
            { Opcode.CMSG_GROUP_CHANGE_SUB_GROUP, 0x364E },
            { Opcode.CMSG_CHARACTER_CHECK_UPGRADE, 0x36CB },
            { Opcode.CMSG_CHARACTER_RENAME_REQUEST, 0x36C6 },
            { Opcode.CMSG_CHARACTER_UPGRADE_MANUAL_UNREVOKE_REQUEST, 0x36C9 },
            { Opcode.CMSG_CHARACTER_UPGRADE_START, 0x36CA },
            { Opcode.CMSG_CHAR_CUSTOMIZE, 0x368B },
            { Opcode.CMSG_CHAR_DELETE, 0x369B },
            { Opcode.CMSG_CHAR_RACE_OR_FACTION_CHANGE, 0x3691 },
            { Opcode.CMSG_CHAT_ADDON_MESSAGE, 0x37EE },
            { Opcode.CMSG_CHAT_ADDON_MESSAGE_TARGETED, 0x37EF },
            { Opcode.CMSG_CHAT_CHANNEL_ANNOUNCEMENTS, 0x37E3 },
            { Opcode.CMSG_CHAT_CHANNEL_BAN, 0x37E1 },
            { Opcode.CMSG_CHAT_CHANNEL_DECLINE_INVITE, 0x37E6 },
            { Opcode.CMSG_CHAT_CHANNEL_DISPLAY_LIST, 0x37D6 },
            { Opcode.CMSG_CHAT_CHANNEL_INVITE, 0x37DF },
            { Opcode.CMSG_CHAT_CHANNEL_KICK, 0x37E0 },
            { Opcode.CMSG_CHAT_CHANNEL_LIST, 0x37D5 },
            { Opcode.CMSG_CHAT_CHANNEL_MODERATOR, 0x37DB },
            { Opcode.CMSG_CHAT_CHANNEL_OWNER, 0x37D9 },
            { Opcode.CMSG_CHAT_CHANNEL_PASSWORD, 0x37D7 },
            { Opcode.CMSG_CHAT_CHANNEL_SET_OWNER, 0x37D8 },
            { Opcode.CMSG_CHAT_CHANNEL_SILENCE_ALL, 0x37E4 },
            { Opcode.CMSG_CHAT_CHANNEL_UNBAN, 0x37E2 },
            { Opcode.CMSG_CHAT_CHANNEL_UNMODERATOR, 0x37DC },
            { Opcode.CMSG_CHAT_CHANNEL_UNSILENCE_ALL, 0x37E5 },
            { Opcode.CMSG_CHAT_JOIN_CHANNEL, 0x37C8 },
            { Opcode.CMSG_CHAT_LEAVE_CHANNEL, 0x37C9 },
            { Opcode.CMSG_CHAT_MESSAGE_AFK, 0x37D3 },
            { Opcode.CMSG_CHAT_MESSAGE_CHANNEL, 0x37CF },
            { Opcode.CMSG_CHAT_MESSAGE_DND, 0x37D4 },
            { Opcode.CMSG_CHAT_MESSAGE_EMOTE, 0x37E8 },
            { Opcode.CMSG_CHAT_MESSAGE_GUILD, 0x37D1 },
            { Opcode.CMSG_CHAT_MESSAGE_INSTANCE_CHAT, 0x37EC },
            { Opcode.CMSG_CHAT_MESSAGE_OFFICER, 0x37D2 },
            { Opcode.CMSG_CHAT_MESSAGE_PARTY, 0x37EA },
            { Opcode.CMSG_CHAT_MESSAGE_RAID, 0x37EB },
            { Opcode.CMSG_CHAT_MESSAGE_RAID_WARNING, 0x37ED },
            { Opcode.CMSG_CHAT_MESSAGE_SAY, 0x37E7 },
            { Opcode.CMSG_CHAT_MESSAGE_WHISPER, 0x37D0 },
            { Opcode.CMSG_CHAT_MESSAGE_YELL, 0x37E9 },
            { Opcode.CMSG_CHAT_REGISTER_ADDON_PREFIXES, 0x37CD },
            { Opcode.CMSG_CHAT_REPORT_FILTERED, 0x37CC },
            { Opcode.CMSG_CHAT_REPORT_IGNORED, 0x37CB },
            { Opcode.CMSG_CHAT_UNREGISTER_ALL_ADDON_PREFIXES, 0x37CE },
            { Opcode.CMSG_CHECK_CHARACTER_NAME_AVAILABILITY, 0x3645 },
            { Opcode.CMSG_CHECK_IS_ADVENTURE_MAP_POI_VALID, 0x3243 },
            { Opcode.CMSG_CHOICE_RESPONSE, 0x329A },
            { Opcode.CMSG_CLEAR_NEW_APPEARANCE, 0x312F },
            { Opcode.CMSG_CLEAR_RAID_MARKER, 0x31A8 },
            { Opcode.CMSG_CLEAR_TRADE_ITEM, 0x315E },
            { Opcode.CMSG_CLIENT_PORT_GRAVEYARD, 0x3527 },
            { Opcode.CMSG_CLOSE_INTERACTION, 0x3493 },
            { Opcode.CMSG_CLOSE_QUEST_CHOICE, 0x329B },
            { Opcode.CMSG_CLUB_FINDER_APPLICATION_RESPONSE, 0x3724 },
            { Opcode.CMSG_CLUB_FINDER_GET_APPLICANTS_LIST, 0x3722 },
            { Opcode.CMSG_CLUB_FINDER_POST, 0x371F },
            { Opcode.CMSG_CLUB_FINDER_REQUEST_CLUBS_DATA, 0x3726 },
            { Opcode.CMSG_CLUB_FINDER_REQUEST_CLUBS_LIST, 0x3720 },
            { Opcode.CMSG_CLUB_FINDER_REQUEST_MEMBERSHIP_TO_CLUB, 0x3721 },
            { Opcode.CMSG_CLUB_FINDER_REQUEST_PENDING_CLUBS_LIST, 0x3725 },
            { Opcode.CMSG_CLUB_FINDER_REQUEST_SUBSCRIBED_CLUB_POSTING_IDS, 0x3727 },
            { Opcode.CMSG_CLUB_FINDER_RESPOND_TO_APPLICANT, 0x3723 },
            { Opcode.CMSG_CLUB_PRESENCE_SUBSCRIBE, 0x36FC },
            { Opcode.CMSG_COLLECTION_ITEM_SET_FAVORITE, 0x3634 },
            { Opcode.CMSG_COMMENTATOR_ENABLE, 0x35F1 },
            { Opcode.CMSG_COMMENTATOR_ENTER_INSTANCE, 0x35F5 },
            { Opcode.CMSG_COMMENTATOR_EXIT_INSTANCE, 0x35F6 },
            { Opcode.CMSG_COMMENTATOR_GET_MAP_INFO, 0x35F2 },
            { Opcode.CMSG_COMMENTATOR_GET_PLAYER_COOLDOWNS, 0x35F4 },
            { Opcode.CMSG_COMMENTATOR_GET_PLAYER_INFO, 0x35F3 },
            { Opcode.CMSG_COMMENTATOR_START_WARGAME, 0x35F0 },
            { Opcode.CMSG_COMMERCE_TOKEN_GET_COUNT, 0x36E9 },
            { Opcode.CMSG_COMMERCE_TOKEN_GET_LOG, 0x36F3 },
            { Opcode.CMSG_COMMERCE_TOKEN_GET_MARKET_PRICE, 0x36EA },
            { Opcode.CMSG_COMPLAINT, 0x366D },
            { Opcode.CMSG_COMPLETE_CINEMATIC, 0x3545 },
            { Opcode.CMSG_COMPLETE_MOVIE, 0x34DD },
            { Opcode.CMSG_CONFIRM_ARTIFACT_RESPEC, 0x31AD },
            { Opcode.CMSG_CONFIRM_RESPEC_WIPE, 0x320B },
            { Opcode.CMSG_CONNECT_TO_FAILED, 0x35D4 },
            { Opcode.CMSG_CONSUMABLE_TOKEN_BUY, 0x36EE },
            { Opcode.CMSG_CONSUMABLE_TOKEN_BUY_AT_MARKET_PRICE, 0x36EF },
            { Opcode.CMSG_CONSUMABLE_TOKEN_CAN_VETERAN_BUY, 0x36ED },
            { Opcode.CMSG_CONSUMABLE_TOKEN_REDEEM, 0x36F1 },
            { Opcode.CMSG_CONSUMABLE_TOKEN_REDEEM_CONFIRMATION, 0x36F2 },
            { Opcode.CMSG_CONVERSATION_CINEMATIC_READY, 0x3547 },
            { Opcode.CMSG_CONVERSATION_LINE_STARTED, 0x3546 },
            { Opcode.CMSG_CONVERT_RAID, 0x3650 },
            { Opcode.CMSG_CREATE_CHARACTER, 0x3644 },
            { Opcode.CMSG_DB_QUERY_BULK, 0x35E5 },
            { Opcode.CMSG_DECLINE_GUILD_INVITES, 0x351D },
            { Opcode.CMSG_DECLINE_PETITION, 0x3534 },
            { Opcode.CMSG_DELETE_EQUIPMENT_SET, 0x350A },
            { Opcode.CMSG_DEL_FRIEND, 0x36D6 },
            { Opcode.CMSG_DEL_IGNORE, 0x36DA },
            { Opcode.CMSG_DESTROY_ITEM, 0x328C },
            { Opcode.CMSG_DF_BOOT_PLAYER_VOTE, 0x3617 },
            { Opcode.CMSG_DF_CONFIRM_EXPAND_SEARCH, 0x3609 },
            { Opcode.CMSG_DF_GET_JOIN_STATUS, 0x3615 },
            { Opcode.CMSG_DF_GET_SYSTEM_INFO, 0x3614 },
            { Opcode.CMSG_DF_JOIN, 0x360A },
            { Opcode.CMSG_DF_LEAVE, 0x3613 },
            { Opcode.CMSG_DF_PROPOSAL_RESPONSE, 0x3608 },
            { Opcode.CMSG_DF_READY_CHECK_RESPONSE, 0x361A },
            { Opcode.CMSG_DF_SET_ROLES, 0x3616 },
            { Opcode.CMSG_DF_TELEPORT, 0x3618 },
            { Opcode.CMSG_DISCARDED_TIME_SYNC_ACKS, 0x3A42 },
            { Opcode.CMSG_DISMISS_CRITTER, 0x34F9 },
            { Opcode.CMSG_DO_COUNTDOWN, 0x371E },
            { Opcode.CMSG_DO_READY_CHECK, 0x3635 },
            { Opcode.CMSG_DUEL_RESPONSE, 0x34E2 },
            { Opcode.CMSG_EJECT_PASSENGER, 0x3238 },
            { Opcode.CMSG_EMOTE, 0x3541 },
            { Opcode.CMSG_ENABLE_NAGLE, 0x376B },
            { Opcode.CMSG_ENABLE_TAXI_NODE, 0x34A9 },
            { Opcode.CMSG_ENGINE_SURVEY, 0x36E8 },
            { Opcode.CMSG_ENTER_ENCRYPTED_MODE_ACK, 0x3767 },
            { Opcode.CMSG_ENUM_CHARACTERS, 0x35E9 },
            { Opcode.CMSG_ENUM_CHARACTERS_DELETED_BY_CLIENT, 0x36E2 },
            { Opcode.CMSG_FAR_SIGHT, 0x34E8 },
            { Opcode.CMSG_GAME_EVENT_DEBUG_DISABLE, 0x31B3 },
            { Opcode.CMSG_GAME_EVENT_DEBUG_ENABLE, 0x31B2 },
            { Opcode.CMSG_GAME_OBJ_REPORT_USE, 0x34EF },
            { Opcode.CMSG_GAME_OBJ_USE, 0x34EE },
            { Opcode.CMSG_GENERATE_RANDOM_CHARACTER_NAME, 0x35E8 },
            { Opcode.CMSG_GET_ACCOUNT_CHARACTER_LIST, 0x36BC },
            { Opcode.CMSG_GET_ACCOUNT_NOTIFICATIONS, 0x373A },
            { Opcode.CMSG_GET_ITEM_PURCHASE_DATA, 0x352F },
            { Opcode.CMSG_GET_MIRROR_IMAGE_DATA, 0x3290 },
            { Opcode.CMSG_GET_PVP_OPTIONS_ENABLED, 0x35EF },
            { Opcode.CMSG_GET_RAF_ACCOUNT_INFO, 0x3728 },
            { Opcode.CMSG_GET_REMAINING_GAME_TIME, 0x36F0 },
            { Opcode.CMSG_GET_UNDELETE_CHARACTER_COOLDOWN_STATUS, 0x36E4 },
            { Opcode.CMSG_GET_VAS_ACCOUNT_CHARACTER_LIST, 0x36F5 },
            { Opcode.CMSG_GET_VAS_TRANSFER_TARGET_REALM_LIST, 0x36F6 },
            { Opcode.CMSG_GM_TICKET_ACKNOWLEDGE_SURVEY, 0x368F },
            { Opcode.CMSG_GM_TICKET_GET_CASE_STATUS, 0x368E },
            { Opcode.CMSG_GM_TICKET_GET_SYSTEM_STATUS, 0x368D },
            { Opcode.CMSG_GOSSIP_SELECT_OPTION, 0x3494 },
            { Opcode.CMSG_GUILD_ADD_RANK, 0x3064 },
            { Opcode.CMSG_GUILD_ASSIGN_MEMBER_RANK, 0x305F },
            { Opcode.CMSG_GUILD_AUTO_DECLINE_INVITATION, 0x3061 },
            { Opcode.CMSG_GUILD_BANK_ACTIVATE, 0x34B5 },
            { Opcode.CMSG_GUILD_BANK_BUY_TAB, 0x34C3 },
            { Opcode.CMSG_GUILD_BANK_DEPOSIT_MONEY, 0x34C5 },
            { Opcode.CMSG_GUILD_BANK_LOG_QUERY, 0x3082 },
            { Opcode.CMSG_GUILD_BANK_QUERY_TAB, 0x34C2 },
            { Opcode.CMSG_GUILD_BANK_REMAINING_WITHDRAW_MONEY_QUERY, 0x3083 },
            { Opcode.CMSG_GUILD_BANK_SET_TAB_TEXT, 0x3086 },
            { Opcode.CMSG_GUILD_BANK_TEXT_QUERY, 0x3087 },
            { Opcode.CMSG_GUILD_BANK_UPDATE_TAB, 0x34C4 },
            { Opcode.CMSG_GUILD_BANK_WITHDRAW_MONEY, 0x34C6 },
            { Opcode.CMSG_GUILD_CHALLENGE_UPDATE_REQUEST, 0x307B },
            { Opcode.CMSG_GUILD_CHANGE_NAME_REQUEST, 0x307E },
            { Opcode.CMSG_GUILD_DECLINE_INVITATION, 0x3060 },
            { Opcode.CMSG_GUILD_DELETE, 0x3068 },
            { Opcode.CMSG_GUILD_DELETE_RANK, 0x3065 },
            { Opcode.CMSG_GUILD_DEMOTE_MEMBER, 0x305E },
            { Opcode.CMSG_GUILD_EVENT_LOG_QUERY, 0x3085 },
            { Opcode.CMSG_GUILD_GET_ACHIEVEMENT_MEMBERS, 0x3071 },
            { Opcode.CMSG_GUILD_GET_RANKS, 0x306D },
            { Opcode.CMSG_GUILD_GET_ROSTER, 0x3073 },
            { Opcode.CMSG_GUILD_INVITE_BY_NAME, 0x3607 },
            { Opcode.CMSG_GUILD_LEAVE, 0x3062 },
            { Opcode.CMSG_GUILD_NEWS_UPDATE_STICKY, 0x306E },
            { Opcode.CMSG_GUILD_OFFICER_REMOVE_MEMBER, 0x3063 },
            { Opcode.CMSG_GUILD_PERMISSIONS_QUERY, 0x3084 },
            { Opcode.CMSG_GUILD_PROMOTE_MEMBER, 0x305D },
            { Opcode.CMSG_GUILD_QUERY_MEMBERS_FOR_RECIPE, 0x306B },
            { Opcode.CMSG_GUILD_QUERY_MEMBER_RECIPES, 0x3069 },
            { Opcode.CMSG_GUILD_QUERY_NEWS, 0x306C },
            { Opcode.CMSG_GUILD_QUERY_RECIPES, 0x306A },
            { Opcode.CMSG_GUILD_REPLACE_GUILD_MASTER, 0x3088 },
            { Opcode.CMSG_GUILD_SET_ACHIEVEMENT_TRACKING, 0x306F },
            { Opcode.CMSG_GUILD_SET_FOCUSED_ACHIEVEMENT, 0x3070 },
            { Opcode.CMSG_GUILD_SET_GUILD_MASTER, 0x36CD },
            { Opcode.CMSG_GUILD_SET_MEMBER_NOTE, 0x3072 },
            { Opcode.CMSG_GUILD_SET_RANK_PERMISSIONS, 0x3067 },
            { Opcode.CMSG_GUILD_SHIFT_RANK, 0x3066 },
            { Opcode.CMSG_GUILD_UPDATE_INFO_TEXT, 0x3075 },
            { Opcode.CMSG_GUILD_UPDATE_MOTD_TEXT, 0x3074 },
            { Opcode.CMSG_HEARTH_AND_RESURRECT, 0x3506 },
            { Opcode.CMSG_HOTFIX_REQUEST, 0x35E6 },
            { Opcode.CMSG_IGNORE_TRADE, 0x3159 },
            { Opcode.CMSG_INITIATE_ROLE_POLL, 0x35DA },
            { Opcode.CMSG_INITIATE_TRADE, 0x3156 },
            { Opcode.CMSG_INSPECT, 0x3529 },
            { Opcode.CMSG_INSPECT_HONOR_STATS, 0x317E },
            { Opcode.CMSG_INSPECT_PVP, 0x36A1 },
            { Opcode.CMSG_INSTANCE_LOCK_RESPONSE, 0x350B },
            { Opcode.CMSG_ITEM_PURCHASE_REFUND, 0x3530 },
            { Opcode.CMSG_ITEM_TEXT_QUERY, 0x32BE },
            { Opcode.CMSG_JOIN_PET_BATTLE_QUEUE, 0x31DE },
            { Opcode.CMSG_JOIN_RATED_BATTLEGROUND, 0x317B },
            { Opcode.CMSG_KEEP_ALIVE, 0x3680 },
            { Opcode.CMSG_KEYBOUND_OVERRIDE, 0x3221 },
            { Opcode.CMSG_LATENCY_REPORT, 0x3771 },
            { Opcode.CMSG_LEARN_TALENT, 0x3552 },
            { Opcode.CMSG_LEAVE_GROUP, 0x364B },
            { Opcode.CMSG_LEAVE_PET_BATTLE_QUEUE, 0x31DF },
            { Opcode.CMSG_LFG_LIST_APPLY_TO_GROUP, 0x360E },
            { Opcode.CMSG_LFG_LIST_CANCEL_APPLICATION, 0x360F },
            { Opcode.CMSG_LFG_LIST_DECLINE_APPLICANT, 0x3610 },
            { Opcode.CMSG_LFG_LIST_GET_STATUS, 0x360C },
            { Opcode.CMSG_LFG_LIST_INVITE_APPLICANT, 0x3611 },
            { Opcode.CMSG_LFG_LIST_INVITE_RESPONSE, 0x3612 },
            { Opcode.CMSG_LFG_LIST_LEAVE, 0x360B },
            { Opcode.CMSG_LFG_LIST_SEARCH, 0x360D },
            { Opcode.CMSG_LFG_LIST_SET_ROLES, 0x32FD },
            { Opcode.CMSG_LIST_INVENTORY, 0x34A1 },
            { Opcode.CMSG_LIVE_REGION_ACCOUNT_RESTORE, 0x36BF },
            { Opcode.CMSG_LIVE_REGION_CHARACTER_COPY, 0x36BE },
            { Opcode.CMSG_LIVE_REGION_GET_ACCOUNT_CHARACTER_LIST, 0x36BD },
            { Opcode.CMSG_LIVE_REGION_KEY_BINDINGS_COPY, 0x36C0 },
            { Opcode.CMSG_LOADING_SCREEN_NOTIFY, 0x35F9 },
            { Opcode.CMSG_LOGOUT_CANCEL, 0x34D8 },
            { Opcode.CMSG_LOGOUT_INSTANT, 0x34D9 },
            { Opcode.CMSG_LOGOUT_REQUEST, 0x34D6 },
            { Opcode.CMSG_LOG_DISCONNECT, 0x3769 },
            { Opcode.CMSG_LOG_STREAMING_ERROR, 0x376D },
            { Opcode.CMSG_LOOT_ITEM, 0x320F },
            { Opcode.CMSG_LOOT_MONEY, 0x320E },
            { Opcode.CMSG_LOOT_RELEASE, 0x3211 },
            { Opcode.CMSG_LOOT_ROLL, 0x3212 },
            { Opcode.CMSG_LOOT_UNIT, 0x320D },
            { Opcode.CMSG_LOW_LEVEL_RAID1, 0x369F },
            { Opcode.CMSG_LOW_LEVEL_RAID2, 0x3512 },
            { Opcode.CMSG_MAIL_CREATE_TEXT_ITEM, 0x353B },
            { Opcode.CMSG_MAIL_DELETE, 0x3223 },
            { Opcode.CMSG_MAIL_GET_LIST, 0x3536 },
            { Opcode.CMSG_MAIL_MARK_AS_READ, 0x353A },
            { Opcode.CMSG_MAIL_RETURN_TO_SENDER, 0x3657 },
            { Opcode.CMSG_MAIL_TAKE_ITEM, 0x3538 },
            { Opcode.CMSG_MAIL_TAKE_MONEY, 0x3537 },
            { Opcode.CMSG_MAKE_CONTITIONAL_APPEARANCE_PERMANENT, 0x3225 },
            { Opcode.CMSG_LOOT_MASTER_GIVE, 0x3210 },
            { Opcode.CMSG_MERGE_GUILD_BANK_ITEM_WITH_GUILD_BANK_ITEM, 0x34C0 },
            { Opcode.CMSG_MERGE_GUILD_BANK_ITEM_WITH_ITEM, 0x34BD },
            { Opcode.CMSG_MERGE_ITEM_WITH_GUILD_BANK_ITEM, 0x34BB },
            { Opcode.CMSG_MINIMAP_PING, 0x364D },
            { Opcode.CMSG_MISSILE_TRAJECTORY_COLLISION, 0x318E },
            { Opcode.CMSG_MOUNT_CLEAR_FANFARE, 0x312D },
            { Opcode.CMSG_MOUNT_SET_FAVORITE, 0x3633 },
            { Opcode.CMSG_MOUNT_SPECIAL_ANIM, 0x327C },
            { Opcode.CMSG_MOVE_APPLY_INERTIA_ACK, 0x3A4B },
            { Opcode.CMSG_MOVE_APPLY_MOVEMENT_FORCE_ACK, 0x3A16 },
            { Opcode.CMSG_MOVE_CHANGE_TRANSPORT, 0x3A30 },
            { Opcode.CMSG_MOVE_CHANGE_VEHICLE_SEATS, 0x3A35 },
            { Opcode.CMSG_MOVE_COLLISION_DISABLE_ACK, 0x3A3A },
            { Opcode.CMSG_MOVE_COLLISION_ENABLE_ACK, 0x3A3B },
            { Opcode.CMSG_MOVE_DISMISS_VEHICLE, 0x3A34 },
            { Opcode.CMSG_MOVE_DOUBLE_JUMP, 0x39EB },
            { Opcode.CMSG_MOVE_ENABLE_DOUBLE_JUMP_ACK, 0x3A1F },
            { Opcode.CMSG_MOVE_ENABLE_SWIM_TO_FLY_TRANS_ACK, 0x3A25 },
            { Opcode.CMSG_MOVE_FALL_LAND, 0x39FB },
            { Opcode.CMSG_MOVE_FALL_RESET, 0x3A1A },
            { Opcode.CMSG_MOVE_FEATHER_FALL_ACK, 0x3A1D },
            { Opcode.CMSG_MOVE_FORCE_FLIGHT_BACK_SPEED_CHANGE_ACK, 0x3A2F },
            { Opcode.CMSG_MOVE_FORCE_FLIGHT_SPEED_CHANGE_ACK, 0x3A2E },
            { Opcode.CMSG_MOVE_FORCE_PITCH_RATE_CHANGE_ACK, 0x3A33 },
            { Opcode.CMSG_MOVE_FORCE_ROOT_ACK, 0x3A0F },
            { Opcode.CMSG_MOVE_FORCE_RUN_BACK_SPEED_CHANGE_ACK, 0x3A0D },
            { Opcode.CMSG_MOVE_FORCE_RUN_SPEED_CHANGE_ACK, 0x3A0C },
            { Opcode.CMSG_MOVE_FORCE_SWIM_BACK_SPEED_CHANGE_ACK, 0x3A23 },
            { Opcode.CMSG_MOVE_FORCE_SWIM_SPEED_CHANGE_ACK, 0x3A0E },
            { Opcode.CMSG_MOVE_FORCE_TURN_RATE_CHANGE_ACK, 0x3A24 },
            { Opcode.CMSG_MOVE_FORCE_UNROOT_ACK, 0x3A10 },
            { Opcode.CMSG_MOVE_FORCE_WALK_SPEED_CHANGE_ACK, 0x3A22 },
            { Opcode.CMSG_MOVE_GRAVITY_DISABLE_ACK, 0x3A36 },
            { Opcode.CMSG_MOVE_GRAVITY_ENABLE_ACK, 0x3A37 },
            { Opcode.CMSG_MOVE_GUILD_BANK_ITEM, 0x34BA },
            { Opcode.CMSG_MOVE_HEARTBEAT, 0x3A11 },
            { Opcode.CMSG_MOVE_HOVER_ACK, 0x3A14 },
            { Opcode.CMSG_MOVE_INERTIA_DISABLE_ACK, 0x3A38 },
            { Opcode.CMSG_MOVE_INERTIA_ENABLE_ACK, 0x3A39 },
            { Opcode.CMSG_MOVE_INIT_ACTIVE_MOVER_COMPLETE, 0x3A47 },
            { Opcode.CMSG_MOVE_JUMP, 0x39EA },
            { Opcode.CMSG_MOVE_KNOCK_BACK_ACK, 0x3A13 },
            { Opcode.CMSG_MOVE_REMOVE_INERTIA_ACK, 0x3A4C },
            { Opcode.CMSG_MOVE_REMOVE_MOVEMENT_FORCES, 0x3A18 },
            { Opcode.CMSG_MOVE_REMOVE_MOVEMENT_FORCE_ACK, 0x3A17 },
            { Opcode.CMSG_MOVE_SEAMLESS_TRANSFER_COMPLETE, 0x3A45 },
            { Opcode.CMSG_MOVE_SET_CAN_FLY_ACK, 0x3A28 },
            { Opcode.CMSG_MOVE_SET_CAN_TURN_WHILE_FALLING_ACK, 0x3A26 },
            { Opcode.CMSG_MOVE_SET_COLLISION_HEIGHT_ACK, 0x3A3C },
            { Opcode.CMSG_MOVE_SET_FACING, 0x3A09 },
            { Opcode.CMSG_MOVE_SET_FACING_HEARTBEAT, 0x3A0A },
            { Opcode.CMSG_MOVE_SET_FLY, 0x3A29 },
            { Opcode.CMSG_MOVE_SET_IGNORE_MOVEMENT_FORCES_ACK, 0x3A27 },
            { Opcode.CMSG_MOVE_SET_MOD_MOVEMENT_FORCE_MAGNITUDE_ACK, 0x3A43 },
            { Opcode.CMSG_MOVE_SET_PITCH, 0x3A0B },
            { Opcode.CMSG_MOVE_SET_RUN_MODE, 0x39F2 },
            { Opcode.CMSG_MOVE_SET_TURN_RATE_CHEAT, 0x3A06 },
            { Opcode.CMSG_MOVE_SET_VEHICLE_REC_ID_ACK, 0x3A15 },
            { Opcode.CMSG_MOVE_SET_WALK_MODE, 0x39F3 },
            { Opcode.CMSG_MOVE_SPLINE_DONE, 0x3A19 },
            { Opcode.CMSG_MOVE_START_ASCEND, 0x3A2A },
            { Opcode.CMSG_MOVE_START_BACKWARD, 0x39E5 },
            { Opcode.CMSG_MOVE_START_DESCEND, 0x3A31 },
            { Opcode.CMSG_MOVE_START_FORWARD, 0x39E4 },
            { Opcode.CMSG_MOVE_START_PITCH_DOWN, 0x39F0 },
            { Opcode.CMSG_MOVE_START_PITCH_UP, 0x39EF },
            { Opcode.CMSG_MOVE_START_STRAFE_LEFT, 0x39E7 },
            { Opcode.CMSG_MOVE_START_STRAFE_RIGHT, 0x39E8 },
            { Opcode.CMSG_MOVE_START_SWIM, 0x39FC },
            { Opcode.CMSG_MOVE_START_TURN_LEFT, 0x39EC },
            { Opcode.CMSG_MOVE_START_TURN_RIGHT, 0x39ED },
            { Opcode.CMSG_MOVE_STOP, 0x39E6 },
            { Opcode.CMSG_MOVE_STOP_ASCEND, 0x3A2B },
            { Opcode.CMSG_MOVE_STOP_PITCH, 0x39F1 },
            { Opcode.CMSG_MOVE_STOP_STRAFE, 0x39E9 },
            { Opcode.CMSG_MOVE_STOP_SWIM, 0x39FD },
            { Opcode.CMSG_MOVE_STOP_TURN, 0x39EE },
            { Opcode.CMSG_MOVE_TELEPORT_ACK, 0x39FA },
            { Opcode.CMSG_MOVE_TIME_SKIPPED, 0x3A1C },
            { Opcode.CMSG_MOVE_UPDATE_FALL_SPEED, 0x3A1B },
            { Opcode.CMSG_MOVE_WATER_WALK_ACK, 0x3A1E },
            { Opcode.CMSG_NEUTRAL_PLAYER_SELECT_FACTION, 0x31D4 },
            { Opcode.CMSG_NEXT_CINEMATIC_CAMERA, 0x3544 },
            { Opcode.CMSG_OBJECT_UPDATE_FAILED, 0x3184 },
            { Opcode.CMSG_OBJECT_UPDATE_RESCUED, 0x3185 },
            { Opcode.CMSG_OFFER_PETITION, 0x32F7 },
            { Opcode.CMSG_OPENING_CINEMATIC, 0x3543 },
            { Opcode.CMSG_OPEN_ITEM, 0x32BF },
            { Opcode.CMSG_OPT_OUT_OF_LOOT, 0x34F6 },
            { Opcode.CMSG_OVERRIDE_SCREEN_FLASH, 0x351E },
            { Opcode.CMSG_PARTY_INVITE, 0x3603 },
            { Opcode.CMSG_PARTY_INVITE_RESPONSE, 0x3605 },
            { Opcode.CMSG_PARTY_UNINVITE, 0x3649 },
            { Opcode.CMSG_PETITION_BUY, 0x34C8 },
            { Opcode.CMSG_PETITION_RENAME_GUILD, 0x36CE },
            { Opcode.CMSG_PETITION_SHOW_LIST, 0x34C7 },
            { Opcode.CMSG_PETITION_SHOW_SIGNATURES, 0x34C9 },
            { Opcode.CMSG_PET_ABANDON, 0x348D },
            { Opcode.CMSG_PET_ACTION, 0x348B },
            { Opcode.CMSG_PET_BATTLE_FINAL_NOTIFY, 0x31E3 },
            { Opcode.CMSG_PET_BATTLE_INPUT, 0x3642 },
            { Opcode.CMSG_PET_BATTLE_QUEUE_PROPOSE_MATCH_RESULT, 0x3222 },
            { Opcode.CMSG_PET_BATTLE_QUIT_NOTIFY, 0x31E2 },
            { Opcode.CMSG_PET_BATTLE_REPLACE_FRONT_PET, 0x3643 },
            { Opcode.CMSG_PET_BATTLE_REQUEST_PVP, 0x31DC },
            { Opcode.CMSG_PET_BATTLE_REQUEST_UPDATE, 0x31DD },
            { Opcode.CMSG_PET_BATTLE_REQUEST_WILD, 0x31DA },
            { Opcode.CMSG_PET_BATTLE_SCRIPT_ERROR_NOTIFY, 0x31E4 },
            { Opcode.CMSG_PET_BATTLE_WILD_LOCATION_FAIL, 0x31DB },
            { Opcode.CMSG_PET_CANCEL_AURA, 0x348E },
            { Opcode.CMSG_PET_CAST_SPELL, 0x3294 },
            { Opcode.CMSG_PET_RENAME, 0x3685 },
            { Opcode.CMSG_PET_SET_ACTION, 0x348A },
            { Opcode.CMSG_PET_SPELL_AUTOCAST, 0x348F },
            { Opcode.CMSG_PET_STOP_ATTACK, 0x348C },
            { Opcode.CMSG_PING, 0x3768 },
            { Opcode.CMSG_PLAYER_LOGIN, 0x35EB },
            { Opcode.CMSG_PLAYER_SHOWING_CLOAK, 0x3569 },
            { Opcode.CMSG_PLAYER_SHOWING_HELM, 0x3568 },
            { Opcode.CMSG_PUSH_QUEST_TO_PARTY, 0x349F },
            { Opcode.CMSG_PVP_LOG_DATA, 0x317F },
            { Opcode.CMSG_QUERY_BATTLE_PET_NAME, 0x3272 },
            { Opcode.CMSG_QUERY_CORPSE_LOCATION_FROM_CLIENT, 0x3661 },
            { Opcode.CMSG_QUERY_CORPSE_TRANSPORT, 0x3662 },
            { Opcode.CMSG_QUERY_COUNTDOWN_TIMER, 0x31AB },
            { Opcode.CMSG_QUERY_CREATURE, 0x326C },
            { Opcode.CMSG_QUERY_GAME_OBJECT, 0x326D },
            { Opcode.CMSG_QUERY_GARRISON_PET_NAME, 0x3273 },
            { Opcode.CMSG_QUERY_GUILD_INFO, 0x368A },
            { Opcode.CMSG_QUERY_INSPECT_ACHIEVEMENTS, 0x3500 },
            { Opcode.CMSG_QUERY_NEXT_MAIL_TIME, 0x3539 },
            { Opcode.CMSG_QUERY_NPC_TEXT, 0x326E },
            { Opcode.CMSG_QUERY_PAGE_TEXT, 0x3270 },
            { Opcode.CMSG_QUERY_PETITION, 0x3274 },
            { Opcode.CMSG_QUERY_PET_NAME, 0x3271 },
            { Opcode.CMSG_QUERY_PLAYER_NAMES, 0x3772 },
            { Opcode.CMSG_QUERY_PLAYER_NAMES_FOR_COMMUNITY, 0x3770 },
            { Opcode.CMSG_QUERY_PLAYER_NAME_BY_COMMUNITY_ID, 0x376F },
            { Opcode.CMSG_QUERY_QUEST_COMPLETION_NPCS, 0x3178 },
            { Opcode.CMSG_QUERY_QUEST_INFO, 0x326F },
            { Opcode.CMSG_QUERY_REALM_NAME, 0x3689 },
            { Opcode.CMSG_QUERY_SCENARIO_POI, 0x3658 },
            { Opcode.CMSG_QUERY_TIME, 0x34D5 },
            { Opcode.CMSG_QUERY_TREASURE_PICKER, 0x32D5 },
            { Opcode.CMSG_QUERY_VOID_STORAGE, 0x31A4 },
            { Opcode.CMSG_QUEST_CONFIRM_ACCEPT, 0x349E },
            { Opcode.CMSG_QUEST_GIVER_ACCEPT_QUEST, 0x3498 },
            { Opcode.CMSG_QUEST_GIVER_CHOOSE_REWARD, 0x349A },
            { Opcode.CMSG_QUEST_GIVER_CLOSE_QUEST, 0x3549 },
            { Opcode.CMSG_QUEST_GIVER_COMPLETE_QUEST, 0x3499 },
            { Opcode.CMSG_QUEST_GIVER_HELLO, 0x3496 },
            { Opcode.CMSG_QUEST_GIVER_QUERY_QUEST, 0x3497 },
            { Opcode.CMSG_QUEST_GIVER_REQUEST_REWARD, 0x349B },
            { Opcode.CMSG_QUEST_GIVER_STATUS_MULTIPLE_QUERY, 0x349D },
            { Opcode.CMSG_QUEST_GIVER_STATUS_QUERY, 0x349C },
            { Opcode.CMSG_QUEST_LOG_REMOVE_QUEST, 0x352E },
            { Opcode.CMSG_QUEST_PUSH_RESULT, 0x34A0 },
            { Opcode.CMSG_QUEST_SESSION_REQUEST_STOP, 0x3733 },
            { Opcode.CMSG_QUEUED_MESSAGES_END, 0x376C },
            { Opcode.CMSG_QUICK_JOIN_AUTO_ACCEPT_REQUESTS, 0x370C },
            { Opcode.CMSG_QUICK_JOIN_REQUEST_INVITE_WITH_CONFIRMATION, 0x3738 },
            { Opcode.CMSG_QUICK_JOIN_RESPOND_TO_INVITE, 0x370A },
            { Opcode.CMSG_QUICK_JOIN_SIGNAL_TOAST_DISPLAYED, 0x3709 },
            { Opcode.CMSG_RAF_CLAIM_NEXT_REWARD, 0x3729 },
            { Opcode.CMSG_RAF_GENERATE_RECRUITMENT_LINK, 0x372B },
            { Opcode.CMSG_RAF_UPDATE_RECRUITMENT_INFO, 0x372A },
            { Opcode.CMSG_RANDOM_ROLL, 0x3656 },
            { Opcode.CMSG_READY_CHECK_RESPONSE, 0x3636 },
            { Opcode.CMSG_READ_ITEM, 0x32C0 },
            { Opcode.CMSG_RECLAIM_CORPSE, 0x34DB },
            { Opcode.CMSG_REMOVE_NEW_ITEM, 0x32D8 },
            { Opcode.CMSG_REMOVE_RAF_RECRUIT, 0x372C },
            { Opcode.CMSG_REORDER_CHARACTERS, 0x35EA },
            { Opcode.CMSG_REPAIR_ITEM, 0x34EC },
            { Opcode.CMSG_REPOP_REQUEST, 0x3526 },
            { Opcode.CMSG_REPORT_CLIENT_VARIABLES, 0x3706 },
            { Opcode.CMSG_REPORT_ENABLED_ADDONS, 0x3705 },
            { Opcode.CMSG_REPORT_KEYBINDING_EXECUTION_COUNTS, 0x3707 },
            { Opcode.CMSG_REPORT_PVP_PLAYER_AFK, 0x34F4 },
            { Opcode.CMSG_REPORT_SERVER_LAG, 0x32F5 },
            { Opcode.CMSG_REQUEST_ACCOUNT_DATA, 0x3693 },
            { Opcode.CMSG_REQUEST_AREA_POI_UPDATE, 0x32D7 },
            { Opcode.CMSG_REQUEST_BATTLEFIELD_STATUS, 0x35DD },
            { Opcode.CMSG_REQUEST_CATEGORY_COOLDOWNS, 0x3181 },
            { Opcode.CMSG_REQUEST_CEMETERY_LIST, 0x3179 },
            { Opcode.CMSG_REQUEST_CONQUEST_FORMULA_CONSTANTS, 0x32AD },
            { Opcode.CMSG_REQUEST_CROWD_CONTROL_SPELL, 0x352A },
            { Opcode.CMSG_REQUEST_FORCED_REACTIONS, 0x3207 },
            { Opcode.CMSG_REQUEST_GUILD_PARTY_STATE, 0x31AA },
            { Opcode.CMSG_REQUEST_GUILD_REWARDS_LIST, 0x31A9 },
            { Opcode.CMSG_REQUEST_LFG_LIST_BLACKLIST, 0x329D },
            { Opcode.CMSG_REQUEST_MYTHIC_PLUS_AFFIXES, 0x3204 },
            { Opcode.CMSG_REQUEST_MYTHIC_PLUS_SEASON_DATA, 0x3205 },
            { Opcode.CMSG_REQUEST_PARTY_JOIN_UPDATES, 0x35F8 },
            { Opcode.CMSG_REQUEST_PARTY_MEMBER_STATS, 0x3655 },
            { Opcode.CMSG_REQUEST_PET_INFO, 0x3490 },
            { Opcode.CMSG_REQUEST_PLAYED_TIME, 0x3276 },
            { Opcode.CMSG_REQUEST_PVP_REWARDS, 0x3197 },
            { Opcode.CMSG_REQUEST_RAID_INFO, 0x36CF },
            { Opcode.CMSG_REQUEST_RATED_PVP_INFO, 0x35E4 },
            { Opcode.CMSG_REQUEST_STABLED_PETS, 0x3491 },
            { Opcode.CMSG_REQUEST_VEHICLE_EXIT, 0x3233 },
            { Opcode.CMSG_REQUEST_VEHICLE_NEXT_SEAT, 0x3235 },
            { Opcode.CMSG_REQUEST_VEHICLE_PREV_SEAT, 0x3234 },
            { Opcode.CMSG_REQUEST_VEHICLE_SWITCH_SEAT, 0x3236 },
            { Opcode.CMSG_REQUEST_WORLD_QUEST_UPDATE, 0x32D6 },
            { Opcode.CMSG_RESET_CHALLENGE_MODE, 0x3202 },
            { Opcode.CMSG_RESET_CHALLENGE_MODE_CHEAT, 0x3203 },
            { Opcode.CMSG_RESET_INSTANCES, 0x3669 },
            { Opcode.CMSG_RESURRECT_RESPONSE, 0x3684 },
            { Opcode.CMSG_RIDE_VEHICLE_INTERACT, 0x3237 },
            { Opcode.CMSG_SAVE_CUF_PROFILES, 0x318F },
            { Opcode.CMSG_SAVE_EQUIPMENT_SET, 0x3509 },
            { Opcode.CMSG_SAVE_GUILD_EMBLEM, 0x32A1 },
            { Opcode.CMSG_SCENE_PLAYBACK_CANCELED, 0x321E },
            { Opcode.CMSG_SCENE_PLAYBACK_COMPLETE, 0x321D },
            { Opcode.CMSG_SCENE_TRIGGER_EVENT, 0x321F },
            { Opcode.CMSG_SELF_RES, 0x3531 },
            { Opcode.CMSG_SELL_ITEM, 0x34A2 },
            { Opcode.CMSG_CONTACT_LIST, 0x36D4 },
            { Opcode.CMSG_SEND_MAIL, 0x35FB },
            { Opcode.CMSG_SEND_TEXT_EMOTE, 0x3488 },
            { Opcode.CMSG_SERVER_TIME_OFFSET_REQUEST, 0x369A },
            { Opcode.CMSG_SET_ACHIEVEMENTS_HIDDEN, 0x3224 },
            { Opcode.CMSG_SET_ACTION_BAR_TOGGLES, 0x3532 },
            { Opcode.CMSG_SET_ACTION_BUTTON, 0x355D },
            { Opcode.CMSG_SET_ACTIVE_MOVER, 0x3A3D },
            { Opcode.CMSG_SET_ADVANCED_COMBAT_LOGGING, 0x32AE },
            { Opcode.CMSG_SET_ASSISTANT_LEADER, 0x3651 },
            { Opcode.CMSG_SET_CONTACT_NOTES, 0x36D7 },
            { Opcode.CMSG_SET_DIFFICULTY_ID, 0x3220 },
            { Opcode.CMSG_SET_DUNGEON_DIFFICULTY, 0x3683 },
            { Opcode.CMSG_SET_EVERYONE_IS_ASSISTANT, 0x3619 },
            { Opcode.CMSG_SET_FACTION_AT_WAR, 0x34DE },
            { Opcode.CMSG_SET_FACTION_INACTIVE, 0x34E0 },
            { Opcode.CMSG_SET_FACTION_NOT_AT_WAR, 0x34DF },
            { Opcode.CMSG_SET_LOOT_METHOD, 0x364A },
            { Opcode.CMSG_SET_LOOT_SPECIALIZATION, 0x353F },
            { Opcode.CMSG_SET_PARTY_ASSIGNMENT, 0x3653 },
            { Opcode.CMSG_SET_PARTY_LEADER, 0x364C },
            { Opcode.CMSG_SET_PLAYER_DECLINED_NAMES, 0x3688 },
            { Opcode.CMSG_SET_PREFERRED_CEMETERY, 0x317A },
            { Opcode.CMSG_SET_PVP, 0x32A5 },
            { Opcode.CMSG_SET_RAID_DIFFICULTY, 0x36E0 },
            { Opcode.CMSG_SET_ROLE, 0x35D9 },
            { Opcode.CMSG_SET_SELECTION, 0x3528 },
            { Opcode.CMSG_SET_SHEATHED, 0x3489 },
            { Opcode.CMSG_SET_TAXI_BENCHMARK_MODE, 0x34F3 },
            { Opcode.CMSG_SET_TITLE, 0x327A },
            { Opcode.CMSG_SET_TRADE_CURRENCY, 0x3160 },
            { Opcode.CMSG_SET_TRADE_GOLD, 0x315F },
            { Opcode.CMSG_SET_TRADE_ITEM, 0x315D },
            { Opcode.CMSG_SET_WAR_MODE, 0x32A6 },
            { Opcode.CMSG_SET_WATCHED_FACTION, 0x34E1 },
            { Opcode.CMSG_SHOW_TRADE_SKILL, 0x36C7 },
            { Opcode.CMSG_SIGN_PETITION, 0x3533 },
            { Opcode.CMSG_SILENCE_PARTY_TALKER, 0x3654 },
            { Opcode.CMSG_SOCIAL_CONTRACT_REQUEST, 0x3743 },
            { Opcode.CMSG_SOCKET_GEMS, 0x34EB },
            { Opcode.CMSG_SPELL_CLICK, 0x3495 },
            { Opcode.CMSG_SPIRIT_HEALER_ACTIVATE, 0x34AF },
            { Opcode.CMSG_SPLIT_GUILD_BANK_ITEM, 0x34C1 },
            { Opcode.CMSG_SPLIT_GUILD_BANK_ITEM_TO_INVENTORY, 0x34BE },
            { Opcode.CMSG_SPLIT_ITEM, 0x399C },
            { Opcode.CMSG_SPLIT_ITEM_TO_GUILD_BANK, 0x34BC },
            { Opcode.CMSG_STABLE_PET, 0x3168 },
            { Opcode.CMSG_STABLE_SWAP_PET, 0x316A },
            { Opcode.CMSG_STAND_STATE_CHANGE, 0x318D },
            { Opcode.CMSG_START_CHALLENGE_MODE, 0x354A },
            { Opcode.CMSG_START_SPECTATOR_WAR_GAME, 0x35E0 },
            { Opcode.CMSG_START_WAR_GAME, 0x35DF },
            { Opcode.CMSG_STORE_GUILD_BANK_ITEM, 0x34B7 },
            { Opcode.CMSG_SUBMIT_USER_FEEDBACK, 0x3692 },
            { Opcode.CMSG_SUMMON_RESPONSE, 0x366B },
            { Opcode.CMSG_SUPPORT_TICKET_SUBMIT_COMPLAINT, 0x3646 },
            { Opcode.CMSG_SURRENDER_ARENA, 0x3177 },
            { Opcode.CMSG_SUSPEND_COMMS_ACK, 0x3764 },
            { Opcode.CMSG_SUSPEND_TOKEN_RESPONSE, 0x376A },
            { Opcode.CMSG_SWAP_GUILD_BANK_ITEM_WITH_GUILD_BANK_ITEM, 0x34B9 },
            { Opcode.CMSG_SWAP_INV_ITEM, 0x399B },
            { Opcode.CMSG_SWAP_ITEM, 0x399A },
            { Opcode.CMSG_SWAP_ITEM_WITH_GUILD_BANK_ITEM, 0x34B8 },
            { Opcode.CMSG_GROUP_SWAP_SUB_GROUP, 0x364F },
            { Opcode.CMSG_SWAP_VOID_ITEM, 0x31A6 },
            { Opcode.CMSG_TABARD_VENDOR_ACTIVATE, 0x32A2 },
            { Opcode.CMSG_TALK_TO_GOSSIP, 0x3492 },
            { Opcode.CMSG_TAXI_NODE_STATUS_QUERY, 0x34A8 },
            { Opcode.CMSG_TAXI_QUERY_AVAILABLE_NODES, 0x34AA },
            { Opcode.CMSG_TAXI_REQUEST_EARLY_LANDING, 0x34AC },
            { Opcode.CMSG_TIME_ADJUSTMENT_RESPONSE, 0x3A41 },
            { Opcode.CMSG_TIME_SYNC_RESPONSE, 0x3A3E },
            { Opcode.CMSG_TIME_SYNC_RESPONSE_DROPPED, 0x3A40 },
            { Opcode.CMSG_TIME_SYNC_RESPONSE_FAILED, 0x3A3F },
            { Opcode.CMSG_TOGGLE_DIFFICULTY, 0x3659 },
            { Opcode.CMSG_TOGGLE_PVP, 0x32A4 },
            { Opcode.CMSG_TOTEM_DESTROYED, 0x34F8 },
            { Opcode.CMSG_TOY_CLEAR_FANFARE, 0x312E },
            { Opcode.CMSG_TRAINER_BUY_SPELL, 0x34AE },
            { Opcode.CMSG_TRAINER_LIST, 0x34AD },
            { Opcode.CMSG_TURN_IN_PETITION, 0x3535 },
            { Opcode.CMSG_TUTORIAL, 0x36E1 },
            { Opcode.CMSG_TWITTER_CHECK_STATUS, 0x312A },
            { Opcode.CMSG_TWITTER_CONNECT, 0x3127 },
            { Opcode.CMSG_TWITTER_DISCONNECT, 0x312B },
            { Opcode.CMSG_UNACCEPT_TRADE, 0x315B },
            { Opcode.CMSG_UNDELETE_CHARACTER, 0x36E3 },
            { Opcode.CMSG_UNLEARN_SKILL, 0x34E5 },
            { Opcode.CMSG_UNLEARN_SPECIALIZATION, 0x31A7 },
            { Opcode.CMSG_UNLOCK_VOID_STORAGE, 0x31A3 },
            { Opcode.CMSG_UNSTABLE_PET, 0x3169 },
            { Opcode.CMSG_SET_CHAT_DISABLED, 0x373F },
            { Opcode.CMSG_UPDATE_ACCOUNT_DATA, 0x3694 },
            { Opcode.CMSG_UPDATE_AREA_TRIGGER_VISUAL, 0x3297 },
            { Opcode.CMSG_UPDATE_CLIENT_SETTINGS, 0x3665 },
            { Opcode.CMSG_UPDATE_MISSILE_TRAJECTORY, 0x3A44 },
            { Opcode.CMSG_UPDATE_RAID_TARGET, 0x3652 },
            { Opcode.CMSG_UPDATE_SPELL_VISUAL, 0x3296 },
            { Opcode.CMSG_UPDATE_VAS_PURCHASE_STATES, 0x36F8 },
            { Opcode.CMSG_USED_FOLLOW, 0x318A },
            { Opcode.CMSG_USE_CRITTER_ITEM, 0x323D },
            { Opcode.CMSG_USE_EQUIPMENT_SET, 0x3995 },
            { Opcode.CMSG_USE_ITEM, 0x3291 },
            { Opcode.CMSG_VAS_CHECK_TRANSFER_OK, 0x3711 },
            { Opcode.CMSG_VAS_GET_QUEUE_MINUTES, 0x3710 },
            { Opcode.CMSG_VAS_GET_SERVICE_STATUS, 0x370F },
            { Opcode.CMSG_VIOLENCE_LEVEL, 0x3188 },
            { Opcode.CMSG_VOICE_CHANNEL_STT_TOKEN_REQUEST, 0x3715 },
            { Opcode.CMSG_VOICE_CHAT_JOIN_CHANNEL, 0x3716 },
            { Opcode.CMSG_VOICE_CHAT_LOGIN, 0x3714 },
            { Opcode.CMSG_VOID_STORAGE_TRANSFER, 0x31A5 },
            { Opcode.CMSG_WARDEN3_DATA, 0x35ED },
            { Opcode.CMSG_WHO, 0x3682 },
            { Opcode.CMSG_WHO_IS, 0x3681 },
            { Opcode.CMSG_WORLD_PORT_RESPONSE, 0x35FA },
            { Opcode.CMSG_WRAP_ITEM, 0x3994 },
            { Opcode.CMSG_UNKNOWN_8192, 0x2000 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_8232, 0x2028 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_9392, 0x24B0 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_9999, 0x270F }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_10032, 0x2730 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_10304, 0x2840 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_10712, 0x29D8 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_10808, 0x2A38 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12152, 0x2F78 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12380, 0x305C }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12406, 0x3076 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12407, 0x3077 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12408, 0x3078 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12409, 0x3079 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12410, 0x307A }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12412, 0x307C }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12413, 0x307D }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12415, 0x307F }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12416, 0x3080 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12417, 0x3081 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12425, 0x3089 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12426, 0x308A }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12427, 0x308B }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12428, 0x308C }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12429, 0x308D }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12430, 0x308E }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12431, 0x308F }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12432, 0x3090 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12433, 0x3091 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12580, 0x3124 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12581, 0x3125 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12582, 0x3126 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12584, 0x3128 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12585, 0x3129 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12592, 0x3130 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12593, 0x3131 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12594, 0x3132 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12595, 0x3133 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12596, 0x3134 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12597, 0x3135 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12598, 0x3136 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12599, 0x3137 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12600, 0x3138 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12601, 0x3139 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12602, 0x313A }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12641, 0x3161 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12642, 0x3162 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12643, 0x3163 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12644, 0x3164 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12645, 0x3165 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12646, 0x3166 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12647, 0x3167 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12652, 0x316C }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12653, 0x316D }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12654, 0x316E }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12655, 0x316F }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12656, 0x3170 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12657, 0x3171 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12658, 0x3172 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12659, 0x3173 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12660, 0x3174 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12661, 0x3175 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12668, 0x317C }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12669, 0x317D }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12672, 0x3180 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12678, 0x3186 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12679, 0x3187 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12681, 0x3189 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12683, 0x318B }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12684, 0x318C }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12688, 0x3190 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12689, 0x3191 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12690, 0x3192 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12691, 0x3193 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12692, 0x3194 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12693, 0x3195 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12694, 0x3196 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12696, 0x3198 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12697, 0x3199 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12698, 0x319A }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12699, 0x319B }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12700, 0x319C }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12701, 0x319D }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12702, 0x319E }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12703, 0x319F }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12704, 0x31A0 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12705, 0x31A1 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12706, 0x31A2 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12721, 0x31B1 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12724, 0x31B4 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12725, 0x31B5 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12726, 0x31B6 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12727, 0x31B7 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12728, 0x31B8 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12729, 0x31B9 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12730, 0x31BA }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12731, 0x31BB }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12732, 0x31BC }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12733, 0x31BD }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12734, 0x31BE }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12735, 0x31BF }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12736, 0x31C0 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12737, 0x31C1 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12738, 0x31C2 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12739, 0x31C3 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12740, 0x31C4 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12741, 0x31C5 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12742, 0x31C6 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12743, 0x31C7 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12744, 0x31C8 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12745, 0x31C9 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12746, 0x31CA }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12747, 0x31CB }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12748, 0x31CC }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12749, 0x31CD }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12750, 0x31CE }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12751, 0x31CF }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12752, 0x31D0 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12753, 0x31D1 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12754, 0x31D2 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12755, 0x31D3 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12757, 0x31D5 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12758, 0x31D6 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12760, 0x31D8 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12761, 0x31D9 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12773, 0x31E5 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12774, 0x31E6 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12775, 0x31E7 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12776, 0x31E8 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12777, 0x31E9 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12778, 0x31EA }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12779, 0x31EB }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12780, 0x31EC }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12781, 0x31ED }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12782, 0x31EE }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12783, 0x31EF }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12784, 0x31F0 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12785, 0x31F1 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12786, 0x31F2 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12787, 0x31F3 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12788, 0x31F4 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12789, 0x31F5 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12790, 0x31F6 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12791, 0x31F7 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12792, 0x31F8 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12793, 0x31F9 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12794, 0x31FA }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12795, 0x31FB }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12796, 0x31FC }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12797, 0x31FD }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12798, 0x31FE }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12799, 0x31FF }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12800, 0x3200 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12806, 0x3206 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12808, 0x3208 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12810, 0x320A }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12812, 0x320C }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12819, 0x3213 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12820, 0x3214 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12821, 0x3215 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12822, 0x3216 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12823, 0x3217 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12824, 0x3218 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12825, 0x3219 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12826, 0x321A }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12827, 0x321B }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12828, 0x321C }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12838, 0x3226 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12839, 0x3227 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12840, 0x3228 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12841, 0x3229 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12842, 0x322A }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12843, 0x322B }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12844, 0x322C }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12845, 0x322D }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12846, 0x322E }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12847, 0x322F }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12848, 0x3230 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12849, 0x3231 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12850, 0x3232 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12857, 0x3239 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12858, 0x323A }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12859, 0x323B }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12860, 0x323C }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12862, 0x323E }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12863, 0x323F }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12864, 0x3240 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12865, 0x3241 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12866, 0x3242 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12868, 0x3244 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12869, 0x3245 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12870, 0x3246 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12871, 0x3247 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12872, 0x3248 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12873, 0x3249 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12874, 0x324A }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12875, 0x324B }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12876, 0x324C }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12877, 0x324D }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12878, 0x324E }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12879, 0x324F }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12880, 0x3250 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12883, 0x3253 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12884, 0x3254 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12885, 0x3255 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12886, 0x3256 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12887, 0x3257 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12888, 0x3258 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12889, 0x3259 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12890, 0x325A }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12891, 0x325B }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12892, 0x325C }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12893, 0x325D }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12894, 0x325E }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12895, 0x325F }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12896, 0x3260 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12897, 0x3261 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12898, 0x3262 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12899, 0x3263 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12900, 0x3264 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12901, 0x3265 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12903, 0x3267 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12904, 0x3268 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12905, 0x3269 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12906, 0x326A }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12917, 0x3275 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12919, 0x3277 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12920, 0x3278 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12921, 0x3279 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12925, 0x327D }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12926, 0x327E }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12927, 0x327F }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12928, 0x3280 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12929, 0x3281 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12930, 0x3282 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12931, 0x3283 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12932, 0x3284 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12933, 0x3285 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12934, 0x3286 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12935, 0x3287 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12936, 0x3288 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12937, 0x3289 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12938, 0x328A }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12939, 0x328B }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12941, 0x328D }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12942, 0x328E }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12943, 0x328F }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12946, 0x3292 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12947, 0x3293 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12953, 0x3299 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12956, 0x329C }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12958, 0x329E }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12959, 0x329F }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12960, 0x32A0 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12963, 0x32A3 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12967, 0x32A7 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12968, 0x32A8 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12969, 0x32A9 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12971, 0x32AB }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12972, 0x32AC }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12975, 0x32AF }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12976, 0x32B0 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12977, 0x32B1 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12978, 0x32B2 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12979, 0x32B3 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12980, 0x32B4 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12981, 0x32B5 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12982, 0x32B6 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12983, 0x32B7 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12984, 0x32B8 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12985, 0x32B9 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12986, 0x32BA }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12987, 0x32BB }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12988, 0x32BC }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12989, 0x32BD }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12995, 0x32C3 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12996, 0x32C4 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12997, 0x32C5 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12998, 0x32C6 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_12999, 0x32C7 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13000, 0x32C8 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13001, 0x32C9 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13002, 0x32CA }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13003, 0x32CB }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13004, 0x32CC }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13005, 0x32CD }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13006, 0x32CE }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13007, 0x32CF }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13008, 0x32D0 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13009, 0x32D1 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13010, 0x32D2 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13011, 0x32D3 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13012, 0x32D4 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13017, 0x32D9 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13018, 0x32DA }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13019, 0x32DB }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13020, 0x32DC }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13021, 0x32DD }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13022, 0x32DE }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13023, 0x32DF }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13024, 0x32E0 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13025, 0x32E1 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13026, 0x32E2 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13027, 0x32E3 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13028, 0x32E4 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13029, 0x32E5 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13030, 0x32E6 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13031, 0x32E7 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13032, 0x32E8 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13033, 0x32E9 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13034, 0x32EA }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13035, 0x32EB }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13036, 0x32EC }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13037, 0x32ED }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13038, 0x32EE }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13039, 0x32EF }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13040, 0x32F0 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13041, 0x32F1 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13042, 0x32F2 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13043, 0x32F3 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13044, 0x32F4 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13046, 0x32F6 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13048, 0x32F8 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13049, 0x32F9 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13050, 0x32FA }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13051, 0x32FB }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13052, 0x32FC }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13152, 0x3360 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13430, 0x3476 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13431, 0x3477 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13432, 0x3478 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13433, 0x3479 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13434, 0x347A }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13435, 0x347B }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13436, 0x347C }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13437, 0x347D }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13438, 0x347E }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13439, 0x347F }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13440, 0x3480 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13441, 0x3481 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13442, 0x3482 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13443, 0x3483 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13444, 0x3484 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13445, 0x3485 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13446, 0x3486 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13447, 0x3487 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13477, 0x34A5 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13478, 0x34A6 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13479, 0x34A7 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13523, 0x34D3 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13524, 0x34D4 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13527, 0x34D7 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13530, 0x34DA }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13532, 0x34DC }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13539, 0x34E3 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13540, 0x34E4 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13542, 0x34E6 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13545, 0x34E9 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13546, 0x34EA }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13549, 0x34ED }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13552, 0x34F0 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13553, 0x34F1 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13559, 0x34F7 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13562, 0x34FA }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13563, 0x34FB }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13564, 0x34FC }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13565, 0x34FD }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13566, 0x34FE }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13567, 0x34FF }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13569, 0x3501 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13570, 0x3502 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13571, 0x3503 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13572, 0x3504 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13573, 0x3505 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13575, 0x3507 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13576, 0x3508 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13580, 0x350C }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13581, 0x350D }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13582, 0x350E }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13583, 0x350F }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13584, 0x3510 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13585, 0x3511 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13587, 0x3513 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13588, 0x3514 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13589, 0x3515 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13590, 0x3516 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13591, 0x3517 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13592, 0x3518 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13593, 0x3519 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13594, 0x351A }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13595, 0x351B }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13596, 0x351C }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13599, 0x351F }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13604, 0x3524 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13628, 0x353C }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13629, 0x353D }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13630, 0x353E }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13632, 0x3540 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13634, 0x3542 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13640, 0x3548 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13643, 0x354B }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13644, 0x354C }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13645, 0x354D }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13646, 0x354E }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13647, 0x354F }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13648, 0x3550 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13649, 0x3551 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13651, 0x3553 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13652, 0x3554 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13653, 0x3555 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13654, 0x3556 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13655, 0x3557 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13656, 0x3558 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13657, 0x3559 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13658, 0x355A }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13659, 0x355B }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13660, 0x355C }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13662, 0x355E }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13663, 0x355F }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13664, 0x3560 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13665, 0x3561 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13666, 0x3562 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13667, 0x3563 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13668, 0x3564 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13669, 0x3565 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13670, 0x3566 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13671, 0x3567 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13760, 0x35C0 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13781, 0x35D5 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13782, 0x35D6 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13783, 0x35D7 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13787, 0x35DB }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13788, 0x35DC }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13790, 0x35DE }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13794, 0x35E2 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13795, 0x35E3 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13799, 0x35E7 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13804, 0x35EC }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13806, 0x35EE }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13815, 0x35F7 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13820, 0x35FC }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13822, 0x35FE }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13823, 0x35FF }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13824, 0x3600 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13825, 0x3601 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13826, 0x3602 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13828, 0x3604 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13830, 0x3606 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13851, 0x361B }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13852, 0x361C }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13853, 0x361D }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13854, 0x361E }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13855, 0x361F }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13856, 0x3620 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13857, 0x3621 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13858, 0x3622 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13859, 0x3623 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13864, 0x3628 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13867, 0x362B }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13868, 0x362C }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13869, 0x362D }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13871, 0x362F }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13872, 0x3630 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13874, 0x3632 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13879, 0x3637 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13880, 0x3638 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13881, 0x3639 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13882, 0x363A }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13883, 0x363B }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13884, 0x363C }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13885, 0x363D }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13886, 0x363E }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13887, 0x363F }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13888, 0x3640 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13889, 0x3641 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13895, 0x3647 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13896, 0x3648 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13914, 0x365A }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13916, 0x365C }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13917, 0x365D }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13918, 0x365E }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13919, 0x365F }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13920, 0x3660 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13924, 0x3664 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13926, 0x3666 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13927, 0x3667 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13928, 0x3668 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13930, 0x366A }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13932, 0x366C }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13934, 0x366E }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13935, 0x366F }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13949, 0x367D }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13959, 0x3687 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13964, 0x368C }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13968, 0x3690 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13973, 0x3695 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13974, 0x3696 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13975, 0x3697 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13976, 0x3698 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13977, 0x3699 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13980, 0x369C }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13981, 0x369D }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13982, 0x369E }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13984, 0x36A0 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13987, 0x36A3 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13988, 0x36A4 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13989, 0x36A5 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13990, 0x36A6 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13991, 0x36A7 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13992, 0x36A8 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13993, 0x36A9 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13994, 0x36AA }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13995, 0x36AB }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13996, 0x36AC }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13997, 0x36AD }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13998, 0x36AE }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_13999, 0x36AF }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14000, 0x36B0 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14001, 0x36B1 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14002, 0x36B2 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14003, 0x36B3 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14004, 0x36B4 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14019, 0x36C3 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14020, 0x36C4 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14021, 0x36C5 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14028, 0x36CC }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14035, 0x36D3 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14043, 0x36DB }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14044, 0x36DC }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14045, 0x36DD }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14046, 0x36DE }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14047, 0x36DF }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14053, 0x36E5 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14054, 0x36E6 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14055, 0x36E7 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14068, 0x36F4 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14073, 0x36F9 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14075, 0x36FB }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14077, 0x36FD }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14079, 0x36FF }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14080, 0x3700 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14081, 0x3701 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14082, 0x3702 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14083, 0x3703 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14084, 0x3704 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14088, 0x3708 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14091, 0x370B }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14099, 0x3713 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14103, 0x3717 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14104, 0x3718 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14106, 0x371A }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14107, 0x371B }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14108, 0x371C }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14109, 0x371D }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14125, 0x372D }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14126, 0x372E }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14127, 0x372F }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14128, 0x3730 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14129, 0x3731 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14130, 0x3732 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14132, 0x3734 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14133, 0x3735 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14134, 0x3736 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14135, 0x3737 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14137, 0x3739 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14141, 0x373D }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14142, 0x373E }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14145, 0x3741 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14146, 0x3742 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14148, 0x3744 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14149, 0x3745 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14150, 0x3746 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14190, 0x376E }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14195, 0x3773 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14196, 0x3774 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14197, 0x3775 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14282, 0x37CA }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14298, 0x37DA }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14301, 0x37DD }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14302, 0x37DE }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14320, 0x37F0 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14321, 0x37F1 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14322, 0x37F2 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14323, 0x37F3 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14576, 0x38F0 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14836, 0x39F4 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14837, 0x39F5 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14838, 0x39F6 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14839, 0x39F7 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14840, 0x39F8 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14841, 0x39F9 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14846, 0x39FE }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14847, 0x39FF }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14848, 0x3A00 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14849, 0x3A01 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14850, 0x3A02 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14851, 0x3A03 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14852, 0x3A04 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14853, 0x3A05 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14855, 0x3A07 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14856, 0x3A08 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14866, 0x3A12 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14880, 0x3A20 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14881, 0x3A21 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14892, 0x3A2C }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14893, 0x3A2D }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14898, 0x3A32 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14918, 0x3A46 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14920, 0x3A48 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14921, 0x3A49 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_14922, 0x3A4A }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_16816, 0x41B0 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_18072, 0x4698 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.CMSG_UNKNOWN_18088, 0x46A8 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
        };

        private static readonly BiDictionary<Opcode, int> ServerOpcodes = new BiDictionary<Opcode, int>
        {
            { Opcode.SMSG_ABORT_NEW_WORLD, 0x259C },
            { Opcode.SMSG_ACCOUNT_CRITERIA_UPDATE, 0x2869 },
            { Opcode.SMSG_ACCOUNT_DATA_TIMES, 0x2706 },
            { Opcode.SMSG_ACCOUNT_HEIRLOOM_UPDATE, 0x25B0 },
            { Opcode.SMSG_ACCOUNT_MOUNT_UPDATE, 0x25AE },
            { Opcode.SMSG_ACCOUNT_NOTIFICATIONS_RESPONSE, 0x2885 },
            { Opcode.SMSG_ACCOUNT_TOY_UPDATE, 0x25AF },
            { Opcode.SMSG_ACCOUNT_TRANSMOG_SET_FAVORITES_UPDATE, 0x25B2 },
            { Opcode.SMSG_ACCOUNT_TRANSMOG_UPDATE, 0x25B1 },
            { Opcode.SMSG_ACHIEVEMENT_DELETED, 0x26E5 },
            { Opcode.SMSG_ACHIEVEMENT_EARNED, 0x2640 },
            { Opcode.SMSG_ACTIVATE_ESSENCE_FAILED, 0x3015 },
            { Opcode.SMSG_ACTIVATE_SOULBIND_FAILED, 0x3017 },
            { Opcode.SMSG_ACTIVATE_TAXI_REPLY, 0x267A },
            { Opcode.SMSG_ACTIVE_GLYPHS, 0x2C54 },
            { Opcode.SMSG_ADDON_LIST_REQUEST, 0x263F },
            { Opcode.SMSG_ADD_BATTLENET_FRIEND_RESPONSE, 0x263A },
            { Opcode.SMSG_ADD_ITEM_PASSIVE, 0x25AA },
            { Opcode.SMSG_ADD_LOSS_OF_CONTROL, 0x266E },
            { Opcode.SMSG_ADD_RUNE_POWER, 0x26B5 },
            { Opcode.SMSG_ADJUST_SPLINE_DURATION, 0x25CE },
            { Opcode.SMSG_ADVENTURE_JOURNAL_DATA_RESPONSE, 0x287A },
            { Opcode.SMSG_ADVENTURE_MAP_OPEN_NPC, 0x27F6 },
            { Opcode.SMSG_AE_LOOT_TARGETS, 0x2615 },
            { Opcode.SMSG_AE_LOOT_TARGET_ACK, 0x2616 },
            { Opcode.SMSG_AI_REACTION, 0x26B2 },
            { Opcode.SMSG_ALLIED_RACE_DETAILS, 0x27FC },
            { Opcode.SMSG_ALL_ACCOUNT_CRITERIA, 0x2571 },
            { Opcode.SMSG_ALL_ACHIEVEMENT_DATA, 0x2570 },
            { Opcode.SMSG_ALL_GUILD_ACHIEVEMENTS, 0x29B8 },
            { Opcode.SMSG_ARCHAEOLOGY_SURVERY_CAST, 0x2588 },
            { Opcode.SMSG_AREA_POI_UPDATE_RESPONSE, 0x3010 },
            { Opcode.SMSG_AREA_SPIRIT_HEALER_TIME, 0x273C },
            { Opcode.SMSG_AREA_TRIGGER_DENIED, 0x2902 },
            { Opcode.SMSG_AREA_TRIGGER_FORCE_SET_POSITION_AND_FACING, 0x28FF },
            { Opcode.SMSG_AREA_TRIGGER_MESSAGE, 0x2882 },
            { Opcode.SMSG_AREA_TRIGGER_NO_CORPSE, 0x2712 },
            { Opcode.SMSG_AREA_TRIGGER_RE_PATH, 0x28FD },
            { Opcode.SMSG_AREA_TRIGGER_RE_SHAPE, 0x2901 },
            { Opcode.SMSG_AREA_TRIGGER_UNATTACH, 0x2900 },
            { Opcode.SMSG_ARENA_CLEAR_OPPONENTS, 0x2646 },
            { Opcode.SMSG_ARENA_CROWD_CONTROL_SPELL_RESULT, 0x262F },
            { Opcode.SMSG_ARENA_PREP_OPPONENT_SPECIALIZATIONS, 0x2645 },
            { Opcode.SMSG_ARENA_TEAM_COMMAND_RESULT, 0x275F },
            { Opcode.SMSG_ARENA_TEAM_EVENT, 0x275E },
            { Opcode.SMSG_ARENA_TEAM_INVITE, 0x275D },
            { Opcode.SMSG_ARENA_TEAM_ROSTER, 0x275C },
            { Opcode.SMSG_ARENA_TEAM_STATS, 0x2760 },
            { Opcode.SMSG_ARTIFACT_XP_GAIN, 0x27EF },
            { Opcode.SMSG_ATTACKER_STATE_UPDATE, 0x2951 },
            { Opcode.SMSG_ATTACK_START, 0x293C },
            { Opcode.SMSG_ATTACK_STOP, 0x293D },
            { Opcode.SMSG_ATTACK_SWING_ERROR, 0x294B },
            { Opcode.SMSG_ATTACK_SWING_LANDED_LOG, 0x294C },
            { Opcode.SMSG_AUCTIONABLE_TOKEN_AUCTION_SOLD, 0x27D8 },
            { Opcode.SMSG_AUCTIONABLE_TOKEN_SELL_AT_MARKET_PRICE_RESPONSE, 0x27D7 },
            { Opcode.SMSG_AUCTIONABLE_TOKEN_SELL_CONFIRM_REQUIRED, 0x27D6 },
            { Opcode.SMSG_AUCTION_CLOSED_NOTIFICATION, 0x26EF },
            { Opcode.SMSG_AUCTION_COMMAND_RESULT, 0x26EC },
            { Opcode.SMSG_AUCTION_FAVORITE_LIST, 0x2870 },
            { Opcode.SMSG_AUCTION_HELLO_RESPONSE, 0x26EA },
            { Opcode.SMSG_AUCTION_LIST_BIDDED_ITEMS_RESULT, 0x287F },
            { Opcode.SMSG_AUCTION_LIST_ITEMS_RESULT, 0x2864 },
            { Opcode.SMSG_AUCTION_LIST_OWNED_ITEMS_RESULT, 0x287E },
            { Opcode.SMSG_AUCTION_OUTBID_NOTIFICATION, 0x26EE },
            { Opcode.SMSG_AUCTION_OWNER_BID_NOTIFICATION, 0x26F0 },
            { Opcode.SMSG_AUCTION_REPLICATE_RESPONSE, 0x26EB },
            { Opcode.SMSG_AUCTION_WON_NOTIFICATION, 0x26ED },
            { Opcode.SMSG_AURA_POINTS_DEPLETED, 0x2C23 },
            { Opcode.SMSG_AURA_UPDATE, 0x2C22 },
            { Opcode.SMSG_AUTH_CHALLENGE, 0x3048 },
            { Opcode.SMSG_AUTH_FAILED, 0x256C },
            { Opcode.SMSG_AUTH_RESPONSE, 0x256D },
            { Opcode.SMSG_AVAILABLE_HOTFIXES, 0x290F },
            { Opcode.SMSG_AZERITE_RESPEC_NPC, 0x27F9 },
            { Opcode.SMSG_BAG_CLEANUP_FINISHED, 0x2DA7 },
            { Opcode.SMSG_UNKNOWN_9651, 0x25B3 }, // unidentified. Same layout as SMSG_ACCOUNT_TRANSMOG_UPDATE (2 bits, 2 u32 counts, 2 u32 arrays); sent once at login right after SMSG_ACCOUNT_MOUNT_UPDATE/SET_FAVORITES, always c0 00.. (9 bytes, counts 0). Probably a collection sibling (illusions/sets). 46779 handler confirmed, not named
            { Opcode.SMSG_UNKNOWN_9714, 0x25F2 }, // unidentified. u32 A, u32 B, then A packed guid128, then B packed guid128; sent during play near SMSG_PARTY_UPDATE, mostly empty (A>0 only, B always 0), up to 24 player guids. 46779 handler confirmed, not named
            { Opcode.SMSG_CONFIRM_BARBERS_CHOICE, 0x26BA },
            { Opcode.SMSG_BARBER_SHOP_RESULT, 0x26BB },
            { Opcode.SMSG_BATCH_PRESENCE_SUBSCRIPTION, 0x2847 },
            { Opcode.SMSG_BATTLEFIELD_LIST, 0x2927 },
            { Opcode.SMSG_BATTLEFIELD_PORT_DENIED, 0x292D },
            { Opcode.SMSG_BATTLEFIELD_STATUS_ACTIVE, 0x2923 },
            { Opcode.SMSG_BATTLEFIELD_STATUS_FAILED, 0x2926 },
            { Opcode.SMSG_BATTLEFIELD_STATUS_GROUP_PROPOSAL_FAILED, 0x2930 },
            { Opcode.SMSG_BATTLEFIELD_STATUS_NEED_CONFIRMATION, 0x2922 },
            { Opcode.SMSG_BATTLEFIELD_STATUS_NONE, 0x2925 },
            { Opcode.SMSG_BATTLEFIELD_STATUS_QUEUED, 0x2924 },
            { Opcode.SMSG_BATTLEFIELD_STATUS_WAIT_FOR_GROUPS, 0x292F },
            { Opcode.SMSG_BATTLEGROUND_INFO_THROTTLED, 0x292E },
            { Opcode.SMSG_BATTLEGROUND_INIT, 0x294E },
            { Opcode.SMSG_BATTLEGROUND_PLAYER_JOINED, 0x292B },
            { Opcode.SMSG_BATTLEGROUND_PLAYER_LEFT, 0x292C },
            { Opcode.SMSG_BATTLEGROUND_PLAYER_POSITIONS, 0x2928 },
            { Opcode.SMSG_BATTLEGROUND_POINTS, 0x294D },
            { Opcode.SMSG_BATTLENET_CHALLENGE_ABORT, 0x278C },
            { Opcode.SMSG_BATTLENET_CHALLENGE_START, 0x278B },
            { Opcode.SMSG_BATTLENET_NOTIFICATION, 0x2807 },
            { Opcode.SMSG_BATTLENET_RESPONSE, 0x2806 },
            { Opcode.SMSG_BATTLE_NET_CONNECTION_STATUS, 0x2808 },
            { Opcode.SMSG_BATTLE_PAY_ACK_FAILED, 0x2784 },
            { Opcode.SMSG_BATTLE_PAY_BATTLE_PET_DELIVERED, 0x2779 },
            { Opcode.SMSG_BATTLE_PAY_COLLECTION_ITEM_DELIVERED, 0x277A },
            { Opcode.SMSG_BATTLE_PAY_CONFIRM_PURCHASE, 0x2783 },
            { Opcode.SMSG_BATTLE_PAY_DELIVERY_ENDED, 0x2777 },
            { Opcode.SMSG_BATTLE_PAY_DELIVERY_STARTED, 0x2776 },
            { Opcode.SMSG_BATTLE_PAY_DISTRIBUTION_UNREVOKED, 0x2774 },
            { Opcode.SMSG_BATTLE_PAY_DISTRIBUTION_UPDATE, 0x2775 },
            { Opcode.SMSG_BATTLE_PAY_GET_DISTRIBUTION_LIST_RESPONSE, 0x2773 },
            { Opcode.SMSG_BATTLE_PAY_GET_PRODUCT_LIST_RESPONSE, 0x2771 },
            { Opcode.SMSG_BATTLE_PAY_GET_PURCHASE_LIST_RESPONSE, 0x2772 },
            { Opcode.SMSG_BATTLE_PAY_MOUNT_DELIVERED, 0x2778 },
            { Opcode.SMSG_BATTLE_PAY_PURCHASE_UPDATE, 0x2782 },
            { Opcode.SMSG_BATTLE_PAY_START_CHECKOUT, 0x2823 },
            { Opcode.SMSG_BATTLE_PAY_START_DISTRIBUTION_ASSIGN_TO_TARGET_RESPONSE, 0x2780 },
            { Opcode.SMSG_BATTLE_PAY_START_PURCHASE_RESPONSE, 0x277F },
            { Opcode.SMSG_BATTLE_PAY_VALIDATE_PURCHASE_RESPONSE, 0x2817 },
            { Opcode.SMSG_BATTLE_PETS_HEALED, 0x25EF },
            { Opcode.SMSG_BATTLE_PET_CAGE_DATE_ERROR, 0x2675 },
            { Opcode.SMSG_BATTLE_PET_DELETED, 0x25EC },
            { Opcode.SMSG_BATTLE_PET_ERROR, 0x2635 },
            { Opcode.SMSG_BATTLE_PET_JOURNAL, 0x25EB },
            { Opcode.SMSG_BATTLE_PET_JOURNAL_LOCK_ACQUIRED, 0x25E9 },
            { Opcode.SMSG_BATTLE_PET_JOURNAL_LOCK_DENIED, 0x25EA },
            { Opcode.SMSG_BATTLE_PET_LICENSE_CHANGED, 0x25F0 },
            { Opcode.SMSG_BATTLE_PET_RESTORED, 0x25EE },
            { Opcode.SMSG_BATTLE_PET_REVOKED, 0x25ED },
            { Opcode.SMSG_BATTLE_PET_TRAP_LEVEL, 0x25E7 },
            { Opcode.SMSG_BATTLE_PET_UPDATES, 0x25E6 },
            { Opcode.SMSG_BINDER_CONFIRM, 0x26F9 },
            { Opcode.SMSG_BIND_POINT_UPDATE, 0x257D },
            { Opcode.SMSG_BLACK_MARKET_BID_ON_ITEM_RESULT, 0x2625 },
            { Opcode.SMSG_BLACK_MARKET_OPEN_RESULT, 0x2623 },
            { Opcode.SMSG_BLACK_MARKET_OUTBID, 0x2626 },
            { Opcode.SMSG_BLACK_MARKET_REQUEST_ITEMS_RESULT, 0x2624 },
            { Opcode.SMSG_BLACK_MARKET_WON, 0x2627 },
            { Opcode.SMSG_BONUS_ROLL_EMPTY, 0x2642 },
            { Opcode.SMSG_BOSS_KILL, 0x2950 },
            { Opcode.SMSG_BREAK_TARGET, 0x293B },
            { Opcode.SMSG_BROADCAST_ACHIEVEMENT, 0x2BBC },
            { Opcode.SMSG_BROADCAST_SUMMON_CAST, 0x2849 },
            { Opcode.SMSG_BROADCAST_SUMMON_RESPONSE, 0x284A },
            { Opcode.SMSG_BUY_FAILED, 0x26C4 },
            { Opcode.SMSG_BUY_SUCCEEDED, 0x26C3 },
            { Opcode.SMSG_CACHE_INFO, 0x291D },
            { Opcode.SMSG_CACHE_VERSION, 0x291C },
            { Opcode.SMSG_CALENDAR_CLEAR_PENDING_ACTION, 0x269A },
            { Opcode.SMSG_CALENDAR_COMMAND_RESULT, 0x269B },
            { Opcode.SMSG_CALENDAR_COMMUNITY_INVITE, 0x268A },
            { Opcode.SMSG_CALENDAR_EVENT_REMOVED_ALERT, 0x2692 },
            { Opcode.SMSG_CALENDAR_EVENT_UPDATED_ALERT, 0x2693 },
            { Opcode.SMSG_CALENDAR_INVITE_ADDED, 0x268B },
            { Opcode.SMSG_CALENDAR_INVITE_ALERT, 0x268F },
            { Opcode.SMSG_CALENDAR_INVITE_NOTES, 0x2694 },
            { Opcode.SMSG_CALENDAR_INVITE_NOTES_ALERT, 0x2695 },
            { Opcode.SMSG_CALENDAR_INVITE_REMOVED, 0x268C },
            { Opcode.SMSG_CALENDAR_INVITE_REMOVED_ALERT, 0x2691 },
            { Opcode.SMSG_CALENDAR_INVITE_STATUS, 0x268D },
            { Opcode.SMSG_CALENDAR_INVITE_STATUS_ALERT, 0x2690 },
            { Opcode.SMSG_CALENDAR_MODERATOR_STATUS, 0x268E },
            { Opcode.SMSG_CALENDAR_RAID_LOCKOUT_ADDED, 0x2696 },
            { Opcode.SMSG_CALENDAR_RAID_LOCKOUT_REMOVED, 0x2697 },
            { Opcode.SMSG_CALENDAR_RAID_LOCKOUT_UPDATED, 0x2698 },
            { Opcode.SMSG_CALENDAR_SEND_CALENDAR, 0x2688 },
            { Opcode.SMSG_CALENDAR_SEND_EVENT, 0x2689 },
            { Opcode.SMSG_CALENDAR_SEND_NUM_PENDING, 0x2699 },
            { Opcode.SMSG_CAMERA_EFFECT, 0x2722 },
            { Opcode.SMSG_CANCEL_AUTO_REPEAT, 0x26DB },
            { Opcode.SMSG_CANCEL_COMBAT, 0x294A },
            { Opcode.SMSG_CANCEL_ORPHAN_SPELL_VISUAL, 0x2C46 },
            { Opcode.SMSG_CANCEL_SCENE, 0x2634 },
            { Opcode.SMSG_CANCEL_SPELL_VISUAL, 0x2C44 },
            { Opcode.SMSG_CANCEL_SPELL_VISUAL_KIT, 0x2C48 },
            { Opcode.SMSG_CAN_DUEL_RESULT, 0x2946 },
            { Opcode.SMSG_CAN_REDEEM_TOKEN_FOR_BALANCE_RESPONSE, 0x2816 },
            { Opcode.SMSG_CAPTURE_POINT_REMOVED, 0x292A },
            { Opcode.SMSG_CAST_FAILED, 0x2C57 },
            { Opcode.SMSG_CATEGORY_COOLDOWN, 0x2C16 },
            { Opcode.SMSG_CHAIN_MISSILE_BOUNCE, 0x25C6 },
            { Opcode.SMSG_CHANGE_PLAYER_DIFFICULTY_RESULT, 0x3004 },
            { Opcode.SMSG_CHANGE_REALM_TICKET_RESPONSE, 0x2809 },
            { Opcode.SMSG_CHANNEL_LIST, 0x2BC3 },
            { Opcode.SMSG_CHANNEL_NOTIFY, 0x2BC0 },
            { Opcode.SMSG_CHANNEL_NOTIFY_JOINED, 0x2BC1 },
            { Opcode.SMSG_CHANNEL_NOTIFY_LEFT, 0x2BC2 },
            { Opcode.SMSG_CHARACTER_CHECK_UPGRADE_RESULT, 0x27C1 },
            { Opcode.SMSG_CHARACTER_LOGIN_FAILED, 0x2701 },
            { Opcode.SMSG_CHARACTER_OBJECT_TEST_RESPONSE, 0x278A },
            { Opcode.SMSG_CHARACTER_RENAME_RESULT, 0x2763 },
            { Opcode.SMSG_CHARACTER_UPGRADE_ABORTED, 0x27C0 },
            { Opcode.SMSG_CHARACTER_UPGRADE_COMPLETE, 0x27BF },
            { Opcode.SMSG_CHARACTER_UPGRADE_MANUAL_UNREVOKE_RESULT, 0x27C2 },
            { Opcode.SMSG_CHARACTER_UPGRADE_STARTED, 0x27BE },
            { Opcode.SMSG_CHAR_CUSTOMIZE_FAILURE, 0x26DF },
            { Opcode.SMSG_CHAR_CUSTOMIZE_SUCCESS, 0x26E0 },
            { Opcode.SMSG_CHAR_FACTION_CHANGE_RESULT, 0x27AB },
            { Opcode.SMSG_CHAT, 0x2BAD },
            { Opcode.SMSG_CHAT_AUTO_RESPONDED, 0x2BB8 },
            { Opcode.SMSG_CHAT_DOWN, 0x2BBD },
            { Opcode.SMSG_CHAT_IGNORED_ACCOUNT_MUTED, 0x2BAC },
            { Opcode.SMSG_CHAT_IS_DOWN, 0x2BBE },
            { Opcode.SMSG_CHAT_NOT_IN_PARTY, 0x2BB2 },
            { Opcode.SMSG_CHAT_PLAYER_AMBIGUOUS, 0x2BB0 },
            { Opcode.SMSG_CHAT_PLAYER_NOTFOUND, 0x2BB7 },
            { Opcode.SMSG_CHAT_RECONNECT, 0x2BBF },
            { Opcode.SMSG_CHAT_RESTRICTED, 0x2BB3 },
            { Opcode.SMSG_CHAT_SERVER_MESSAGE, 0x2BC4 },
            { Opcode.SMSG_CHEAT_IGNORE_DIMISHING_RETURNS, 0x2C12 },
            { Opcode.SMSG_CHECK_ABANDON_NPE, 0x3018 },
            { Opcode.SMSG_CHECK_CHARACTER_NAME_AVAILABILITY_RESULT, 0x2584 },
            { Opcode.SMSG_CHECK_WARGAME_ENTRY, 0x2594 },
            { Opcode.SMSG_CHROMIE_TIME_OPEN_NPC, 0x27FE },
            { Opcode.SMSG_CHROMIE_TIME_SELECT_EXPANSION_SUCCESS, 0x2874 },
            { Opcode.SMSG_CLEAR_ALL_SPELL_CHARGES, 0x2C27 },
            { Opcode.SMSG_CLEAR_BOSS_EMOTES, 0x25B9 },
            { Opcode.SMSG_CLEAR_COOLDOWN, 0x26B7 },
            { Opcode.SMSG_CLEAR_COOLDOWNS, 0x2C26 },
            { Opcode.SMSG_CLEAR_RESURRECT, 0x257F },
            { Opcode.SMSG_CLEAR_SPELL_CHARGES, 0x2C28 },
            { Opcode.SMSG_CLEAR_TARGET, 0x2947 },
            { Opcode.SMSG_CLEAR_TREASURE_PICKER_CACHE, 0x2AA1 },
            { Opcode.SMSG_CLOSE_HEART_FORGE, 0x2829 },
            { Opcode.SMSG_COIN_REMOVED, 0x2614 },
            { Opcode.SMSG_COMBAT_EVENT_FAILED, 0x293E },
            { Opcode.SMSG_COMMENTATOR_MAP_INFO, 0x2703 },
            { Opcode.SMSG_COMMENTATOR_PLAYER_INFO, 0x2704 },
            { Opcode.SMSG_COMMENTATOR_STATE_CHANGED, 0x2702 },
            { Opcode.SMSG_COMMERCE_TOKEN_GET_COUNT_RESPONSE, 0x27D3 },
            { Opcode.SMSG_COMMERCE_TOKEN_GET_LOG_RESPONSE, 0x27DF },
            { Opcode.SMSG_COMMERCE_TOKEN_GET_MARKET_PRICE_RESPONSE, 0x27D5 },
            { Opcode.SMSG_COMMERCE_TOKEN_UPDATE, 0x27D4 },
            { Opcode.SMSG_COMPLAINT_RESULT, 0x26A8 },
            { Opcode.SMSG_COMPLETE_SHIPMENT_RESPONSE, 0x279D },
            { Opcode.SMSG_COMPRESSED_PACKET, 0x3052 },
            { Opcode.SMSG_CONFIRM_PARTY_INVITE, 0x2815 },
            { Opcode.SMSG_CONNECT_TO, 0x304D },
            { Opcode.SMSG_CONQUEST_FORMULA_CONSTANTS, 0x2785 },
            { Opcode.SMSG_CONSOLE_WRITE, 0x2632 },
            { Opcode.SMSG_CONSUMABLE_TOKEN_BUY_AT_MARKET_PRICE_RESPONSE, 0x27DB },
            { Opcode.SMSG_CONSUMABLE_TOKEN_BUY_CHOICE_REQUIRED, 0x27DA },
            { Opcode.SMSG_CONSUMABLE_TOKEN_CAN_VETERAN_BUY_RESPONSE, 0x27D9 },
            { Opcode.SMSG_CONSUMABLE_TOKEN_REDEEM_CONFIRM_REQUIRED, 0x27DD },
            { Opcode.SMSG_CONSUMABLE_TOKEN_REDEEM_RESPONSE, 0x27DE },
            { Opcode.SMSG_CONTACT_LIST, 0x2788 },
            { Opcode.SMSG_CONTRIBUTION_LAST_UPDATE_RESPONSE, 0x281C },
            { Opcode.SMSG_CONTROL_UPDATE, 0x2644 },
            { Opcode.SMSG_CONVERT_ITEMS_TO_CURRENCY_VALUE, 0x287D },
            { Opcode.SMSG_COOLDOWN_CHEAT, 0x2735 },
            { Opcode.SMSG_COOLDOWN_EVENT, 0x26B6 },
            { Opcode.SMSG_CORPSE_LOCATION, 0x264C },
            { Opcode.SMSG_CORPSE_RECLAIM_DELAY, 0x2746 },
            { Opcode.SMSG_CORPSE_TRANSPORT_QUERY, 0x270E },
            { Opcode.SMSG_COVENANT_CALLINGS_AVAILABILITY_RESPONSE, 0x2AA3 },
            { Opcode.SMSG_COVENANT_PREVIEW_OPEN_NPC, 0x27FF },
            { Opcode.SMSG_COVENANT_RENOWN_OPEN_NPC, 0x287C },
            { Opcode.SMSG_CREATE_CHAR, 0x26FD },
            { Opcode.SMSG_CREATE_SHIPMENT_RESPONSE, 0x279C },
            { Opcode.SMSG_CRITERIA_DELETED, 0x26E4 },
            { Opcode.SMSG_CRITERIA_UPDATE, 0x26DE },
            { Opcode.SMSG_CROSSED_INEBRIATION_THRESHOLD, 0x26BF },
            { Opcode.SMSG_CUSTOM_LOAD_SCREEN, 0x25C9 },
            { Opcode.SMSG_DAILY_QUESTS_RESET, 0x2A80 },
            { Opcode.SMSG_DAMAGE_CALC_LOG, 0x27C8 },
            { Opcode.SMSG_DB_REPLY, 0x290E },
            { Opcode.SMSG_DEATH_RELEASE_LOC, 0x26D0 },
            { Opcode.SMSG_DEBUG_MENU_MANAGER_FULL_UPDATE, 0x2652 },
            { Opcode.SMSG_DEFENSE_MESSAGE, 0x2BB6 },
            { Opcode.SMSG_DELETE_CHAR, 0x26FE },
            { Opcode.SMSG_DESTROY_ARENA_UNIT, 0x273E },
            { Opcode.SMSG_DESTRUCTIBLE_BUILDING_DAMAGE, 0x26F5 },
            { Opcode.SMSG_DIFFERENT_INSTANCE_FROM_PARTY, 0x258D },
            { Opcode.SMSG_DISENCHANT_CREDIT, 0x25A7 },
            { Opcode.SMSG_DISMOUNT, 0x26AE },
            { Opcode.SMSG_DISMOUNT_RESULT, 0x257C },
            { Opcode.SMSG_DISPEL_FAILED, 0x2C30 },
            { Opcode.SMSG_DISPLAY_GAME_ERROR, 0x25A1 },
            { Opcode.SMSG_DISPLAY_PLAYER_CHOICE, 0x2FFC },
            { Opcode.SMSG_DISPLAY_PROMOTION, 0x2649 },
            { Opcode.SMSG_DISPLAY_QUEST_POPUP, 0x2A9E },
            { Opcode.SMSG_DISPLAY_TOAST, 0x2621 },
            { Opcode.SMSG_DISPLAY_WORLD_TEXT, 0x27F0 },
            { Opcode.SMSG_DONT_AUTO_PUSH_SPELLS_TO_ACTION_BAR, 0x25DD },
            { Opcode.SMSG_DROP_NEW_CONNECTION, 0x304C },
            { Opcode.SMSG_DUEL_ARRANGED, 0x2940 },
            { Opcode.SMSG_DUEL_COMPLETE, 0x2944 },
            { Opcode.SMSG_DUEL_COUNTDOWN, 0x2943 },
            { Opcode.SMSG_DUEL_IN_BOUNDS, 0x2942 },
            { Opcode.SMSG_DUEL_OUT_OF_BOUNDS, 0x2941 },
            { Opcode.SMSG_DUEL_REQUESTED, 0x293F },
            { Opcode.SMSG_DUEL_WINNER, 0x2945 },
            { Opcode.SMSG_DURABILITY_DAMAGE_DEATH, 0x2742 },
            { Opcode.SMSG_EMOTE, 0x27C9 },
            { Opcode.SMSG_ENABLE_BARBER_SHOP, 0x26B9 },
            { Opcode.SMSG_ENCHANTMENT_LOG, 0x270F },
            { Opcode.SMSG_ENCOUNTER_END, 0x277E },
            { Opcode.SMSG_ENCOUNTER_START, 0x277D },
            { Opcode.SMSG_END_LIGHTNING_STORM, 0x26A5 },
            { Opcode.SMSG_ENTER_ENCRYPTED_MODE, 0x3049 },
            { Opcode.SMSG_ENUM_CHARACTERS_RESULT, 0x2583 },
            { Opcode.SMSG_ENUM_VAS_PURCHASE_STATES_RESPONSE, 0x27F5 },
            { Opcode.SMSG_ENVIRONMENTAL_DAMAGE_LOG, 0x2C21 },
            { Opcode.SMSG_EQUIPMENT_SET_ID, 0x26AF },
            { Opcode.SMSG_EXPECTED_SPAM_RECORDS, 0x2BB1 },
            { Opcode.SMSG_EXPLORATION_EXPERIENCE, 0x275B },
            { Opcode.SMSG_EXTERNAL_TRANSACTION_ID_GENERATED, 0x287B },
            { Opcode.SMSG_FACTION_BONUS_INFO, 0x2721 },
            { Opcode.SMSG_FAILED_PLAYER_CONDITION, 0x2FFA },
            { Opcode.SMSG_FAILED_QUEST_TURN_IN, 0x2812 },
            { Opcode.SMSG_FEATURE_SYSTEM_STATUS, 0x25BD },
            { Opcode.SMSG_FEATURE_SYSTEM_STATUS_GLUE_SCREEN, 0x25BE },
            { Opcode.SMSG_FEIGN_DEATH_RESISTED, 0x2741 },
            { Opcode.SMSG_FISH_ESCAPED, 0x26CD },
            { Opcode.SMSG_FISH_NOT_HOOKED, 0x26CC },
            { Opcode.SMSG_FLIGHT_SPLINE_SYNC, 0x2E2B },
            { Opcode.SMSG_FORCED_DEATH_UPDATE, 0x26D1 },
            { Opcode.SMSG_FORCE_ANIM, 0x274D },
            { Opcode.SMSG_FORCE_ANIMATIONS, 0x274E },
            { Opcode.SMSG_FORCE_OBJECT_RELINK, 0x2648 },
            { Opcode.SMSG_FRIEND_STATUS, 0x2789 },
            { Opcode.SMSG_GAME_OBJECT_ACTIVATE_ANIM_KIT, 0x25C1 },
            { Opcode.SMSG_GAME_OBJECT_BASE, 0x282A },
            { Opcode.SMSG_GAME_OBJECT_CUSTOM_ANIM, 0x25C2 },
            { Opcode.SMSG_GAME_OBJECT_DESPAWN, 0x25C3 },
            { Opcode.SMSG_GAME_OBJECT_PLAY_SPELL_VISUAL, 0x2C4B },
            { Opcode.SMSG_GAME_OBJECT_PLAY_SPELL_VISUAL_KIT, 0x2C4A },
            { Opcode.SMSG_GAME_OBJECT_RESET_STATE, 0x271A },
            { Opcode.SMSG_GAME_OBJECT_SET_STATE_LOCAL, 0x2805 },
            { Opcode.SMSG_GAME_OBJECT_UI_LINK, 0x2716 },
            { Opcode.SMSG_GAME_SPEED_SET, 0x267E },
            { Opcode.SMSG_GAME_TIME_SET, 0x2708 },
            { Opcode.SMSG_GAME_TIME_UPDATE, 0x2707 },
            { Opcode.SMSG_GENERATE_RANDOM_CHARACTER_NAME_RESULT, 0x2585 },
            { Opcode.SMSG_GENERATE_SSO_TOKEN_RESPONSE, 0x281D },
            { Opcode.SMSG_GET_ACCOUNT_CHARACTER_LIST_RESULT, 0x2761 },
            { Opcode.SMSG_GET_LANDING_PAGE_SHIPMENTS_RESPONSE, 0x279F },
            { Opcode.SMSG_GET_REMAINING_GAME_TIME_RESPONSE, 0x27DC },
            { Opcode.SMSG_GET_SELECTED_TROPHY_ID_RESPONSE, 0x27C6 },
            { Opcode.SMSG_GET_SHIPMENTS_OF_TYPE_RESPONSE, 0x279E },
            { Opcode.SMSG_GET_SHIPMENT_INFO_RESPONSE, 0x279A },
            { Opcode.SMSG_GET_TROPHY_LIST_RESPONSE, 0x27C5 },
            { Opcode.SMSG_GET_VAS_ACCOUNT_CHARACTER_LIST_RESULT, 0x27F1 },
            { Opcode.SMSG_GET_VAS_TRANSFER_TARGET_REALM_LIST_RESULT, 0x27F2 },
            { Opcode.SMSG_GM_PLAYER_INFO, 0x3005 },
            { Opcode.SMSG_GM_REQUEST_PLAYER_INFO, 0x2FFB },
            { Opcode.SMSG_GM_TICKET_CASE_STATUS, 0x26A0 },
            { Opcode.SMSG_GM_TICKET_SYSTEM_STATUS, 0x269F },
            { Opcode.SMSG_GOD_MODE, 0x26F8 },
            { Opcode.SMSG_GOSSIP_COMPLETE, 0x2A97 },
            { Opcode.SMSG_GOSSIP_MESSAGE, 0x2A98 },
            { Opcode.SMSG_GOSSIP_POI, 0x2797 },
            { Opcode.SMSG_GOSSIP_QUEST_UPDATE, 0x2A99 },
            { Opcode.SMSG_GOSSIP_REFRESH_OPTIONS, 0x2AA6 },
            { Opcode.SMSG_GROUP_ACTION_THROTTLED, 0x2592 },
            { Opcode.SMSG_GROUP_AUTO_KICK, 0x2794 },
            { Opcode.SMSG_GROUP_DECLINE, 0x2790 },
            { Opcode.SMSG_GROUP_DESTROYED, 0x2793 },
            { Opcode.SMSG_GROUP_NEW_LEADER, 0x262A },
            { Opcode.SMSG_GROUP_UNINVITE, 0x2792 },
            { Opcode.SMSG_GUILD_ACHIEVEMENT_DELETED, 0x29C5 },
            { Opcode.SMSG_GUILD_ACHIEVEMENT_EARNED, 0x29C4 },
            { Opcode.SMSG_GUILD_ACHIEVEMENT_MEMBERS, 0x29C7 },
            { Opcode.SMSG_GUILD_BANK_LOG_QUERY_RESULTS, 0x29DF },
            { Opcode.SMSG_GUILD_BANK_QUERY_RESULTS, 0x29DE },
            { Opcode.SMSG_GUILD_BANK_REMAINING_WITHDRAW_MONEY, 0x29E0 },
            { Opcode.SMSG_GUILD_BANK_TEXT_QUERY_RESULT, 0x29E3 },
            { Opcode.SMSG_GUILD_CHALLENGE_COMPLETED, 0x29D3 },
            { Opcode.SMSG_GUILD_CHALLENGE_UPDATE, 0x29D2 },
            { Opcode.SMSG_GUILD_CHANGE_NAME_RESULT, 0x29DD },
            { Opcode.SMSG_GUILD_COMMAND_RESULT, 0x29BA },
            { Opcode.SMSG_GUILD_CRITERIA_DELETED, 0x29C6 },
            { Opcode.SMSG_GUILD_CRITERIA_UPDATE, 0x29C3 },
            { Opcode.SMSG_GUILD_EVENT_BANK_CONTENTS_CHANGED, 0x29F7 },
            { Opcode.SMSG_GUILD_EVENT_BANK_MONEY_CHANGED, 0x29F6 },
            { Opcode.SMSG_GUILD_EVENT_DISBANDED, 0x29ED },
            { Opcode.SMSG_GUILD_EVENT_LOG_QUERY_RESULTS, 0x29E2 },
            { Opcode.SMSG_GUILD_EVENT_MOTD, 0x29EE },
            { Opcode.SMSG_GUILD_EVENT_NEW_LEADER, 0x29EC },
            { Opcode.SMSG_GUILD_EVENT_PLAYER_JOINED, 0x29EA },
            { Opcode.SMSG_GUILD_EVENT_PLAYER_LEFT, 0x29EB },
            { Opcode.SMSG_GUILD_EVENT_PRESENCE_CHANGE, 0x29EF },
            { Opcode.SMSG_GUILD_EVENT_RANKS_UPDATED, 0x29F0 },
            { Opcode.SMSG_GUILD_EVENT_RANK_CHANGED, 0x29F1 },
            { Opcode.SMSG_GUILD_EVENT_TAB_ADDED, 0x29F2 },
            { Opcode.SMSG_GUILD_EVENT_TAB_DELETED, 0x29F3 },
            { Opcode.SMSG_GUILD_EVENT_TAB_MODIFIED, 0x29F4 },
            { Opcode.SMSG_GUILD_EVENT_TAB_TEXT_CHANGED, 0x29F5 },
            { Opcode.SMSG_GUILD_FLAGGED_FOR_RENAME, 0x29DC },
            { Opcode.SMSG_GUILD_INVITE, 0x29CA },
            { Opcode.SMSG_GUILD_INVITE_DECLINED, 0x29E8 },
            { Opcode.SMSG_GUILD_INVITE_EXPIRED, 0x29E9 },
            { Opcode.SMSG_GUILD_ITEM_LOOTED_NOTIFY, 0x29D4 },
            { Opcode.SMSG_GUILD_KNOWN_RECIPES, 0x29BE },
            { Opcode.SMSG_GUILD_MEMBERS_WITH_RECIPE, 0x29BF },
            { Opcode.SMSG_GUILD_MEMBER_DAILY_RESET, 0x29E4 },
            { Opcode.SMSG_GUILD_MEMBER_RECIPES, 0x29BD },
            { Opcode.SMSG_GUILD_MEMBER_UPDATE_NOTE, 0x29C9 },
            { Opcode.SMSG_GUILD_MOVED, 0x29DA },
            { Opcode.SMSG_GUILD_MOVE_STARTING, 0x29D9 },
            { Opcode.SMSG_GUILD_NAME_CHANGED, 0x29DB },
            { Opcode.SMSG_GUILD_NEWS, 0x29C1 },
            { Opcode.SMSG_GUILD_NEWS_DELETED, 0x29C2 },
            { Opcode.SMSG_GUILD_PARTY_STATE, 0x29CB },
            { Opcode.SMSG_GUILD_PERMISSIONS_QUERY_RESULTS, 0x29E1 },
            { Opcode.SMSG_GUILD_RANKS, 0x29C8 },
            { Opcode.SMSG_GUILD_REPUTATION_REACTION_CHANGED, 0x29CC },
            { Opcode.SMSG_GUILD_RESET, 0x29D8 },
            { Opcode.SMSG_GUILD_REWARD_LIST, 0x29C0 },
            { Opcode.SMSG_GUILD_ROSTER, 0x29BB },
            { Opcode.SMSG_GUILD_ROSTER_UPDATE, 0x29BC },
            { Opcode.SMSG_GUILD_SEND_RANK_CHANGE, 0x29B9 },
            { Opcode.SMSG_HEALTH_UPDATE, 0x26CE },
            { Opcode.SMSG_HIGHEST_THREAT_UPDATE, 0x26D6 },
            { Opcode.SMSG_HOTFIX_CONNECT, 0x2911 },
            { Opcode.SMSG_HOTFIX_MESSAGE, 0x2910 },
            { Opcode.SMSG_INITIALIZE_FACTIONS, 0x2720 },
            { Opcode.SMSG_INITIAL_SETUP, 0x2580 },
            { Opcode.SMSG_INIT_WORLD_STATES, 0x2743 },
            { Opcode.SMSG_INSPECT_HONOR_STATS, 0x2933 },
            { Opcode.SMSG_INSPECT_PVP, 0x271E },
            { Opcode.SMSG_INSPECT_RESULT, 0x262E },
            { Opcode.SMSG_INSTANCE_ENCOUNTER_CHANGE_PRIORITY, 0x27B1 },
            { Opcode.SMSG_INSTANCE_ENCOUNTER_DISENGAGE_UNIT, 0x27B0 },
            { Opcode.SMSG_INSTANCE_ENCOUNTER_END, 0x27B9 },
            { Opcode.SMSG_INSTANCE_ENCOUNTER_ENGAGE_UNIT, 0x27AF },
            { Opcode.SMSG_INSTANCE_ENCOUNTER_GAIN_COMBAT_RESURRECTION_CHARGE, 0x27BB },
            { Opcode.SMSG_INSTANCE_ENCOUNTER_IN_COMBAT_RESURRECTION, 0x27BA },
            { Opcode.SMSG_INSTANCE_ENCOUNTER_OBJECTIVE_COMPLETE, 0x27B4 },
            { Opcode.SMSG_INSTANCE_ENCOUNTER_OBJECTIVE_START, 0x27B3 },
            { Opcode.SMSG_INSTANCE_ENCOUNTER_OBJECTIVE_UPDATE, 0x27B8 },
            { Opcode.SMSG_INSTANCE_ENCOUNTER_PHASE_SHIFT_CHANGED, 0x27BC },
            { Opcode.SMSG_INSTANCE_ENCOUNTER_START, 0x27B5 },
            { Opcode.SMSG_INSTANCE_ENCOUNTER_TIMER_START, 0x27B2 },
            { Opcode.SMSG_INSTANCE_ENCOUNTER_UPDATE_ALLOW_RELEASE_IN_PROGRESS, 0x27B7 },
            { Opcode.SMSG_INSTANCE_ENCOUNTER_UPDATE_SUPPRESS_RELEASE, 0x27B6 },
            { Opcode.SMSG_INSTANCE_GROUP_SIZE_CHANGED, 0x26F6 },
            { Opcode.SMSG_RAID_INSTANCE_INFO, 0x2631 },
            { Opcode.SMSG_INSTANCE_RESET, 0x2683 },
            { Opcode.SMSG_INSTANCE_RESET_FAILED, 0x2684 },
            { Opcode.SMSG_INSTANCE_SAVE_CREATED, 0x277C },
            { Opcode.SMSG_INTERRUPT_POWER_REGEN, 0x2C59 },
            { Opcode.SMSG_INVALIDATE_PAGE_TEXT, 0x2918 },
            { Opcode.SMSG_INVALIDATE_PLAYER, 0x2FFF },
            { Opcode.SMSG_INVALID_PROMOTION_CODE, 0x274F },
            { Opcode.SMSG_INVENTORY_CHANGE_FAILURE, 0x2DA5 },
            { Opcode.SMSG_INVENTORY_FIXUP_COMPLETE, 0x2814 },
            { Opcode.SMSG_INVENTORY_FULL_OVERFLOW, 0x2825 },
            { Opcode.SMSG_ISLANDS_MISSION_NPC, 0x27FB },
            { Opcode.SMSG_ISLAND_AZERITE_GAIN, 0x2758 },
            { Opcode.SMSG_ISLAND_COMPLETE, 0x2759 },
            { Opcode.SMSG_IS_QUEST_COMPLETE_RESPONSE, 0x2A84 },
            { Opcode.SMSG_ITEM_CHANGED, 0x26E7 },
            { Opcode.SMSG_ITEM_COOLDOWN, 0x27C7 },
            { Opcode.SMSG_ITEM_ENCHANT_TIME_UPDATE, 0x2751 },
            { Opcode.SMSG_ITEM_EXPIRE_PURCHASE_REFUND, 0x25A0 },
            { Opcode.SMSG_ITEM_INTERACTION_COMPLETE, 0x2873 },
            { Opcode.SMSG_ITEM_PURCHASE_REFUND_RESULT, 0x259E },
            { Opcode.SMSG_ITEM_PUSH_RESULT, 0x2620 },
            { Opcode.SMSG_ITEM_TIME_UPDATE, 0x2750 },
            { Opcode.SMSG_KICK_REASON, 0x2686 },
            { Opcode.SMSG_LATENCY_REPORT_PING, 0x2886 },
            { Opcode.SMSG_LEARNED_SPELLS, 0x2C4D },
            { Opcode.SMSG_LEARN_PVP_TALENT_FAILED, 0x25D0 },
            { Opcode.SMSG_LEARN_TALENT_FAILED, 0x25CF },
            { Opcode.SMSG_LEGACY_LOOT_RULES, 0x282B },
            { Opcode.SMSG_LEVEL_UP_INFO, 0x26E6 },
            { Opcode.SMSG_LFG_BOOT_PLAYER, 0x2A35 },
            { Opcode.SMSG_LFG_DISABLED, 0x2A33 },
            { Opcode.SMSG_LFG_EXPAND_SEARCH_PROMPT, 0x2A3B },
            { Opcode.SMSG_LFG_INSTANCE_SHUTDOWN_COUNTDOWN, 0x2A25 },
            { Opcode.SMSG_LFG_JOIN_RESULT, 0x2A1C },
            { Opcode.SMSG_LFG_LIST_APPLICANT_LIST_UPDATE, 0x2A2B },
            { Opcode.SMSG_LFG_LIST_APPLICATION_STATUS_UPDATE, 0x2A28 },
            { Opcode.SMSG_LFG_LIST_APPLY_TO_GROUP_RESULT, 0x2A29 },
            { Opcode.SMSG_LFG_LIST_JOIN_RESULT, 0x2A1D },
            { Opcode.SMSG_LFG_LIST_SEARCH_RESULTS, 0x2A1E },
            { Opcode.SMSG_LFG_LIST_SEARCH_RESULTS_UPDATE, 0x2A2C },
            { Opcode.SMSG_LFG_LIST_SEARCH_STATUS, 0x2A1F },
            { Opcode.SMSG_LFG_LIST_UPDATE_BLACKLIST, 0x2A2A },
            { Opcode.SMSG_LFG_LIST_UPDATE_EXPIRATION, 0x2A27 },
            { Opcode.SMSG_LFG_LIST_UPDATE_STATUS, 0x2A26 },
            { Opcode.SMSG_LFG_OFFER_CONTINUE, 0x2A34 },
            { Opcode.SMSG_LFG_PARTY_INFO, 0x2A36 },
            { Opcode.SMSG_LFG_PLAYER_INFO, 0x2A37 },
            { Opcode.SMSG_LFG_PLAYER_REWARD, 0x2A38 },
            { Opcode.SMSG_LFG_PROPOSAL_UPDATE, 0x2A2D },
            { Opcode.SMSG_LFG_QUEUE_STATUS, 0x2A20 },
            { Opcode.SMSG_LFG_READY_CHECK_RESULT, 0x2A3A },
            { Opcode.SMSG_LFG_READY_CHECK_UPDATE, 0x2A22 },
            { Opcode.SMSG_LFG_ROLE_CHECK_UPDATE, 0x2A21 },
            { Opcode.SMSG_LFG_SLOT_INVALID, 0x2A30 },
            { Opcode.SMSG_LFG_TELEPORT_DENIED, 0x2A32 },
            { Opcode.SMSG_LFG_UPDATE_STATUS, 0x2A24 },
            { Opcode.SMSG_LIVE_REGION_ACCOUNT_RESTORE_RESULT, 0x276E },
            { Opcode.SMSG_LIVE_REGION_CHARACTER_COPY_RESULT, 0x276D },
            { Opcode.SMSG_LIVE_REGION_GET_ACCOUNT_CHARACTER_LIST_RESULT, 0x2762 },
            { Opcode.SMSG_LIVE_REGION_KEY_BINDINGS_COPY_RESULT, 0x276F },
            { Opcode.SMSG_LOAD_CUF_PROFILES, 0x25BA },
            { Opcode.SMSG_LOAD_EQUIPMENT_SET, 0x270A },
            { Opcode.SMSG_LOGIN_SET_TIME_SPEED, 0x2709 },
            { Opcode.SMSG_LOGIN_VERIFY_WORLD, 0x259B },
            { Opcode.SMSG_LOGOUT_CANCEL_ACK, 0x2682 },
            { Opcode.SMSG_LOGOUT_COMPLETE, 0x2681 },
            { Opcode.SMSG_LOGOUT_RESPONSE, 0x2680 },
            { Opcode.SMSG_LOG_XP_GAIN, 0x26E2 },
            { Opcode.SMSG_LOOT_ALL_PASSED, 0x261E },
            { Opcode.SMSG_LOOT_LIST, 0x273D },
            { Opcode.SMSG_LOOT_MONEY_NOTIFY, 0x2619 },
            { Opcode.SMSG_LOOT_RELEASE, 0x2618 },
            { Opcode.SMSG_LOOT_RELEASE_ALL, 0x2617 },
            { Opcode.SMSG_LOOT_REMOVED, 0x2612 },
            { Opcode.SMSG_LOOT_RESPONSE, 0x2611 },
            { Opcode.SMSG_LOOT_ROLL, 0x261B },
            { Opcode.SMSG_LOOT_ROLLS_COMPLETE, 0x261D },
            { Opcode.SMSG_LOOT_ROLL_WON, 0x261F },
            { Opcode.SMSG_LOSS_OF_CONTROL_AURA_UPDATE, 0x266D },
            { Opcode.SMSG_MAIL_COMMAND_RESULT, 0x2638 },
            { Opcode.SMSG_MAIL_LIST_RESULT, 0x2752 },
            { Opcode.SMSG_MAIL_QUERY_NEXT_TIME_RESULT, 0x2753 },
            { Opcode.SMSG_MAP_OBJECTIVES_INIT, 0x294F },
            { Opcode.SMSG_MAP_OBJ_EVENTS, 0x25C4 },
            { Opcode.SMSG_MASTER_LOOT_CANDIDATE_LIST, 0x261C },
            { Opcode.SMSG_MESSAGE_BOX, 0x2576 },
            { Opcode.SMSG_MINIMAP_PING, 0x26CB },
            { Opcode.SMSG_MIRROR_IMAGE_COMPONENTED_DATA, 0x2C14 },
            { Opcode.SMSG_MIRROR_IMAGE_CREATURE_DATA, 0x2C13 },
            { Opcode.SMSG_MISSILE_CANCEL, 0x25C5 },
            { Opcode.SMSG_MODIFY_COOLDOWN, 0x2764 },
            { Opcode.SMSG_MOTD, 0x2BAF },
            { Opcode.SMSG_MOUNT_RESULT, 0x257B },
            { Opcode.SMSG_MOVEMENT_ENFORCEMENT_ALERT, 0x2848 },
            { Opcode.SMSG_MOVE_APPLY_INERTIA, 0x2E2E },
            { Opcode.SMSG_MOVE_APPLY_MOVEMENT_FORCE, 0x2E15 },
            { Opcode.SMSG_MOVE_DISABLE_COLLISION, 0x2E11 },
            { Opcode.SMSG_MOVE_DISABLE_DOUBLE_JUMP, 0x2DFD },
            { Opcode.SMSG_MOVE_DISABLE_GRAVITY, 0x2E0D },
            { Opcode.SMSG_MOVE_DISABLE_INERTIA, 0x2E0F },
            { Opcode.SMSG_MOVE_DISABLE_TRANSITION_BETWEEN_SWIM_AND_FLY, 0x2E0C },
            { Opcode.SMSG_MOVE_ENABLE_COLLISION, 0x2E12 },
            { Opcode.SMSG_MOVE_ENABLE_DOUBLE_JUMP, 0x2DFC },
            { Opcode.SMSG_MOVE_ENABLE_GRAVITY, 0x2E0E },
            { Opcode.SMSG_MOVE_ENABLE_INERTIA, 0x2E10 },
            { Opcode.SMSG_MOVE_ENABLE_TRANSITION_BETWEEN_SWIM_AND_FLY, 0x2E0B },
            { Opcode.SMSG_MOVE_KNOCK_BACK, 0x2E03 },
            { Opcode.SMSG_MOVE_REMOVE_INERTIA, 0x2E2F },
            { Opcode.SMSG_MOVE_REMOVE_MOVEMENT_FORCE, 0x2E16 },
            { Opcode.SMSG_MOVE_ROOT, 0x2DF9 },
            { Opcode.SMSG_MOVE_SET_ACTIVE_MOVER, 0x2DD5 },
            { Opcode.SMSG_MOVE_SET_CAN_FLY, 0x2E05 },
            { Opcode.SMSG_MOVE_SET_CAN_TURN_WHILE_FALLING, 0x2E07 },
            { Opcode.SMSG_MOVE_SET_COLLISION_HEIGHT, 0x2E13 },
            { Opcode.SMSG_MOVE_SET_COMPOUND_STATE, 0x2E17 },
            { Opcode.SMSG_MOVE_SET_FEATHER_FALL, 0x2DFF },
            { Opcode.SMSG_MOVE_SET_FLIGHT_BACK_SPEED, 0x2DF5 },
            { Opcode.SMSG_MOVE_SET_FLIGHT_SPEED, 0x2DF4 },
            { Opcode.SMSG_MOVE_SET_HOVERING, 0x2E01 },
            { Opcode.SMSG_MOVE_SET_IGNORE_MOVEMENT_FORCES, 0x2E09 },
            { Opcode.SMSG_MOVE_SET_LAND_WALK, 0x2DFE },
            { Opcode.SMSG_MOVE_SET_MOD_MOVEMENT_FORCE_MAGNITUDE, 0x2DE6 },
            { Opcode.SMSG_MOVE_SET_NORMAL_FALL, 0x2E00 },
            { Opcode.SMSG_MOVE_SET_PITCH_RATE, 0x2DF8 },
            { Opcode.SMSG_MOVE_SET_RUN_BACK_SPEED, 0x2DF1 },
            { Opcode.SMSG_MOVE_SET_RUN_SPEED, 0x2DF0 },
            { Opcode.SMSG_MOVE_SET_SWIM_BACK_SPEED, 0x2DF3 },
            { Opcode.SMSG_MOVE_SET_SWIM_SPEED, 0x2DF2 },
            { Opcode.SMSG_MOVE_SET_TURN_RATE, 0x2DF7 },
            { Opcode.SMSG_MOVE_SET_VEHICLE_REC_ID, 0x2E14 },
            { Opcode.SMSG_MOVE_SET_WALK_SPEED, 0x2DF6 },
            { Opcode.SMSG_MOVE_SET_WATER_WALK, 0x2DFB },
            { Opcode.SMSG_MOVE_SKIP_TIME, 0x2E18 },
            { Opcode.SMSG_MOVE_SPLINE_DISABLE_COLLISION, 0x2E1D },
            { Opcode.SMSG_MOVE_SPLINE_DISABLE_GRAVITY, 0x2E1B },
            { Opcode.SMSG_MOVE_SPLINE_ENABLE_COLLISION, 0x2E1E },
            { Opcode.SMSG_MOVE_SPLINE_ENABLE_GRAVITY, 0x2E1C },
            { Opcode.SMSG_MOVE_SPLINE_ROOT, 0x2E19 },
            { Opcode.SMSG_MOVE_SPLINE_SET_FEATHER_FALL, 0x2E1F },
            { Opcode.SMSG_MOVE_SPLINE_SET_FLIGHT_BACK_SPEED, 0x2DEC },
            { Opcode.SMSG_MOVE_SPLINE_SET_FLIGHT_SPEED, 0x2DEB },
            { Opcode.SMSG_MOVE_SPLINE_SET_FLYING, 0x2E29 },
            { Opcode.SMSG_MOVE_SPLINE_SET_HOVER, 0x2E21 },
            { Opcode.SMSG_MOVE_SPLINE_SET_LAND_WALK, 0x2E24 },
            { Opcode.SMSG_MOVE_SPLINE_SET_NORMAL_FALL, 0x2E20 },
            { Opcode.SMSG_MOVE_SPLINE_SET_PITCH_RATE, 0x2DEF },
            { Opcode.SMSG_MOVE_SPLINE_SET_RUN_BACK_SPEED, 0x2DE8 },
            { Opcode.SMSG_MOVE_SPLINE_SET_RUN_MODE, 0x2E27 },
            { Opcode.SMSG_MOVE_SPLINE_SET_RUN_SPEED, 0x2DE7 },
            { Opcode.SMSG_MOVE_SPLINE_SET_SWIM_BACK_SPEED, 0x2DEA },
            { Opcode.SMSG_MOVE_SPLINE_SET_SWIM_SPEED, 0x2DE9 },
            { Opcode.SMSG_MOVE_SPLINE_SET_TURN_RATE, 0x2DEE },
            { Opcode.SMSG_MOVE_SPLINE_SET_WALK_MODE, 0x2E28 },
            { Opcode.SMSG_MOVE_SPLINE_SET_WALK_SPEED, 0x2DED },
            { Opcode.SMSG_MOVE_SPLINE_SET_WATER_WALK, 0x2E23 },
            { Opcode.SMSG_MOVE_SPLINE_START_SWIM, 0x2E25 },
            { Opcode.SMSG_MOVE_SPLINE_STOP_SWIM, 0x2E26 },
            { Opcode.SMSG_MOVE_SPLINE_UNROOT, 0x2E1A },
            { Opcode.SMSG_MOVE_SPLINE_UNSET_FLYING, 0x2E2A },
            { Opcode.SMSG_MOVE_SPLINE_UNSET_HOVER, 0x2E22 },
            { Opcode.SMSG_MOVE_TELEPORT, 0x2E04 },
            { Opcode.SMSG_MOVE_UNROOT, 0x2DFA },
            { Opcode.SMSG_MOVE_UNSET_CAN_FLY, 0x2E06 },
            { Opcode.SMSG_MOVE_UNSET_CAN_TURN_WHILE_FALLING, 0x2E08 },
            { Opcode.SMSG_MOVE_UNSET_HOVERING, 0x2E02 },
            { Opcode.SMSG_MOVE_UNSET_IGNORE_MOVEMENT_FORCES, 0x2E0A },
            { Opcode.SMSG_MOVE_UPDATE, 0x2DE0 },
            { Opcode.SMSG_MOVE_UPDATE_APPLY_INERTIA, 0x2E30 },
            { Opcode.SMSG_MOVE_UPDATE_APPLY_MOVEMENT_FORCE, 0x2DE4 },
            { Opcode.SMSG_MOVE_UPDATE_COLLISION_HEIGHT, 0x2DDF },
            { Opcode.SMSG_MOVE_UPDATE_FLIGHT_BACK_SPEED, 0x2DDC },
            { Opcode.SMSG_MOVE_UPDATE_FLIGHT_SPEED, 0x2DDB },
            { Opcode.SMSG_MOVE_UPDATE_KNOCK_BACK, 0x2DE2 },
            { Opcode.SMSG_MOVE_UPDATE_MOD_MOVEMENT_FORCE_MAGNITUDE, 0x2DE3 },
            { Opcode.SMSG_MOVE_UPDATE_PITCH_RATE, 0x2DDE },
            { Opcode.SMSG_MOVE_UPDATE_REMOVE_INERTIA, 0x2E31 },
            { Opcode.SMSG_MOVE_UPDATE_REMOVE_MOVEMENT_FORCE, 0x2DE5 },
            { Opcode.SMSG_MOVE_UPDATE_RUN_BACK_SPEED, 0x2DD7 },
            { Opcode.SMSG_MOVE_UPDATE_RUN_SPEED, 0x2DD6 },
            { Opcode.SMSG_MOVE_UPDATE_SWIM_BACK_SPEED, 0x2DDA },
            { Opcode.SMSG_MOVE_UPDATE_SWIM_SPEED, 0x2DD9 },
            { Opcode.SMSG_MOVE_UPDATE_TELEPORT, 0x2DE1 },
            { Opcode.SMSG_MOVE_UPDATE_TURN_RATE, 0x2DDD },
            { Opcode.SMSG_MOVE_UPDATE_WALK_SPEED, 0x2DD8 },
            { Opcode.SMSG_MULTIPLE_PACKETS, 0x3051 },
            { Opcode.SMSG_NEUTRAL_PLAYER_FACTION_SELECT_RESULT, 0x25D8 },
            { Opcode.SMSG_NEW_TAXI_PATH, 0x267B },
            { Opcode.SMSG_NEW_WORLD, 0x259A },
            { Opcode.SMSG_NOTIFY_DEST_LOC_SPELL_CAST, 0x2C43 },
            { Opcode.SMSG_NOTIFY_MISSILE_TRAJECTORY_COLLISION, 0x26A7 },
            { Opcode.SMSG_NOTIFY_MONEY, 0x259D },
            { Opcode.SMSG_NOTIFY_RECEIVED_MAIL, 0x2639 },
            { Opcode.SMSG_OFFER_PETITION_ERROR, 0x26B3 },
            { Opcode.SMSG_ON_CANCEL_EXPECTED_RIDE_VEHICLE_AURA, 0x26E3 },
            { Opcode.SMSG_ON_MONSTER_MOVE, 0x2DD4 },
            { Opcode.SMSG_OPEN_ANIMA_DIVERSION_UI, 0x2717 },
            { Opcode.SMSG_OPEN_CONTAINER, 0x2DA6 },
            { Opcode.SMSG_OPEN_HEART_FORGE, 0x2828 },
            { Opcode.SMSG_OPEN_LFG_DUNGEON_FINDER, 0x2A31 },
            { Opcode.SMSG_OPEN_SHIPMENT_NPC_FROM_GOSSIP, 0x2799 },
            { Opcode.SMSG_OPEN_SHIPMENT_NPC_RESULT, 0x279B },
            { Opcode.SMSG_OVERRIDE_LIGHT, 0x26B8 },
            { Opcode.SMSG_PAGE_TEXT, 0x2715 },
            { Opcode.SMSG_PARTY_COMMAND_RESULT, 0x2795 },
            { Opcode.SMSG_PARTY_INVITE, 0x25BB },
            { Opcode.SMSG_PARTY_KILL_LOG, 0x2756 },
            { Opcode.SMSG_PARTY_MEMBER_FULL_STATE, 0x2755 },
            { Opcode.SMSG_PARTY_MEMBER_PARTIAL_STATE, 0x2754 },
            { Opcode.SMSG_PARTY_NOTIFY_LFG_LEADER_CHANGE, 0x2879 },
            { Opcode.SMSG_PARTY_UPDATE, 0x25F1 },
            { Opcode.SMSG_PAST_TIME_EVENTS, 0x25C0 },
            { Opcode.SMSG_PAUSE_MIRROR_TIMER, 0x270C },
            { Opcode.SMSG_PENDING_RAID_LOCK, 0x26F4 },
            { Opcode.SMSG_PETITION_ALREADY_SIGNED, 0x25A3 },
            { Opcode.SMSG_PETITION_RENAME_GUILD_RESPONSE, 0x29F9 },
            { Opcode.SMSG_PETITION_SHOW_LIST, 0x26BC },
            { Opcode.SMSG_PETITION_SHOW_SIGNATURES, 0x26BD },
            { Opcode.SMSG_PETITION_SIGN_RESULTS, 0x2748 },
            { Opcode.SMSG_PET_ACTION_FEEDBACK, 0x2745 },
            { Opcode.SMSG_PET_ACTION_SOUND, 0x269D },
            { Opcode.SMSG_PET_ADDED, 0x2597 },
            { Opcode.SMSG_PET_BATTLE_CHAT_RESTRICTED, 0x25FF },
            { Opcode.SMSG_PET_BATTLE_DEBUG_QUEUE_DUMP_RESPONSE, 0x2672 },
            { Opcode.SMSG_PET_BATTLE_FINALIZE_LOCATION, 0x25F8 },
            { Opcode.SMSG_PET_BATTLE_FINAL_ROUND, 0x25FD },
            { Opcode.SMSG_PET_BATTLE_FINISHED, 0x25FE },
            { Opcode.SMSG_PET_BATTLE_FIRST_ROUND, 0x25FA },
            { Opcode.SMSG_PET_BATTLE_INITIAL_UPDATE, 0x25F9 },
            { Opcode.SMSG_PET_BATTLE_MAX_GAME_LENGTH_WARNING, 0x2600 },
            { Opcode.SMSG_PET_BATTLE_PVP_CHALLENGE, 0x25F7 },
            { Opcode.SMSG_PET_BATTLE_QUEUE_PROPOSE_MATCH, 0x2636 },
            { Opcode.SMSG_PET_BATTLE_QUEUE_STATUS, 0x2637 },
            { Opcode.SMSG_PET_BATTLE_REPLACEMENTS_MADE, 0x25FC },
            { Opcode.SMSG_PET_BATTLE_REQUEST_FAILED, 0x25F6 },
            { Opcode.SMSG_PET_BATTLE_ROUND_RESULT, 0x25FB },
            { Opcode.SMSG_PET_BATTLE_SLOT_UPDATES, 0x25E8 },
            { Opcode.SMSG_PET_CAST_FAILED, 0x2C58 },
            { Opcode.SMSG_PET_CLEAR_SPELLS, 0x2C24 },
            { Opcode.SMSG_PET_DISMISS_SOUND, 0x269E },
            { Opcode.SMSG_PET_GOD_MODE, 0x2678 },
            { Opcode.SMSG_PET_GUIDS, 0x2700 },
            { Opcode.SMSG_PET_LEARNED_SPELLS, 0x2C4F },
            { Opcode.SMSG_PET_MODE, 0x258C },
            { Opcode.SMSG_PET_NAME_INVALID, 0x26C1 },
            { Opcode.SMSG_PET_NEWLY_TAMED, 0x2589 },
            { Opcode.SMSG_PET_SLOT_UPDATED, 0x258B },
            { Opcode.SMSG_PET_SPELLS_MESSAGE, 0x2C25 },
            { Opcode.SMSG_PET_STABLE_LIST, 0x2598 },
            { Opcode.SMSG_PET_STABLE_RESULT, 0x2599 },
            { Opcode.SMSG_PET_TAME_FAILURE, 0x26B0 },
            { Opcode.SMSG_PET_UNLEARNED_SPELLS, 0x2C50 },
            { Opcode.SMSG_PHASE_SHIFT_CHANGE, 0x2578 },
            { Opcode.SMSG_PLAYED_TIME, 0x26D2 },
            { Opcode.SMSG_PLAYER_AZERITE_ITEM_EQUIPPED_STATUS_CHANGED, 0x3014 },
            { Opcode.SMSG_PLAYER_AZERITE_ITEM_GAINS, 0x3013 },
            { Opcode.SMSG_PLAYER_BONUS_ROLL_FAILED, 0x3016 },
            { Opcode.SMSG_PLAYER_BOUND, 0x2FF8 },
            { Opcode.SMSG_PLAYER_CHOICE_CLEAR, 0x2FFE },
            { Opcode.SMSG_PLAYER_CHOICE_DISPLAY_ERROR, 0x2FFD },
            { Opcode.SMSG_PLAYER_CONDITION_RESULT, 0x300A },
            { Opcode.SMSG_PLAYER_IS_ADVENTURE_MAP_POI_VALID, 0x3009 },
            { Opcode.SMSG_PLAYER_OPEN_SUBSCRIPTION_INTERSTITIAL, 0x300E },
            { Opcode.SMSG_PLAYER_SAVE_GUILD_EMBLEM, 0x29F8 },
            { Opcode.SMSG_PLAYER_SHOW_UI_EVENT_TOAST, 0x3019 },
            { Opcode.SMSG_PLAYER_SKINNED, 0x3006 },
            { Opcode.SMSG_PLAYER_TABARD_VENDOR_ACTIVATE, 0x3007 },
            { Opcode.SMSG_PLAYER_TUTORIAL_HIGHLIGHT_SPELL, 0x300D },
            { Opcode.SMSG_PLAYER_TUTORIAL_UNHIGHLIGHT_SPELL, 0x300C },
            { Opcode.SMSG_PLAY_MUSIC, 0x2769 },
            { Opcode.SMSG_PLAY_OBJECT_SOUND, 0x276A },
            { Opcode.SMSG_PLAY_ONE_SHOT_ANIM_KIT, 0x272D },
            { Opcode.SMSG_PLAY_ORPHAN_SPELL_VISUAL, 0x2C47 },
            { Opcode.SMSG_PLAY_SCENE, 0x2633 },
            { Opcode.SMSG_PLAY_SOUND, 0x2768 },
            { Opcode.SMSG_PLAY_SPEAKERBOT_SOUND, 0x276B },
            { Opcode.SMSG_PLAY_SPELL_VISUAL, 0x2C45 },
            { Opcode.SMSG_PLAY_SPELL_VISUAL_KIT, 0x2C49 },
            { Opcode.SMSG_PLAY_TIME_WARNING, 0x26FA },
            { Opcode.SMSG_PONG, 0x304E },
            { Opcode.SMSG_POWER_UPDATE, 0x26CF },
            { Opcode.SMSG_PRELOAD_CHILD_MAP, 0x2579 },
            { Opcode.SMSG_PREPOPULATE_NAME_CACHE, 0x284B },
            { Opcode.SMSG_PRE_RESSURECT, 0x2767 },
            { Opcode.SMSG_PRINT_NOTIFICATION, 0x25C8 },
            { Opcode.SMSG_PROC_RESIST, 0x2757 },
            { Opcode.SMSG_PUSH_SPELL_TO_ACTION_BAR, 0x2C51 },
            { Opcode.SMSG_PVP_CREDIT, 0x2949 },
            { Opcode.SMSG_PVP_MATCH_COMPLETE, 0x2953 },
            { Opcode.SMSG_PVP_MATCH_INITIALIZE, 0x2954 },
            { Opcode.SMSG_PVP_MATCH_START, 0x2952 },
            { Opcode.SMSG_PVP_MATCH_STATISTICS, 0x2934 },
            { Opcode.SMSG_PVP_OPTIONS_ENABLED, 0x2937 },
            { Opcode.SMSG_QUERY_ARENA_TEAM_RESPONSE, 0x2920 },
            { Opcode.SMSG_QUERY_BATTLE_PET_NAME_RESPONSE, 0x291A },
            { Opcode.SMSG_QUERY_CREATURE_RESPONSE, 0x2914 },
            { Opcode.SMSG_QUERY_GAME_OBJECT_RESPONSE, 0x2915 },
            { Opcode.SMSG_QUERY_GUILD_FOLLOW_INFO_RESPONSE, 0x29E7 },
            { Opcode.SMSG_QUERY_GUILD_INFO_RESPONSE, 0x29E5 },
            { Opcode.SMSG_QUERY_ITEM_TEXT_RESPONSE, 0x291E },
            { Opcode.SMSG_QUERY_NPC_TEXT_RESPONSE, 0x2916 },
            { Opcode.SMSG_QUERY_PAGE_TEXT_RESPONSE, 0x2917 },
            { Opcode.SMSG_QUERY_PETITION_RESPONSE, 0x291B },
            { Opcode.SMSG_QUERY_PET_NAME_RESPONSE, 0x2919 },
            { Opcode.SMSG_QUERY_PLAYER_NAMES_RESPONSE, 0x301B },
            { Opcode.SMSG_QUERY_PLAYER_NAME_BY_COMMUNITY_ID_RESPONSE, 0x3002 },
            { Opcode.SMSG_QUERY_QUEST_INFO_RESPONSE, 0x2A96 },
            { Opcode.SMSG_QUERY_REALM_GUILD_MASTER_INFO_RESPONSE, 0x29E6 },
            { Opcode.SMSG_QUERY_TIME_RESPONSE, 0x26E1 },
            { Opcode.SMSG_QUEST_COMPLETION_NPC_RESPONSE, 0x2A81 },
            { Opcode.SMSG_QUEST_CONFIRM_ACCEPT, 0x2A8F },
            { Opcode.SMSG_QUEST_FORCE_REMOVED, 0x2A9C },
            { Opcode.SMSG_QUEST_GIVER_INVALID_QUEST, 0x2A85 },
            { Opcode.SMSG_QUEST_GIVER_OFFER_REWARD_MESSAGE, 0x2A94 },
            { Opcode.SMSG_QUEST_GIVER_QUEST_COMPLETE, 0x2A83 },
            { Opcode.SMSG_QUEST_GIVER_QUEST_DETAILS, 0x2A92 },
            { Opcode.SMSG_QUEST_GIVER_QUEST_FAILED, 0x2A86 },
            { Opcode.SMSG_QUEST_GIVER_QUEST_LIST_MESSAGE, 0x2A9A },
            { Opcode.SMSG_QUEST_GIVER_REQUEST_ITEMS, 0x2A93 },
            { Opcode.SMSG_QUEST_GIVER_STATUS, 0x2A9B },
            { Opcode.SMSG_QUEST_GIVER_STATUS_MULTIPLE, 0x2A91 },
            { Opcode.SMSG_QUEST_LOG_FULL, 0x2A87 },
            { Opcode.SMSG_QUEST_NON_LOG_UPDATE_COMPLETE, 0x2A88 },
            { Opcode.SMSG_QUEST_POI_QUERY_RESPONSE, 0x2A9D },
            { Opcode.SMSG_QUEST_POI_UPDATE_RESPONSE, 0x2A9F },
            { Opcode.SMSG_QUEST_PUSH_RESULT, 0x2A90 },
            { Opcode.SMSG_QUEST_SESSION_INFO_RESPONSE, 0x286E },
            { Opcode.SMSG_QUEST_UPDATE_ADD_CREDIT, 0x2A8C },
            { Opcode.SMSG_QUEST_UPDATE_ADD_CREDIT_SIMPLE, 0x2A8D },
            { Opcode.SMSG_QUEST_UPDATE_ADD_PVP_CREDIT, 0x2A8E },
            { Opcode.SMSG_QUEST_UPDATE_COMPLETE, 0x2A89 },
            { Opcode.SMSG_QUEST_UPDATE_FAILED, 0x2A8A },
            { Opcode.SMSG_QUEST_UPDATE_FAILED_TIMER, 0x2A8B },
            { Opcode.SMSG_QUEUE_SUMMARY_UPDATE, 0x2813 },
            { Opcode.SMSG_RAF_ACTIVITY_STATE_CHANGED, 0x286A },
            { Opcode.SMSG_RAID_DIFFICULTY_SET, 0x27AC },
            { Opcode.SMSG_RAID_GROUP_ONLY, 0x27AE },
            { Opcode.SMSG_RAID_INSTANCE_MESSAGE, 0x2BB4 },
            { Opcode.SMSG_RAID_MARKERS_CHANGED, 0x25A4 },
            { Opcode.SMSG_RANDOM_ROLL, 0x262D },
            { Opcode.SMSG_RATED_PVP_INFO, 0x2931 },
            { Opcode.SMSG_READY_CHECK_COMPLETED, 0x25F5 },
            { Opcode.SMSG_READY_CHECK_RESPONSE, 0x25F4 },
            { Opcode.SMSG_READY_CHECK_STARTED, 0x25F3 },
            { Opcode.SMSG_READ_ITEM_RESULT_FAILED, 0x27A8 },
            { Opcode.SMSG_READ_ITEM_RESULT_OK, 0x27A0 },
            { Opcode.SMSG_REALM_LOOKUP_INFO, 0x27CC },
            { Opcode.SMSG_REALM_QUERY_RESPONSE, 0x2913 },
            { Opcode.SMSG_REATTACH_RESURRECT, 0x2747 },
            { Opcode.SMSG_RECRUIT_A_FRIEND_FAILURE, 0x26BE },
            { Opcode.SMSG_REFRESH_COMPONENT, 0x264E },
            { Opcode.SMSG_REFRESH_SPELL_HISTORY, 0x2C2C },
            { Opcode.SMSG_REMOVE_ITEM_PASSIVE, 0x25AB },
            { Opcode.SMSG_REMOVE_SPELL_FROM_ACTION_BAR, 0x2C52 },
            { Opcode.SMSG_REPLACE_TROPHY_RESPONSE, 0x27C4 },
            { Opcode.SMSG_REPORT_PVP_PLAYER_AFK_RESULT, 0x3001 },
            { Opcode.SMSG_REQUEST_CEMETERY_LIST_RESPONSE, 0x2593 },
            { Opcode.SMSG_REQUEST_PVP_REWARDS_RESPONSE, 0x2938 },
            { Opcode.SMSG_REQUEST_SCHEDULED_PVP_INFO_RESPONSE, 0x2939 },
            { Opcode.SMSG_RESEARCH_COMPLETE, 0x2587 },
            { Opcode.SMSG_RESET_COMPRESSION_CONTEXT, 0x304F },
            { Opcode.SMSG_RESET_FAILED_NOTIFY, 0x26B4 },
            { Opcode.SMSG_RESET_QUEST_POI, 0x2AA0 },
            { Opcode.SMSG_RESET_RANGED_COMBAT_TIMER, 0x2948 },
            { Opcode.SMSG_RESET_WEEKLY_CURRENCY, 0x2575 },
            { Opcode.SMSG_RESPEC_WIPE_CONFIRM, 0x260F },
            { Opcode.SMSG_RESPOND_INSPECT_ACHIEVEMENTS, 0x2572 },
            { Opcode.SMSG_RESTART_GLOBAL_COOLDOWN, 0x2C61 },
            { Opcode.SMSG_RESTRICTED_ACCOUNT_WARNING, 0x25B7 },
            { Opcode.SMSG_RESUME_CAST, 0x2C3B },
            { Opcode.SMSG_RESUME_CAST_BAR, 0x2C3E },
            { Opcode.SMSG_RESUME_COMMS, 0x304B },
            { Opcode.SMSG_RESUME_TOKEN, 0x25A9 },
            { Opcode.SMSG_RESURRECT_REQUEST, 0x257E },
            { Opcode.SMSG_RESYNC_RUNES, 0x2C5F },
            { Opcode.SMSG_ROLE_CHANGED_INFORM, 0x258E },
            { Opcode.SMSG_ROLE_CHOSEN, 0x2A39 },
            { Opcode.SMSG_ROLE_POLL_INFORM, 0x258F },
            { Opcode.SMSG_RUNEFORGE_LEGENDARY_CRAFTING_OPEN_NPC, 0x2800 },
            { Opcode.SMSG_RUNE_REGEN_DEBUG, 0x25B4 },
            { Opcode.SMSG_SCENARIO_COMPLETED, 0x27EE },
            { Opcode.SMSG_SCENARIO_POIS, 0x2630 },
            { Opcode.SMSG_SCENARIO_PROGRESS_UPDATE, 0x2629 },
            { Opcode.SMSG_SCENARIO_SHOW_CRITERIA, 0x2803 },
            { Opcode.SMSG_SCENARIO_STATE, 0x2628 },
            { Opcode.SMSG_SCENARIO_UI_UPDATE, 0x2802 },
            { Opcode.SMSG_SCENARIO_VACATE, 0x27A9 },
            { Opcode.SMSG_SCENE_OBJECT_EVENT, 0x25DE },
            { Opcode.SMSG_SCENE_OBJECT_PET_BATTLE_FINAL_ROUND, 0x25E3 },
            { Opcode.SMSG_SCENE_OBJECT_PET_BATTLE_FINISHED, 0x25E4 },
            { Opcode.SMSG_SCENE_OBJECT_PET_BATTLE_FIRST_ROUND, 0x25E0 },
            { Opcode.SMSG_SCENE_OBJECT_PET_BATTLE_INITIAL_UPDATE, 0x25DF },
            { Opcode.SMSG_SCENE_OBJECT_PET_BATTLE_REPLACEMENTS_MADE, 0x25E2 },
            { Opcode.SMSG_SCENE_OBJECT_PET_BATTLE_ROUND_RESULT, 0x25E1 },
            { Opcode.SMSG_SCRIPT_CAST, 0x2C56 },
            { Opcode.SMSG_SEASON_INFO, 0x25BF },
            { Opcode.SMSG_SELL_RESPONSE, 0x26C2 },
            { Opcode.SMSG_SEND_ITEM_PASSIVES, 0x25AC },
            { Opcode.SMSG_SEND_KNOWN_SPELLS, 0x2C2A },
            { Opcode.SMSG_SEND_RAID_TARGET_UPDATE_ALL, 0x262B },
            { Opcode.SMSG_SEND_RAID_TARGET_UPDATE_SINGLE, 0x262C },
            { Opcode.SMSG_SEND_SPELL_CHARGES, 0x2C2D },
            { Opcode.SMSG_SEND_SPELL_HISTORY, 0x2C2B },
            { Opcode.SMSG_SEND_UNLEARN_SPELLS, 0x2C2E },
            { Opcode.SMSG_SERVER_FIRST_ACHIEVEMENTS, 0x264B },
            { Opcode.SMSG_SERVER_TIME, 0x267F },
            { Opcode.SMSG_SERVER_TIME_OFFSET, 0x2710 },
            { Opcode.SMSG_SETUP_CURRENCY, 0x2573 },
            { Opcode.SMSG_SETUP_RESEARCH_HISTORY, 0x2586 },
            { Opcode.SMSG_SET_AI_ANIM_KIT, 0x272C },
            { Opcode.SMSG_SET_ALL_TASK_PROGRESS, 0x278E },
            { Opcode.SMSG_SET_ANIM_TIER, 0x2730 },
            { Opcode.SMSG_SET_CHR_UPGRADE_TIER, 0x25DB },
            { Opcode.SMSG_SET_CURRENCY, 0x2574 },
            { Opcode.SMSG_SET_DF_FAST_LAUNCH_RESULT, 0x2A2E },
            { Opcode.SMSG_SET_DUNGEON_DIFFICULTY, 0x26A1 },
            { Opcode.SMSG_SET_FACTION_AT_WAR, 0x26FC },
            { Opcode.SMSG_SET_FACTION_NOT_VISIBLE, 0x2727 },
            { Opcode.SMSG_SET_FACTION_STANDING, 0x2728 },
            { Opcode.SMSG_SET_FACTION_VISIBLE, 0x2726 },
            { Opcode.SMSG_SET_FLAT_SPELL_MODIFIER, 0x2C36 },
            { Opcode.SMSG_SET_FORCED_REACTIONS, 0x2719 },
            { Opcode.SMSG_SET_ITEM_PURCHASE_DATA, 0x259F },
            { Opcode.SMSG_SET_LOOT_METHOD_FAILED, 0x27D2 },
            { Opcode.SMSG_SET_MAX_WEEKLY_QUANTITY, 0x25A2 },
            { Opcode.SMSG_SET_MELEE_ANIM_KIT, 0x272F },
            { Opcode.SMSG_SET_MOVEMENT_ANIM_KIT, 0x272E },
            { Opcode.SMSG_SET_PCT_SPELL_MODIFIER, 0x2C37 },
            { Opcode.SMSG_SET_PET_SPECIALIZATION, 0x2622 },
            { Opcode.SMSG_SET_PLAYER_DECLINED_NAMES_RESULT, 0x3003 },
            { Opcode.SMSG_SET_PLAY_HOVER_ANIM, 0x25B8 },
            { Opcode.SMSG_SET_PROFICIENCY, 0x2731 },
            { Opcode.SMSG_SET_SPELL_CHARGES, 0x2C29 },
            { Opcode.SMSG_SET_TASK_COMPLETE, 0x278F },
            { Opcode.SMSG_SET_TIME_ZONE_INFORMATION, 0x2674 },
            { Opcode.SMSG_SET_VEHICLE_REC_ID, 0x26F3 },
            { Opcode.SMSG_SHOW_BANK, 0x267C },
            { Opcode.SMSG_SHOW_MAILBOX, 0x27AA },
            { Opcode.SMSG_SHOW_NEUTRAL_PLAYER_FACTION_SELECT_UI, 0x25D7 },
            { Opcode.SMSG_SHOW_QUEST_COMPLETION_TEXT, 0x2A95 },
            { Opcode.SMSG_SHOW_TAXI_NODES, 0x26CA },
            { Opcode.SMSG_SHOW_TRADE_SKILL_RESPONSE, 0x2770 },
            { Opcode.SMSG_SOCIAL_CONTRACT_REQUEST_RESPONSE, 0x288C },
            { Opcode.SMSG_SOCKET_GEMS_FAILURE, 0x2724 },
            { Opcode.SMSG_SOCKET_GEMS_SUCCESS, 0x2723 },
            { Opcode.SMSG_SPECIAL_MOUNT_ANIM, 0x269C },
            { Opcode.SMSG_SPEC_INVOLUNTARILY_CHANGED, 0x2714 },
            { Opcode.SMSG_SPELL_ABSORB_LOG, 0x2C1F },
            { Opcode.SMSG_SPELL_CATEGORY_COOLDOWN, 0x2C17 },
            { Opcode.SMSG_SPELL_CHANNEL_START, 0x2C34 },
            { Opcode.SMSG_SPELL_CHANNEL_UPDATE, 0x2C35 },
            { Opcode.SMSG_SPELL_COOLDOWN, 0x2C15 },
            { Opcode.SMSG_SPELL_DAMAGE_SHIELD, 0x2C31 },
            { Opcode.SMSG_SPELL_DELAYED, 0x2C3F },
            { Opcode.SMSG_SPELL_DISPELL_LOG, 0x2C1A },
            { Opcode.SMSG_SPELL_ENERGIZE_LOG, 0x2C1C },
            { Opcode.SMSG_SPELL_EXECUTE_LOG, 0x2C40 },
            { Opcode.SMSG_SPELL_FAILED_OTHER, 0x2C55 },
            { Opcode.SMSG_SPELL_FAILURE, 0x2C53 },
            { Opcode.SMSG_SPELL_FAILURE_MESSAGE, 0x2C5A },
            { Opcode.SMSG_SPELL_GO, 0x2C39 },
            { Opcode.SMSG_SPELL_HEAL_ABSORB_LOG, 0x2C1E },
            { Opcode.SMSG_SPELL_HEAL_LOG, 0x2C1D },
            { Opcode.SMSG_SPELL_INSTAKILL_LOG, 0x2C33 },
            { Opcode.SMSG_SPELL_INTERRUPT_LOG, 0x2C20 },
            { Opcode.SMSG_SPELL_MISS_LOG, 0x2C41 },
            { Opcode.SMSG_SPELL_NON_MELEE_DAMAGE_LOG, 0x2C32 },
            { Opcode.SMSG_SPELL_OR_DAMAGE_IMMUNE, 0x2C2F },
            { Opcode.SMSG_SPELL_PERIODIC_AURA_LOG, 0x2C1B },
            { Opcode.SMSG_SPELL_PREPARE, 0x2C38 },
            { Opcode.SMSG_SPELL_START, 0x2C3A },
            { Opcode.SMSG_SPELL_VISUAL_LOAD_SCREEN, 0x25CA },
            { Opcode.SMSG_SPIRIT_HEALER_CONFIRM, 0x2711 },
            { Opcode.SMSG_SPLASH_SCREEN_SHOW_LATEST, 0x2875 },
            { Opcode.SMSG_STAND_STATE_UPDATE, 0x2718 },
            { Opcode.SMSG_START_ELAPSED_TIMER, 0x2601 },
            { Opcode.SMSG_START_ELAPSED_TIMERS, 0x2603 },
            { Opcode.SMSG_START_LIGHTNING_STORM, 0x26A4 },
            { Opcode.SMSG_LOOT_START_ROLL, 0x261A },
            { Opcode.SMSG_START_MIRROR_TIMER, 0x270B },
            { Opcode.SMSG_START_TIMER, 0x25A6 },
            { Opcode.SMSG_STOP_ELAPSED_TIMER, 0x2602 },
            { Opcode.SMSG_STOP_MIRROR_TIMER, 0x270D },
            { Opcode.SMSG_STOP_SPEAKERBOT_SOUND, 0x276C },
            { Opcode.SMSG_STREAMING_MOVIES, 0x25A5 },
            { Opcode.SMSG_SUMMON_CANCEL, 0x26AD },
            { Opcode.SMSG_SUMMON_RAID_MEMBER_VALIDATE_FAILED, 0x2591 },
            { Opcode.SMSG_SUMMON_REQUEST, 0x271D },
            { Opcode.SMSG_SUPERCEDED_SPELLS, 0x2C4C },
            { Opcode.SMSG_SUSPEND_COMMS, 0x304A },
            { Opcode.SMSG_SUSPEND_TOKEN, 0x25A8 },
            { Opcode.SMSG_SYNC_WOW_ENTITLEMENTS, 0x286C },
            { Opcode.SMSG_TALENTS_INVOLUNTARILY_RESET, 0x2713 },
            { Opcode.SMSG_TALENT_GROUP_ROLE_CHANGED, 0x2590 },
            { Opcode.SMSG_TAXI_NODE_STATUS, 0x2679 },
            { Opcode.SMSG_TEXT_EMOTE, 0x2677 },
            { Opcode.SMSG_THREAT_CLEAR, 0x26D9 },
            { Opcode.SMSG_THREAT_REMOVE, 0x26D8 },
            { Opcode.SMSG_THREAT_UPDATE, 0x26D7 },
            { Opcode.SMSG_TIME_ADJUSTMENT, 0x2DD3 },
            { Opcode.SMSG_TIME_SYNC_REQUEST, 0x2DD2 },
            { Opcode.SMSG_TITLE_EARNED, 0x26D4 },
            { Opcode.SMSG_TITLE_LOST, 0x26D5 },
            { Opcode.SMSG_TOTEM_CREATED, 0x26C5 },
            { Opcode.SMSG_TOTEM_MOVED, 0x26C7 },
            { Opcode.SMSG_TRADE_STATUS, 0x2582 },
            { Opcode.SMSG_TRADE_UPDATED, 0x2581 },
            { Opcode.SMSG_TRAINER_BUY_FAILED, 0x26DD },
            { Opcode.SMSG_TRAINER_LIST, 0x26DC },
            { Opcode.SMSG_TRANSFER_ABORTED, 0x26FF },
            { Opcode.SMSG_TRANSFER_PENDING, 0x25CB },
            { Opcode.SMSG_TRANSMOGRIFY_NPC, 0x27F8 },
            { Opcode.SMSG_TREASURE_PICKER_RESPONSE, 0x291F },
            { Opcode.SMSG_TRIGGER_CINEMATIC, 0x27CA },
            { Opcode.SMSG_TRIGGER_MOVIE, 0x26C8 },
            { Opcode.SMSG_TURN_IN_PETITION_RESULT, 0x274A },
            { Opcode.SMSG_TUTORIAL_FLAGS, 0x27BD },
            { Opcode.SMSG_TWITTER_STATUS, 0x3043 },
            { Opcode.SMSG_UI_HEALING_RANGE_MODIFIED, 0x2740 },
            { Opcode.SMSG_UI_ITEM_INTERACTION_NPC, 0x27FA },
            { Opcode.SMSG_UI_MAP_QUEST_LINES_RESPONSE, 0x2AA2 },
            { Opcode.SMSG_UNDELETE_CHARACTER_RESPONSE, 0x27CD },
            { Opcode.SMSG_UNDELETE_COOLDOWN_STATUS_RESPONSE, 0x27CE },
            { Opcode.SMSG_UNLEARNED_SPELLS, 0x2C4E },
            { Opcode.SMSG_UNLOAD_CHILD_MAP, 0x257A },
            { Opcode.SMSG_UPDATE_AADC_STATUS_RESPONSE, 0x2888 },
            { Opcode.SMSG_UPDATE_ACCOUNT_DATA, 0x2705 },
            { Opcode.SMSG_UPDATE_ACTION_BUTTONS, 0x25DC },
            { Opcode.SMSG_UPDATE_BNET_SESSION_KEY, 0x2824 },
            { Opcode.SMSG_UPDATE_CAPTURE_POINT, 0x2929 },
            { Opcode.SMSG_UPDATE_CELESTIAL_BODY, 0x2820 },
            { Opcode.SMSG_UPDATE_CHARACTER_FLAGS, 0x27C3 },
            { Opcode.SMSG_UPDATE_CHARGE_CATEGORY_COOLDOWN, 0x2766 },
            { Opcode.SMSG_UPDATE_COOLDOWN, 0x2765 },
            { Opcode.SMSG_UPDATE_EXPANSION_LEVEL, 0x2643 },
            { Opcode.SMSG_UPDATE_GAME_TIME_STATE, 0x2827 },
            { Opcode.SMSG_UPDATE_INSTANCE_OWNERSHIP, 0x26A6 },
            { Opcode.SMSG_UPDATE_LAST_INSTANCE, 0x2685 },
            { Opcode.SMSG_UPDATE_OBJECT, 0x27CB },
            { Opcode.SMSG_UPDATE_PRIMARY_SPEC, 0x25D4 },
            { Opcode.SMSG_UPDATE_TALENT_DATA, 0x25D3 },
            { Opcode.SMSG_UPDATE_TASK_PROGRESS, 0x278D },
            { Opcode.SMSG_UPDATE_WEEKLY_SPELL_USAGE, 0x2C19 },
            { Opcode.SMSG_UPDATE_WORLD_STATE, 0x2744 },
            { Opcode.SMSG_USERLIST_ADD, 0x2BB9 },
            { Opcode.SMSG_USERLIST_REMOVE, 0x2BBA },
            { Opcode.SMSG_USERLIST_UPDATE, 0x2BBB },
            { Opcode.SMSG_USE_EQUIPMENT_SET_RESULT, 0x274B },
            { Opcode.SMSG_VAS_CHECK_TRANSFER_OK_RESPONSE, 0x281B },
            { Opcode.SMSG_VAS_GET_QUEUE_MINUTES_RESPONSE, 0x2819 },
            { Opcode.SMSG_VAS_GET_SERVICE_STATUS_RESPONSE, 0x2818 },
            { Opcode.SMSG_VAS_PURCHASE_COMPLETE, 0x27F4 },
            { Opcode.SMSG_VAS_PURCHASE_STATE_UPDATE, 0x27F3 },
            { Opcode.SMSG_VENDOR_INVENTORY, 0x25B6 },
            { Opcode.SMSG_VIGNETTE_UPDATE, 0x3008 },
            { Opcode.SMSG_VOICE_CHANNEL_INFO_RESPONSE, 0x281F },
            { Opcode.SMSG_VOICE_CHANNEL_STT_TOKEN_RESPONSE, 0x2884 },
            { Opcode.SMSG_VOICE_LOGIN_RESPONSE, 0x281E },
            { Opcode.SMSG_VOID_ITEM_SWAP_RESPONSE, 0x2DA4 },
            { Opcode.SMSG_VOID_STORAGE_CONTENTS, 0x2DA1 },
            { Opcode.SMSG_VOID_STORAGE_FAILED, 0x2DA0 },
            { Opcode.SMSG_VOID_STORAGE_TRANSFER_CHANGES, 0x2DA2 },
            { Opcode.SMSG_VOID_TRANSFER_RESULT, 0x2DA3 },
            { Opcode.SMSG_WAIT_QUEUE_FINISH, 0x256F },
            { Opcode.SMSG_WAIT_QUEUE_UPDATE, 0x256E },
            { Opcode.SMSG_WARDEN3_DATA, 0x2577 },
            { Opcode.SMSG_WARDEN3_DISABLED, 0x2822 },
            { Opcode.SMSG_WARDEN3_ENABLED, 0x2821 },
            { Opcode.SMSG_WARFRONT_COMPLETE, 0x275A },
            { Opcode.SMSG_WARGAME_REQUEST_SUCCESSFULLY_SENT_TO_OPPONENT, 0x2935 },
            { Opcode.SMSG_WEATHER, 0x26A3 },
            { Opcode.SMSG_WEEKLY_REWARDS_PROGRESS_RESULT, 0x2878 },
            { Opcode.SMSG_WEEKLY_REWARDS_RESULT, 0x2876 },
            { Opcode.SMSG_WEEKLY_REWARD_CLAIM_RESULT, 0x2877 },
            { Opcode.SMSG_WEEKLY_SPELL_USAGE, 0x2C18 },
            { Opcode.SMSG_WHO, 0x2BAE },
            { Opcode.SMSG_WHO_IS, 0x26A2 },
            { Opcode.SMSG_WILL_BE_KICKED_FOR_ADDED_SUBSCRIPTION_TIME, 0x2826 },
            { Opcode.SMSG_WORLD_MAP_OPEN_NPC, 0x27F7 },
            { Opcode.SMSG_WORLD_QUEST_UPDATE_RESPONSE, 0x300F },
            { Opcode.SMSG_WORLD_SERVER_INFO, 0x25AD },
            { Opcode.SMSG_WOW_ENTITLEMENT_NOTIFICATION, 0x286D },
            { Opcode.SMSG_XP_GAIN_ABORTED, 0x25C7 },
            { Opcode.SMSG_XP_GAIN_ENABLED, 0x27AD },
            { Opcode.SMSG_ZONE_UNDER_ATTACK, 0x2BB5 },
            { Opcode.SMSG_UNKNOWN_9610, 0x258A }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9621, 0x2595 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9622, 0x2596 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9653, 0x25B5 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9660, 0x25BC }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9676, 0x25CC }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9677, 0x25CD }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9681, 0x25D1 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9682, 0x25D2 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9685, 0x25D5 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9686, 0x25D6 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9689, 0x25D9 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9690, 0x25DA }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9701, 0x25E5 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9732, 0x2604 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9733, 0x2605 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9734, 0x2606 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9735, 0x2607 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9736, 0x2608 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9737, 0x2609 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9738, 0x260A }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9739, 0x260B }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9740, 0x260C }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9741, 0x260D }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9742, 0x260E }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9744, 0x2610 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9747, 0x2613 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9787, 0x263B }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9788, 0x263C }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9789, 0x263D }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9790, 0x263E }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9793, 0x2641 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9799, 0x2647 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9802, 0x264A }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9805, 0x264D }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9807, 0x264F }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9808, 0x2650 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9809, 0x2651 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9811, 0x2653 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9812, 0x2654 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9813, 0x2655 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9814, 0x2656 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9815, 0x2657 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9816, 0x2658 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9817, 0x2659 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9818, 0x265A }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9819, 0x265B }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9820, 0x265C }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9821, 0x265D }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9822, 0x265E }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9823, 0x265F }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9824, 0x2660 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9825, 0x2661 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9826, 0x2662 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9827, 0x2663 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9828, 0x2664 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9829, 0x2665 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9830, 0x2666 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9831, 0x2667 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9832, 0x2668 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9833, 0x2669 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9834, 0x266A }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9835, 0x266B }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9836, 0x266C }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9839, 0x266F }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9840, 0x2670 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9841, 0x2671 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9843, 0x2673 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9846, 0x2676 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9853, 0x267D }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9863, 0x2687 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9897, 0x26A9 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9898, 0x26AA }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9899, 0x26AB }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9900, 0x26AC }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9905, 0x26B1 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9920, 0x26C0 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9926, 0x26C6 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9929, 0x26C9 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9939, 0x26D3 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9946, 0x26DA }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9960, 0x26E8 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9961, 0x26E9 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9969, 0x26F1 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9970, 0x26F2 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9975, 0x26F7 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_9979, 0x26FB }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10011, 0x271B }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10012, 0x271C }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10015, 0x271F }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10021, 0x2725 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10025, 0x2729 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10026, 0x272A }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10027, 0x272B }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10034, 0x2732 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10035, 0x2733 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10036, 0x2734 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10038, 0x2736 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10039, 0x2737 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10040, 0x2738 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10041, 0x2739 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10042, 0x273A }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10043, 0x273B }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10047, 0x273F }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10057, 0x2749 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10060, 0x274C }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10107, 0x277B }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10113, 0x2781 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10118, 0x2786 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10119, 0x2787 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10129, 0x2791 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10134, 0x2796 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10136, 0x2798 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10145, 0x27A1 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10146, 0x27A2 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10147, 0x27A3 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10148, 0x27A4 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10149, 0x27A5 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10150, 0x27A6 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10151, 0x27A7 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10191, 0x27CF }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10192, 0x27D0 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10193, 0x27D1 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10208, 0x27E0 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10209, 0x27E1 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10210, 0x27E2 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10211, 0x27E3 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10212, 0x27E4 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10213, 0x27E5 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10214, 0x27E6 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10215, 0x27E7 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10216, 0x27E8 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10217, 0x27E9 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10218, 0x27EA }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10219, 0x27EB }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10220, 0x27EC }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10221, 0x27ED }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10237, 0x27FD }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10241, 0x2801 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10244, 0x2804 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10250, 0x280A }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10251, 0x280B }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10252, 0x280C }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10253, 0x280D }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10254, 0x280E }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10255, 0x280F }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10256, 0x2810 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10257, 0x2811 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10266, 0x281A }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10284, 0x282C }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10285, 0x282D }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10286, 0x282E }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10287, 0x282F }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10288, 0x2830 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10289, 0x2831 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10290, 0x2832 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10291, 0x2833 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10292, 0x2834 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10293, 0x2835 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10294, 0x2836 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10295, 0x2837 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10296, 0x2838 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10297, 0x2839 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10298, 0x283A }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10299, 0x283B }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10300, 0x283C }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10301, 0x283D }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10302, 0x283E }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10303, 0x283F }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10304, 0x2840 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10305, 0x2841 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10306, 0x2842 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10307, 0x2843 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10308, 0x2844 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10309, 0x2845 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10310, 0x2846 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10316, 0x284C }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10317, 0x284D }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10318, 0x284E }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10319, 0x284F }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10320, 0x2850 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10321, 0x2851 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10322, 0x2852 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10323, 0x2853 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10324, 0x2854 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10325, 0x2855 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10326, 0x2856 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10327, 0x2857 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10328, 0x2858 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10329, 0x2859 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10330, 0x285A }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10331, 0x285B }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10332, 0x285C }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10333, 0x285D }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10334, 0x285E }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10335, 0x285F }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10336, 0x2860 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10337, 0x2861 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10338, 0x2862 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10339, 0x2863 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10341, 0x2865 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10342, 0x2866 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10343, 0x2867 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10344, 0x2868 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10347, 0x286B }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10351, 0x286F }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10353, 0x2871 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10354, 0x2872 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10368, 0x2880 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10369, 0x2881 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10371, 0x2883 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10375, 0x2887 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10377, 0x2889 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10378, 0x288A }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10379, 0x288B }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10381, 0x288D }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10382, 0x288E }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10383, 0x288F }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10490, 0x28FA }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10491, 0x28FB }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10492, 0x28FC }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10494, 0x28FE }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10514, 0x2912 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10546, 0x2932 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10550, 0x2936 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10554, 0x293A }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10701, 0x29CD }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10702, 0x29CE }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10703, 0x29CF }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10704, 0x29D0 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10705, 0x29D1 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10709, 0x29D5 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10710, 0x29D6 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10711, 0x29D7 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10746, 0x29FA }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10787, 0x2A23 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10799, 0x2A2F }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10882, 0x2A82 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10916, 0x2AA4 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_10917, 0x2AA5 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_11205, 0x2BC5 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_11206, 0x2BC6 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_11207, 0x2BC7 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_11208, 0x2BC8 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_11209, 0x2BC9 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_11280, 0x2C10 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_11281, 0x2C11 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_11324, 0x2C3C }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_11325, 0x2C3D }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_11330, 0x2C42 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_11355, 0x2C5B }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_11356, 0x2C5C }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_11357, 0x2C5D }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_11358, 0x2C5E }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_11360, 0x2C60 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_11820, 0x2E2C }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_11821, 0x2E2D }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_12281, 0x2FF9 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_12288, 0x3000 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_12299, 0x300B }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_12305, 0x3011 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_12306, 0x3012 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_12314, 0x301A }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_12316, 0x301C }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_12317, 0x301D }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_12350, 0x303E }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_12351, 0x303F }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_12352, 0x3040 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_12353, 0x3041 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_12354, 0x3042 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
            { Opcode.SMSG_UNKNOWN_12368, 0x3050 }, // placeholder, id present in 3.4.0.45166/46779 client tables, name unknown
        };

        private static readonly BiDictionary<Opcode, int> MiscOpcodes = new BiDictionary<Opcode, int>();
    }
}