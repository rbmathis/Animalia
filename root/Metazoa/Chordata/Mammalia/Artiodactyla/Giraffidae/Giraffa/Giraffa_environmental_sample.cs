namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Giraffidae.Giraffa;

/// <summary>
/// Species: Giraffa environmental sample
/// NCBI TaxId: 2682742
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Giraffa_environmental_sample : Giraffa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Giraffa environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Giraffa_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2682742;
}
