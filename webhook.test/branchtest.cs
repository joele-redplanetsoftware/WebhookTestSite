using LibGit2Sharp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webhook.test
{
    [TestFixture]
    public class branchtest
    {
        [Test]
        public void testbranch()
        {
           
            //string repoPath = @"C:\Red Planet\webhook_test2";
            const string url = "https://github.com/joele-redplanetsoftware/WebhookTestSite.git";
            const string remoteName = "origin";

            string repoPath = @"C:\Red Planet\webhook_test2";

            using (var repo = new Repository(repoPath))
            {
                Remote remote = repo.Network.Remotes.Add(remoteName, url);
                IList<Reference> references = repo.Network.ListReferences(remote).ToList();


                foreach (var reference in references)
                {
                    // None of those references point to an existing
                    // object in this brand new repository
                    Assert.Null(reference.ResolveToDirectReference().Target);
                }

                List<Tuple<string, string>> actualRefs = references.
                    Select(directRef => new Tuple<string, string>(directRef.CanonicalName, directRef.ResolveToDirectReference()
                        .TargetIdentifier)).ToList();

             
            }
        }
    }
}
