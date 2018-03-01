using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practica2
{
    /// <summary>
    /// Clase BMP
    /// Esta clase lee un archivo y valida si es un mapa de bits 'BMP'. Si el archivo
    /// es valido, guarda su tamaño(bytes), pixeles de ancho, pixeles de alto, y el numero 
    /// de bits por pixel. 
    /// </summary>
    class BMP
    {
        private string _filename;
        private bool _isBmp;
        private int _size;
        private int _width;
        private int _height;
        private Int16 _npixel;

        public string filename { get { return _filename; } set { _filename = value; } }
        public bool isBmp{ get { return _isBmp; } }
        public int size  { get { return _size; } }
        public int width { get { return _width; } }
        public int height{ get { return _height; } }
        public Int16 npixel { get { return _npixel; } }

        public BMP(string filename)
        {
            _filename = filename;
            process();
        }

        public void process()
        {
            FileStream file = new FileStream(_filename, FileMode.Open);
            BinaryReader binr = new BinaryReader(file);

            //valida si es un archivo BMP
            
            if (binr.ReadUInt16() == 0x4D42)
            {
                _isBmp = true;
                //guarda el tamaño del archivo
                _size = binr.ReadInt32();

                //guarda alto de la imagen
                binr.BaseStream.Seek(18, SeekOrigin.Begin);
                _width = binr.ReadInt32();
                _height = binr.ReadInt32();

                //lee numero de bits por pixel
                binr.BaseStream.Seek(28, SeekOrigin.Begin);
                _npixel = binr.ReadInt16();

                binr.Close();
                file.Close();

            }
            else
                _isBmp = false;
        }
    }
}
