using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using LibGit2Sharp.Core;
using LibGit2Sharp.Core.Handles;
using LibGit2Sharp.Handlers;
using LibGit2Sharp;

namespace webhook.test
{
    public class webhootest
    {
        public void GetBranches()
        {
            string url = "https://github.com/joele-redplanetsoftware/WebhookTestSite.git";

            // Location on the disk where the local repository should be cloned
            string workingDirectory = @"C:\Red Planet\webhook_test2";

            // Perform the initial clone
            string repoPath = Repository.Clone(url, workingDirectory);

            using (var repo = new Repository(repoPath))
            {

            }
          
        }
    }
}
