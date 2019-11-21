﻿namespace HexSqlCLR
{
    using System.Globalization;
    using System.IO;
    using System.Text;

    internal class GetAssemblyBits
    {
        public string Run(string assemblyPath)

        {

            StringBuilder builder = new StringBuilder();

            builder.Append("0x");


            using (FileStream stream = new FileStream(assemblyPath,

                  FileMode.Open, FileAccess.Read, FileShare.Read))

            {

                int currentByte = stream.ReadByte();

                while (currentByte > -1)

                {

                    builder.Append(currentByte.ToString("X2",

                    CultureInfo.InvariantCulture));

                    currentByte = stream.ReadByte();

                }
            }

            return builder.ToString();
        }

    }
}

