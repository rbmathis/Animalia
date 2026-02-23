namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Leporidae.Lepus;

/// <summary>
/// Species: Lepus timidus
/// NCBI TaxId: 62621
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lepus_timidus : Lepus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lepus timidus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lepus_timidus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 62621;
}
