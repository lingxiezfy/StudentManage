using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _3sdnMap.ToolClass
{
    public class ArrayTool
    {
        public static void copyFullFromStringToInt(String[] source, int[] target)
        {
            if (target.Length < source.Length)
            {
                return;
            }
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = Convert.ToInt32(source[i]);
            }
        }

        public static void PrintOutArray(double[,] srcDouble)
        {
#if DEBUG

            int RowCount = srcDouble.GetLength(0);
            int ColCount = srcDouble.GetLength(1);

            for (int ilen = 0; ilen <= RowCount - 1; ilen++)
            {
                for (int idata = 0; idata <= ColCount - 1; idata++)
                {
                    Console.Out.Write(Convert.ToString(srcDouble[ilen, idata]));
                }
                Console.Out.WriteLine();
            }



#endif

        }

        /// <summary>
        /// 将一维double数组数值存成文件
        /// </summary>
        /// <param name="src">一维double数组</param>
        /// <param name="fileName">目标文件</param>
        public static void SaveArrayToFile(double[] src, string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName, false))
            {
                foreach (double d in src)
                {
                    sw.Write(d);
                    sw.Write(" ");
                }
            }
        }

        public static void SaveArrayToFile(string[] src, string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName, false))
            {
                foreach (string d in src)
                {
                    sw.Write(d);
                    sw.Write(" ");
                }
            }
        }

        /// <summary>
        /// 将二维double数组数值存成文件
        /// </summary>
        /// <param name="src">二维double数组</param>
        /// <param name="fileName">目标文件</param>
        public static void SaveArrayToFile(double[,] src, string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName, false))
            {
                int RowCount = src.GetLength(0);
                int ColCount = src.GetLength(1);
                for (int y = 0; y < RowCount; y++)
                {
                    for (int x = 0; x < ColCount; x++)
                    {
                        sw.Write(src[y, x]);
                        sw.Write(" ");
                    }
                }
            }
        }

        public static void SaveArrayToFile(string[,] src, string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName, false, Encoding.Unicode))
            {
                int RowCount = src.GetLength(0);
                int ColCount = src.GetLength(1);
                for (int y = 0; y < RowCount; y++)
                {
                    for (int x = 0; x < ColCount; x++)
                    {
                        sw.Write(src[y, x]);
                        sw.Write(" ");
                    }
                }
            }
        }


        /// <summary>
        /// 从文件恢复到给定一维数组
        /// </summary>
        /// <param name="fileName">源文件</param>
        /// <param name="target">一维数组</param>
        public static void RestoreArrayFromFile(string fileName, ref double[] target)
        {
            string[] temp = File.ReadAllText(fileName, Encoding.Default).Split(new char[] { ' ' });

            for (int y = 0; y < target.Length; y++)
            {
                target[y] = Double.Parse(temp[y]);
            }
        }

        public static void RestoreArrayFromFile(string fileName, ref string[] target)
        {
            string[] temp = File.ReadAllText(fileName, Encoding.Unicode).Split(new char[] { ' ' });

            for (int y = 0; y < target.Length; y++)
            {
                target[y] = temp[y];
            }
        }

        /// <summary>
        /// 从文件恢复到给定二维数组
        /// </summary>
        /// <param name="fileName">源文件</param>
        /// <param name="target">二维数组</param>
        public static void RestoreArrayFromFile(string fileName, ref double[,] target)
        {
            string[] temp = File.ReadAllText(fileName, Encoding.Default).Split(new char[] { });
            int i = 0;

            for (int y = 0; y < target.GetLength(0); y++)
            {
                for (int x = 0; x < target.GetLength(1); x++)
                {
                    target[y, x] = Double.Parse(temp[i]);
                    i++;
                }
            }
        }

        public static void RestoreArrayFromFile(string fileName, ref string[,] target)
        {
            string[] temp = File.ReadAllText(fileName, Encoding.Unicode).Split(new char[] { });
            int i = 0;

            for (int y = 0; y < target.GetLength(0); y++)
            {
                for (int x = 0; x < target.GetLength(1); x++)
                {
                    target[y, x] = temp[i];
                    i++;
                }
            }
        }

        /// <summary>
        /// 产生一个规律性的数组值
        /// </summary>
        /// <param name="startNum">第一个元素值</param>
        /// <param name="endNum">最后一个元素值</param>
        /// <param name="waveMax">期间最大值</param>
        /// <param name="waveMin">期间最小值-保留</param>
        /// <param name="waveCnt">波动次数-保留</param>
        /// <param name="outArray">返回到数组中</param>
        public static void GetRandomArray(double startNum, double endNum, Double waveMax, Double waveMin, int waveCnt, ref double[] outArray)
        {
            //int arrayLen = outArray.Length;
            //int arrayLenHalf = arrayLen /2;

            //outArray[0] = startNum;

            //double upMax = waveMax - startNum;
            //double downMax = endNum - waveMax;

            //double upValPerVal = upMax / ((arrayLenHalf-1) * 1.0);
            //double downValPerVal = downMax / ((arrayLenHalf-1) * 1.0);

            //for (int i = 1; i < arrayLenHalf; i++)
            //{
            //    outArray[i]=outArray[i-1]+upValPerVal;
            //}
            //for (int i = arrayLenHalf; i < arrayLen-1; i++)
            //{
            //    outArray[i] = outArray[i - 1] + downValPerVal;
            //}

            //outArray[arrayLen - 1] = endNum;

            int arrayLen = outArray.Length;
            int arrayLenHalf = arrayLen / 2;
            int arrayLenTrip = 416;//arrayLen / 3;
            int arrayLenTrip2 = 426;

            outArray[0] = startNum;



            //--初始恒定 1/3
            for (int i = 0; i < arrayLenTrip; i++)
            {
                outArray[i] = startNum;
            }

            //-- 中间缓变
            double upMax = waveMax - startNum;
            double downMax = endNum - waveMax;

            double upValPerVal = upMax / ((arrayLenTrip2 - arrayLenTrip) * 1.0);
            double downValPerVal = downMax / ((arrayLenTrip - 1) * 1.0);

            for (int i = arrayLenTrip; i < arrayLenTrip2; i++)
            {
                outArray[i] = outArray[i - 1] + upValPerVal;
            }

            //-最终恒定
            for (int i = arrayLenTrip2; i < arrayLen; i++)
            {
                outArray[i] = endNum;
            }

            outArray[arrayLen - 1] = endNum;

        }


    }
}
