namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Rana;

/// <summary>
/// Species: Rana coreana
/// NCBI TaxId: 1168020
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rana_coreana : Rana
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rana coreana";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rana_coreana";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1168020;
}
