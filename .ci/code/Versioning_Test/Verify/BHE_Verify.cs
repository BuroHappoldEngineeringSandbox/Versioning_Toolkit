/*
 * Sandbox test — proves that VersioningRunner discovers and invokes Verify.FromJsonDatasets
 * across multiple assemblies and namespaces. In production BHE would ship this class in a
 * separate assembly from their own versioning toolkit repo.
 */

using BH.Engine.Test;
using BH.oM.Test.Results;

namespace BHE.Test.Versioning
{
    public static partial class Verify
    {
        public static TestResult FromJsonDatasets(bool testAll = false)
        {
            // Placeholder — no BHE datasets staged yet.
            // Purpose: verify VersioningRunner finds and invokes this method alongside
            // BH.Test.Versioning.Verify.FromJsonDatasets from the same assembly.
            return Create.PassResult("BHE versioning: no datasets registered yet.");
        }
    }
}
