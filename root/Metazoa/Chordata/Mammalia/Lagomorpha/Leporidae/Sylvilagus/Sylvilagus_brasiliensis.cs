namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Leporidae.Sylvilagus;

/// <summary>
/// Species: Sylvilagus brasiliensis
/// NCBI TaxId: 483865
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sylvilagus_brasiliensis : Sylvilagus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sylvilagus brasiliensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sylvilagus_brasiliensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 483865;
}
