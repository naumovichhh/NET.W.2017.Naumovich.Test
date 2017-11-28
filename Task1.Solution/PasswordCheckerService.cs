using System;
using System.Linq;

namespace Task1.Solution
{
    public class PasswordCheckerService
    {
        private IRepository repository;
        private IVerifier verifier;

        public PasswordCheckerService(IRepository repository, IVerifier verifier)
        {
            this.repository = repository;
            this.verifier = verifier;
        }

        public Tuple<bool, string> VerifyAndStore(string password)
        {
            if (password == null)
                throw new ArgumentException($"{password} is null arg");

            Tuple<bool, string> verificationResult = this.verifier.Verify(password);

            if (verificationResult.Item1)
            {
                repository.Create(password);
            }

            return verificationResult;
        }
    }
}
