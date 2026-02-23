namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Squalidae.Squalus;

/// <summary>
/// Species: Squalus raoulensis
/// NCBI TaxId: 440101
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Squalus_raoulensis : Squalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Squalus raoulensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Squalus_raoulensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 440101;
}
