namespace ProductsAPI.Entities
{
    public class Product
    {
        public string codMaterial { get; set; }
        public string orgVentas { get; set; }
        public string canDistribucion { get; set; }
        public string sector { get; set; }
        public string desCorta { get; set; }
        public string desLarga { get; set; }
        public decimal pesoNeto { get; set; }
        public decimal pesoBruto { get; set; }
        public string codUM { get; set; }
        public string codUMB { get; set; }
        public string codUMV { get; set; }
        public decimal facUMBToUMV { get; set; }
        public string codTipoMaterial { get; set; }
        public string codJerarquia { get; set; }
        public string codGrupoMaterial { get; set; }
        public string codFamilia { get; set; }
        public string codMarca { get; set; }
        public string codCategoria { get; set; }
        public string codMaterialReemplazante { get; set; }
        public string codRegimen { get; set; }
        public int cantMinima { get; set; }

    }
}
