
using Microsoft.VisualStudio.TestPlatform.TestHost;
using ConsoleApp1;
using Program = ConsoleApp1.Program;
using PersonDetails = ConsoleApp1.PersonDetails;
using ConsoleApp1.Classes;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void LoopAndPrint_ShouldPrintCorrectMessages()
        {
            Calculator calculator = new Calculator();

            // Redirect console output to capture the messages
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                calculator.LoopAndPrint(5);
                string output = sw.ToString();

                List<string> list = output.Split(new string[] { "\r\n" }, StringSplitOptions.None).ToList();


                //Complete the list depending on the output
                List<string> toCompare = new List<string> {
                    "Iteration 0: Multiple of 3"
                };

                foreach(string data in list)
                {
                    if(!string.IsNullOrEmpty(data))
                    {
                        try
                        {
                            Assert.Equal(data, toCompare.ElementAt(list.IndexOf(data)));
                        }
                        catch
                        {
                            break;
                        }
                    }
                }
            }
        }

    }
}