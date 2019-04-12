using System.IO;
using System.Threading.Tasks;

namespace Polyrific.Project.Common.Helpers
{
    /// <summary>
    /// Helper to support unavailable implementations of <see cref="System.IO.File"/> in netstandard2.0
    /// </summary>
    public static class FileHelper
    {
        /// <summary>
        /// Read the file content asynchronously.
        /// </summary>
        /// <param name="path">Path to the file</param>
        /// <returns></returns>
        public static async Task<string> ReadAllTextAsync(string path)
        {
            string text;
            using (var reader = File.OpenText(path))
            {
                text = await reader.ReadToEndAsync();
            }

            return text;
        }

        /// <summary>
        /// Write file content asynchronously. If the file exists, its content will be replaced.
        /// </summary>
        /// <param name="path">Path to the file</param>
        /// <param name="content">The string to write as file content</param>
        /// <returns></returns>
        public static async Task WriteAllTextAsync(string path, string content)
        {
            using (var writer = File.CreateText(path))
            {
                await writer.WriteAsync(content);

                await writer.FlushAsync();
            }
        }

        /// <summary>
        /// Write file content asynchronously. If the file exists, it will append the content.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public static async Task AppendAllTextAsync(string path, string content)
        {
            using (var writer = File.AppendText(path))
            {
                await writer.WriteAsync(content);

                await writer.FlushAsync();
            }
        }
    }
}
