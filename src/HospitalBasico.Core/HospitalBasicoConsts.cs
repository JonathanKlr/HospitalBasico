using HospitalBasico.Debugging;

namespace HospitalBasico
{
    public class HospitalBasicoConsts
    {
        public const string LocalizationSourceName = "HospitalBasico";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "80472a7f1bf0438491dd4e2ac62973e5";
    }
}
