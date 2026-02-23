namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Arizona;

/// <summary>
/// Species: Arizona elegans
/// NCBI TaxId: 94893
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Arizona_elegans : Arizona
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Arizona elegans";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Arizona_elegans";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 94893;
}
