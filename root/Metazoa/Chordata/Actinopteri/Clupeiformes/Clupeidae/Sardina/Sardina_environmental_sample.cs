namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Sardina;

/// <summary>
/// Species: Sardina environmental sample
/// NCBI TaxId: 1814143
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sardina_environmental_sample : Sardina
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sardina environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sardina_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1814143;
}
