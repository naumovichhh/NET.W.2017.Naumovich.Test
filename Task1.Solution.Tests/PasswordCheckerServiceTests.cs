using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task1.Solution.Tests
{
    public class PasswordCheckerServiceTests
    {
        private static IVerifier verifier = new Verifier();
        private static IRepository repository = new Repository();
        private static PasswordCheckerService service = new PasswordCheckerService(repository, verifier);
        private static Tuple<bool, bool>[] source; 

        static PasswordCheckerServiceTests()
        {
            source = new Tuple<bool, bool>[]{
                new Tuple<bool, bool>(true, service.VerifyAndStore("password").Item1),
                new Tuple<bool, bool>(false, service.VerifyAndStore("1").Item1),
                new Tuple<bool, bool>(false, service.VerifyAndStore("12345").Item1)
            };
        }

        [TestCaseSource("source")]
        public void Tests(Tuple<bool, bool> t)
        {
            Assert.AreEqual(t.Item1, t.Item2);
        }
    }

    public class Verifier : IVerifier
    {
        public Tuple<bool, string> Verify(string password)
        {
            if (password.Length < 8)
                return new Tuple<bool, string>(false, $"{password} length too short");

            return new Tuple<bool, string>(true, $"{password} is OK");
        }
    }

    public class Repository : IRepository
    {
        public void Create(string password)
        {
            
        }
    }
}
