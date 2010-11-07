// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.4.0.0
//      Runtime Version:4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace FluentHttp.Tests.HttpHeader
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class FluentHttpHeaderCtorFeature : Xunit.IUseFixture<FluentHttpHeaderCtorFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "HttpHeaderCtor.feature"
#line hidden
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "FluentHttpHeader ctor", "Check if ctor assings value correctly\nand FluentHttpHeader is constructed correct" +
                    "ly.", GenerationTargetLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public virtual void SetFixture(FluentHttpHeaderCtorFeature.FixtureData fixtureData)
        {
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "FluentHttpHeader ctor")]
        [Xunit.TraitAttribute("Description", "Pass header name and header value as ctor params")]
        public virtual void PassHeaderNameAndHeaderValueAsCtorParams()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Pass header name and header value as ctor params", new string[] {
                        "important"});
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given("a null fluent http header");
#line 8
 testRunner.When("I create a new fluent http header with ctor params (\"header-name\" and \"header-val" +
                    "ue\")");
#line 9
  testRunner.And("I get name");
#line 10
  testRunner.And("I get value");
#line 11
 testRunner.Then("there should be no exception thrown");
#line 12
  testRunner.And("name should be \"header-name\"");
#line 13
  testRunner.And("value should be \"header-value\"");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "FluentHttpHeader ctor")]
        [Xunit.TraitAttribute("Description", "Pass header name as null")]
        public virtual void PassHeaderNameAsNull()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Pass header name as null", ((string[])(null)));
#line 16
this.ScenarioSetup(scenarioInfo);
#line 17
 testRunner.Given("a null fluent http header");
#line 18
 testRunner.When("I create a new fluent http header with http header name as null");
#line 19
 testRunner.Then("it should throw ArgumentOutOfRangeException");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "FluentHttpHeader ctor")]
        [Xunit.TraitAttribute("Description", "Pass header name as string.Empty")]
        public virtual void PassHeaderNameAsString_Empty()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Pass header name as string.Empty", ((string[])(null)));
#line 21
this.ScenarioSetup(scenarioInfo);
#line 22
 testRunner.Given("a null fluent http header");
#line 23
 testRunner.When("I create a new fluent http header with http header name as string.Empty");
#line 24
 testRunner.Then("it should throw ArgumentOutOfRangeException");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "FluentHttpHeader ctor")]
        [Xunit.TraitAttribute("Description", "Pass header name as \"\"")]
        public virtual void PassHeaderNameAs()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Pass header name as \"\"", ((string[])(null)));
#line 26
this.ScenarioSetup(scenarioInfo);
#line 27
 testRunner.Given("a null fluent http header");
#line 28
 testRunner.When("I create a new fluent http header with http header name as \"\"");
#line 29
 testRunner.Then("it should throw ArgumentOutOfRangeException");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "FluentHttpHeader ctor")]
        [Xunit.TraitAttribute("Description", "Pass header name as white space.")]
        public virtual void PassHeaderNameAsWhiteSpace_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Pass header name as white space.", ((string[])(null)));
#line 31
this.ScenarioSetup(scenarioInfo);
#line 32
 testRunner.Given("a null fluent http header");
#line 33
 testRunner.When("I create a new fluent http header with http header name as \" \"");
#line 34
 testRunner.Then("it should throw ArgumentOutOfRangeException");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.4.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                FluentHttpHeaderCtorFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                FluentHttpHeaderCtorFeature.FeatureTearDown();
            }
        }
    }
}
#endregion
