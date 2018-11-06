namespace BeFaster.App.Tests

open NUnit.Framework
open BeFaster.App.Solutions.TST

[<TestFixture>]
type OneTest() =
    
    [<Test>]
    member x.``One.apply = 1``() =
        Assert.AreEqual(1, One.apply())
