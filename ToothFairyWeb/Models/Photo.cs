namespace ToothFairyWeb.Models
{
    /// <summary>
    /// Fotos de dentes
    /// </summary>
    public class Photo
    {
        /// <summary>
        /// Identificador único da foto do dente
        /// </summary>
        public int PhotoID { get; set; }
        /// <summary>
        /// Caminho para encontrar a foto no repositório
        /// </summary>
        public string Path { get; set; }
    }
}