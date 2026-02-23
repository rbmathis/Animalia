namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Leporidae.Oryctolagus;

/// <summary>
/// Species: Oryctolagus sp.
/// NCBI TaxId: 60556
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oryctolagus_sp : Oryctolagus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oryctolagus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oryctolagus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 60556;
}
