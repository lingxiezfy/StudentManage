namespace Student.DBUtility
{

    //using IWshRuntimeLibrary;
    using Microsoft.VisualBasic;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Management;
    using System.Net;
    using System.Net.Sockets;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;


    public static class ToolHelper
    {
        public static string AsciiToString(byte iAsciiCode)
        {
            if ((iAsciiCode >= 0) && (iAsciiCode <= 0xff))
            {
                ASCIIEncoding encoding = new ASCIIEncoding();
                byte[] buffer = new byte[] { iAsciiCode };
                return encoding.GetString(buffer);
            }
            return "";
        }

        public static string BytesToHexStr(byte[] bytes)
        {
            string str = "";
            for (int i = 0; i < bytes.Length; i++)
            {
                string str2 = Convert.ToString(bytes[i], 0x10).PadLeft(2, '0');
                str2 = str2.Substring(str2.Length - 2, 2);
                str = str + str2;
            }
            return str;
        }

        public static string CatchWebCode(string sUrl, string PostData, string EncodeType)
        {
            Stream requestStream = null;
            StreamReader reader = null;
            HttpWebResponse response = null;
            HttpWebRequest request = null;
            ServicePointManager.Expect100Continue = false;
            Encoding encoding = Encoding.GetEncoding(EncodeType);
            byte[] bytes = encoding.GetBytes(PostData);
            try
            {
                request = WebRequest.Create(sUrl) as HttpWebRequest;
                CookieContainer container = new CookieContainer();
                request.CookieContainer = container;
                request.AllowAutoRedirect = true;
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = bytes.Length;
                requestStream = request.GetRequestStream();
                requestStream.Write(bytes, 0, bytes.Length);
                requestStream.Close();
                response = request.GetResponse() as HttpWebResponse;
                reader = new StreamReader(response.GetResponseStream(), encoding);
                return reader.ReadToEnd();
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static void ClearDirectory(string sPath, bool bDelDir)
        {
            if (sPath[sPath.Length - 1] != Path.DirectorySeparatorChar)
            {
                sPath = sPath + Path.DirectorySeparatorChar;
            }
            if (Directory.Exists(sPath))
            {
                new DirectoryInfo(sPath);
                try
                {
                    foreach (string str in Directory.GetFileSystemEntries(sPath))
                    {
                        if (Directory.Exists(str))
                        {
                            ClearDirectory(str, bDelDir);
                            if (bDelDir)
                            {
                                Directory.Delete(str);
                            }
                        }
                        else
                        {
                            System.IO.File.Delete(str);
                        }
                    }
                }
                catch
                {
                }
            }
        }

        public static int CompareDate(DateTime dt1, DateTime dt2)
        {
            DateTime time = new DateTime(dt1.Year, dt1.Month, dt1.Day, 0, 0, 0);
            DateTime time2 = new DateTime(dt2.Year, dt2.Month, dt2.Day, 0, 0, 0);
            return DateTime.Compare(time, time2);
        }

        public static int CompareTime(DateTime dt1, DateTime dt2)
        {
            DateTime time = new DateTime(1, 1, 1, dt1.Hour, dt1.Minute, dt1.Second);
            DateTime time2 = new DateTime(1, 1, 1, dt2.Hour, dt2.Minute, dt2.Second);
            return DateTime.Compare(time, time2);
        }

        public static bool ConvertToBool(object obj)
        
        {
            if (obj == null)
            {
                return false;
            }
            string str = obj.ToString();
            if (str == null)
            {
                return false;
            }
            if (str.Trim() == "")
            {
                return false;
            }
            if (str.ToUpper().Trim() == "TRUE")
            {
                return true;
            }
            if (str.ToUpper().Trim() == "FALSE")
            {
                return false;
            }
            bool flag = true;
            bool.TryParse(str, out flag);
            return flag;
        }

        public static DateTime? ConvertToDateTime(object obj)
        {
            if (obj == null)
            {
                return null;
            }
            string str = obj.ToString();
            if (str == "")
            {
                return null;
            }
            str = str.Replace(" 00:00:00 UTC+0800", "");
            DateTime minValue = DateTime.MinValue;
            DateTime.TryParse(str, out minValue);
            return new DateTime?(minValue);
        }

        public static float ConvertToFloat(object obj)
        {
            if (obj == null)
            {
                return 0f;
            }
            string str = obj.ToString();
            if (str.Trim().ToUpper() == "TRUE")
            {
                return 1f;
            }
            if (str.Trim().ToUpper() == "FALSE")
            {
                return 0f;
            }
            float num = 0f;
            float.TryParse(str, out num);
            return num;
        }

        public static double ConvertToDouble(object obj)
        {
            if (obj == null)
            {
                return 0;
            }
            double num = 0;
            double.TryParse(obj.ToString(), out num);
            return num;
        }

        public static string ConvertToGMK(long length)
        {
            if (length < 0x400L)
            {
                return length.ToString();
            }
            if ((length >= 0x400L) && (length < 0x100000L))
            {
                return (Math.Round((double) (((float) length) / 1024f), 2).ToString() + "K");
            }
            if ((length >= 0x100000L) && (length < 0x40000000L))
            {
                return (Math.Round((double) ((((float) length) / 1024f) / 1024f), 2).ToString() + "M");
            }
            if (length > 0x40000000L)
            {
                return (Math.Round((double) (((((float) length) / 1024f) / 1024f) / 1024f), 2).ToString() + "G");
            }
            return "";
        }

        public static int ConvertToInt(object obj)
        {
            if (obj == null)
            {
                return 0;
            }
            string str = obj.ToString();
            if (str.Trim().ToUpper() == "TRUE")
            {
                return 1;
            }
            if (str.Trim().ToUpper() == "FALSE")
            {
                return 0;
            }
            int num = 0;
            int.TryParse(str, out num);
            return num;
        }

        public static long ConvertToLong(object obj)
        {
            if (obj == null)
            {
                return 0L;
            }
            string str = obj.ToString();
            if (str.Trim().ToUpper() == "TRUE")
            {
                return 1L;
            }
            if (str.Trim().ToUpper() == "FALSE")
            {
                return 0L;
            }
            long num = 0L;
            long.TryParse(str, out num);
            return num;
        }

        public static string ConvertToString(object obj)
        {
            if (obj == null)
            {
                return "";
            }
            return obj.ToString();
        }

        //public static bool CopyDirectory(string SourcePath, string TargetPath)
        //{
        //    bool flag = true;
        //    if (SourcePath[SourcePath.Length - 1] != Path.DirectorySeparatorChar)
        //    {
        //        SourcePath = SourcePath + Path.DirectorySeparatorChar;
        //    }
        //    if (TargetPath[TargetPath.Length - 1] != Path.DirectorySeparatorChar)
        //    {
        //        TargetPath = TargetPath + Path.DirectorySeparatorChar;
        //    }
        //    if (!Directory.Exists(SourcePath))
        //    {
        //        return false;
        //    }
        //    if (!Directory.Exists(TargetPath))
        //    {
        //        Directory.CreateDirectory(TargetPath);
        //    }
        //    string[] fileSystemEntries = Directory.GetFileSystemEntries(SourcePath);
        //    try
        //    {
        //        foreach (string str in fileSystemEntries)
        //        {
        //            if (Directory.Exists(str))
        //            {
        //                string targetPath = str.Replace(SourcePath, TargetPath);
        //                flag = CopyDirectory(str, targetPath);
        //                if (!flag)
        //                {
        //                    return flag;
        //                }
        //            }
        //            else
        //            {
        //                System.IO.File.Copy(str, str.Replace(SourcePath, TargetPath));
        //            }
        //        }
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //    return flag;
        //}

        //public static void Delay(long iMilliSecond)
        //{
        //    long curMilliSecond = GetCurMilliSecond();
        //    while ((GetCurMilliSecond() - curMilliSecond) < iMilliSecond)
        //    {
        //        System.Windows.Forms.Application.DoEvents();
        //    }
        //}

        //public static void DeleteDirAllFile(string dirRoot)
        //{
        //    if (!dirRoot.EndsWith(@"\"))
        //    {
        //        dirRoot = dirRoot + @"\";
        //    }
        //    DirectoryInfo info = new DirectoryInfo(Path.GetDirectoryName(dirRoot));
        //    foreach (FileInfo info2 in info.GetFiles("*.*", SearchOption.AllDirectories))
        //    {
        //        try
        //        {
        //            System.IO.File.Delete(info2.FullName);
        //        }
        //        catch
        //        {
        //        }
        //    }
        //}

        //public static string GBKToString(byte[] GBKByte)
        //{
        //    return Encoding.GetEncoding("GBK").GetString(GBKByte);
        //}

        //public static string GetCpuInfo()
        //{
        //    string str = " ";
        //    using (ManagementClass class2 = new ManagementClass("Win32_Processor"))
        //    {
        //        foreach (ManagementObject obj2 in class2.GetInstances())
        //        {
        //            str = obj2.Properties["ProcessorId"].Value.ToString();
        //            obj2.Dispose();
        //        }
        //    }
        //    return str.ToString();
        //}

        //public static long GetCurMilliSecond()
        //{
        //    long lpPerformanceCount = 0L;
        //    long lpFrequency = 0L;
        //    if (QueryPerformanceFrequency(ref lpFrequency))
        //    {
        //        QueryPerformanceCounter(ref lpPerformanceCount);
        //        return (long) ((lpPerformanceCount / lpFrequency) * 1000M);
        //    }
        //    return 0L;
        //}

        //public static List<FormAct> getFormAct(string sHTML)
        //{
        //    List<FormAct> list = new List<FormAct>();
        //    Regex regex = new Regex("(?m)<form[^>\"']+name=\"(?<name>([^>|\"'])+)\"([^>])+\\baction=(\"|')?(?<act>[^>|\"]+)\">", RegexOptions.Multiline | RegexOptions.IgnoreCase);
        //    for (Match match = regex.Match(sHTML); match.Success; match = match.NextMatch())
        //    {
        //        string url = match.Groups["act"].Value;
        //        FormAct act = new FormAct(match.Groups["name"].Value, url);
        //        list.Add(act);
        //    }
        //    return list;
        //}

        public static string GetIPv4Address()
        {
            try
            {
                string hostName = Dns.GetHostName();
                string str2 = null;
                for (int i = 0; i <= (Dns.GetHostEntry(hostName).AddressList.Length - 1); i++)
                {
                    if (Dns.GetHostEntry(hostName).AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                    {
                        str2 = Dns.GetHostEntry(hostName).AddressList[i].ToString();
                    }
                }
                return str2;
            }
            catch
            {
                return "";
            }
        }

       

        public static string GetSubValue(string sMainStr, string sName)
        {
            return GetSubValue(sMainStr, sName, new char[] { ',' }, new char[] { '=' });
        }

        public static string GetSubValue(string sMainStr, string sName, char[] ItemSep, char[] ValueSep)
        {
            if (sMainStr.Length != 0)
            {
                string[] strArray = sMainStr.Split(ItemSep);
                if (strArray.Length >= 1)
                {
                    for (int i = 0; i < strArray.Length; i++)
                    {
                        int index = strArray[i].IndexOf(new string(ValueSep));
                        if ((index >= 0) && (strArray[i].Substring(0, index) == sName))
                        {
                            return strArray[i].Substring(index + 1);
                        }
                    }
                }
            }
            return "";
        }

        public static string GetUniqueDirectory(string sPath)
        {
            if (sPath[sPath.Length - 1] != Path.DirectorySeparatorChar)
            {
                sPath = sPath + Path.DirectorySeparatorChar;
            }
            DirectoryInfo info = new DirectoryInfo(sPath);
            if (!info.Exists)
            {
                info.Create();
            }
            string str = string.Empty;
            while (Directory.Exists(Path.Combine(sPath, str = DateTime.Now.ToString("yyyyMMddHHmmssffff"))))
            {
                System.Windows.Forms.Application.DoEvents();
            }
            return Path.Combine(sPath, str);
        }

        public static string GetUniqueFileName(string sDir, string sPostfix)
        {
            DirectoryInfo info = new DirectoryInfo(sDir);
            if (!info.Exists)
            {
                info.Create();
            }
            string str = DateTime.Now.ToString("yyyyMMddHHmmssffff") + "." + sPostfix;
            FileInfo info2 = new FileInfo(Path.Combine(info.ToString(), str));
            while (info2.Exists)
            {
                str = DateTime.Now.ToString("yyyyMMddHHmmssffff") + "." + sPostfix;
                info2 = new FileInfo(Path.Combine(info.ToString(), str));
            }
            return info2.FullName;
        }

        public static byte[] HexToBytes(string sHex)
        {
            if (sHex == "")
            {
                return null;
            }
            byte[] buffer = new byte[sHex.Length / 2];
            for (int i = 0; i < (sHex.Length / 2); i++)
            {
                buffer[i] = Convert.ToByte(sHex.Substring(i * 2, 2), 0x10);
            }
            return buffer;
        }

        public static bool IsMail(string sMailAddress)
        {
            return Regex.IsMatch(sMailAddress, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

        public static bool IsNumeric(string str)
        {
            Regex regex = new Regex(@"^[-]?\d+[.]?\d*$");
            return regex.IsMatch(str);
        }

        public static bool IsNumOrLetter(string str)
        {
            Regex regex = new Regex("^[a-zA-Z0-9]+$");
            return regex.IsMatch(str);
        }

        private static bool IsSameSerial(string sSerial, string sSubSerial)
        {
            for (int i = (sSerial.Length / 5) * 5; i < sSerial.Length; i++)
            {
                if (sSerial.Substring(i, 1) == sSubSerial)
                {
                    return true;
                }
            }
            return false;
        }

        public static string MakeSerialNo(long iUnique, string sUnit, int iClientCount)
        {
            int num = 0;
            for (int i = 0; i < sUnit.Length; i++)
            {
                num += Convert.ToChar(sUnit.Substring(i, 1));
            }
            int iSeed = 0;
            int num4 = 0;
            int num5 = 0;
            int num6 = 0;
            string sSerial = "";
            for (int j = 0; j < 0x19; j++)
            {
                num4 = Random(0, iUnique.ToString().Length - 1, j);
                num5 = Random(0, num.ToString().Length - 1, j);
                num6 = Random(0, iClientCount.ToString().Length - 1, j);
                iSeed = (Convert.ToChar(iUnique.ToString().Substring(num4, 1)) * Convert.ToChar(num.ToString().Substring(num5, 1))) * Convert.ToChar(iClientCount.ToString().Substring(num6, 1));
                string sSubSerial = Convert.ToChar(Random(0x41, 90, iSeed)).ToString();
                while (IsSameSerial(sSerial, sSubSerial))
                {
                    iSeed++;
                    sSubSerial = Convert.ToChar(Random(0x41, 90, iSeed)).ToString();
                }
                sSerial = sSerial + sSubSerial;
            }
            return sSerial;
        }

        [DllImport("kernel32.dll ")]
        private static extern bool QueryPerformanceCounter(ref long lpPerformanceCount);
        [DllImport("kernel32.dll ")]
        private static extern bool QueryPerformanceFrequency(ref long lpFrequency);
        public static int Random(int iDown, int iUp)
        {
            System.Random random = new System.Random();
            return random.Next(iDown, iUp + 1);
        }

        public static int Random(int iDown, int iUp, int iSeed)
        {
            System.Random random = new System.Random(iSeed);
            return random.Next(iDown, iUp + 1);
        }

        //public static Point Rotate(Point p, int angle)
        //{
        //    double num = (6.2831853071795862 * angle) / 360.0;
        //    Point point = new Point();
        //    point.X = Convert.ToInt16((Math.Cos(num) * p.X) - (Math.Sin(num) * p.Y));
        //    point.Y = Convert.ToInt16((Math.Cos(num) * p.Y) + (Math.Sin(num) * p.X));
        //    return point;
        //}

        public static string SetSubValue(string sMainStr, string sName, string sValue)
        {
            int index = sMainStr.IndexOf(sName);
            if (index >= 0)
            {
                int num2 = (sMainStr.IndexOf(",", index) > index) ? sMainStr.IndexOf(",", index) : sMainStr.Length;
                return (sMainStr.Substring(0, index) + sName + "=" + sValue + sMainStr.Substring(num2));
            }
            return (((sMainStr.Length == 0) ? "" : (sMainStr + ",")) + sName + "=" + sValue);
        }

        //public static void Shortcut(string Name, string Description, string Path, string Arguments, Environment.SpecialFolder ShortcutType, WshWindowStyle WindowStyle, string IconPath)
        //{
        //    try
        //    {
        //        string folderPath = Environment.GetFolderPath(ShortcutType);
        //        FileInfo info = new FileInfo(folderPath + @"\" + Name + ".lnk");
        //        if (info.Exists)
        //        {
        //            info.Delete();
        //        }
        //        if (!info.Exists)
        //        {
        //            WshShell shell = new WshShellClass();
        //            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(folderPath + @"\" + Name + ".lnk");
        //            shortcut.TargetPath = Path;
        //            shortcut.Arguments = Arguments;
        //            shortcut.WorkingDirectory = new FileInfo(Path).Directory.ToString();
        //            shortcut.WindowStyle = Convert.ToInt16(WindowStyle);
        //            shortcut.Description = Description;
        //            shortcut.IconLocation = IconPath;
        //            shortcut.Arguments = Arguments;
        //            shortcut.Save();
        //        }
        //    }
        //    catch (Exception exception)
        //    {
        //        MessageBox.Show("创建快捷方式失败!\r\n原因:" + exception.Message);
        //    }
        //}

        //public static string SimplifiedToTraditional(string str)
        //{
        //    return Strings.StrConv(str, VbStrConv.TraditionalChinese, 0);
        //}

        //public static long SoftUniqueCode()
        //{
        //    string str = HardwareInfo.GetHardDiskID() + HardwareInfo.GetCpuID() + HardwareInfo.GetMacAddress();
        //    if (str == "")
        //    {
        //        str = "14";
        //    }
        //    string str2 = "";
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if ((Convert.ToChar(str.Substring(i, 1)) >= '0') && (Convert.ToChar(str.Substring(i, 1)) <= '9'))
        //        {
        //            str2 = str2 + str.Substring(i, 1);
        //        }
        //    }
        //    if (str2.Length < 0x10)
        //    {
        //        for (int j = str2.Length + 1; j <= 0x10; j++)
        //        {
        //            str2 = str2 + Random(0, 9, ConvertToInt(str2.Substring(str2.Length - 1)) * j).ToString();
        //        }
        //    }
        //    if (str2.Length > 0x10)
        //    {
        //        str2 = str2.Substring(0, 0x10);
        //    }
        //    return Convert.ToInt64(str2);
        //}

        public static int StringToAscii(string schar)
        {
            if (schar.Length == 1)
            {
                ASCIIEncoding encoding = new ASCIIEncoding();
                return encoding.GetBytes(schar)[0];
            }
            return -1;
        }

        //public static bcxAlignEnum StringToEnumBarCodeAlign(string sAlign)
        //{
        //    switch (sAlign)
        //    {
        //        case "Left":
        //            return bcxAlignEnum.bcxAlignLeft;

        //        case "Right":
        //            return bcxAlignEnum.bcxAlignRight;

        //        case "Center":
        //            return bcxAlignEnum.bcxAlignCenter;
        //    }
        //    return bcxAlignEnum.bcxAlignLeft;
        //}

        //public static bcxTypeEnum StringToEnumBarCodePrintType(string sType)
        //{
        //    switch (sType)
        //    {
        //        case "Code128":
        //            return bcxTypeEnum.bcxCode128;

        //        case "Code128A":
        //            return bcxTypeEnum.bcxCode128A;

        //        case "Code128B":
        //            return bcxTypeEnum.bcxCode128B;

        //        case "Code128C":
        //            return bcxTypeEnum.bcxCode128C;

        //        case "Code 25":
        //            return bcxTypeEnum.bcxCode25;

        //        case "Code39":
        //            return bcxTypeEnum.bcxCode39;

        //        case "Code39Ext":
        //            return bcxTypeEnum.bcxCode39Ext;

        //        case "Code93":
        //            return bcxTypeEnum.bcxCode93;

        //        case "Codebar":
        //            return bcxTypeEnum.bcxCodebar;

        //        case "Custom":
        //            return bcxTypeEnum.bcxCustom;

        //        case "EAN-128":
        //            return bcxTypeEnum.bcxEAN128;

        //        case "EAN-13":
        //            return bcxTypeEnum.bcxEAN13;

        //        case "EAN-2":
        //            return bcxTypeEnum.bcxEAN2;

        //        case "EAN-5":
        //            return bcxTypeEnum.bcxEAN5;

        //        case "EAN-8":
        //            return bcxTypeEnum.bcxEAN8;

        //        case "Interleaved 2of5":
        //            return bcxTypeEnum.bcxInteleave25;

        //        case "ISBN":
        //            return bcxTypeEnum.bcxISBN;

        //        case "ISSN":
        //            return bcxTypeEnum.bcxISSN;

        //        case "MSI Plessey":
        //            return bcxTypeEnum.bcxMSI;

        //        case "PDF417":
        //            return bcxTypeEnum.bcxPDF417;

        //        case "Plessey":
        //            return bcxTypeEnum.bcxPlessey;

        //        case "Post2/5":
        //            return bcxTypeEnum.bcxPost25;

        //        case "POSTNet":
        //            return bcxTypeEnum.bcxPOSTNet;

        //        case "UPC-A":
        //            return bcxTypeEnum.bcxUPCA;

        //        case "UPC-E":
        //            return bcxTypeEnum.bcxUPCE;
        //    }
        //    return bcxTypeEnum.bcxCode128;
        //}

        public static byte[] StringToGBK(string sGBK)
        {
            byte[] buffer = new byte[sGBK.Length * 2];
            for (int i = 0; i < sGBK.Length; i++)
            {
                byte[] bytes = Encoding.GetEncoding("GBK").GetBytes(sGBK.Substring(i, 1));
                if (bytes.Length == 1)
                {
                    buffer[i * 2] = 0xa3;
                    buffer[(i * 2) + 1] = Convert.ToByte(bytes[0] + 0x80);
                }
                else
                {
                    buffer[i * 2] = bytes[0];
                    buffer[(i * 2) + 1] = bytes[1];
                }
            }
            return buffer;
        }

        //public static string TraditionalToSimplified(string str)
        //{
        //    return Strings.StrConv(str, VbStrConv.SimplifiedChinese, 0);
        //}

        public static int WeekOfMonth(DateTime day, int WeekStart)
        {
            int num = (int)Convert.ToDateTime(string.Concat(new object[] { day.Date.Year, "-", day.Date.Month, "-", 1 })).Date.DayOfWeek;
            if (num == 0)
            {
                num = 7;
            }
            if (WeekStart == 1)
            {
                return ((((day.Date.Day + num) - 2) / 7) + 1);
            }
            if (WeekStart == 2)
            {
                return (((day.Date.Day + num) - 1) / 7);
            }
            return 0;
        }

        //public static int GetCmbIndexByID(ComboBox Cb, int ID)
        //{
        //    for (int i = 0; i < Cb.Items.Count; i++)
        //    {
        //        if (ConvertToInt((Cb.Items[i] as CComboBoxItem).Value) == ID)
        //        {
        //            return i;
        //        }
        //    }
        //    return -1;
        //}

        //public static int GetCmbIndexByValue(ComboBox Cb, string sValue)
        //{
        //    for (int i = 0; i < Cb.Items.Count; i++)
        //    {
        //        if ( (Cb.Items[i] as CComboBoxItem).Value.ToString() == sValue)
        //        {
        //            return i;
        //        }
        //    }
        //    return -1;
        //}

        internal static decimal ConvertToDecimal(object obj)
        {
            if (obj == null)
            {
                return 0;
            }
            decimal num = 0;
            decimal.TryParse(obj.ToString(), out num);
            return num;
        }


        public static string GetProjectDirectory()
        {
            string strProjectDerectory = null;
            // strProjectDerectory
            strProjectDerectory = Application.ExecutablePath; ;
            string temppath = strProjectDerectory.Substring(0, strProjectDerectory.LastIndexOf("\\") + 1);
            strProjectDerectory = temppath;

            if (!Directory.Exists(strProjectDerectory))
            {

                Directory.CreateDirectory(strProjectDerectory);

            }
            return strProjectDerectory;
        }

        /// <summary>  
        /// GridView  显示行号   设置行号列的宽度  
        /// </summary>  
        /// <param name="gv">GridView 控件名称</param>  
        /// <param name="width">行号列的宽度 如果为null或为0 默认为30</param>  
        public static void DrawRowIndicator(DevExpress.XtraGrid.Views.Grid.GridView gv, int width)
        {
            gv.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(gv_CustomDrawRowIndicator);
            if (width != null)
            {
                if (width != 0)
                {
                    gv.IndicatorWidth = width;
                }
                else
                {
                    gv.IndicatorWidth = 30;
                }
            }
            else
            {
                gv.IndicatorWidth = 30;
            }

        }
        //行号设置  
        public static void gv_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle > -1)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        //设置GridView奇偶行颜色
        public static void SetLineColorofGridView(DevExpress.XtraGrid.Views.Grid.GridView gv)
        {
            gv.Appearance.EvenRow.BackColor = Color.FromArgb(150, 237, 243, 254);
            gv.Appearance.OddRow.BackColor = Color.FromArgb(150, 199, 237, 204);
            //gv.Appearance.FocusedRow.BackColor = Color.FromArgb(150,0,0,185);
            gv.Appearance.FocusedRow.ForeColor = Color.FromArgb(150, 0, 0, 185);
            gv.OptionsView.EnableAppearanceEvenRow = true;
            gv.OptionsView.EnableAppearanceOddRow = true;
        }
    }
}

