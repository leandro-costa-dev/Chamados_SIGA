﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoSIGA
{
    public static class Util
    {        
        public static string criarDiretorios()
        {
            string path = Directory.GetCurrentDirectory();

            try
            {
                if (Directory.Exists(path + @"\XML"))
                {
                    return path;
                }
                else
                {
                    Directory.CreateDirectory(path + @"\XML");
                    Directory.CreateDirectory(path + @"\XML\Envio");
                    Directory.CreateDirectory(path + @"\XML\Rretorno");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro ao criar as pastas!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
            return path;
        }
        public static string limparString(string str)
		{
			string[] charsToRemove = new string[] { "\\"," ", "-", "/", "@", ",", ".", ";", ":", "'", "%", "&", "(", ")" };
			foreach (var c in charsToRemove)
			{
				str = str.Replace(c, string.Empty);
			}
			return str;
		}
	}
}
