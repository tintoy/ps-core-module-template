using System.Management.Automation;

namespace PSModule
{
    /// <summary>
    ///     A simple Cmdlet that outputs a greeting to the pipeline.
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "Greeting")]
    public class GetGreeting
        : Cmdlet
    {
        /// <summary>
        ///     The name of the person to greet.
        /// </summary>
        [ValidateNotNullOrEmpty]
        [Parameter(Position = 0, HelpMessage = "The name of the person to greet")]
        public string Name { get; set; } = "Stranger";

        /// <summary>
        ///     Perform Cmdlet processing.
        /// </summary>
        protected override void ProcessRecord()
        {
            WriteObject($"Hello, {Name}!");
        }
    }
}
