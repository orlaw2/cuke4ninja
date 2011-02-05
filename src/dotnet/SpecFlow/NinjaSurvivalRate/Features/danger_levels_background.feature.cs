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
namespace NinjaSurvivalRate.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Skill availability with Background")]
    public partial class SkillAvailabilityWithBackgroundFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "danger_levels_background.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Skill availability with Background", "As a ninja trainer,\nI want ninjas to understand the dangers of various opponents\n" +
                    "so that they can engage them in combat more effectively", GenerationTargetLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            this.FeatureBackground();
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void FeatureBackground()
        {
#line 6
  #line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "skills"});
            table1.AddRow(new string[] {
                        "katana"});
            table1.AddRow(new string[] {
                        "karate-kick"});
            table1.AddRow(new string[] {
                        "roundhouse-kick"});
#line 7
 testRunner.Given("the following skills are allowed", ((string)(null)), table1);
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Samurai are dangeous with katanas, no advanced kicks")]
        public virtual void SamuraiAreDangeousWithKatanasNoAdvancedKicks()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Samurai are dangeous with katanas, no advanced kicks", ((string[])(null)));
#line 13
  this.ScenarioSetup(scenarioInfo);
#line 14
 testRunner.When("a ninja faces a samurai");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "technique",
                        "danger"});
            table2.AddRow(new string[] {
                        "katana",
                        "high"});
            table2.AddRow(new string[] {
                        "karate-kick",
                        "low"});
#line 15
 testRunner.Then("he should expect the following attack techniques", ((string)(null)), table2);
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Chuch Norris can do anything and is always dangerous")]
        public virtual void ChuchNorrisCanDoAnythingAndIsAlwaysDangerous()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Chuch Norris can do anything and is always dangerous", ((string[])(null)));
#line 20
  this.ScenarioSetup(scenarioInfo);
#line 21
 testRunner.When("a ninja faces Chuck Norris");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "technique",
                        "danger"});
            table3.AddRow(new string[] {
                        "katana",
                        "extreme"});
            table3.AddRow(new string[] {
                        "karate-kick",
                        "extreme"});
            table3.AddRow(new string[] {
                        "roundhouse-kick",
                        "extreme"});
#line 22
 testRunner.Then("he should expect the following attack techniques", ((string)(null)), table3);
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion