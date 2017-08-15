using System;

namespace LocalizaCaracter
{
    public class Stream : IStream
    {
        private char[] texto;
        private int tamanho;
        private int index;

        public Stream(string stream)
        {
            texto = stream.ToCharArray();
            tamanho = texto.Length;
            index = 0;
        }

        public char GetNext()
        {
            return texto[index++];
        }

        public bool HasNext()
        {
            return index < tamanho;
        }
    }
}
