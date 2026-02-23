namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Leporidae.Sylvilagus;

/// <summary>
/// Species: Sylvilagus floridanus
/// NCBI TaxId: 9988
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sylvilagus_floridanus : Sylvilagus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sylvilagus floridanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sylvilagus_floridanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9988;
}
