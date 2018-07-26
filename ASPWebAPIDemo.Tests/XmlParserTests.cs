using System;
using ASPWebAPIDemo.Parser;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprache;

namespace ASPWebAPIDemo.Tests
{
    [TestClass]
    public class XmlParserTests
    {
        [TestMethod]
        public void BasicParseTest()
        {
            string input = "<node><subnode>test</subnode></node>";
            var parsed = XmlParser.Document.Parse(input);
            Console.WriteLine(parsed);
        }
    }
}
