namespace ToothFairyWeb.Models
{
    /// <summary>
    /// Lista de países disponível no sistema
    /// </summary>
    public class Country
    {
        /// <summary>
        /// Id interno do País
        /// </summary>
        public virtual int CountryID { get; set; }
        /// <summary>
        /// Nome do país
        /// </summary>
        public virtual string Name { get; set; }
        /// <summary>
        /// Abreviatura do país (ex.: Portugal = PT)
        /// </summary>
        public virtual string Abreviation { get; set; }
    }
}