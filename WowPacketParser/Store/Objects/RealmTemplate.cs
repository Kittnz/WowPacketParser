using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [DBTableName("realm_template")]
    public sealed class RealmTemplate : IDataModel
    {
        [DBFieldName("virtual_realm_address", true, true)]
        public uint VirtualRealmAddress = 0;

        [DBFieldName("lookup_state")]
        public uint LookupState = 0;

        [DBFieldName("is_local")]
        public uint IsLocal = 0;

        [DBFieldName("is_internal_realm")]
        public uint IsInternalRealm = 0;

        [DBFieldName("realm_name_actual")]
        public string RealmNameActual = "";

        [DBFieldName("realm_name_normalized")]
        public string RealmNameNormalized = "";
    }
}
