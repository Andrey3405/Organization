using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization.Class
{
    internal class ImageExtension
    {
        /// <summary>
        /// Загрузить Bitmap по указанному пути и преобразовать в соотвествтие с указанными размерами.
        /// Если Bitmap не найден, то вернуть null
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <param name="width">Ширина итогового Bitmap</param>
        /// <param name="height">Высота итогового Bitmap</param>
        public static Bitmap GetBitmapFromPath(string path, int width, int height)
        {
            if (String.IsNullOrEmpty(path)) throw new Exception("Путь к файлу не указан");
            if (File.Exists(path))
            {
                Bitmap bitmap = new Bitmap(path);
                return new Bitmap(bitmap, width, height);
            }
            else
            {
                return null;
            }
        }
    }
}
