namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Arizona;

/// <summary>
/// Species: Arizona sp.
/// NCBI TaxId: 2878751
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Arizona_sp : Arizona
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Arizona sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Arizona_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2878751;
}
