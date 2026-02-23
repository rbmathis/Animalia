namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Pseudoryx;

/// <summary>
/// Species: Pseudoryx nghetinhensis
/// NCBI TaxId: 97363
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pseudoryx_nghetinhensis : Pseudoryx
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pseudoryx nghetinhensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pseudoryx_nghetinhensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 97363;
}
