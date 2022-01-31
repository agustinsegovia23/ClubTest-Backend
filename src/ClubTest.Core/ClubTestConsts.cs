using ClubTest.Debugging;

namespace ClubTest
{
    public class ClubTestConsts
    {
        public const string LocalizationSourceName = "ClubTest";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "1f89df9da8324d878abdf24664821ba0";
    }
}
