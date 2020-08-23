using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms.VisualStyles;

namespace NotepadGAP
{
    static class Gerenciador
    {
        private static List<string> _recentes = new List<string>();

        // Valores Padrão
        public static string DefaultFolderPath { get; set; } = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\";
        public static string DefaultFileName { get; set; } = "arquivo";
        public static string DefaultFileExt { get; set; } = ".txt";
        public static string RecentsFile => "recentes.nprf";

        // Valores Atribuidos ao uso
        public static string FolderPath { get; set; } = DefaultFolderPath;
        public static string FileName { get; set; } = DefaultFileName;
        public static string FileExt { get; set; } = DefaultFileExt;
        public static string FilePath => FolderPath + FileName + FileExt;
        public static bool FileSaved { get; set; } = true;

        #region Histórico de arquivos recentes
        // Atualizar o historico de arquivos recentes limitando a 10 arquivos
        public static void AddRecente(string filePath)
        {
            if (_recentes.Contains(filePath))
            {
                _recentes.Remove(filePath);
            }

            _recentes.Insert(0, filePath);

            if (_recentes.Count > 10)
            {
                _recentes.RemoveRange(10, _recentes.Count - 10);
            }
        }

        // Retornar o histórico atualizado de arquivos recentes
        public static List<string> GetRecentes()
        {
            return _recentes;
        }
        
        // Verificar a existência de arquivo de histórico de recentes
        public static void VerificarRecentsFile()
        {
            // Se não existir cirar arquivo
            if (File.Exists(RecentsFile))
            {
                // Se existir ler conteúdo e atualizar a lista
                StreamReader reader = new StreamReader(RecentsFile);
                try
                {
                    string linha;
                    while ((linha = reader.ReadLine()) != null)
                    {
                        _recentes.Add(linha);
                    }
                }
                catch (Exception) { throw; }
                reader.Close();
            }
        }

        // Atualizar o arquivo de historico de recentes
        public static void AtualizarArquivoRecentes()
        {
            StreamWriter writer = new StreamWriter(RecentsFile, false);
            try
            {
                foreach (string file in _recentes)
                {
                    writer.WriteLine(file);
                }
            }
            catch (Exception) { throw; }
            writer.Close();
        }
        #endregion        
    }
}
