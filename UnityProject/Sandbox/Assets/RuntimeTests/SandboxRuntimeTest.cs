using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class SandboxRuntimeTest
{
    [Test]
    public void SandboxTestSimplePasses()
    {
        Assert.Pass();
    }

    [UnityTest]
    public IEnumerator SandboxTestWithEnumeratorPasses()
    {
        Assert.Pass();
        yield return null;
    }
}
