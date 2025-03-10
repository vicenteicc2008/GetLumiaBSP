﻿// Copyright (c) 2018, Gustave M. - gus33000.me - @gus33000
//
// Permission is hereby granted, free of charge, to any person obtaining a
// copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.

namespace GetLumiaBSP
{
    internal class WlanInfHandler
    {
        public static void GenInfProperly(string QCWLANSYS, string QCWLANDAT)
        {
            Console.WriteLine("(wlanCare) Copying files...");

            Directory.CreateDirectory("Wlan");
            File.Move(QCWLANSYS, @"Wlan\" + QCWLANSYS);
            File.Move(QCWLANDAT, @"Wlan\" + QCWLANDAT);

            if (QCWLANSYS.Contains("8974"))
            {
                File.Copy(@"Care\WLANCare\qcwlan8974.inf", @"Wlan\qcwlan8974.inf");
            }
            else if (QCWLANSYS.Contains("8626"))
            {
                File.Copy(@"Care\WLANCare\qcwlan8626.inf", @"Wlan\qcwlan8626.inf");
            }
            else if (QCWLANSYS.Contains("8612"))
            {
                File.Copy(@"Care\WLANCare\qcwlan8612.inf", @"Wlan\qcwlan8612.inf");
            }
            else if (QCWLANSYS.Contains("8930"))
            {
                File.Copy(@"Care\WLANCare\qcwlan_24ghz8930.inf", @"Wlan\qcwlan_24ghz8930.inf");
            }
            else if (QCWLANSYS.Contains("8960"))
            {
                File.Copy(@"Care\WLANCare\qcwlan8960.inf", @"Wlan\qcwlan8960.inf");
            }

            Console.WriteLine("(wlanCare) Done.");
        }
    }
}
