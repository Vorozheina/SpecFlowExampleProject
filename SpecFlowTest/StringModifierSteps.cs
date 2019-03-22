using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpecFlowTest
{
    [Binding]
    public class StringModifierSteps
    {
        private StringModifier stringModifier = new StringModifier();
        private string result;

        [Given(@"I have entered ""(.*)"" into my string modifier")]
        public void GivenIHaveEnteredIntoMyStringModifier(string firstString)
        {
            //ScenarioContext.Current.Pending();
            stringModifier.MainString = firstString;
        }
        
        [Given(@"I have also entered ""(.*)"" into my string modifier")]
        public void GivenIHaveAlsoEnteredIntoMyStringModifier(string secondString)
        {
            //ScenarioContext.Current.Pending();
            stringModifier.Substring = secondString;
        }
        
        [When(@"I press add the second string in the ending of the first string")]
        public void WhenIPressAddTheSecondStringInTheEndingOfTheFirstString()
        {
            //ScenarioContext.Current.Pending();
            result = stringModifier.AddSubstringLast();
        }
        
        [Then(@"the result should be ""(.*)"" on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(string expectedResult)
        {
            //ScenarioContext.Current.Pending();
            Assert.AreEqual(expectedResult, result);
        }
    }
}
