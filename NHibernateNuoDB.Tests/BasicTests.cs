using System.Linq;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Linq;
using NHibernateNuoDB.Tests.DomainModel;
using NUnit.Framework;

namespace NHibernateNuoDB.Tests {
    [TestFixture]
    public class BasicTests {
        private readonly ISessionFactory sessionFactory = new Configuration()
            .Configure()
            .AddAssembly(typeof (BasicTests).Assembly)
            .BuildSessionFactory();

        [Test]
        public void OpenSession() {
            sessionFactory.OpenSession();
        }

        [Test]
        public void Read() {
            var session = sessionFactory.OpenSession();

            var team = session.Query<Team>().Single(Team.ByCode("COB"));

            Assert.That(team, Is.Not.Null);
        }
    }
}