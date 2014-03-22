using System;
using System.Linq.Expressions;

namespace NHibernateNuoDB.Tests.DomainModel {
    public class Team {
        private readonly string teamId;
        private readonly string name;

        public Team(string teamId, string name) {
            this.teamId = teamId;
            this.name = name;
        }

        private Team() {}

        public static Expression<Func<Team, bool>> ByCode(string id) {
            return _ => _.teamId == id;
        }
    }
}