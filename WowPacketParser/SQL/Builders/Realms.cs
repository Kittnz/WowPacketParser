using System;
using System.Text;
using WowPacketParser.Misc;
using WowPacketParser.Store;
using WowPacketParser.Store.Objects;

namespace WowPacketParser.SQL.Builders
{
    [BuilderClass]
    class Realms
    {
        [BuilderMethod]
        public static string RealmsBuilder()
        {
            if (!Settings.SqlTables.realms)
                return string.Empty;

            if (Storage.Realms.IsEmpty())
                return string.Empty;

            StringBuilder result = new StringBuilder();

            var realmRows = new RowList<RealmTemplate>();

            foreach (var realm in Storage.Realms)
            {
                Row<RealmTemplate> realmRow = new Row<RealmTemplate>();
                realmRow.Data.VirtualRealmAddress = realm.Item1.VirtualRealmAddress;
                realmRow.Data.LookupState = realm.Item1.LookupState;
                realmRow.Data.IsLocal = realm.Item1.IsLocal;
                realmRow.Data.IsInternalRealm = realm.Item1.IsInternalRealm;
                realmRow.Data.RealmNameActual = realm.Item1.RealmNameActual;
                realmRow.Data.RealmNameNormalized = realm.Item1.RealmNameNormalized;
                realmRows.Add(realmRow);
            }

            if (Settings.SqlTables.realms)
            {
                var realmSql = new SQLInsert<RealmTemplate>(realmRows, false, false);
                result.Append(realmSql.Build());
                result.AppendLine();
            }

            return result.ToString();
        }
    }
}
