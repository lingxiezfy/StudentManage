using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.DBUtility
{public class LogUtil
    {
        public static void Info(string module, string text)
        {
            //如果日志文件为空，则默认在Debug目录下新建 YYYY-mm-dd_Log.log文件
            string FileName = Environment.CurrentDirectory + "\\Log_" +
                              DateTime.Now.Year + '-' +
                              DateTime.Now.Month + '-' +
                              DateTime.Now.Day + ".log";

            //把异常信息输出到文件
            StreamWriter fs = new StreamWriter(FileName, true);
            fs.WriteLine(string.Format("[Info] {0} -- [{1}] {2}", DateTime.Now.ToString("HH:mm:ss"), module, text));
            fs.Close();
        }

        public static void Debug(string module, string text)
        {
            //如果日志文件为空，则默认在Debug目录下新建 YYYY-mm-dd_Log.log文件
            string FileName = Environment.CurrentDirectory + "\\Log_" +
                    DateTime.Now.Year + '-' +
                    DateTime.Now.Month + '-' +
                    DateTime.Now.Day + ".log";

            //把异常信息输出到文件
            StreamWriter fs = new StreamWriter(FileName, true);
            try
            {
                fs.WriteLine(string.Format("[Info] {0} -- [{1}] {2}", DateTime.Now.ToString("HH:mm:ss"), module, text));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                fs.Close();
            }
        }

        public static void Error(string module, string text)
        {
            //如果日志文件为空，则默认在Debug目录下新建 YYYY-mm-dd_Log.log文件
            string FileName = Environment.CurrentDirectory + "\\Log_" +
                    DateTime.Now.Year + '-' +
                    DateTime.Now.Month + '-' +
                    DateTime.Now.Day + ".log";

            //把异常信息输出到文件
            StreamWriter fs = new StreamWriter(FileName, true);
            fs.WriteLine(string.Format("[Error!] {0} -- [{1}] {2}", DateTime.Now.ToString("HH:mm:ss"), module, text));
            fs.Close();
        }
    }
}
