namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae.Engraulis;

/// <summary>
/// Species: Engraulis environmental sample
/// NCBI TaxId: 1814133
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Engraulis_environmental_sample : Engraulis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Engraulis environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Engraulis_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1814133;
}
