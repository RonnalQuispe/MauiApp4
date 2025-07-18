using System;
using System.IO;
using System.Threading.Tasks;

namespace MauiApp4.Repositories
{
    internal class FilesRepository
    {
        private string filePath = Path.Combine(FileSystem.AppDataDirectory, "Archivo1.txt");

    
        public async Task<bool> GenerarArchivoAsync(string texto)
        {
            try
            {
                await File.WriteAllTextAsync(filePath, texto);
                return File.Exists(filePath);  
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Error al generar el archivo: {ex.Message}");
                return false;
            }
        }

        
        public async Task<string> DevuelveInformacionArchivoAsync()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string texto = await File.ReadAllTextAsync(filePath);
                    return texto;
                }
                return "No existe el archivo";  
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Error al leer el archivo: {ex.Message}");
                throw; 
            }
        }
    }
}
