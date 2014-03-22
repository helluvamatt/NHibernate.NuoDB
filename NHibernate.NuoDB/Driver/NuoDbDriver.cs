using System.Data;
using NuoDb.Data.Client;

namespace NHibernate.Driver {
    public class NuoDbClientDriver : DriverBase {
        public override IDbCommand CreateCommand() {
            return new NuoDbCommand();
        }

        public override IDbConnection CreateConnection() {
            return new NuoDbConnection();
        }

        public override string NamedPrefix {
            get { return "@"; }
        }

        public override bool UseNamedPrefixInParameter {
            get { return true; }
        }

        public override bool UseNamedPrefixInSql {
            get { return false; }
        }
    }
}