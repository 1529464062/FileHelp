using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileHelp
{
    public class FileHelp
    {
        /// <summary>
        /// 检测文件是否存在,存在返回true,不存在返回false
        /// </summary>
        /// <param name="FilePath">文件的路径</param>
        /// <returns></returns>
        public bool Exists(string FilePath)
        {
            if (File.Exists(FilePath))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 根据文件路径创建文件,若文件不存在则创建,若存在则覆盖,返回文件是否创建成功,成功则为true,不成功为false。
        /// </summary>
        /// <param name="FilePath">文件路径</param>
        /// <returns></returns>
        public bool CreateFile(string FilePath)
        {
            File.Create(FilePath);
            return Exists(FilePath);
        }
    }
}
