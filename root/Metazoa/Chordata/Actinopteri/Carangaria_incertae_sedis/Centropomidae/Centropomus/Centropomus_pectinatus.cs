namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Centropomidae.Centropomus;

/// <summary>
/// Species: Centropomus pectinatus
/// NCBI TaxId: 28802
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Centropomus_pectinatus : Centropomus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Centropomus pectinatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Centropomus_pectinatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 28802;
}
